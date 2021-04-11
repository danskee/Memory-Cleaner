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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory_Cleaner.Settings;

namespace Memory_Cleaner.Updating
{
    class Check
    {
        public static WebClient wc = new WebClient();

        public static float CheckForUpdates()
        {
            Memory_Cleaner.Settings.Registry.Write("CheckedForUpdates", "True");
            string newestver = wc.DownloadString("https://raw.githubusercontent.com/danskee/MemoryCleaner/main/version").Replace("\n", "").Replace("\r", "");
            return Convert.ToSingle(newestver.Replace(".", ""));
        }
    }
}
