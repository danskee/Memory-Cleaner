﻿/*
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

namespace Memory_Cleaner
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentTimerRes = new System.Windows.Forms.Label();
            this.GroupBoxTimerResolution = new System.Windows.Forms.GroupBox();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MaxTimerRes = new System.Windows.Forms.Label();
            this.MinTimerRes = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.GroupBoxRAM = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalMemory = new System.Windows.Forms.Label();
            this.AvailableMemory = new System.Windows.Forms.Label();
            this.ButtonCleanMemory = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip.SuspendLayout();
            this.GroupBoxTimerResolution.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.GroupBoxRAM.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.ContextMenuStrip = this.ContextMenuStrip;
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "Memory Cleaner";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIcon_DoubleClick);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuStrip.Size = new System.Drawing.Size(184, 48);
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.CheckForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ExitToolStripMenuItem.Text = "Exit Memory Cleaner";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // CurrentTimerRes
            // 
            this.CurrentTimerRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentTimerRes.AutoSize = true;
            this.CurrentTimerRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimerRes.Location = new System.Drawing.Point(3, 3);
            this.CurrentTimerRes.Name = "CurrentTimerRes";
            this.CurrentTimerRes.Size = new System.Drawing.Size(93, 17);
            this.CurrentTimerRes.TabIndex = 21;
            this.CurrentTimerRes.Text = "Current: 1 ms";
            this.CurrentTimerRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxTimerResolution
            // 
            this.GroupBoxTimerResolution.Controls.Add(this.ButtonStop);
            this.GroupBoxTimerResolution.Controls.Add(this.TableLayoutPanel1);
            this.GroupBoxTimerResolution.Controls.Add(this.ButtonStart);
            this.GroupBoxTimerResolution.Location = new System.Drawing.Point(12, 29);
            this.GroupBoxTimerResolution.Name = "GroupBoxTimerResolution";
            this.GroupBoxTimerResolution.Size = new System.Drawing.Size(157, 122);
            this.GroupBoxTimerResolution.TabIndex = 23;
            this.GroupBoxTimerResolution.TabStop = false;
            this.GroupBoxTimerResolution.Text = "Timer resolution";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonStop.Location = new System.Drawing.Point(86, 94);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(65, 23);
            this.ButtonStop.TabIndex = 4;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.MaxTimerRes, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.MinTimerRes, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.CurrentTimerRes, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(145, 72);
            this.TableLayoutPanel1.TabIndex = 25;
            // 
            // MaxTimerRes
            // 
            this.MaxTimerRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxTimerRes.AutoSize = true;
            this.MaxTimerRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTimerRes.Location = new System.Drawing.Point(3, 27);
            this.MaxTimerRes.Name = "MaxTimerRes";
            this.MaxTimerRes.Size = new System.Drawing.Size(83, 17);
            this.MaxTimerRes.TabIndex = 25;
            this.MaxTimerRes.Text = "Max: 0.5 ms";
            this.MaxTimerRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinTimerRes
            // 
            this.MinTimerRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinTimerRes.AutoSize = true;
            this.MinTimerRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTimerRes.Location = new System.Drawing.Point(3, 51);
            this.MinTimerRes.Name = "MinTimerRes";
            this.MinTimerRes.Size = new System.Drawing.Size(104, 17);
            this.MinTimerRes.TabIndex = 22;
            this.MinTimerRes.Text = "Min: 15.625 ms";
            this.MinTimerRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonStart.Location = new System.Drawing.Point(6, 94);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(65, 23);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // GroupBoxRAM
            // 
            this.GroupBoxRAM.Controls.Add(this.TableLayoutPanel2);
            this.GroupBoxRAM.Controls.Add(this.ButtonCleanMemory);
            this.GroupBoxRAM.Location = new System.Drawing.Point(12, 160);
            this.GroupBoxRAM.Name = "GroupBoxRAM";
            this.GroupBoxRAM.Size = new System.Drawing.Size(157, 96);
            this.GroupBoxRAM.TabIndex = 24;
            this.GroupBoxRAM.TabStop = false;
            this.GroupBoxRAM.Text = "RAM";
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.Controls.Add(this.TotalMemory, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.AvailableMemory, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(7, 16);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 2;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(143, 45);
            this.TableLayoutPanel2.TabIndex = 30;
            // 
            // TotalMemory
            // 
            this.TotalMemory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalMemory.AutoSize = true;
            this.TotalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMemory.Location = new System.Drawing.Point(3, 25);
            this.TotalMemory.Name = "TotalMemory";
            this.TotalMemory.Size = new System.Drawing.Size(112, 17);
            this.TotalMemory.TabIndex = 28;
            this.TotalMemory.Text = "Total: 16384 MB";
            this.TotalMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableMemory
            // 
            this.AvailableMemory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AvailableMemory.AutoSize = true;
            this.AvailableMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableMemory.Location = new System.Drawing.Point(3, 2);
            this.AvailableMemory.Name = "AvailableMemory";
            this.AvailableMemory.Size = new System.Drawing.Size(137, 17);
            this.AvailableMemory.TabIndex = 27;
            this.AvailableMemory.Text = "Available: 12288 MB";
            this.AvailableMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCleanMemory
            // 
            this.ButtonCleanMemory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCleanMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanMemory.Location = new System.Drawing.Point(7, 67);
            this.ButtonCleanMemory.Name = "ButtonCleanMemory";
            this.ButtonCleanMemory.Size = new System.Drawing.Size(143, 23);
            this.ButtonCleanMemory.TabIndex = 28;
            this.ButtonCleanMemory.Text = "Clean memory";
            this.ButtonCleanMemory.UseVisualStyleBackColor = true;
            this.ButtonCleanMemory.Click += new System.EventHandler(this.ButtonCleanMemory_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(182, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.MenuItemSettings_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 268);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GroupBoxRAM);
            this.Controls.Add(this.GroupBoxTimerResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Cleaner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ContextMenuStrip.ResumeLayout(false);
            this.GroupBoxTimerResolution.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.GroupBoxRAM.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.Label CurrentTimerRes;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxTimerResolution;
        private System.Windows.Forms.GroupBox GroupBoxRAM;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonCleanMemory;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        private System.Windows.Forms.Label TotalMemory;
        private System.Windows.Forms.Label AvailableMemory;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Label MaxTimerRes;
        private System.Windows.Forms.Label MinTimerRes;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}