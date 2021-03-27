using System;
using System.Drawing;
using System.IO;
using CoinOPS_Configurator.FilesManagement;
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

namespace Main
{
    public partial class MainWindows : MetroSetForm
    {
        private readonly Data data = new Data();
        private readonly FilesDownloader filesDownloader = new FilesDownloader();
        private readonly Extractor extractor = new Extractor();
        private readonly SystemsAndTools sysAndTools = new SystemsAndTools();
        private readonly FolderBrowserDialog folderbd = new FolderBrowserDialog();


        // Path variable
        private string systemPathFolder;

        private readonly string sourceLauncherPath = Directory.GetCurrentDirectory() + "\\launchers\\";
        private readonly string mainToolsPath = Directory.GetCurrentDirectory() + "\\Tools\\";
        private readonly string sourceCollectionPath = Directory.GetCurrentDirectory() + "\\collections\\";
        private readonly string sourceSystemImagePath = Directory.GetCurrentDirectory() + "\\Systems_Images\\";
        private string sourceSystemLogoPath = Directory.GetCurrentDirectory() + "\\Systems_Logos\\";
        public string copsPath;
        public string emulatorsPath;
        private string toolsTargetPath;
        private string collectionsTargetPath;
        private string launcherTargetPath;

        private string systemName;
        private string fileToDisplay;
        private string logoToDisplay;
        public string selectedEmuName;

        //Temp Variable
        private readonly string tempFolder = Path.GetTempPath();


        // Extracting Variable
        public string zipSource;
        public string targetFolder;


        public MainWindows()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }


        //Select Theme
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
            copsPath = tbMainCopsPath.Text;
            emulatorsPath = copsPath + "\\emulators\\";
            tbMainEmuTxtPath.Text = emulatorsPath;
            collectionsTargetPath = copsPath + "\\collections\\";
            tbMainColTxtPath.Text = collectionsTargetPath;
            launcherTargetPath = copsPath + "\\launchers.windows\\";
            tbMainLauncherTxtPath.Text = launcherTargetPath;
        }

        private void BtnEmuOpen_Click(object sender, EventArgs e)
        {
            // Determine whether the directory exists.
            if (!Directory.Exists(emulatorsPath))
            {
                MessageBox.Show("Folder not found.");
                return;
            }

            else
            {
                Process.Start(emulatorsPath);
            }

        }

        private void BtnCollectonOpen_Click(object sender, EventArgs e)
        { 
            if (!Directory.Exists(collectionsTargetPath))
            {
                MessageBox.Show("Folder not found.");
                return;
            }

            else
            {
                Process.Start(collectionsTargetPath);
            }
        }

        private void BtnLauncherOpen_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(collectionsTargetPath))
            {
                MessageBox.Show("Folder not found.");
                return;
            }

            else
            {
                Process.Start(collectionsTargetPath);
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



        // Save Button to XML
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
            
            systemPathFolder = sourceCollectionPath + systemName;


            {
                // Determine whether the directory exists.
                if (Directory.Exists(systemPathFolder))
                {
                    MessageBox.Show("That system directory exists already.");
                    return;
                }
                else
                {
                    targetFolder = copsPath;
                    collectionsTargetPath = copsPath + "\\collections\\";
                    string openDir = collectionsTargetPath + systemName;
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
            toolsTargetPath = copsPath + "\\tools\\";
            SetDownloadProgress();

            string torrentUI = toolsTargetPath + "TrrntZipUI.exe";

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
                    extractor.ExtractFile(zipSource, toolsTargetPath);
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

        // copy launcher function
        public void CopySystemLauncher()
        {
            string sourceFile = sourceLauncherPath + systemName + ".conf";
            string destFile = launcherTargetPath + systemName + ".conf";

            File.Copy(sourceFile, destFile, true); // add ask for overwriting?
        }

        // Set emulators Paths
        private void CbEmuSelecEmulator_TextChanged(object sender, EventArgs e)
        {

            selectedEmuName = cbEmuSelecEmulator.Text;
            sysAndTools.selectedEmuName = selectedEmuName;
            sysAndTools.SetEmuDownloadPath();
            TbEmuDownloadLink.Text = sysAndTools.EmuURL;
            tbEmuFolderDestination.Text = emulatorsPath + selectedEmuName;
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

        private void CbSysSelSystem_TextChanged(object sender, EventArgs e)
        {
            systemName = cbSysSelSystem.Text;
            fileToDisplay = sourceSystemImagePath + systemName + ".jpg";
            logoToDisplay = sourceSystemLogoPath + systemName + ".png";
            SystemPictureBox.ImageLocation = fileToDisplay;
            SysLogoPictureBox.ImageLocation = logoToDisplay;
        }
    }
}
