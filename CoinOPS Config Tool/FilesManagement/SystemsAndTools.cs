﻿using System;
using System.IO;
using System.Windows.Forms;


namespace CoinOPS_Config_Tool.FilesManagement
{
    internal class SystemsAndTools
    {
        private readonly string tempFolder = Path.GetTempPath();

        public string EmuURL;
        public string themeURL;
        public string downloadedFileName;
        public string fileSource;
        public string selectedEmuName;
        public string selectedThemeName;
        public string systemType;

        public void SetEmuDownloadPath()
        {

            //string yuzuURL = "https://github.com/yuzu-emu/liftinstall/releases/download/1.8/yuzu_install.exe";
            //string citraURL = "https://github.com/citra-emu/citra-canary/releases/download/canary-1956/citra-windows-mingw-20210311-7a60d46.7z";

            fileSource = tempFolder + downloadedFileName;

            if (selectedEmuName == "Mame")
            {
                EmuURL = "https://github.com/mamedev/mame/releases/download/mame0234/mame0234b_64bit.exe";
                downloadedFileName = "mame0234b_64bit.exe";
                systemType = "Arcade Emulator";
            }

            else if (selectedEmuName == "RetroArch")
            {
                EmuURL = "https://buildbot.libretro.com/stable/1.9.7/windows/x86_64/RetroArch.7z";
                downloadedFileName = tempFolder + "RetroArch.7z";
                systemType = "Multi System Emulator";
            }

            else if (selectedEmuName == "Dolphin")
            {
                EmuURL = "https://dl.dolphin-emu.org/builds/5a/6c/dolphin-master-5.0-14790-x64.7z";
                downloadedFileName = "dolphin-master-5.0-14790-x64.7z";
                systemType = "Gamecube and Wii";
            }

            else if (selectedEmuName == "Cemu")
            {
                EmuURL = "https://cemu.info/releases/cemu_1.25.1.zip";
                downloadedFileName = "cemu_1.25.1.zip";  // need to rename folder to cemu after extraction
                systemType = "Wii U Emulator";
            }

            else if (selectedEmuName == "DuckStation")
            {
                EmuURL = "https://github.com/stenzek/duckstation/releases/download/latest/duckstation-windows-x64-release.zip";
                downloadedFileName = "duckstation-windows-x64-release.zip";
                systemType = "PS1 Emulator";
            }

            else if (selectedEmuName == "PCSX2")
            {
                EmuURL = "https://github.com/PCSX2/pcsx2/releases/download/v1.6.0/pcsx2-1.6.0-binaries.7z";
                downloadedFileName = "pcsx2-1.6.0-binaries.7z";
                systemType = "PS2 Emulator";
            }

            else if (selectedEmuName == "Rpcs3")
            {
                EmuURL = "https://github.com/RPCS3/rpcs3-binaries-win/releases/download/build-f745971cc8e85d8f71622c9e6ce25437febb50a9/rpcs3-v0.0.17-12611-f745971c_win64.7z";
                downloadedFileName = "rpcs3-v0.0.17-12611-f745971c_win64.7z";
                systemType = "PS3 Emulator";
            }

            else if (selectedEmuName == "PPSSPP")
            {
                EmuURL = "https://www.ppsspp.org/files/1_11_3/ppsspp_win.zip";
                downloadedFileName = "ppsspp_win.zip";
                systemType = "Sony PSP Emulator";
            }

            else
            {
                MessageBox.Show("This emulator has not been implemented yet." + Environment.NewLine + "          It will be add in a future update!");
            }

        }


        public void DownloadTheme()
        {
            fileSource = tempFolder + downloadedFileName;

            if (selectedThemeName == "Worlds")
            {
                themeURL = "https://github.com/mamedev/mame/releases/download/mame0230/mame0230b_64bit.exe";
                downloadedFileName = "mame0230b_64bit.exe";
            }

            else if (selectedThemeName == "Animatic")
            {
                themeURL = "http://retrofe.nl/Download/Themes/Animatic/Animatic.zip";
                downloadedFileName = tempFolder + "Animatic.zip";
            }

            else if (selectedThemeName == "Flatio")
            {
                themeURL = "http://retrofe.nl/Download/Themes/Flatio/Flatio%2016x9.zip";
                downloadedFileName = tempFolder + "Flatio%2016x9.zip";
            }

            else if (selectedThemeName == "Pandora's Box HD Blue")
            {

                themeURL = "http://retrofe.nl/Download/Themes/Pandora" + "'" + "s%20Box%20HD/Pandora's%20Box%20HD.zip";
                downloadedFileName = tempFolder + "Pandora's Box HD.zip";
            }

            else
            {
                MessageBox.Show("This theme has not been implemented yet." + Environment.NewLine + "          It will be add in a future update!");
            }
        }
    }
}