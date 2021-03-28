using System;
using System.IO;
using System.Windows.Forms;

namespace CoinOPS_Config_Tool.FilesManagement
{
    internal class FileReadWrite
    {
        public string path;
        public string readText;

        public void ReadAndWriteFile()
        {
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                MessageBox.Show("The files does not exist");
                // Create a file to write to.
                //string createText = "" + Environment.NewLine;
                //File.WriteAllText(path, createText, Encoding.UTF8);
            }
            else
            {
                // Open the file to read from.
                readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
        }
    }
}