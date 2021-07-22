using AltoHttp;
using AltoHttp.Exceptions;
using CoinOPS_Config_Tool.FilesManagement;
using CoinOPS_Config_Tool.Properties;
using MetroSet_UI.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Main
{
    public partial class MainWindows : MetroSetForm
    {
        // Gain Access to other classes
        //private readonly Extractor extractor = new Extractor();
        private readonly SystemsAndTools sysAndTools = new SystemsAndTools();
        private readonly FolderBrowserDialog folderbd = new FolderBrowserDialog();
        private readonly FileReadWrite fileReadAndWrite = new FileReadWrite();

        // Source path variable
        private readonly string sourceLauncherPath = Directory.GetCurrentDirectory() + "\\launchers\\";
        private readonly string sourceToolsPath = Directory.GetCurrentDirectory() + "\\Tools\\";
        private readonly string sourceCollectionPath = Directory.GetCurrentDirectory() + "\\collections\\";
        private readonly string sourceSystemImagePath = Directory.GetCurrentDirectory() + "\\Systems_Images\\";
        private readonly string sourceSystemLogoPath = Directory.GetCurrentDirectory() + "\\Systems_Logos\\";
        private readonly string sourceSystemInfoPath = Directory.GetCurrentDirectory() + "\\Systems_Infos\\";
        private readonly string sourceThemeImagePath = Directory.GetCurrentDirectory() + "\\CopsThemesImages\\";

        // Target path variable
        public string targetCopsPath;
        public string targetEmulatorsPath;
        private string targetToolsPath;
        private string targetCollectionsPath;
        private string targetLauncherPath;
        private string targetThemePath;
        private string FolderPath;

        private string systemName;
        private string fileToDisplay;
        private string logoToDisplay;
        //private string actualThemeImage;
        //private string selectedThemeImage;

        public string selectedEmuName;

        // Temp Variable
        private readonly string tempFolder = Path.GetTempPath();

        // Downloader variable
        public HttpDownloader httpDownloader;

        public bool isDownloading;

        public string downloadLink;

        public string statusTxt;
        public string downloadSpeed;
        public string downloadedSize;
        public string downloadStatus;
        public string progressionValue;
        public string completionTxt;
        public int completionBar;

        // Extractor Variable
        public string zipSource;

        public string targetFolder;

        // CoinOPS Setting Variable
        private string copsTheme;
        private bool toolsDownloadClicked;
        private bool isExtracting;

        public bool EmuDownloadClicked { get; private set; }

        public MainWindows()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }



        // Load saved setttings at launch
        private void MainWindows_Load(object sender, EventArgs e)
        {
            tbMainCopsPath.Text = Settings.Default["CopsPath"].ToString();
            SetPath();
            msThemeSwitch.Switched = (bool)Settings.Default["Theme"];
            HideEMUDownloadProgress();
            HideToolsDownloadProgress();
            GetCopsTheme();
        }

        // Save user settings
        private void SaveSettingButton_Click(object sender, EventArgs e)
        {
            Settings.Default["Theme"] = msThemeSwitch.Switched;
            Settings.Default["CopsPath"] = targetCopsPath;
            Settings.Default.Save();
        }



        // Select light or dark Theme
        private void MsThemeSwitch_SwitchedChanged(object sender)
        {
            if (msThemeSwitch.Switched == false)//(metroStyleManager.Style == MetroSet_UI.Enums.Style.Light)
            {
                metroStyleManager.Style = MetroSet_UI.Enums.Style.Dark;
            }
            else
            {
                metroStyleManager.Style = MetroSet_UI.Enums.Style.Light;
            }
        }



        // Set CoinOPS Paths
        private void BtnMainBrowse_Click(object sender, EventArgs e)
        {
            folderbd.ShowDialog();
            tbMainCopsPath.Text = folderbd.SelectedPath;
            SetPath();
            //GetCopsTheme();
        }

        private void SetPath()
        {
            targetCopsPath = tbMainCopsPath.Text;

            targetEmulatorsPath = targetCopsPath + "\\emulators\\";
            FolderPath = targetEmulatorsPath;
            CreateDir(FolderPath);

            tbMainEmuTxtPath.Text = targetEmulatorsPath;

            targetCollectionsPath = targetCopsPath + "\\collections\\";
            FolderPath = targetCollectionsPath;
            CreateDir(FolderPath);

            tbMainColTxtPath.Text = targetCollectionsPath;

            targetLauncherPath = targetCopsPath + "\\launchers.windows\\";
            FolderPath = targetLauncherPath;
            CreateDir(FolderPath);

            tbMainLauncherTxtPath.Text = targetLauncherPath;

            targetThemePath = targetCopsPath + "\\layouts\\";
            FolderPath = targetThemePath;
            CreateDir(FolderPath);

        }

        private void CreateDir(string FolderPath)
        {

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(FolderPath))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(FolderPath);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(FolderPath));

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }


        private void BtnEmuOpen_Click(object sender, EventArgs e)
        {
            // Determine whether the directory exists.
            if (!Directory.Exists(targetEmulatorsPath))
            {
                MetroSetMessageBox.Show(this, "Folder not found.");
                return;
            }
            else
            {
                Process.Start(targetEmulatorsPath);
            }
        }

        private void BtnCollectionOpen_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(targetCollectionsPath))
            {
                MetroSetMessageBox.Show(this, "Folder not found.");
                return;
            }
            else
            {
                Process.Start(targetCollectionsPath);
            }
        }

        private void BtnLauncherOpen_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(targetCollectionsPath))
            {
                MetroSetMessageBox.Show(this, "Folder not found.");
                return;
            }
            else
            {
                Process.Start(targetCollectionsPath);
            }
        }



        // Add new system
        private void BntSysAddSystem_Click(object sender, EventArgs e)
        {
            systemName = cbSysSelSystem.Text;

            zipSource = sourceCollectionPath + systemName + ".7z";

            {
                // Determine whether the directory exists.
                if (Directory.Exists(sourceCollectionPath + systemName))
                {
                    MetroSetMessageBox.Show(this, "That system directory exists already.");
                    return;
                }
                else
                {
                    targetFolder = targetCopsPath;
                    targetCollectionsPath = targetCopsPath + "\\collections\\";
                    string openDir = targetCollectionsPath + systemName;
                    CopySystemLauncher();
                    ExtractFile(zipSource, targetFolder);
                    MetroSetMessageBox.Show(this, "All directories were created successfully");
                    if (Directory.Exists(openDir))
                    {
                        Process.Start(openDir);
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "The target directory not found");
                    }
                }
            }
        }

        public void CopySystemLauncher()
        {
            string sourceFile = sourceLauncherPath + systemName + ".conf";
            string destFile = targetLauncherPath + systemName + ".conf";

            File.Copy(sourceFile, destFile, true); // add ask for overwriting?
        }



        // Download buttons
        private void BtnEmuDownload_Click(object sender, EventArgs e)
        {
            downloadLink = sysAndTools.EmuURL;
            EmuDownloadClicked = true;
            sysAndTools.SetEmuDownloadPath();

            DownloadingFile(sender,e);

            if (!isDownloading)
            {
                zipSource = sysAndTools.downloadedFileName;
                targetFolder = targetEmulatorsPath + selectedEmuName;
                ExtractFile(zipSource, targetFolder);
            }

        }

        // Pause download
        public void PauseButton_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Pause();
        }

        // Resume Download
        public void ResumeButton_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
        }

        // Extract button
        private void BtnEmuExtract_Click(object sender, EventArgs e)
        {
            {
                sysAndTools.SetEmuDownloadPath();
                zipSource = sysAndTools.downloadedFileName;

                ExtractFile(zipSource, tbEmuFolderDestination.Text);
            }
        }



        // Install Visual Runtime AIO
        private void BtnInstallRuntime_Click(object sender, EventArgs e)
        {
            toolsDownloadClicked = true;
            downloadLink = "https://github.com/abbodi1406/vcredist/releases/download/v0.45.0/VisualCppRedist_AIO_x86_x64_45.zip";
            DownloadingFile(sender, e);
            toolsDownloadClicked = false;
            if (!isDownloading)
            {
                string extractedFile = tempFolder + "VisualCppRedist_AIO_x86_x64.exe";
                zipSource = tempFolder + "VisualCppRedist_AIO_x86_x64_45.zip";
                targetFolder = tempFolder;
                ExtractFile(zipSource, targetFolder);
                Process.Start(extractedFile);
            }
        }

        // Install TorrentZip
        private void BtnInstallTorrentZip_Click(object sender, EventArgs e)
        {
            toolsDownloadClicked = true;
            targetToolsPath = targetCopsPath + "\\tools\\";

            string torrentUI = targetToolsPath + "TrrntZipUI.exe";

            if (File.Exists(torrentUI))
            {
                Process.Start(torrentUI);
            }
            else
            {
                downloadLink = "https://www.romvault.com/trrntzip/download/TrrntZipUI280.zip";
                DownloadingFile(sender, e);

                if (!isDownloading)
                {
                    zipSource = tempFolder + "TrrntZipUI280.zip";
                    ExtractFile(zipSource, targetToolsPath);
                    Process.Start(torrentUI);
                }
            }
        }

        // Install DirectX
        private void BtnToolsInstallDirectX_Click(object sender, EventArgs e)
        {
            toolsDownloadClicked = true;
            string directX = tempFolder + "dxwebsetup.exe";

            if (File.Exists(directX))
            {
                Process.Start(directX);
            }
            else
            {
                downloadLink = "https://download.microsoft.com/download/1/7/1/1718CCC4-6315-4D8E-9543-8E28A4E18C4C/dxwebsetup.exe";
                DownloadingFile(sender, e);
                if (!isDownloading)
                {
                    zipSource = tempFolder + "dxwebsetup.exe";
                    Process.Start(directX);
                }
            }
        }

        // Install Romcenter
        private void BtnToolsInstallRomsCenter_Click(object sender, EventArgs e)
        {
            toolsDownloadClicked = true; 
            string romcenter = tempFolder + "romcenter32_4.1.1.exe";

            if (File.Exists(romcenter))
            {
                Process.Start(romcenter);
            }
            else
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://www.romcenter.com/downloadfile.php?file=romcenter32_4.1.1.exe", tempFolder + "romcenter32_4.1.1.exe");
                    isDownloading = true;

                }
                isDownloading = false;
                if (!isDownloading)
                {
                    Process.Start(romcenter);
                }
            }
        }



        // Set System text and image
        private void CbSysSelSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            systemName = cbSysSelSystem.Text;

            string infoTxtPath = sourceSystemInfoPath + systemName + ".txt";
            if (File.Exists(infoTxtPath))
            {
                string readText = File.ReadAllText(infoTxtPath);
                lblSysTxtInfo.Text = readText;
            }
            else
            {
                MetroSetMessageBox.Show(this, "Description unavailable");
            }
            fileToDisplay = sourceSystemImagePath + systemName + ".jpg";
            logoToDisplay = sourceSystemLogoPath + systemName + ".png";
            SystemPictureBox.ImageLocation = fileToDisplay;
            lblSysTxtInfo.BorderStyle = BorderStyle.FixedSingle;
            SystemPictureBox.BorderStyle = BorderStyle.FixedSingle;
            SysLogoPictureBox.ImageLocation = logoToDisplay;
        }


        // Set emulators Paths
        private void CbEmuSelecEmulator_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEmuName = cbEmuSelecEmulator.Text;
            sysAndTools.selectedEmuName = selectedEmuName;
            sysAndTools.SetEmuDownloadPath();
            TbEmuDownloadLink.Text = sysAndTools.EmuURL;
            tbEmuFolderDestination.Text = targetEmulatorsPath + selectedEmuName;
            lblEmuSystemType.Text = sysAndTools.systemType;
            targetFolder = tbEmuFolderDestination.Text;
        }



        // Themes Functions
        private void CbSettingTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string themeName = cbSettingTheme.Text;
            pbSelectedTheme.ImageLocation = sourceThemeImagePath + themeName + ".jpg";
            sysAndTools.selectedThemeName = cbSettingTheme.Text;
            //string infoTxtPath = targetCopsPath + "setting.txt";

            /*if (File.Exists(infoTxtPath))
            {
                string readText = File.ReadAllText(infoTxtPath);
                lblSysTxtInfo.Text = readText;
            }
            else
            {
                MetroSetMessageBox.Show(this, "No theme available");
            }*/
        }

        private void GetCopsTheme()
        {
            string path = targetCopsPath + "\\settings.conf";
            bool fileExist = File.Exists(path);

            if (fileExist)
            {

                using (var reader = new StreamReader(targetCopsPath + "\\settings.conf"))
                {
                    while (!reader.EndOfStream)
                    {
                        var layout = reader.ReadLine();

                        if (layout.Contains("Worlds") == true)
                        {
                            copsTheme = layout;
                            tbSettingTheme.Text = "Worlds";
                        }
                        else if (layout.Contains("Animatic") == true)
                        {
                            copsTheme = layout;
                            tbSettingTheme.Text = "Animatic";
                        }
                        else if (layout.Contains("Flatio") == true)
                        {
                            copsTheme = layout;
                            tbSettingTheme.Text = "Flatio";
                        }
                        /*else
                        {
                            tbSettingTheme.Text = "Unknown theme";
                            MetroSetMessageBox.Show(this, "You are using an unknown theme");
                            break;
                        }*/
                    }
                    reader.Close();

                    string themeName = tbSettingTheme.Text;
                    //string themeImage = sourceThemeImagePath + themeName + ".jpg";

                    pbActualTheme.ImageLocation = sourceThemeImagePath + themeName + ".jpg";
                }

            }
            else
                MessageBox.Show("Setting File don't exist, creating ...");


        }

        private void BtnThemeDownload_Click(object sender, EventArgs e)
        {
            sysAndTools.DownloadTheme();
            sysAndTools.selectedThemeName = cbSettingTheme.Text;
            downloadLink = sysAndTools.themeURL;

            DownloadingFile(sender, e);
            if (!isDownloading)
            {
                zipSource = sysAndTools.downloadedFileName;
                targetFolder = targetThemePath;
                ExtractFile(zipSource, targetThemePath);
            }
        }



        // Manage Downloading Function
        public void DownloadingFile(object sender, EventArgs e)
        {
            string temp = Path.GetTempPath();
            string path = $"{temp}\\{Path.GetFileName(downloadLink)}";
            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                MessageBox.Show("File already exist, extracting ...");
                isDownloading = false;

            }
            else
            {
                isDownloading = true;
                httpDownloader = new HttpDownloader(downloadLink, path);
                httpDownloader.ProgressChanged += HttpDownloader_progressChanged;
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.ErrorOccured += HttpDownloader_ErrorOccured;
                httpDownloader.Start();
            }

        }

        public void HttpDownloader_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadSpeed = e.SpeedInBytes.ToHumanReadableSize() + "/s";
            completionTxt = $"{e.Progress.ToString("0.00")} % ";
            completionBar = (int)e.Progress;
            downloadedSize = string.Format("{0} / {1}", httpDownloader.TotalBytesReceived.ToHumanReadableSize(),
            httpDownloader.Info.Length > 0 ? httpDownloader.Info.Length.ToHumanReadableSize() : "Unknown");
            statusTxt = "Downloading ...";

            if(EmuDownloadClicked)
            {
                ShowEMUDownloadProgress();
                lblEmuDownloadStatus.Text = statusTxt;
                lblEmuDownloadedValue.Text = downloadedSize;
                lblEmuDownloadSpeedValue.Text = downloadSpeed;
                lblEmuPercent.Text = completionTxt;
                EmuProgressBar.Value = completionBar;
            }

            else if (toolsDownloadClicked)
            {
                ShowToolsDownloadProgress();
                lblToolsStatusValue.Text = statusTxt;
                lblToolsDownloadedValue.Text = downloadedSize;
                lblToolsDownloadSpeedValue.Text = downloadSpeed;
                lblToolsPercent.Text = completionTxt;
                ToolsProgressBar.Value = completionBar;
            }

            statusTxt = "Download completed";
        }

        public void HttpDownloader_ErrorOccured(object sender, ErrorEventArgs e)
        {
            var ex = e.GetException();
            if (ex is FileValidationFailedException)
            {
                httpDownloader.Pause();
            }
            MessageBox.Show("Error: " + e.GetException().Message + " " + e.GetException().StackTrace);
        }

        public void HttpDownloader_DownloadCompleted(object sender, EventArgs e)  // Status never change need fix
        {
            Invoke((MethodInvoker)delegate
            {
                statusTxt = "Download completed";
                progressionValue = "100%";
                isDownloading = false;
                HideEMUDownloadProgress();
                HideToolsDownloadProgress();
            });

        }


        // Show  and hide emulator tab download progress
        private void ShowEMUDownloadProgress()
        {
            lblEmuDownloadedValue.Visible = true;
            lblEmuDownloadSpeedValue.Visible = true;
            lblEmuPercent.Visible = true;
            EmuProgressBar.Visible = true;
        }
        private void HideEMUDownloadProgress()
        {
            lblEmuDownloadedValue.Visible = false;
            lblEmuDownloadSpeedValue.Visible = false;
            lblEmuPercent.Visible = false;
            EmuProgressBar.Visible = false;
        }


        // Show  and hide Tools tab download progress
        private void ShowToolsDownloadProgress()
        {
            lblToolsDownloadedValue.Visible = true;
            lblToolsDownloadSpeedValue.Visible = true;
            lblToolsPercent.Visible = true;
            ToolsProgressBar.Visible = true;
        }
        private void HideToolsDownloadProgress()
        {
            lblToolsDownloadedValue.Visible = false;
            lblToolsDownloadSpeedValue.Visible = false;
            lblToolsPercent.Visible = false;
            ToolsProgressBar.Visible = false;
        }



        // Extract and compress functions
        public void ExtractFile(string zipSource, string targetFolder)
        {

            string zPath = "7za.exe"; //add to project and set CopyToOuputDir
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Normal,
                    FileName = zPath,
                    Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", zipSource, targetFolder)
                };
                Process x = Process.Start(pro);
                isExtracting = true;
                statusTxt = " Extracting ...";
                x.WaitForExit();
                statusTxt = "Waiting";
                MessageBox.Show("Extracted Completed");
            }
            catch (System.Exception)
            {
                //handle error
                MessageBox.Show("An error has occured");
            }
            isExtracting = false;
        }

        public void CreateZip(string sourceName, string targetArchive)
        {
            ProcessStartInfo p = new ProcessStartInfo
            {
                FileName = "7za.exe",
                Arguments = string.Format("a -tzip \"{0}\" \"{1}\" -mx=9", targetArchive, sourceName),
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process x = Process.Start(p);
            x.WaitForExit();
        }

    }
}