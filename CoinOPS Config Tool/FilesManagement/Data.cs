using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace CoinOPS_Config_Tool.FilesManagement
{
    public class Data
    {
        private string _copsPath;
        public string CopsPath
        {
            get { return _copsPath; }
            set { _copsPath = value; }
        }

        private string _emuPath;
        public string EmuPath
        {
            get { return _emuPath; }
            set { _emuPath = value; }
        }

        private string _installedSystems;
        public string InstalledSystems
        {
            get { return _installedSystems; }
            set { _installedSystems = value; }
        }

        private string _launcherPath;
        public string LauncherPath
        {
            get { return _launcherPath; }
            set { _launcherPath = value; }
        }

    }
}
