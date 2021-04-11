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
using Memory_Cleaner;
using Microsoft.Win32;
using Memory_Cleaner.Settings;

namespace Memory_Cleaner.Settings
{
    class Read
    {
        public static void ReadOrAssignSettings()
        {
            // Copyright License
            if (Memory_Cleaner.Settings.Registry.Exists("LicenseAccepted") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("LicenseAccepted", "False");
            }

            // Enable Clearing Of The Standby List
            if (Memory_Cleaner.Settings.Registry.Exists("EnableClearingOfTheStandbyList") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("EnableClearingOfTheStandbyList", "1");
            }

            // Enable Flushing Of The Modified List
            if (Memory_Cleaner.Settings.Registry.Exists("EnableFlushingOfTheModifiedList") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("EnableFlushingOfTheModifiedList", "1");
            }

            // Enable Custom Timer Resolution
            if (Memory_Cleaner.Settings.Registry.Exists("EnableCustomTimerResolution") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("EnableCustomTimerResolution", "1");
            }

            // Enable Clearing Of The Low Priority Standby List
            if (Memory_Cleaner.Settings.Registry.Exists("EnableClearingOfTheLowPriorityStandbyList") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("EnableClearingOfTheLowPriorityStandbyList", "1");
            }

            // Enable Emptying Of The Working Set
            if (Memory_Cleaner.Settings.Registry.Exists("EnableEmptyingOfTheWorkingSet") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("EnableEmptyingOfTheWorkingSet", "1");
            }

            // Start Memory Cleaner On System Startup
            if (Memory_Cleaner.Settings.Registry.Exists("StartMemoryCleanerOnSystemStartup") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("StartMemoryCleanerOnSystemStartup", "0");
            }

            // Start Minimized
            if (Memory_Cleaner.Settings.Registry.Exists("StartMinimized") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("StartMinimized", "0");
            }

            // Start Timer Resolution Automatically
            if (Memory_Cleaner.Settings.Registry.Exists("StartTimerResolutionAutomatically") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("StartTimerResolutionAutomatically", "0");
            }

            // Timer Enabled
            if (Memory_Cleaner.Settings.Registry.Exists("TimerEnabled") == false)
            {
                Memory_Cleaner.Settings.Registry.Write("TimerEnabled", "1");
            }
        }
    }
}
