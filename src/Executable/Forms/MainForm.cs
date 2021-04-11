/*
   Memory Cleaner

   Copyright (C) 2021 Danske

   This file is part of Memory Cleaner

   Memory Cleaner is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   Memory Cleaner is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with Memory Cleaner.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO.Compression;
using Memory_Cleaner.Updating;
using Memory_Cleaner.Functions;
using System.Security.Principal;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Memory_Cleaner
{
    public partial class MainForm : Form
    {
        [DllImport("Memory Cleaner.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CleanMemory(bool standbylist, bool modifiedlist, bool workingset, bool lowpriostandbylist);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private bool allowVisible;
        AboutDialog AboutDialog = new AboutDialog("1.6.6");
        SettingsForm SettingsForm = new SettingsForm();
        LicenseAgreementDialog LicenseAgreementDialog = new LicenseAgreementDialog();
        RegistryKey Startup = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

        public MainForm()
        {
            InitializeComponent();
            Memory_Cleaner.Settings.Read.ReadOrAssignSettings();

            // Checked For Updates
            switch (Memory_Cleaner.Settings.Registry.Exists("CheckedForUpdates"))
            {
                case true:
                    if (Memory_Cleaner.Settings.Registry.Read("CheckedForUpdates") == "False")
                    {
                        Calculate.Updates(Convert.ToInt32("1.6.6".Replace(".", "")));
                    }
                    break;

                case false:
                    Calculate.Updates(Convert.ToInt32("1.6.6".Replace(".", "")));
                    break;
            }

            // Copyright License
            if (Memory_Cleaner.Settings.Registry.Read("LicenseAccepted") == "False")
            {
                LicenseAgreementDialog.ShowDialog(this);
            }

            // Desired Timer Resolution
            switch (Memory_Cleaner.Settings.Registry.Exists("DesiredTimerResolution"))
            {
                case true:
                    SettingsForm.numericud_timerres.Value = Convert.ToInt32(Memory_Cleaner.Settings.Registry.Read("DesiredTimerResolution"));
                    break;

                case false:
                    SettingsForm.numericud_timerres.Value = 5000;
                    Memory_Cleaner.Settings.Registry.Write("DesiredTimerResolution", SettingsForm.numericud_timerres.Value.ToString());
                    break;
            }

            // Enable Clearing Of The Standby List
            switch (Memory_Cleaner.Settings.Registry.Read("EnableClearingOfTheStandbyList"))
            {
                case "1":
                    SettingsForm.cb_standbylist.Checked = true;
                    break;

                case "0":
                    SettingsForm.cb_standbylist.Checked = false;
                    break;
            }

            // Enable Flushing Of The Modified List
            switch (Memory_Cleaner.Settings.Registry.Read("EnableFlushingOfTheModifiedList"))
            {
                case "1":
                    SettingsForm.cb_modifiedlist.Checked = true;
                    break;

                case "0":
                    SettingsForm.cb_modifiedlist.Checked = false;
                    break;
            }

            // Enable Custom Timer Resolution
            switch (Memory_Cleaner.Settings.Registry.Read("EnableCustomTimerResolution"))
            {
                case "1":
                    SettingsForm.cb_timerres.Checked = true;
                    break;

                case "0":
                    SettingsForm.cb_timerres.Checked = false;
                    break;
            }

            // Enable Clearing Of The Low Priority Standby List
            switch (Memory_Cleaner.Settings.Registry.Read("EnableClearingOfTheLowPriorityStandbyList"))
            {
                case "1":
                    SettingsForm.cb_lowpriostandbylist.Checked = true;
                    break;

                case "0":
                    SettingsForm.cb_lowpriostandbylist.Checked = false;
                    break;
            }

            // Enable Emptying Of The Working Set
            switch (Memory_Cleaner.Settings.Registry.Read("EnableEmptyingOfTheWorkingSet"))
            {
                case "1":
                    SettingsForm.cb_workingset.Checked = true;
                    break;

                case "0":
                    SettingsForm.cb_workingset.Checked = false;
                    break;
            }

            // Hotkey To Clean Memory
            switch (Memory_Cleaner.Settings.Registry.Exists("HotkeyToCleanMemory"))
            {
                case true:
                    SettingsForm.txtbox_hotkey.Text = Memory_Cleaner.Settings.Registry.Read("HotkeyToCleanMemory");
                    break;

                case false:
                    SettingsForm.txtbox_hotkey.Text = "F10";
                    Memory_Cleaner.Settings.Registry.Write("HotkeyToCleanMemory", SettingsForm.txtbox_hotkey.Text);
                    break;
            }

            // Start Memory Cleaner On System Startup
            switch (Memory_Cleaner.Settings.Registry.Read("StartMemoryCleanerOnSystemStartup"))
            {
                case "1":
                    SettingsForm.cb_startup.Checked = true;
                    Startup.SetValue("Memory Cleaner", "\"" + Application.ExecutablePath + "\"", RegistryValueKind.String);
                    break;

                case "0":
                    SettingsForm.cb_startup.Checked = false;
                    if (Startup.GetValue("Memory Cleaner") != null)
                    {
                        Startup.DeleteValue("Memory Cleaner");
                    }
                    break;
            }

            // Start Minimized
            switch (Memory_Cleaner.Settings.Registry.Read("StartMinimized"))
            {
                case "1":
                    SettingsForm.cb_minimize.Checked = true;
                    Minimize();
                    break;

                case "0":
                    SettingsForm.cb_minimize.Checked = false;
                    Maximize();
                    break;
            }

            // Start Timer Resolution Automatically
            switch (Memory_Cleaner.Settings.Registry.Read("StartTimerResolutionAutomatically"))
            {
                case "1":
                    SettingsForm.cb_autotimerres.Checked = true;
                    Memory_Cleaner.Functions.TimerRes.SetTimerRes(true, Convert.ToUInt32(SettingsForm.numericud_timerres.Value));
                    break;

                case "0":
                    SettingsForm.cb_autotimerres.Checked = false;
                    Memory_Cleaner.Functions.TimerRes.SetTimerRes(false, Convert.ToUInt32(SettingsForm.numericud_timerres.Value));
                    break;
            }

            // Timer Enabled
            switch (Memory_Cleaner.Settings.Registry.Read("TimerEnabled"))
            {
                case "1":
                    SettingsForm.cb_timer.Checked = true;
                    break;

                case "0":
                    SettingsForm.cb_timer.Checked = false;
                    break;
            }

            // Timer Polling Interval
            switch (Memory_Cleaner.Settings.Registry.Exists("TimerPollingInterval"))
            {
                case true:
                    SettingsForm.cmbox_timer.Text = Memory_Cleaner.Settings.Registry.Read("TimerPollingInterval");
                    break;

                case false:
                    SettingsForm.cmbox_timer.Text = "1 sec";
                    Memory_Cleaner.Settings.Registry.Write("TimerPollingInterval", SettingsForm.cmbox_timer.Text);
                    break;
            }

            if (!File.Exists("Memory Cleaner.dll"))
            {
                MessageBox.Show("Memory Cleaner.dll missing!", "Missing DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            SaveSettings();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Exit(sender, e);
            UpdateValues();
        }

        private void MenuItemSettings_Click(object sender, EventArgs e)
        {
            SettingsForm.ShowDialog(this);
            UpdateValues();
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutDialog.ShowDialog(this);
            UpdateValues();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Memory_Cleaner.Functions.TimerRes.SetTimerRes(true, Convert.ToUInt32(SettingsForm.numericud_timerres.Value));
            UpdateValues();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Memory_Cleaner.Functions.TimerRes.SetTimerRes(false, Convert.ToUInt32(SettingsForm.numericud_timerres.Value));
            UpdateValues();
        }

        private void ButtonCleanMemory_Click(object sender, EventArgs e)
        {
            CleanMemory(SettingsForm.cb_standbylist.Checked, SettingsForm.cb_modifiedlist.Checked, SettingsForm.cb_workingset.Checked, SettingsForm.cb_lowpriostandbylist.Checked);
            UpdateValues();
        }

        private void SystemTrayIcon_DoubleClick(object sender, MouseEventArgs e)
        {
            Maximize();
            UpdateValues();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Minimized:
                    Minimize();
                    UpdateValues();
                    break;

                case FormWindowState.Maximized:
                    Maximize();
                    UpdateValues();
                    break;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit(sender, e);
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
            UnregisterHotKey(this.Handle, 1);
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate.Updates(Convert.ToInt32("1.6.6".Replace(".", "")));
        }

        public void SaveSettings()
        {
            RegisterHotkey();
            UpdateValues();
            Timer();

            switch (SettingsForm.cb_startup.Checked)
            {
                case true:
                    Startup.SetValue("Memory Cleaner", "\"" + Application.ExecutablePath + "\"", RegistryValueKind.String);
                    break;

                case false:
                    if (Startup.GetValue("Memory Cleaner") != null)
                    {
                        Startup.DeleteValue("Memory Cleaner");
                    }
                    break;
            }

            switch (SettingsForm.cb_timerres.Checked)
            {
                case true:
                    ButtonStart.Enabled = true;
                    ButtonStop.Enabled = true;
                    break;

                case false:
                    ButtonStart.Enabled = false;
                    ButtonStop.Enabled = false;
                    break;
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        private void Minimize()
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize()
        {
            this.allowVisible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void RegisterHotkey()
        {
            Keys a;
            Enum.TryParse(SettingsForm.txtbox_hotkey.Text.Replace("Shift + ", "").Replace("Control + ", "").Replace("Alt + ", ""), out a);

            if (SettingsForm.txtbox_hotkey.Text.Contains("Shift"))
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)4, a.GetHashCode());
            }
            else if (SettingsForm.txtbox_hotkey.Text.Contains("Control"))
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)2, a.GetHashCode());
            }
            else if (SettingsForm.txtbox_hotkey.Text.Contains("Alt"))
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)1, a.GetHashCode());
            }
            else
            {
                UnregisterHotKey(this.Handle, 1);
                RegisterHotKey(this.Handle, 1, (int)0, a.GetHashCode());
            }
        }

        private void Timer()
        {
            switch (SettingsForm.cmbox_timer.Text)
            {
                case "0.5 sec":
                    if (SettingsForm.cb_timer.Checked == true)
                    {
                        Timer1.Interval = 500;
                    }
                    break;

                case "1 sec":
                    if (SettingsForm.cb_timer.Checked == true)
                    {
                        Timer1.Interval = 1000;
                    }
                    break;

                case "2 sec":
                    if (SettingsForm.cb_timer.Checked == true)
                    {
                        Timer1.Interval = 2000;
                    }
                    break;

                case "5 sec":
                    if (SettingsForm.cb_timer.Checked == true)
                    {
                        Timer1.Interval = 5000;
                    }
                    break;

                case "10 sec":
                    if (SettingsForm.cb_timer.Checked == true)
                    {
                        Timer1.Interval = 10000;
                    }
                    break;
            }

            switch (SettingsForm.cb_timer.Checked)
            {
                case true:
                    Timer1.Enabled = true;
                    break;

                case false:
                    Timer1.Enabled = false;
                    break;
            }
        }

        private void UpdateValues()
        {
            AvailableMemory.Text = "Available: " + (Memory.Get(1) / 1048576) + " MB";
            TotalMemory.Text = "Total: " + (Memory.Get(2) / 1048576) + " MB";
            CurrentTimerRes.Text = "Current: " + (TimerRes.Get().cur / 10000.0) + " ms";
            MaxTimerRes.Text = "Max: " + (TimerRes.Get().max / 10000.0) + " ms";
            MinTimerRes.Text = "Min: " + (TimerRes.Get().min / 10000.0) + " ms";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateValues();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                CleanMemory(SettingsForm.cb_standbylist.Checked, SettingsForm.cb_modifiedlist.Checked, SettingsForm.cb_workingset.Checked, SettingsForm.cb_lowpriostandbylist.Checked);
            }
        }
    }
}