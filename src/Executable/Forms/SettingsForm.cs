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
using Microsoft.Win32;
using System.Windows.Forms;
using Memory_Cleaner.Settings;

namespace Memory_Cleaner
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void txtbox_hotkey_KeyDown(object sender, KeyEventArgs e)
        {
            Options.Hotkey(txtbox_hotkey, e);
        }

        private void cb_standbylist_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_standbylist, "EnableClearingOfTheStandbyList");
        }

        private void cb_modifiedlist_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_modifiedlist, "EnableFlushingOfTheModifiedList");
        }

        private void cb_workingset_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_workingset, "EnableEmptyingOfTheWorkingSet");
        }

        private void cb_lowpriostandbylist_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_lowpriostandbylist, "EnableClearingOfTheLowPriorityStandbyList");
        }

        private void numericud_timerres_ValueChanged(object sender, EventArgs e)
        {
            Memory_Cleaner.Settings.Registry.Write("DesiredTimerResolution", numericud_timerres.Value.ToString());
        }

        private void cb_timerres_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_timerres, "EnableCustomTimerResolution");
        }

        private void cmbox_timer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Memory_Cleaner.Settings.Registry.Write("TimerPollingInterval", cmbox_timer.Text);
        }

        private void cb_timer_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_timer, "TimerEnabled");
        }

        private void cb_minimize_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_minimize, "StartMinimized");
        }

        private void cb_autotimerres_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_autotimerres, "StartTimerResolutionAutomatically");
        }

        private void cb_startup_CheckedChanged(object sender, EventArgs e)
        {
            Options.Checkboxes(cb_startup, "StartMemoryCleanerOnSystemStartup");
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to reset all of the settings?", "Memory Cleaner", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        Memory_Cleaner.Settings.Registry.Write("DesiredTimerResolution", "5000");
                        numericud_timerres.Value = 5000;

                        Memory_Cleaner.Settings.Registry.Write("EnableClearingOfTheStandbyList", "1");
                        cb_standbylist.Checked = true;

                        Memory_Cleaner.Settings.Registry.Write("EnableClearingOfTheLowPriorityStandbyList", "1");
                        cb_lowpriostandbylist.Checked = true;

                        Memory_Cleaner.Settings.Registry.Write("EnableFlushingOfTheModifiedList", "1");
                        cb_modifiedlist.Checked = true;

                        Memory_Cleaner.Settings.Registry.Write("EnableCustomTimerResolution", "1");
                        cb_timer.Checked = true;

                        Memory_Cleaner.Settings.Registry.Write("EnableEmptyingOfTheWorkingSet", "1");
                        cb_workingset.Checked = true;

                        Memory_Cleaner.Settings.Registry.Write("HotkeyToCleanMemory", "F10");
                        txtbox_hotkey.Text = "F10";

                        Memory_Cleaner.Settings.Registry.Write("StartMemoryCleanerOnSystemStartup", "0");
                        cb_startup.Checked = false;

                        Memory_Cleaner.Settings.Registry.Write("StartMinimized", "0");
                        cb_minimize.Checked = false;

                        Memory_Cleaner.Settings.Registry.Write("StartTimerResolutionAutomatically", "0");
                        cb_autotimerres.Checked = false;

                        Memory_Cleaner.Settings.Registry.Write("TimerEnabled", "1");
                        cb_timer.Checked = true;

                        Memory_Cleaner.Settings.Registry.Write("TimerPollingInterval", "1 sec");
                        cmbox_timer.Text = "1 sec";

                        break;
                    }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm MainForm = (MainForm)Application.OpenForms["MainForm"];
            MainForm.SaveSettings();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs a = new KeyEventArgs(keyData);
            if (a.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
