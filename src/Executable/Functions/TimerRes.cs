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
using System.Runtime.InteropServices;

namespace Memory_Cleaner.Functions
{
    class TimerRes
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Timer
        {
            public uint min;
            public uint max;
            public uint cur;
        }

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern void NtSetTimerResolution(uint DesiredResolution, bool SetResolution, ref uint CurrentResolution);

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern int NtQueryTimerResolution(out uint MinimumResolution, out uint MaximumResolution, out uint ActualResolution);

        public static uint CurrentResolution;

        public static void SetTimerRes(bool enabled, uint value)
        {
            switch (enabled)
            {
                case true:
                    NtSetTimerResolution(value, true, ref CurrentResolution);
                    break;

                case false:
                    NtSetTimerResolution(value, false, ref CurrentResolution);
                    break;
            }
        }

        public static Timer Get()
        {
            var a = new Timer();
            NtQueryTimerResolution(out a.min, out a.max, out a.cur);
            return a;
        }
    }
}
