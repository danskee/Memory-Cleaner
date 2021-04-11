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

using System;
using System.Windows.Forms;

namespace Memory_Cleaner.Updating
{
    class Calculate
    {
        public static void Updates(int currentversion)
        {
            currentversion = Convert.ToInt32(currentversion.ToString().Replace(".", ""));

            if (currentversion < Check.CheckForUpdates())
            {
                switch (MessageBox.Show("The version " + Check.CheckForUpdates().ToString().Insert(1, ".").Insert(3, ".") + " is available. Download?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Updating.Download.DownloadNewestVersion(Check.CheckForUpdates().ToString().Insert(1, ".").Insert(3, "."));
                        break;
                }
            }
        }
    }
}
