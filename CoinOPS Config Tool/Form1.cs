using System;
using System.Drawing;
using System.IO;
using MetroSet_UI.Forms;
using System.Diagnostics;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinOPS_Config_Tool.FilesManagement;

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
        }


        // Select Theme
        private void metroSetSwitch1_SwitchedChanged(object sender)
        {
            if (metroStyleManager.Style == MetroSet_UI.Enums.Style.Light)
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
            targetCopsPath = tbMainCopsPath.Text;
            targetEmulatorsPath = targetCopsPath + "\\emulators\\";
            tbMainEmuTxtPath.Text = targetEmulatorsPath;
            targetCollectionsPath = targetCopsPath + "\\collections\\";
            tbMainColTxtPath.Text = targetCollectionsPath;
            targetLauncherPath = targetCopsPath + "\\launchers.windows\\";
            tbMainLauncherTxtPath.Text = targetLauncherPath;
                        GetCopsTheme();
        }

        private void BtnEmuOpen_Click(object sender, EventArgs e)
        {
            // Determine whether the directory exists.
            if (!Directory.Exists(targetEmulatorsPath))
            {
                MessageBox.Show("Folder not found.");
                return;
            }

            else
            {
                Process.Start(targetEmulatorsPath);
            }

        }

        private void BtnCollectonOpen_Click(object sender, EventArgs e)
        { 
            if (!Directory.Exists(targetCollectionsPath))
            {
                MessageBox.Show("Folder not found.");
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
                MessageBox.Show("Folder not found.");
                return;
            }

            else
            {
                Process.Start(targetCollectionsPath);
            }
        }



        // Settings Buttons
        private void SettingButton_MouseHover(object sender, EventArgs e)
        {
            // To do show tooltip
        }

        private void SettingButton_MouseLeave(object sender, EventArgs e)
        {
            // To do hide tooltip
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            //To do
        }



        //Save Button to XML
        /*private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                data = XmlManager.XmlDataReader("config.xml");
                data.CopsPath = tbCopsPath.Text;
                data.EmuPath = EmuTxtPath.Text;
                data.LauncherPath = copsPath + "\\launchers.windows\\";
                data.EmuPath = emulatorsPath;
                //systemPathFolder = copsPath + selectedEmuName;
                XmlManager.XmlDataWriter(data, "config.xml");
                MessageBox.Show("data successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured" + ex.ToString());
            }
        }*/



        // Add new system
        private void BntSysAddSystem_Click(object sender, EventArgs e)
        {
            systemName = cbSysSelSystem.Text;

            zipSource = sourceCollectionPath + systemName + ".7z";



            {
                // Determine whether the directory exists.
                if (Directory.Exists(sourceCollectionPath + systemName))
                {
                    MessageBox.Show("That system directory exists already.");
                    return;
                }
                else
                {
                    targetFolder = targetCopsPath;
                    targetCollectionsPath = targetCopsPath + "\\collections\\";
                    string openDir = targetCollectionsPath + systemName;
                    CopySystemLauncher();
                    extractor.ExtractFile(zipSource, targetFolder);
                    MessageBox.Show("All directories were created successfully");
                    if (Directory.Exists(openDir))
                    {
                        Process.Start(openDir);
                    }
                    else
                    {
                        MessageBox.Show("The target directory not found");
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




        // Delete temp files
        private void BtnDeleteTemp_Click(object sender, EventArgs e)
        {
            EmptyTempFolder();
        }

        // Install Visual Runtime AIO
        private void btnInstallRuntime_Click(object sender, EventArgs e)
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



        // Delete file in temp folder
        public void EmptyTempFolder()
        {
            var dir = new DirectoryInfo(tempFolder);
            foreach (var file in Directory.GetFiles(dir.ToString()))
            {
                File.Delete(file);
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
                MessageBox.Show("Description unavailable");
            }
            fileToDisplay = sourceSystemImagePath + systemName + ".jpg";
            logoToDisplay = sourceSystemLogoPath + systemName + ".png";
            SystemPictureBox.ImageLocation = fileToDisplay;
            SysLogoPictureBox.BackColor = Color.Transparent;
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
            ToolsProgressBar.Value = filesDownloader.completionBar;
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
                MessageBox.Show("No theme available");
            }

        }

        private void GetCopsTheme()
        {
            using (var reader = new StreamReader(targetCopsPath + "\\settings.conf"))
            {
                while (!reader.EndOfStream)
                {
                    var layout = reader.ReadLine();

                    if (layout.Contains("Worlds"))
                    {
                        copsTheme = layout;
                        tbSettingTheme.Text = "Worlds";
                        break;
                    }
                    else if (layout.Contains("Animatic"))
                    {
                        copsTheme = layout;
                        tbSettingTheme.Text = "Animatic";
                        break;
                    }
                    else if (layout.Contains("Flatio"))
                    {
                        copsTheme = layout;
                        tbSettingTheme.Text = "Flatio";
                        break;
                    }
                    else
                    {
                        tbSettingTheme.Text = "Unknown theme";
                        MessageBox.Show("You are using an unknown theme");
                        break;
                    }

                }

                reader.Close();
            }

        }
    

    }
}
