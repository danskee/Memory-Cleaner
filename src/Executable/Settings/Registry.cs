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

namespace Memory_Cleaner.Settings
{
    class Registry
    {
        public static RegistryKey Settings = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Memory Cleaner", true);

        public static void Write(string valuename, string value)
        {
            Settings.SetValue(valuename, value, RegistryValueKind.String);
        }

        public static string Read(string valuename)
        {
            return Settings.GetValue(valuename).ToString();
        }

        public static bool Exists(string valuename)
        {
            if (Settings.GetValue(valuename) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
