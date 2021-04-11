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
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ButtonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_lowpriostandbylist = new System.Windows.Forms.CheckBox();
            this.label_hotkey = new System.Windows.Forms.Label();
            this.txtbox_hotkey = new System.Windows.Forms.TextBox();
            this.cb_standbylist = new System.Windows.Forms.CheckBox();
            this.cb_workingset = new System.Windows.Forms.CheckBox();
            this.cb_modifiedlist = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_timerres = new System.Windows.Forms.CheckBox();
            this.numericud_timerres = new System.Windows.Forms.NumericUpDown();
            this.label_timerres = new System.Windows.Forms.Label();
            this.cb_timer = new System.Windows.Forms.CheckBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbox_timer = new System.Windows.Forms.ComboBox();
            this.label_timer = new System.Windows.Forms.Label();
            this.GroupBoxStartupSettings = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_startup = new System.Windows.Forms.CheckBox();
            this.cb_autotimerres = new System.Windows.Forms.CheckBox();
            this.cb_minimize = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericud_timerres)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.GroupBoxStartupSettings.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonReset.Location = new System.Drawing.Point(10, 416);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 53;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableLayoutPanel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 145);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memory cleaning settings";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.TableLayoutPanel1.Controls.Add(this.cb_lowpriostandbylist, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.label_hotkey, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.txtbox_hotkey, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.cb_standbylist, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.cb_workingset, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.cb_modifiedlist, 0, 2);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 5;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(350, 120);
            this.TableLayoutPanel1.TabIndex = 61;
            // 
            // cb_lowpriostandbylist
            // 
            this.cb_lowpriostandbylist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_lowpriostandbylist.AutoSize = true;
            this.cb_lowpriostandbylist.Checked = true;
            this.cb_lowpriostandbylist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_lowpriostandbylist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_lowpriostandbylist.Location = new System.Drawing.Point(3, 99);
            this.cb_lowpriostandbylist.Name = "cb_lowpriostandbylist";
            this.cb_lowpriostandbylist.Size = new System.Drawing.Size(242, 18);
            this.cb_lowpriostandbylist.TabIndex = 29;
            this.cb_lowpriostandbylist.Text = "Enable clearing of the low priority standby list";
            this.cb_lowpriostandbylist.UseVisualStyleBackColor = true;
            this.cb_lowpriostandbylist.CheckedChanged += new System.EventHandler(this.cb_lowpriostandbylist_CheckedChanged);
            // 
            // label_hotkey
            // 
            this.label_hotkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_hotkey.AutoSize = true;
            this.label_hotkey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_hotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hotkey.Location = new System.Drawing.Point(3, 5);
            this.label_hotkey.Name = "label_hotkey";
            this.label_hotkey.Size = new System.Drawing.Size(124, 13);
            this.label_hotkey.TabIndex = 23;
            this.label_hotkey.Text = "Hotkey to clean memory:";
            this.label_hotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_hotkey
            // 
            this.txtbox_hotkey.Location = new System.Drawing.Point(257, 3);
            this.txtbox_hotkey.Name = "txtbox_hotkey";
            this.txtbox_hotkey.ReadOnly = true;
            this.txtbox_hotkey.Size = new System.Drawing.Size(90, 20);
            this.txtbox_hotkey.TabIndex = 27;
            this.txtbox_hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_hotkey_KeyDown);
            // 
            // cb_standbylist
            // 
            this.cb_standbylist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_standbylist.AutoSize = true;
            this.cb_standbylist.Checked = true;
            this.cb_standbylist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_standbylist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_standbylist.Location = new System.Drawing.Point(3, 27);
            this.cb_standbylist.Name = "cb_standbylist";
            this.cb_standbylist.Size = new System.Drawing.Size(190, 18);
            this.cb_standbylist.TabIndex = 25;
            this.cb_standbylist.Text = "Enable clearing of the standby list";
            this.cb_standbylist.UseVisualStyleBackColor = true;
            this.cb_standbylist.CheckedChanged += new System.EventHandler(this.cb_standbylist_CheckedChanged);
            // 
            // cb_workingset
            // 
            this.cb_workingset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_workingset.AutoSize = true;
            this.cb_workingset.Checked = true;
            this.cb_workingset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_workingset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_workingset.Location = new System.Drawing.Point(3, 75);
            this.cb_workingset.Name = "cb_workingset";
            this.cb_workingset.Size = new System.Drawing.Size(197, 18);
            this.cb_workingset.TabIndex = 26;
            this.cb_workingset.Text = "Enable emptying of the working set";
            this.cb_workingset.UseVisualStyleBackColor = true;
            this.cb_workingset.CheckedChanged += new System.EventHandler(this.cb_workingset_CheckedChanged);
            // 
            // cb_modifiedlist
            // 
            this.cb_modifiedlist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_modifiedlist.AutoSize = true;
            this.cb_modifiedlist.Checked = true;
            this.cb_modifiedlist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_modifiedlist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_modifiedlist.Location = new System.Drawing.Point(3, 51);
            this.cb_modifiedlist.Name = "cb_modifiedlist";
            this.cb_modifiedlist.Size = new System.Drawing.Size(191, 18);
            this.cb_modifiedlist.TabIndex = 28;
            this.cb_modifiedlist.Text = "Enable flushing of the modified list";
            this.cb_modifiedlist.UseVisualStyleBackColor = true;
            this.cb_modifiedlist.CheckedChanged += new System.EventHandler(this.cb_modifiedlist_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TableLayoutPanel2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(10, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 72);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer resolution settings";
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.TableLayoutPanel2.Controls.Add(this.cb_timerres, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.numericud_timerres, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.label_timerres, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(6, 16);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 2;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(350, 50);
            this.TableLayoutPanel2.TabIndex = 34;
            // 
            // cb_timerres
            // 
            this.cb_timerres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_timerres.AutoSize = true;
            this.cb_timerres.Checked = true;
            this.cb_timerres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_timerres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_timerres.Location = new System.Drawing.Point(3, 28);
            this.cb_timerres.Name = "cb_timerres";
            this.cb_timerres.Size = new System.Drawing.Size(175, 18);
            this.cb_timerres.TabIndex = 33;
            this.cb_timerres.Text = "Enable custom timer resolution";
            this.cb_timerres.UseVisualStyleBackColor = true;
            this.cb_timerres.CheckedChanged += new System.EventHandler(this.cb_timerres_CheckedChanged);
            // 
            // numericud_timerres
            // 
            this.numericud_timerres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericud_timerres.Location = new System.Drawing.Point(257, 3);
            this.numericud_timerres.Maximum = new decimal(new int[] {
            156250,
            0,
            0,
            0});
            this.numericud_timerres.Name = "numericud_timerres";
            this.numericud_timerres.Size = new System.Drawing.Size(90, 20);
            this.numericud_timerres.TabIndex = 32;
            this.numericud_timerres.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericud_timerres.ValueChanged += new System.EventHandler(this.numericud_timerres_ValueChanged);
            // 
            // label_timerres
            // 
            this.label_timerres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_timerres.AutoSize = true;
            this.label_timerres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_timerres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timerres.Location = new System.Drawing.Point(3, 6);
            this.label_timerres.Name = "label_timerres";
            this.label_timerres.Size = new System.Drawing.Size(119, 13);
            this.label_timerres.TabIndex = 22;
            this.label_timerres.Text = "Desired timer resolution:";
            this.label_timerres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_timer
            // 
            this.cb_timer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_timer.AutoSize = true;
            this.cb_timer.Checked = true;
            this.cb_timer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_timer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_timer.Location = new System.Drawing.Point(3, 28);
            this.cb_timer.Name = "cb_timer";
            this.cb_timer.Size = new System.Drawing.Size(90, 18);
            this.cb_timer.TabIndex = 2;
            this.cb_timer.Text = "Enable timer";
            this.cb_timer.UseVisualStyleBackColor = true;
            this.cb_timer.CheckedChanged += new System.EventHandler(this.cb_timer_CheckedChanged);
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonClose.Location = new System.Drawing.Point(297, 416);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 59;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TableLayoutPanel3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(10, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 72);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer settings";
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.TableLayoutPanel3.Controls.Add(this.cb_timer, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.cmbox_timer, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.label_timer, 0, 0);
            this.TableLayoutPanel3.Location = new System.Drawing.Point(6, 16);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(350, 50);
            this.TableLayoutPanel3.TabIndex = 34;
            // 
            // cmbox_timer
            // 
            this.cmbox_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbox_timer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbox_timer.FormattingEnabled = true;
            this.cmbox_timer.Items.AddRange(new object[] {
            "0.5 sec",
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec"});
            this.cmbox_timer.Location = new System.Drawing.Point(257, 3);
            this.cmbox_timer.Name = "cmbox_timer";
            this.cmbox_timer.Size = new System.Drawing.Size(90, 21);
            this.cmbox_timer.TabIndex = 25;
            this.cmbox_timer.Text = "1 sec";
            this.cmbox_timer.SelectedIndexChanged += new System.EventHandler(this.cmbox_timer_SelectedIndexChanged);
            // 
            // label_timer
            // 
            this.label_timer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_timer.AutoSize = true;
            this.label_timer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(3, 6);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(106, 13);
            this.label_timer.TabIndex = 23;
            this.label_timer.Text = "Timer polling interval:";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxStartupSettings
            // 
            this.GroupBoxStartupSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBoxStartupSettings.Controls.Add(this.TableLayoutPanel4);
            this.GroupBoxStartupSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBoxStartupSettings.Location = new System.Drawing.Point(10, 315);
            this.GroupBoxStartupSettings.Name = "GroupBoxStartupSettings";
            this.GroupBoxStartupSettings.Size = new System.Drawing.Size(362, 95);
            this.GroupBoxStartupSettings.TabIndex = 71;
            this.GroupBoxStartupSettings.TabStop = false;
            this.GroupBoxStartupSettings.Text = "Startup settings";
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel4.ColumnCount = 2;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.73F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27F));
            this.TableLayoutPanel4.Controls.Add(this.cb_startup, 0, 2);
            this.TableLayoutPanel4.Controls.Add(this.cb_autotimerres, 0, 1);
            this.TableLayoutPanel4.Controls.Add(this.cb_minimize, 0, 0);
            this.TableLayoutPanel4.Location = new System.Drawing.Point(6, 16);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 3;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(350, 73);
            this.TableLayoutPanel4.TabIndex = 68;
            // 
            // cb_startup
            // 
            this.cb_startup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_startup.AutoSize = true;
            this.cb_startup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_startup.Location = new System.Drawing.Point(3, 51);
            this.cb_startup.Name = "cb_startup";
            this.cb_startup.Size = new System.Drawing.Size(218, 18);
            this.cb_startup.TabIndex = 2;
            this.cb_startup.Text = "Start Memory Cleaner on system startup";
            this.cb_startup.UseVisualStyleBackColor = true;
            this.cb_startup.CheckedChanged += new System.EventHandler(this.cb_startup_CheckedChanged);
            // 
            // cb_autotimerres
            // 
            this.cb_autotimerres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_autotimerres.AutoSize = true;
            this.cb_autotimerres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_autotimerres.Location = new System.Drawing.Point(3, 27);
            this.cb_autotimerres.Name = "cb_autotimerres";
            this.cb_autotimerres.Size = new System.Drawing.Size(191, 18);
            this.cb_autotimerres.TabIndex = 0;
            this.cb_autotimerres.Text = "Start timer resolution automatically";
            this.cb_autotimerres.UseVisualStyleBackColor = true;
            this.cb_autotimerres.CheckedChanged += new System.EventHandler(this.cb_autotimerres_CheckedChanged);
            // 
            // cb_minimize
            // 
            this.cb_minimize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_minimize.AutoSize = true;
            this.cb_minimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_minimize.Location = new System.Drawing.Point(3, 3);
            this.cb_minimize.Name = "cb_minimize";
            this.cb_minimize.Size = new System.Drawing.Size(102, 18);
            this.cb_minimize.TabIndex = 1;
            this.cb_minimize.Text = "Start minimized";
            this.cb_minimize.UseVisualStyleBackColor = true;
            this.cb_minimize.CheckedChanged += new System.EventHandler(this.cb_minimize_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.GroupBoxStartupSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericud_timerres)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            this.GroupBoxStartupSettings.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButtonReset;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button ButtonClose;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        public System.Windows.Forms.Label label_hotkey;
        public System.Windows.Forms.CheckBox cb_standbylist;
        public System.Windows.Forms.CheckBox cb_workingset;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        public System.Windows.Forms.CheckBox cb_timer;
        public System.Windows.Forms.NumericUpDown numericud_timerres;
        public System.Windows.Forms.Label label_timerres;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        public System.Windows.Forms.Label label_timer;
        public System.Windows.Forms.ComboBox cmbox_timer;
        public System.Windows.Forms.CheckBox cb_timerres;
        public System.Windows.Forms.GroupBox GroupBoxStartupSettings;
        public System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
        public System.Windows.Forms.CheckBox cb_startup;
        public System.Windows.Forms.CheckBox cb_autotimerres;
        public System.Windows.Forms.CheckBox cb_minimize;
        public System.Windows.Forms.TextBox txtbox_hotkey;
        public System.Windows.Forms.CheckBox cb_modifiedlist;
        public System.Windows.Forms.CheckBox cb_lowpriostandbylist;
    }
}