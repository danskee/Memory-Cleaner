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
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelMemoryCleaner = new System.Windows.Forms.Label();
            this.LinkGithub = new System.Windows.Forms.LinkLabel();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClose.AutoSize = true;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonClose.Location = new System.Drawing.Point(273, 88);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 58;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelMemoryCleaner
            // 
            this.LabelMemoryCleaner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelMemoryCleaner.AutoSize = true;
            this.LabelMemoryCleaner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelMemoryCleaner.Location = new System.Drawing.Point(12, 9);
            this.LabelMemoryCleaner.Name = "LabelMemoryCleaner";
            this.LabelMemoryCleaner.Size = new System.Drawing.Size(83, 13);
            this.LabelMemoryCleaner.TabIndex = 0;
            this.LabelMemoryCleaner.Text = "Memory Cleaner";
            this.LabelMemoryCleaner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LinkGithub
            // 
            this.LinkGithub.ActiveLinkColor = System.Drawing.Color.White;
            this.LinkGithub.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LinkGithub.AutoSize = true;
            this.LinkGithub.LinkColor = System.Drawing.SystemColors.ControlText;
            this.LinkGithub.Location = new System.Drawing.Point(12, 66);
            this.LinkGithub.Name = "LinkGithub";
            this.LinkGithub.Size = new System.Drawing.Size(105, 13);
            this.LinkGithub.TabIndex = 1;
            this.LinkGithub.TabStop = true;
            this.LinkGithub.Text = "github.com/danskee";
            this.LinkGithub.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkGithub.Click += new System.EventHandler(this.LinkGithub_Click);
            // 
            // LabelAbout
            // 
            this.LabelAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelAbout.Location = new System.Drawing.Point(12, 30);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(130, 26);
            this.LabelAbout.TabIndex = 61;
            this.LabelAbout.Text = "Version x, 64-bit\r\nCopyright © 2021 Danske";
            this.LabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Line.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Line.Location = new System.Drawing.Point(-19, 115);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(397, 13);
            this.Line.TabIndex = 62;
            this.Line.Text = "_________________________________________________________________";
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelCopyright.Location = new System.Drawing.Point(13, 136);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(333, 52);
            this.LabelCopyright.TabIndex = 63;
            this.LabelCopyright.Text = resources.GetString("LabelCopyright.Text");
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 196);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.LabelAbout);
            this.Controls.Add(this.LinkGithub);
            this.Controls.Add(this.LabelMemoryCleaner);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelMemoryCleaner;
        private System.Windows.Forms.LinkLabel LinkGithub;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label LabelCopyright;
    }
}