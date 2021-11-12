using System;
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
                EmuURL = "https://github.com/mamedev/mame/releases/download/mame0237/mame0237b_64bit.exe";
                downloadedFileName = "mame0237b_64bit.exe";
                systemType = "Arcade Emulator";
            }

            else if (selectedEmuName == "RetroArch")
            {
                EmuURL = "https://buildbot.libretro.com/stable/1.9.13/windows/x86_64/RetroArch.7z";
                downloadedFileName = tempFolder + "RetroArch.7z";
                systemType = "Multi System Emulator";
            }

            else if (selectedEmuName == "Dolphin")
            {
                EmuURL = "https://dl.dolphin-emu.org/builds/76/43/dolphin-master-5.0-15260-x64.7z";
                downloadedFileName = "dolphin-master-5.0-15260-x64.7z";
                systemType = "Gamecube and Wii";
            }

            else if (selectedEmuName == "Cemu")
            {
                EmuURL = "https://cemu.info/releases/cemu_1.25.6.zip";
                downloadedFileName = "cemu_1.25.6.zip";  // need to rename folder to cemu after extraction
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
                EmuURL = "https://github.com/RPCS3/rpcs3-binaries-win/releases/download/build-8b3ed7b5991d649c726c9b966b30032540ce598b/rpcs3-v0.0.19-13006-8b3ed7b5_win64.7z";
                downloadedFileName = "rpcs3-v0.0.19-13006-8b3ed7b5_win64.7z";
                systemType = "PS3 Emulator";
            }

            else if (selectedEmuName == "PPSSPP")
            {
                EmuURL = "https://www.ppsspp.org/files/1_12_3/ppsspp_win.zip";
                downloadedFileName = "ppsspp_win.zip";
                systemType = "Sony PSP Emulator";
            }

            else
            {
                MessageBox.Show("This emulator has not been implemented yet." + Environment.NewLine + "          It will be add in a future update!");
            }

        }


        public void DownloadTheme(string themeName)
        {
            fileSource = tempFolder + downloadedFileName;

            if (themeName == "Worlds")
            {
                themeURL = "https://github.com/matguitarist/CoinOPS-Config-Tool/raw/master/CoinOPS%20Config%20Tool/Themes/Worlds.7z";
                downloadedFileName = tempFolder + "Worlds.7z";
            }

            else if (themeName == "Animatic")
            {
                themeURL = "http://retrofe.nl/Download/Themes/Animatic/Animatic.zip";
                downloadedFileName = tempFolder + "Animatic.zip";
            }

            else if (themeName == "Flatio")
            {
                themeURL = "http://retrofe.nl/Download/Themes/Flatio/Flatio%2016x9.zip";
                downloadedFileName = tempFolder + "Flatio%2016x9.zip";
            }

            else if (themeName == "Pandora's Box HD Blue")
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