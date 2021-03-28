using System.Diagnostics;
using System.Windows.Forms;


namespace CoinOPS_Config_Tool.FilesManagement
{
    internal class Extractor
    {

        public string statusTxt;
        public bool isExtracting;


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
            catch (System.Exception Ex)
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