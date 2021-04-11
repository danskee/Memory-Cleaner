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
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Cleaner.Updating
{
    class Download
    {
        public static string Folder;
        public static WebClient wc = new WebClient();

        public static void DownloadNewestVersion(string newestver)
        {
            SelectFolder();

            try
            {
                wc.DownloadFile("https://github.com/danskee/MemoryCleaner/releases/download/v" + newestver + "/" + "MemoryCleaner-v" + newestver + ".zip", Folder + @"\" + "MemoryCleaner-v" + newestver + ".zip");
                ZipFile.ExtractToDirectory(Folder + @"\" + "MemoryCleaner-v" + newestver + ".zip", Folder);
                File.Delete(Folder + @"\" + "MemoryCleaner-v" + newestver + ".zip");
                MessageBox.Show("Succesfully downloaded the newest version in " + Folder + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to download the newest version. Make sure you have a stable internet connection and that you're not trying to overwrite an already existing file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Folder = fbd.SelectedPath;
            }
            else if (fbd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Please select a folder where to download the newest version in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectFolder();
            }
        }
    }
}
