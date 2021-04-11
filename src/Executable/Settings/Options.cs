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

namespace Memory_Cleaner.Settings
{
    class Options
    {
        public static void Hotkey(TextBox txtbox, KeyEventArgs e)
        {
            switch (Control.ModifierKeys)
            {
                case Keys.Shift:
                    switch (e.KeyCode.ToString())
                    {
                        case "ShiftKey":
                            break;

                        default:
                            txtbox.Text = "Shift + " + e.KeyCode.ToString();
                            break;
                    }
                    break;

                case Keys.Control:
                    switch (e.KeyCode.ToString())
                    {
                        case "ControlKey":
                            break;

                        default:
                            txtbox.Text = "Control + " + e.KeyCode.ToString();
                            break;
                    }
                    break;

                case Keys.Alt:
                    switch (e.KeyCode.ToString())
                    {
                        case "Menu":
                            break;

                        default:
                            txtbox.Text = "Alt + " + e.KeyCode.ToString();
                            break;
                    }
                    break;

                default:
                    txtbox.Text = e.KeyCode.ToString();
                    break;
            }

            Memory_Cleaner.Settings.Registry.Write("HotkeyToCleanMemory", txtbox.Text);
        }

        public static void Checkboxes(CheckBox cb, string valuename)
        {
            switch (cb.Checked)
            {
                case true:
                    Memory_Cleaner.Settings.Registry.Write(valuename, "1");
                    break;

                case false:
                    Memory_Cleaner.Settings.Registry.Write(valuename, "0");
                    break;
            }
        }
    }
}
