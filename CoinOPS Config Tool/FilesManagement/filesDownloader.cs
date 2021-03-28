using AltoHttp;
using System;
using System.IO;
using System.Windows.Forms;

namespace CoinOPS_Config_Tool.FilesManagement
{

    internal class FilesDownloader
    {
        public HttpDownloader httpDownloader;

        public bool isDownloading;

        public string downloadLink;

        public string downloadSpeed;
        public string completionTxt;
        public int completionBar;
        public string downloadedSize;
        public string downloadStatus;
        public string statusTxt;
        public string progressionValue;


        // Manage Download
        public void DownloadingFile()
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
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.ProgressChanged += HttpDownloader_progressChanged;
                httpDownloader.Start();
            }
        }

        public void HttpDownloader_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ToolsProgressBarTool.Value = completionBar;
            //lblToolsDownloadedValue.Text = completionTxt;
            //lblToolsSpeedValue.Text = downloadSpeed;
            //lblToolsDownloadedValue.Text = downloadedSize;
            //lblStatus.Text = downloadStatus;

            downloadSpeed = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            completionTxt = $"{e.Progress.ToString("0.00")} % ";
            completionBar = (int)e.Progress;
            downloadedSize = string.Format("{0} MB", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            downloadStatus = "Downloading ...";
        }

        public void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            {
                statusTxt = "Download completed";
                progressionValue = "100%";
                isDownloading = false;
            }
        }



        public void DownloadVisualRuntime()
        {
            downloadLink = "https://github.com/abbodi1406/vcredist/releases/download/v0.45.0/VisualCppRedist_AIO_x86_x64_45.zip";
            DownloadingFile();
        }


        public void DownloadTorrentZip()
        {
            downloadLink = "https://www.romvault.com/trrntzip/download/TrrntZipUI280.zip";
            DownloadingFile();
        }
    }
}