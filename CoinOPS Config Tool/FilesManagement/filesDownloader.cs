using AltoHttp;
using AltoHttp.Exceptions;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MetroSet_UI.Forms;

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
        private readonly string tempFolder = Path.GetTempPath();


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
                httpDownloader = new HttpDownloader(downloadLink, path);
                httpDownloader.ProgressChanged += HttpDownloader_progressChanged;
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.ErrorOccured += HttpDownloader_ErrorOccured;
                isDownloading = true;
                httpDownloader.Start();
            }
        }

        public void HttpDownloader_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            //downloadSpeed = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            downloadSpeed = e.SpeedInBytes.ToHumanReadableSize() + "/s";
            completionTxt = $"{e.Progress.ToString("0.00")} % ";
            completionBar = (int)e.Progress;
            //downloadedSize = string.Format("{0} MB", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            downloadedSize = string.Format("{0} / {1}", httpDownloader.TotalBytesReceived.ToHumanReadableSize(),
                httpDownloader.Info.Length >0 ? httpDownloader.Info.Length.ToHumanReadableSize() : "Unknown");
            downloadStatus = "Downloading ...";
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

        public void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            
            {
                statusTxt = "Download completed";
                progressionValue = "100%";
                isDownloading = false;
            }
        }

    }
}