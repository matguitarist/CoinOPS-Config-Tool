using System;
using System.IO;
using MetroSet_UI.Forms;
using System.Diagnostics;
using System.Xml;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinOPS_Config_Tool.FilesManagement;
using CoinOPS_Config_Tool.Properties;

namespace Main
{
    public partial class MainWindows : MetroSetForm
    {
        // Gain Access to other classes
        private readonly Data data = new Data();
        private readonly FilesDownloader filesDownloader = new FilesDownloader();
        private readonly Extractor extractor = new Extractor();
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


        // Target path variable
        public string targetCopsPath;
        public string targetEmulatorsPath;
        private string targetToolsPath;
        private string targetCollectionsPath;
        private string targetLauncherPath;


        private string systemName;
        private string fileToDisplay;
        private string logoToDisplay;

        public string selectedEmuName;

        // Temp Variable
        private readonly string tempFolder = Path.GetTempPath();


        // Extracting Variable
        public string zipSource;
        public string targetFolder;

        // CoinOPS Setting Variable
        private string copsTheme;


        public MainWindows()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            CheckForIllegalCrossThreadCalls = false;
        }


        // Load saved setttings at launch
        private void MainWindows_Load(object sender, EventArgs e)
        {
            tbMainCopsPath.Text = Settings.Default["CopsPath"].ToString();
            SetPath();
            msThemeSwitch.Switched = (bool)Settings.Default["Theme"];
        }



        // Save user settings
        private void SaveSettingButton_Click(object sender, EventArgs e)
        {
            Settings.Default["Theme"] = msThemeSwitch.Switched;
            Settings.Default["CopsPath"] = targetCopsPath;
            Settings.Default.Save();
        }



        // Select Theme
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



        // Browse coinOPS Path
        private void BtnMainBrowse_Click(object sender, EventArgs e)
        {
            folderbd.ShowDialog();
            tbMainCopsPath.Text = folderbd.SelectedPath;
            SetPath();
            //GetCopsTheme();
        }


        // Set Paths
        private void SetPath()
        {
            targetCopsPath = tbMainCopsPath.Text;
            targetEmulatorsPath = targetCopsPath + "\\emulators\\";
            tbMainEmuTxtPath.Text = targetEmulatorsPath;
            targetCollectionsPath = targetCopsPath + "\\collections\\";
            tbMainColTxtPath.Text = targetCollectionsPath;
            targetLauncherPath = targetCopsPath + "\\launchers.windows\\";
            tbMainLauncherTxtPath.Text = targetLauncherPath;
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
                    extractor.ExtractFile(zipSource, targetFolder);
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


        // copy launcher function
        public void CopySystemLauncher()
        {
            string sourceFile = sourceLauncherPath + systemName + ".conf";
            string destFile = targetLauncherPath + systemName + ".conf";

            File.Copy(sourceFile, destFile, true); // add ask for overwriting?
        }



        // Download buttons
        private void BtnEmuDownload_Click(object sender, EventArgs e)
        {
            filesDownloader.downloadLink = sysAndTools.EmuURL;

            lblEmuDownloadStatus.Text = filesDownloader.statusTxt;
            lblDownloadSpeedValue.Text = filesDownloader.downloadSpeed;
            EmuProgressBar.Value = filesDownloader.completionBar;
            lblEmuDownloadedValue.Text = filesDownloader.downloadedSize;
            lblEmuPercent.Text = filesDownloader.progressionValue;

            sysAndTools.SetEmuDownloadPath();
            filesDownloader.DownloadingFile();
            if (!filesDownloader.isDownloading)
            {
                zipSource = sysAndTools.downloadedFileName;
                //targetFolder = emulatorsPath + selectedEmuName;
                extractor.ExtractFile(zipSource, targetFolder);
            }
        }

        // Pause download
        public void PauseButton_Click(object sender, EventArgs e)
        {
            if (filesDownloader.httpDownloader != null)
                filesDownloader.httpDownloader.Pause();
        }

        // Resume Download
        public void ResumeButton_Click(object sender, EventArgs e)
        {
            if (filesDownloader.httpDownloader != null)
                filesDownloader.httpDownloader.Resume();
        }

        // Extract button
        private void BtnEmuExtract_Click(object sender, EventArgs e)
        {
            {
                sysAndTools.SetEmuDownloadPath();
                zipSource = sysAndTools.downloadedFileName;

                extractor.ExtractFile(zipSource, tbEmuFolderDestination.Text);
            }
        }



        // Install Visual Runtime AIO
        private void BtnInstallRuntime_Click(object sender, EventArgs e)
        {
            SetDownloadProgress();
            filesDownloader.DownloadVisualRuntime();

            if (!filesDownloader.isDownloading)
            {
                string extractedFile = tempFolder + "VisualCppRedist_AIO_x86_x64.exe";
                zipSource = tempFolder + "VisualCppRedist_AIO_x86_x64_45.zip";
                targetFolder = tempFolder;
                extractor.ExtractFile(zipSource, targetFolder);
                Process.Start(extractedFile);
            }
        }

        // Install TorrentZip
        private void BtnInstallTorrentZip_Click(object sender, EventArgs e)
        {
            targetToolsPath = targetCopsPath + "\\tools\\";
            SetDownloadProgress();

            string torrentUI = targetToolsPath + "TrrntZipUI.exe";

            if (File.Exists(torrentUI))
            {
                Process.Start(torrentUI);
            }

            else
            {
                filesDownloader.DownloadTorrentZip();
                if (!filesDownloader.isDownloading)
                {
                    zipSource = tempFolder + "TrrntZipUI280.zip";
                    extractor.ExtractFile(zipSource, targetToolsPath);
                    Process.Start(torrentUI);
                }

            }
        }

        // Install DirectX
        private void BtnToolsInstallDirectX_Click(object sender, EventArgs e)
        {

            string directX = tempFolder + "dxwebsetup.exe";

            if (File.Exists(directX))
            {
                Process.Start(directX);
            }

            else
            {
                SetDownloadProgress();
                filesDownloader.DownloadDirectX();
                if (!filesDownloader.isDownloading)
                {
                    zipSource = tempFolder + "dxwebsetup.exe";
                    Process.Start(directX);
                }
            }
        }

        // Install Romcenter
        private void BtnToolsInstallRomsCenter_Click(object sender, EventArgs e)
        {

            string romcenter = tempFolder + "romcenter32_4.1.1.exe";

            if (File.Exists(romcenter))
            {
                Process.Start(romcenter);
            }

            else
            {
                filesDownloader.DownloadRomcenter();
                SetDownloadProgress();
                filesDownloader.isDownloading = false;
                if (!filesDownloader.isDownloading)
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


        public void SetDownloadProgress()
        {
            lblToolsStatusValue.Text = filesDownloader.statusTxt;
            lblToolsDownloadedValue.Text = filesDownloader.downloadedSize;
            lblToolsDownloadSpeedValue.Text = filesDownloader.downloadSpeed;
            TxtEmuPercent.Text = filesDownloader.completionTxt;
        }

        private void CbSettingTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string infoTxtPath = targetCopsPath + "setting.txt";
            if (File.Exists(infoTxtPath))
            {
                string readText = File.ReadAllText(infoTxtPath);
                lblSysTxtInfo.Text = readText;
            }

            else
            {
                MetroSetMessageBox.Show(this, "No theme available");
            }

        }

        /*private void GetCopsTheme()
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
                        break;
                    }
                    else if (layout.Contains("Animatic") == true)
                    {
                        copsTheme = layout;
                        tbSettingTheme.Text = "Animatic";
                        break;
                    }
                    else if (layout.Contains("Flatio") == true)
                    {
                        copsTheme = layout;
                        tbSettingTheme.Text = "Flatio";
                        break;
                    }
                    /*else
                    {
                        tbSettingTheme.Text = "Unknown theme";
                        MetroSetMessageBox.Show(this, "You are using an unknown theme");
                        break;
                    }

                }

                reader.Close();
            }

        }*/


    }
}
