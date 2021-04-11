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
    partial class LicenseAgreementDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseAgreementDialog));
            this.License = new System.Windows.Forms.RichTextBox();
            this.ButtonDecline = new System.Windows.Forms.Button();
            this.ButtonAgree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // License
            // 
            this.License.Location = new System.Drawing.Point(13, 12);
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Size = new System.Drawing.Size(441, 238);
            this.License.TabIndex = 0;
            this.License.Text = resources.GetString("License.Text");
            // 
            // ButtonDecline
            // 
            this.ButtonDecline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDecline.Location = new System.Drawing.Point(379, 261);
            this.ButtonDecline.Name = "ButtonDecline";
            this.ButtonDecline.Size = new System.Drawing.Size(75, 21);
            this.ButtonDecline.TabIndex = 61;
            this.ButtonDecline.Text = "Decline";
            this.ButtonDecline.UseVisualStyleBackColor = true;
            this.ButtonDecline.Click += new System.EventHandler(this.ButtonDecline_Click);
            // 
            // ButtonAgree
            // 
            this.ButtonAgree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAgree.Location = new System.Drawing.Point(298, 261);
            this.ButtonAgree.Name = "ButtonAgree";
            this.ButtonAgree.Size = new System.Drawing.Size(75, 21);
            this.ButtonAgree.TabIndex = 62;
            this.ButtonAgree.Text = "Agree";
            this.ButtonAgree.UseVisualStyleBackColor = true;
            this.ButtonAgree.Click += new System.EventHandler(this.ButtonAgree_Click);
            // 
            // LicenseAgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 291);
            this.Controls.Add(this.ButtonAgree);
            this.Controls.Add(this.ButtonDecline);
            this.Controls.Add(this.License);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseAgreementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memory Cleaner License Agreement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox License;
        public System.Windows.Forms.Button ButtonDecline;
        public System.Windows.Forms.Button ButtonAgree;
    }
}