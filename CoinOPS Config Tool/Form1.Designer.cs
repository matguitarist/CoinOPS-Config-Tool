
namespace Main
{
    partial class MainWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseControlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroStyleManager = new MetroSet_UI.Components.StyleManager();
            this.TabSelection = new MetroSet_UI.Controls.MetroSetTabControl();
            this.TabMain = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.BtnSaveSetting = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnLauncherOpen = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnCollectonOpen = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnEmuOpen = new MetroSet_UI.Controls.MetroSetButton();
            this.txtMainLauncherPath = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbMainLauncherTxtPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMainCollectionPath = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbMainColTxtPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMainEmuPath = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbMainEmuTxtPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbMainCopsPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.TxtMainCopsPath = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnMainBrowse = new MetroSet_UI.Controls.MetroSetButton();
            this.TabSystem = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.SysLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSysTxtInfo = new MetroSet_UI.Controls.MetroSetLabel();
            this.SystemPictureBox = new System.Windows.Forms.PictureBox();
            this.bntSysAddSystem = new MetroSet_UI.Controls.MetroSetButton();
            this.TxtSysSelectSystem = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbSysSelSystem = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TabEmulators = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.BtnEmuExtract = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnEmuDownload = new MetroSet_UI.Controls.MetroSetButton();
            this.lblEmuSystemType = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbEmuFolderDestination = new MetroSet_UI.Controls.MetroSetTextBox();
            this.TxtEmuDownloadLink = new MetroSet_UI.Controls.MetroSetLabel();
            this.TbEmuDownloadLink = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblEmuDownloadStatus = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuStatusTxt = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuDownloadedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuDownloadSpeedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuPercent = new MetroSet_UI.Controls.MetroSetLabel();
            this.EmuProgressBar = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.lblEmuDownloadSpeed = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuDownloaded = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtEmuSelectEmulator = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbEmuSelecEmulator = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TxtEmuFolderDestination = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabTools = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnToolsInstallDirectX = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnToolsInstallRomsCenter = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnToolsInstallRuntime = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnToolsInstallTorrentZip = new MetroSet_UI.Controls.MetroSetButton();
            this.lblToolsStatusValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsStatus = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsDownloadedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsDownloadSpeedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.ToolsProgressBar = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.lblToolDownloadSpeed = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolDownloadedTxt = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsPercent = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetSetTabPage1 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.BtnDownloadApply = new MetroSet_UI.Controls.MetroSetButton();
            this.pbSelectedTheme = new System.Windows.Forms.PictureBox();
            this.pbActualTheme = new System.Windows.Forms.PictureBox();
            this.tbSettingTheme = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblSettingActualTheme = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblSettingTheme = new MetroSet_UI.Controls.MetroSetLabel();
            this.BtnThemeDownload = new MetroSet_UI.Controls.MetroSetButton();
            this.cbSettingTheme = new MetroSet_UI.Controls.MetroSetComboBox();
            this.fbd = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblThemeTxt = new MetroSet_UI.Controls.MetroSetLabel();
            this.msThemeSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroSetContextMenuStrip1 = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.lblVersion = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblVersionValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabSelection.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SysLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemPictureBox)).BeginInit();
            this.TabEmulators.SuspendLayout();
            this.TabTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroSetSetTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseControlBox
            // 
            this.CloseControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseControlBox.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.CloseControlBox.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.CloseControlBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.CloseControlBox.IsDerivedStyle = true;
            this.CloseControlBox.Location = new System.Drawing.Point(784, 8);
            this.CloseControlBox.MaximizeBox = true;
            this.CloseControlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CloseControlBox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.CloseControlBox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.CloseControlBox.MinimizeBox = true;
            this.CloseControlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CloseControlBox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.CloseControlBox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.CloseControlBox.Name = "CloseControlBox";
            this.CloseControlBox.Size = new System.Drawing.Size(100, 25);
            this.CloseControlBox.Style = MetroSet_UI.Enums.Style.Light;
            this.CloseControlBox.StyleManager = this.metroStyleManager;
            this.CloseControlBox.TabIndex = 0;
            this.CloseControlBox.Text = "metroSetControlBox1";
            this.CloseControlBox.ThemeAuthor = "Narwin";
            this.CloseControlBox.ThemeName = "MetroLight";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.CustomTheme = "C:\\Users\\matgu\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.metroStyleManager.MetroForm = this;
            this.metroStyleManager.Style = MetroSet_UI.Enums.Style.Light;
            this.metroStyleManager.ThemeAuthor = "Narwin";
            this.metroStyleManager.ThemeName = "MetroLight";
            // 
            // TabSelection
            // 
            this.TabSelection.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabSelection.AnimateTime = 200;
            this.TabSelection.BackgroundColor = System.Drawing.Color.White;
            this.TabSelection.Controls.Add(this.TabMain);
            this.TabSelection.Controls.Add(this.TabSystem);
            this.TabSelection.Controls.Add(this.TabEmulators);
            this.TabSelection.Controls.Add(this.TabTools);
            this.TabSelection.Controls.Add(this.metroSetSetTabPage1);
            this.TabSelection.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabSelection.IsDerivedStyle = true;
            this.TabSelection.ItemSize = new System.Drawing.Size(100, 38);
            this.TabSelection.Location = new System.Drawing.Point(50, 100);
            this.TabSelection.Name = "TabSelection";
            this.TabSelection.SelectedIndex = 0;
            this.TabSelection.SelectedTextColor = System.Drawing.Color.White;
            this.TabSelection.ShowToolTips = true;
            this.TabSelection.Size = new System.Drawing.Size(800, 450);
            this.TabSelection.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabSelection.Speed = 100;
            this.TabSelection.Style = MetroSet_UI.Enums.Style.Light;
            this.TabSelection.StyleManager = this.metroStyleManager;
            this.TabSelection.TabIndex = 1;
            this.TabSelection.ThemeAuthor = "Narwin";
            this.TabSelection.ThemeName = "MetroLight";
            this.TabSelection.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabSelection.UseAnimation = false;
            // 
            // TabMain
            // 
            this.TabMain.BaseColor = System.Drawing.Color.White;
            this.TabMain.Controls.Add(this.BtnSaveSetting);
            this.TabMain.Controls.Add(this.BtnLauncherOpen);
            this.TabMain.Controls.Add(this.BtnCollectonOpen);
            this.TabMain.Controls.Add(this.BtnEmuOpen);
            this.TabMain.Controls.Add(this.txtMainLauncherPath);
            this.TabMain.Controls.Add(this.tbMainLauncherTxtPath);
            this.TabMain.Controls.Add(this.txtMainCollectionPath);
            this.TabMain.Controls.Add(this.tbMainColTxtPath);
            this.TabMain.Controls.Add(this.txtMainEmuPath);
            this.TabMain.Controls.Add(this.tbMainEmuTxtPath);
            this.TabMain.Controls.Add(this.tbMainCopsPath);
            this.TabMain.Controls.Add(this.TxtMainCopsPath);
            this.TabMain.Controls.Add(this.btnMainBrowse);
            this.TabMain.Font = null;
            this.TabMain.ImageIndex = 0;
            this.TabMain.ImageKey = null;
            this.TabMain.IsDerivedStyle = true;
            this.TabMain.Location = new System.Drawing.Point(4, 42);
            this.TabMain.Name = "TabMain";
            this.TabMain.Size = new System.Drawing.Size(792, 404);
            this.TabMain.Style = MetroSet_UI.Enums.Style.Light;
            this.TabMain.StyleManager = this.metroStyleManager;
            this.TabMain.TabIndex = 0;
            this.TabMain.Text = "Main Path";
            this.TabMain.ThemeAuthor = "Narwin";
            this.TabMain.ThemeName = "MetroLight";
            this.TabMain.ToolTipText = "Main Path";
            // 
            // BtnSaveSetting
            // 
            this.BtnSaveSetting.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSaveSetting.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSaveSetting.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnSaveSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveSetting.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSaveSetting.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnSaveSetting.HoverTextColor = System.Drawing.Color.White;
            this.BtnSaveSetting.IsDerivedStyle = true;
            this.BtnSaveSetting.Location = new System.Drawing.Point(694, 14);
            this.BtnSaveSetting.Name = "BtnSaveSetting";
            this.BtnSaveSetting.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSaveSetting.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnSaveSetting.NormalTextColor = System.Drawing.Color.White;
            this.BtnSaveSetting.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnSaveSetting.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnSaveSetting.PressTextColor = System.Drawing.Color.White;
            this.BtnSaveSetting.Size = new System.Drawing.Size(90, 35);
            this.BtnSaveSetting.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnSaveSetting.StyleManager = this.metroStyleManager;
            this.BtnSaveSetting.TabIndex = 14;
            this.BtnSaveSetting.Text = "Save settings";
            this.BtnSaveSetting.ThemeAuthor = "Narwin";
            this.BtnSaveSetting.ThemeName = "MetroLight";
            this.BtnSaveSetting.Click += new System.EventHandler(this.SaveSettingButton_Click);
            // 
            // BtnLauncherOpen
            // 
            this.BtnLauncherOpen.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnLauncherOpen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnLauncherOpen.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnLauncherOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLauncherOpen.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnLauncherOpen.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnLauncherOpen.HoverTextColor = System.Drawing.Color.White;
            this.BtnLauncherOpen.IsDerivedStyle = true;
            this.BtnLauncherOpen.Location = new System.Drawing.Point(726, 320);
            this.BtnLauncherOpen.Name = "BtnLauncherOpen";
            this.BtnLauncherOpen.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnLauncherOpen.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnLauncherOpen.NormalTextColor = System.Drawing.Color.White;
            this.BtnLauncherOpen.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnLauncherOpen.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnLauncherOpen.PressTextColor = System.Drawing.Color.White;
            this.BtnLauncherOpen.Size = new System.Drawing.Size(58, 29);
            this.BtnLauncherOpen.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnLauncherOpen.StyleManager = this.metroStyleManager;
            this.BtnLauncherOpen.TabIndex = 13;
            this.BtnLauncherOpen.Text = "Open";
            this.BtnLauncherOpen.ThemeAuthor = "Narwin";
            this.BtnLauncherOpen.ThemeName = "MetroLight";
            this.BtnLauncherOpen.Click += new System.EventHandler(this.BtnLauncherOpen_Click);
            // 
            // BtnCollectonOpen
            // 
            this.BtnCollectonOpen.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnCollectonOpen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnCollectonOpen.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnCollectonOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCollectonOpen.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnCollectonOpen.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnCollectonOpen.HoverTextColor = System.Drawing.Color.White;
            this.BtnCollectonOpen.IsDerivedStyle = true;
            this.BtnCollectonOpen.Location = new System.Drawing.Point(726, 230);
            this.BtnCollectonOpen.Name = "BtnCollectonOpen";
            this.BtnCollectonOpen.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnCollectonOpen.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnCollectonOpen.NormalTextColor = System.Drawing.Color.White;
            this.BtnCollectonOpen.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnCollectonOpen.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnCollectonOpen.PressTextColor = System.Drawing.Color.White;
            this.BtnCollectonOpen.Size = new System.Drawing.Size(58, 29);
            this.BtnCollectonOpen.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnCollectonOpen.StyleManager = this.metroStyleManager;
            this.BtnCollectonOpen.TabIndex = 12;
            this.BtnCollectonOpen.Text = "Open";
            this.BtnCollectonOpen.ThemeAuthor = "Narwin";
            this.BtnCollectonOpen.ThemeName = "MetroLight";
            this.BtnCollectonOpen.Click += new System.EventHandler(this.BtnCollectionOpen_Click);
            // 
            // BtnEmuOpen
            // 
            this.BtnEmuOpen.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuOpen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuOpen.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnEmuOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmuOpen.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnEmuOpen.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnEmuOpen.HoverTextColor = System.Drawing.Color.White;
            this.BtnEmuOpen.IsDerivedStyle = true;
            this.BtnEmuOpen.Location = new System.Drawing.Point(726, 150);
            this.BtnEmuOpen.Name = "BtnEmuOpen";
            this.BtnEmuOpen.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuOpen.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuOpen.NormalTextColor = System.Drawing.Color.White;
            this.BtnEmuOpen.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuOpen.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuOpen.PressTextColor = System.Drawing.Color.White;
            this.BtnEmuOpen.Size = new System.Drawing.Size(58, 29);
            this.BtnEmuOpen.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnEmuOpen.StyleManager = this.metroStyleManager;
            this.BtnEmuOpen.TabIndex = 11;
            this.BtnEmuOpen.Text = "Open";
            this.BtnEmuOpen.ThemeAuthor = "Narwin";
            this.BtnEmuOpen.ThemeName = "MetroLight";
            this.BtnEmuOpen.Click += new System.EventHandler(this.BtnEmuOpen_Click);
            // 
            // txtMainLauncherPath
            // 
            this.txtMainLauncherPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainLauncherPath.IsDerivedStyle = true;
            this.txtMainLauncherPath.Location = new System.Drawing.Point(0, 280);
            this.txtMainLauncherPath.Name = "txtMainLauncherPath";
            this.txtMainLauncherPath.Size = new System.Drawing.Size(330, 35);
            this.txtMainLauncherPath.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMainLauncherPath.StyleManager = this.metroStyleManager;
            this.txtMainLauncherPath.TabIndex = 10;
            this.txtMainLauncherPath.Text = "Launcher Folder Path";
            this.txtMainLauncherPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMainLauncherPath.ThemeAuthor = "Narwin";
            this.txtMainLauncherPath.ThemeName = "MetroLight";
            // 
            // tbMainLauncherTxtPath
            // 
            this.tbMainLauncherTxtPath.AutoCompleteCustomSource = null;
            this.tbMainLauncherTxtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMainLauncherTxtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMainLauncherTxtPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainLauncherTxtPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbMainLauncherTxtPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainLauncherTxtPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbMainLauncherTxtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainLauncherTxtPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbMainLauncherTxtPath.Image = null;
            this.tbMainLauncherTxtPath.IsDerivedStyle = true;
            this.tbMainLauncherTxtPath.Lines = null;
            this.tbMainLauncherTxtPath.Location = new System.Drawing.Point(0, 320);
            this.tbMainLauncherTxtPath.MaxLength = 32767;
            this.tbMainLauncherTxtPath.Multiline = false;
            this.tbMainLauncherTxtPath.Name = "tbMainLauncherTxtPath";
            this.tbMainLauncherTxtPath.ReadOnly = false;
            this.tbMainLauncherTxtPath.Size = new System.Drawing.Size(720, 29);
            this.tbMainLauncherTxtPath.Style = MetroSet_UI.Enums.Style.Light;
            this.tbMainLauncherTxtPath.StyleManager = this.metroStyleManager;
            this.tbMainLauncherTxtPath.TabIndex = 9;
            this.tbMainLauncherTxtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMainLauncherTxtPath.ThemeAuthor = "Narwin";
            this.tbMainLauncherTxtPath.ThemeName = "MetroLight";
            this.tbMainLauncherTxtPath.UseSystemPasswordChar = false;
            this.tbMainLauncherTxtPath.WatermarkText = "";
            // 
            // txtMainCollectionPath
            // 
            this.txtMainCollectionPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainCollectionPath.IsDerivedStyle = true;
            this.txtMainCollectionPath.Location = new System.Drawing.Point(0, 190);
            this.txtMainCollectionPath.Name = "txtMainCollectionPath";
            this.txtMainCollectionPath.Size = new System.Drawing.Size(330, 35);
            this.txtMainCollectionPath.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMainCollectionPath.StyleManager = this.metroStyleManager;
            this.txtMainCollectionPath.TabIndex = 8;
            this.txtMainCollectionPath.Text = "Collection Folder Path";
            this.txtMainCollectionPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMainCollectionPath.ThemeAuthor = "Narwin";
            this.txtMainCollectionPath.ThemeName = "MetroLight";
            // 
            // tbMainColTxtPath
            // 
            this.tbMainColTxtPath.AutoCompleteCustomSource = null;
            this.tbMainColTxtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMainColTxtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMainColTxtPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainColTxtPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbMainColTxtPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainColTxtPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbMainColTxtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainColTxtPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbMainColTxtPath.Image = null;
            this.tbMainColTxtPath.IsDerivedStyle = true;
            this.tbMainColTxtPath.Lines = null;
            this.tbMainColTxtPath.Location = new System.Drawing.Point(0, 230);
            this.tbMainColTxtPath.MaxLength = 32767;
            this.tbMainColTxtPath.Multiline = false;
            this.tbMainColTxtPath.Name = "tbMainColTxtPath";
            this.tbMainColTxtPath.ReadOnly = false;
            this.tbMainColTxtPath.Size = new System.Drawing.Size(720, 29);
            this.tbMainColTxtPath.Style = MetroSet_UI.Enums.Style.Light;
            this.tbMainColTxtPath.StyleManager = this.metroStyleManager;
            this.tbMainColTxtPath.TabIndex = 7;
            this.tbMainColTxtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMainColTxtPath.ThemeAuthor = "Narwin";
            this.tbMainColTxtPath.ThemeName = "MetroLight";
            this.tbMainColTxtPath.UseSystemPasswordChar = false;
            this.tbMainColTxtPath.WatermarkText = "";
            // 
            // txtMainEmuPath
            // 
            this.txtMainEmuPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainEmuPath.IsDerivedStyle = true;
            this.txtMainEmuPath.Location = new System.Drawing.Point(0, 110);
            this.txtMainEmuPath.Name = "txtMainEmuPath";
            this.txtMainEmuPath.Size = new System.Drawing.Size(330, 35);
            this.txtMainEmuPath.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMainEmuPath.StyleManager = this.metroStyleManager;
            this.txtMainEmuPath.TabIndex = 6;
            this.txtMainEmuPath.Text = "Emulators Folder Path";
            this.txtMainEmuPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMainEmuPath.ThemeAuthor = "Narwin";
            this.txtMainEmuPath.ThemeName = "MetroLight";
            // 
            // tbMainEmuTxtPath
            // 
            this.tbMainEmuTxtPath.AutoCompleteCustomSource = null;
            this.tbMainEmuTxtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMainEmuTxtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMainEmuTxtPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainEmuTxtPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbMainEmuTxtPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainEmuTxtPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbMainEmuTxtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainEmuTxtPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbMainEmuTxtPath.Image = null;
            this.tbMainEmuTxtPath.IsDerivedStyle = true;
            this.tbMainEmuTxtPath.Lines = null;
            this.tbMainEmuTxtPath.Location = new System.Drawing.Point(0, 150);
            this.tbMainEmuTxtPath.MaxLength = 32767;
            this.tbMainEmuTxtPath.Multiline = false;
            this.tbMainEmuTxtPath.Name = "tbMainEmuTxtPath";
            this.tbMainEmuTxtPath.ReadOnly = false;
            this.tbMainEmuTxtPath.Size = new System.Drawing.Size(720, 29);
            this.tbMainEmuTxtPath.Style = MetroSet_UI.Enums.Style.Light;
            this.tbMainEmuTxtPath.StyleManager = this.metroStyleManager;
            this.tbMainEmuTxtPath.TabIndex = 5;
            this.tbMainEmuTxtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMainEmuTxtPath.ThemeAuthor = "Narwin";
            this.tbMainEmuTxtPath.ThemeName = "MetroLight";
            this.tbMainEmuTxtPath.UseSystemPasswordChar = false;
            this.tbMainEmuTxtPath.WatermarkText = "";
            // 
            // tbMainCopsPath
            // 
            this.tbMainCopsPath.AutoCompleteCustomSource = null;
            this.tbMainCopsPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMainCopsPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMainCopsPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainCopsPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbMainCopsPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbMainCopsPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbMainCopsPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainCopsPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbMainCopsPath.Image = null;
            this.tbMainCopsPath.IsDerivedStyle = true;
            this.tbMainCopsPath.Lines = null;
            this.tbMainCopsPath.Location = new System.Drawing.Point(0, 70);
            this.tbMainCopsPath.MaxLength = 32767;
            this.tbMainCopsPath.Multiline = false;
            this.tbMainCopsPath.Name = "tbMainCopsPath";
            this.tbMainCopsPath.ReadOnly = false;
            this.tbMainCopsPath.Size = new System.Drawing.Size(720, 29);
            this.tbMainCopsPath.Style = MetroSet_UI.Enums.Style.Light;
            this.tbMainCopsPath.StyleManager = this.metroStyleManager;
            this.tbMainCopsPath.TabIndex = 4;
            this.tbMainCopsPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMainCopsPath.ThemeAuthor = "Narwin";
            this.tbMainCopsPath.ThemeName = "MetroLight";
            this.tbMainCopsPath.UseSystemPasswordChar = false;
            this.tbMainCopsPath.WatermarkText = "";
            // 
            // TxtMainCopsPath
            // 
            this.TxtMainCopsPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMainCopsPath.IsDerivedStyle = true;
            this.TxtMainCopsPath.Location = new System.Drawing.Point(0, 30);
            this.TxtMainCopsPath.Name = "TxtMainCopsPath";
            this.TxtMainCopsPath.Size = new System.Drawing.Size(330, 35);
            this.TxtMainCopsPath.Style = MetroSet_UI.Enums.Style.Light;
            this.TxtMainCopsPath.StyleManager = this.metroStyleManager;
            this.TxtMainCopsPath.TabIndex = 3;
            this.TxtMainCopsPath.Text = "Please select your CoinOPS Path";
            this.TxtMainCopsPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtMainCopsPath.ThemeAuthor = "Narwin";
            this.TxtMainCopsPath.ThemeName = "MetroLight";
            // 
            // btnMainBrowse
            // 
            this.btnMainBrowse.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMainBrowse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMainBrowse.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnMainBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainBrowse.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMainBrowse.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnMainBrowse.HoverTextColor = System.Drawing.Color.White;
            this.btnMainBrowse.IsDerivedStyle = true;
            this.btnMainBrowse.Location = new System.Drawing.Point(726, 70);
            this.btnMainBrowse.Name = "btnMainBrowse";
            this.btnMainBrowse.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMainBrowse.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMainBrowse.NormalTextColor = System.Drawing.Color.White;
            this.btnMainBrowse.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMainBrowse.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMainBrowse.PressTextColor = System.Drawing.Color.White;
            this.btnMainBrowse.Size = new System.Drawing.Size(58, 29);
            this.btnMainBrowse.Style = MetroSet_UI.Enums.Style.Light;
            this.btnMainBrowse.StyleManager = this.metroStyleManager;
            this.btnMainBrowse.TabIndex = 2;
            this.btnMainBrowse.Text = "...";
            this.btnMainBrowse.ThemeAuthor = "Narwin";
            this.btnMainBrowse.ThemeName = "MetroLight";
            this.btnMainBrowse.Click += new System.EventHandler(this.BtnMainBrowse_Click);
            // 
            // TabSystem
            // 
            this.TabSystem.BaseColor = System.Drawing.Color.White;
            this.TabSystem.Controls.Add(this.SysLogoPictureBox);
            this.TabSystem.Controls.Add(this.lblSysTxtInfo);
            this.TabSystem.Controls.Add(this.SystemPictureBox);
            this.TabSystem.Controls.Add(this.bntSysAddSystem);
            this.TabSystem.Controls.Add(this.TxtSysSelectSystem);
            this.TabSystem.Controls.Add(this.cbSysSelSystem);
            this.TabSystem.Font = null;
            this.TabSystem.ImageIndex = 0;
            this.TabSystem.ImageKey = null;
            this.TabSystem.IsDerivedStyle = true;
            this.TabSystem.Location = new System.Drawing.Point(4, 42);
            this.TabSystem.Name = "TabSystem";
            this.TabSystem.Size = new System.Drawing.Size(792, 404);
            this.TabSystem.Style = MetroSet_UI.Enums.Style.Light;
            this.TabSystem.StyleManager = this.metroStyleManager;
            this.TabSystem.TabIndex = 3;
            this.TabSystem.Text = "Systems";
            this.TabSystem.ThemeAuthor = "Narwin";
            this.TabSystem.ThemeName = "MetroLight";
            this.TabSystem.ToolTipText = "System Tab";
            // 
            // SysLogoPictureBox
            // 
            this.SysLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SysLogoPictureBox.Location = new System.Drawing.Point(20, 124);
            this.SysLogoPictureBox.Name = "SysLogoPictureBox";
            this.SysLogoPictureBox.Size = new System.Drawing.Size(300, 95);
            this.SysLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SysLogoPictureBox.TabIndex = 8;
            this.SysLogoPictureBox.TabStop = false;
            // 
            // lblSysTxtInfo
            // 
            this.lblSysTxtInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSysTxtInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysTxtInfo.IsDerivedStyle = true;
            this.lblSysTxtInfo.Location = new System.Drawing.Point(20, 222);
            this.lblSysTxtInfo.Name = "lblSysTxtInfo";
            this.lblSysTxtInfo.Size = new System.Drawing.Size(300, 182);
            this.lblSysTxtInfo.Style = MetroSet_UI.Enums.Style.Light;
            this.lblSysTxtInfo.StyleManager = this.metroStyleManager;
            this.lblSysTxtInfo.TabIndex = 7;
            this.lblSysTxtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSysTxtInfo.ThemeAuthor = "Narwin";
            this.lblSysTxtInfo.ThemeName = "MetroLight";
            // 
            // SystemPictureBox
            // 
            this.SystemPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SystemPictureBox.Location = new System.Drawing.Point(344, 124);
            this.SystemPictureBox.Name = "SystemPictureBox";
            this.SystemPictureBox.Size = new System.Drawing.Size(434, 280);
            this.SystemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SystemPictureBox.TabIndex = 6;
            this.SystemPictureBox.TabStop = false;
            // 
            // bntSysAddSystem
            // 
            this.bntSysAddSystem.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bntSysAddSystem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bntSysAddSystem.DisabledForeColor = System.Drawing.Color.Gray;
            this.bntSysAddSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntSysAddSystem.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bntSysAddSystem.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.bntSysAddSystem.HoverTextColor = System.Drawing.Color.White;
            this.bntSysAddSystem.IsDerivedStyle = true;
            this.bntSysAddSystem.Location = new System.Drawing.Point(703, 70);
            this.bntSysAddSystem.Name = "bntSysAddSystem";
            this.bntSysAddSystem.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bntSysAddSystem.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.bntSysAddSystem.NormalTextColor = System.Drawing.Color.White;
            this.bntSysAddSystem.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.bntSysAddSystem.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.bntSysAddSystem.PressTextColor = System.Drawing.Color.White;
            this.bntSysAddSystem.Size = new System.Drawing.Size(75, 26);
            this.bntSysAddSystem.Style = MetroSet_UI.Enums.Style.Light;
            this.bntSysAddSystem.StyleManager = this.metroStyleManager;
            this.bntSysAddSystem.TabIndex = 5;
            this.bntSysAddSystem.Text = "Add";
            this.bntSysAddSystem.ThemeAuthor = "Narwin";
            this.bntSysAddSystem.ThemeName = "MetroLight";
            this.bntSysAddSystem.Click += new System.EventHandler(this.BntSysAddSystem_Click);
            // 
            // TxtSysSelectSystem
            // 
            this.TxtSysSelectSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSysSelectSystem.IsDerivedStyle = true;
            this.TxtSysSelectSystem.Location = new System.Drawing.Point(20, 30);
            this.TxtSysSelectSystem.Name = "TxtSysSelectSystem";
            this.TxtSysSelectSystem.Size = new System.Drawing.Size(310, 35);
            this.TxtSysSelectSystem.Style = MetroSet_UI.Enums.Style.Light;
            this.TxtSysSelectSystem.StyleManager = this.metroStyleManager;
            this.TxtSysSelectSystem.TabIndex = 4;
            this.TxtSysSelectSystem.Text = "Please select a system";
            this.TxtSysSelectSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtSysSelectSystem.ThemeAuthor = "Narwin";
            this.TxtSysSelectSystem.ThemeName = "MetroLight";
            // 
            // cbSysSelSystem
            // 
            this.cbSysSelSystem.AllowDrop = true;
            this.cbSysSelSystem.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbSysSelSystem.BackColor = System.Drawing.Color.Transparent;
            this.cbSysSelSystem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbSysSelSystem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbSysSelSystem.CausesValidation = false;
            this.cbSysSelSystem.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbSysSelSystem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbSysSelSystem.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbSysSelSystem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSysSelSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSysSelSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSysSelSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSysSelSystem.FormattingEnabled = true;
            this.cbSysSelSystem.IsDerivedStyle = true;
            this.cbSysSelSystem.ItemHeight = 20;
            this.cbSysSelSystem.Items.AddRange(new object[] {
            "Arcade",
            "Arcade Light Gun",
            "Atari 2600",
            "Atari 5200",
            "Atari 7800",
            "Atari Jaguar",
            "ColecoVision",
            "Game Boy",
            "Game Boy Color",
            "Game Boy Advance",
            "Nintendo DS",
            "Nintendo 3DS",
            "Nintendo Entertainment System",
            "Nintendo SNES",
            "Nintendo 64",
            "Nintendo Gamecube",
            "Nintendo Wii",
            "Nintendo Wii Virtual Console",
            "Nintendo Wii U",
            "Nintendo Switch",
            "Sega Master System",
            "Sega Genesis",
            "Sega 32X",
            "Sega CD",
            "Sega Saturn",
            "Sega Dreamcast",
            "Sega Game Gear",
            "Sony Playstation",
            "Sony Playstation 2",
            "Sony Playstation 3",
            "Sony PSP",
            "NEC TurboGrafx16",
            "NEC TurboGrafx16 CD",
            "Microsoft Xbox",
            "Microsoft Xbox 360",
            "PC Games"});
            this.cbSysSelSystem.Location = new System.Drawing.Point(20, 70);
            this.cbSysSelSystem.MaxDropDownItems = 12;
            this.cbSysSelSystem.Name = "cbSysSelSystem";
            this.cbSysSelSystem.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbSysSelSystem.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbSysSelSystem.Size = new System.Drawing.Size(677, 26);
            this.cbSysSelSystem.Style = MetroSet_UI.Enums.Style.Light;
            this.cbSysSelSystem.StyleManager = this.metroStyleManager;
            this.cbSysSelSystem.TabIndex = 0;
            this.cbSysSelSystem.ThemeAuthor = "Narwin";
            this.cbSysSelSystem.ThemeName = "MetroLight";
            this.cbSysSelSystem.SelectedIndexChanged += new System.EventHandler(this.CbSysSelSystem_SelectedIndexChanged);
            // 
            // TabEmulators
            // 
            this.TabEmulators.BaseColor = System.Drawing.Color.White;
            this.TabEmulators.Controls.Add(this.BtnEmuExtract);
            this.TabEmulators.Controls.Add(this.BtnEmuDownload);
            this.TabEmulators.Controls.Add(this.lblEmuSystemType);
            this.TabEmulators.Controls.Add(this.tbEmuFolderDestination);
            this.TabEmulators.Controls.Add(this.TxtEmuDownloadLink);
            this.TabEmulators.Controls.Add(this.TbEmuDownloadLink);
            this.TabEmulators.Controls.Add(this.lblEmuDownloadStatus);
            this.TabEmulators.Controls.Add(this.lblEmuStatusTxt);
            this.TabEmulators.Controls.Add(this.lblEmuDownloadedValue);
            this.TabEmulators.Controls.Add(this.lblEmuDownloadSpeedValue);
            this.TabEmulators.Controls.Add(this.lblEmuPercent);
            this.TabEmulators.Controls.Add(this.EmuProgressBar);
            this.TabEmulators.Controls.Add(this.lblEmuDownloadSpeed);
            this.TabEmulators.Controls.Add(this.lblEmuDownloaded);
            this.TabEmulators.Controls.Add(this.TxtEmuSelectEmulator);
            this.TabEmulators.Controls.Add(this.cbEmuSelecEmulator);
            this.TabEmulators.Controls.Add(this.TxtEmuFolderDestination);
            this.TabEmulators.Font = null;
            this.TabEmulators.ImageIndex = 0;
            this.TabEmulators.ImageKey = null;
            this.TabEmulators.IsDerivedStyle = true;
            this.TabEmulators.Location = new System.Drawing.Point(4, 42);
            this.TabEmulators.Name = "TabEmulators";
            this.TabEmulators.Size = new System.Drawing.Size(792, 404);
            this.TabEmulators.Style = MetroSet_UI.Enums.Style.Light;
            this.TabEmulators.StyleManager = this.metroStyleManager;
            this.TabEmulators.TabIndex = 1;
            this.TabEmulators.Text = "Emulators";
            this.TabEmulators.ThemeAuthor = "Narwin";
            this.TabEmulators.ThemeName = "MetroLight";
            this.TabEmulators.ToolTipText = "Emulators Tab";
            // 
            // BtnEmuExtract
            // 
            this.BtnEmuExtract.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuExtract.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuExtract.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnEmuExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEmuExtract.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnEmuExtract.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnEmuExtract.HoverTextColor = System.Drawing.Color.White;
            this.BtnEmuExtract.IsDerivedStyle = true;
            this.BtnEmuExtract.Location = new System.Drawing.Point(669, 70);
            this.BtnEmuExtract.Name = "BtnEmuExtract";
            this.BtnEmuExtract.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuExtract.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuExtract.NormalTextColor = System.Drawing.Color.White;
            this.BtnEmuExtract.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuExtract.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuExtract.PressTextColor = System.Drawing.Color.White;
            this.BtnEmuExtract.Size = new System.Drawing.Size(100, 26);
            this.BtnEmuExtract.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnEmuExtract.StyleManager = this.metroStyleManager;
            this.BtnEmuExtract.TabIndex = 21;
            this.BtnEmuExtract.Text = "Extract";
            this.BtnEmuExtract.ThemeAuthor = "Narwin";
            this.BtnEmuExtract.ThemeName = "MetroLight";
            this.BtnEmuExtract.Click += new System.EventHandler(this.BtnEmuExtract_Click);
            // 
            // BtnEmuDownload
            // 
            this.BtnEmuDownload.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuDownload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuDownload.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnEmuDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEmuDownload.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnEmuDownload.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnEmuDownload.HoverTextColor = System.Drawing.Color.White;
            this.BtnEmuDownload.IsDerivedStyle = true;
            this.BtnEmuDownload.Location = new System.Drawing.Point(561, 70);
            this.BtnEmuDownload.Name = "BtnEmuDownload";
            this.BtnEmuDownload.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuDownload.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuDownload.NormalTextColor = System.Drawing.Color.White;
            this.BtnEmuDownload.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuDownload.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuDownload.PressTextColor = System.Drawing.Color.White;
            this.BtnEmuDownload.Size = new System.Drawing.Size(100, 26);
            this.BtnEmuDownload.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnEmuDownload.StyleManager = this.metroStyleManager;
            this.BtnEmuDownload.TabIndex = 20;
            this.BtnEmuDownload.Text = "Download";
            this.BtnEmuDownload.ThemeAuthor = "Narwin";
            this.BtnEmuDownload.ThemeName = "MetroLight";
            this.BtnEmuDownload.Click += new System.EventHandler(this.BtnEmuDownload_Click);
            // 
            // lblEmuSystemType
            // 
            this.lblEmuSystemType.AutoCompleteCustomSource = null;
            this.lblEmuSystemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lblEmuSystemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lblEmuSystemType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.lblEmuSystemType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblEmuSystemType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.lblEmuSystemType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblEmuSystemType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuSystemType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblEmuSystemType.Image = null;
            this.lblEmuSystemType.IsDerivedStyle = true;
            this.lblEmuSystemType.Lines = null;
            this.lblEmuSystemType.Location = new System.Drawing.Point(295, 70);
            this.lblEmuSystemType.MaxLength = 32767;
            this.lblEmuSystemType.Multiline = false;
            this.lblEmuSystemType.Name = "lblEmuSystemType";
            this.lblEmuSystemType.ReadOnly = true;
            this.lblEmuSystemType.Size = new System.Drawing.Size(251, 26);
            this.lblEmuSystemType.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuSystemType.StyleManager = this.metroStyleManager;
            this.lblEmuSystemType.TabIndex = 19;
            this.lblEmuSystemType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lblEmuSystemType.ThemeAuthor = "Narwin";
            this.lblEmuSystemType.ThemeName = "MetroLight";
            this.lblEmuSystemType.UseSystemPasswordChar = false;
            this.lblEmuSystemType.WatermarkText = "";
            // 
            // tbEmuFolderDestination
            // 
            this.tbEmuFolderDestination.AutoCompleteCustomSource = null;
            this.tbEmuFolderDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbEmuFolderDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbEmuFolderDestination.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbEmuFolderDestination.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbEmuFolderDestination.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbEmuFolderDestination.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbEmuFolderDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmuFolderDestination.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbEmuFolderDestination.Image = null;
            this.tbEmuFolderDestination.IsDerivedStyle = true;
            this.tbEmuFolderDestination.Lines = null;
            this.tbEmuFolderDestination.Location = new System.Drawing.Point(20, 230);
            this.tbEmuFolderDestination.MaxLength = 32767;
            this.tbEmuFolderDestination.Multiline = false;
            this.tbEmuFolderDestination.Name = "tbEmuFolderDestination";
            this.tbEmuFolderDestination.ReadOnly = false;
            this.tbEmuFolderDestination.Size = new System.Drawing.Size(750, 26);
            this.tbEmuFolderDestination.Style = MetroSet_UI.Enums.Style.Light;
            this.tbEmuFolderDestination.StyleManager = this.metroStyleManager;
            this.tbEmuFolderDestination.TabIndex = 17;
            this.tbEmuFolderDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmuFolderDestination.ThemeAuthor = "Narwin";
            this.tbEmuFolderDestination.ThemeName = "MetroLight";
            this.tbEmuFolderDestination.UseSystemPasswordChar = false;
            this.tbEmuFolderDestination.WatermarkText = "";
            // 
            // TxtEmuDownloadLink
            // 
            this.TxtEmuDownloadLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmuDownloadLink.IsDerivedStyle = true;
            this.TxtEmuDownloadLink.Location = new System.Drawing.Point(20, 110);
            this.TxtEmuDownloadLink.Name = "TxtEmuDownloadLink";
            this.TxtEmuDownloadLink.Size = new System.Drawing.Size(310, 35);
            this.TxtEmuDownloadLink.Style = MetroSet_UI.Enums.Style.Light;
            this.TxtEmuDownloadLink.StyleManager = this.metroStyleManager;
            this.TxtEmuDownloadLink.TabIndex = 16;
            this.TxtEmuDownloadLink.Text = "Emulators download link";
            this.TxtEmuDownloadLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtEmuDownloadLink.ThemeAuthor = "Narwin";
            this.TxtEmuDownloadLink.ThemeName = "MetroLight";
            // 
            // TbEmuDownloadLink
            // 
            this.TbEmuDownloadLink.AutoCompleteCustomSource = null;
            this.TbEmuDownloadLink.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbEmuDownloadLink.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbEmuDownloadLink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TbEmuDownloadLink.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TbEmuDownloadLink.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TbEmuDownloadLink.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.TbEmuDownloadLink.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmuDownloadLink.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TbEmuDownloadLink.Image = null;
            this.TbEmuDownloadLink.IsDerivedStyle = true;
            this.TbEmuDownloadLink.Lines = null;
            this.TbEmuDownloadLink.Location = new System.Drawing.Point(20, 148);
            this.TbEmuDownloadLink.MaxLength = 32767;
            this.TbEmuDownloadLink.Multiline = false;
            this.TbEmuDownloadLink.Name = "TbEmuDownloadLink";
            this.TbEmuDownloadLink.ReadOnly = false;
            this.TbEmuDownloadLink.Size = new System.Drawing.Size(750, 26);
            this.TbEmuDownloadLink.Style = MetroSet_UI.Enums.Style.Light;
            this.TbEmuDownloadLink.StyleManager = this.metroStyleManager;
            this.TbEmuDownloadLink.TabIndex = 15;
            this.TbEmuDownloadLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbEmuDownloadLink.ThemeAuthor = "Narwin";
            this.TbEmuDownloadLink.ThemeName = "MetroLight";
            this.TbEmuDownloadLink.UseSystemPasswordChar = false;
            this.TbEmuDownloadLink.WatermarkText = "";
            // 
            // lblEmuDownloadStatus
            // 
            this.lblEmuDownloadStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuDownloadStatus.IsDerivedStyle = true;
            this.lblEmuDownloadStatus.Location = new System.Drawing.Point(635, 320);
            this.lblEmuDownloadStatus.Name = "lblEmuDownloadStatus";
            this.lblEmuDownloadStatus.Size = new System.Drawing.Size(157, 35);
            this.lblEmuDownloadStatus.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloadStatus.StyleManager = this.metroStyleManager;
            this.lblEmuDownloadStatus.TabIndex = 14;
            this.lblEmuDownloadStatus.Text = "Waiting ...";
            this.lblEmuDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmuDownloadStatus.ThemeAuthor = "Narwin";
            this.lblEmuDownloadStatus.ThemeName = "MetroLight";
            // 
            // lblEmuStatusTxt
            // 
            this.lblEmuStatusTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuStatusTxt.IsDerivedStyle = true;
            this.lblEmuStatusTxt.Location = new System.Drawing.Point(499, 320);
            this.lblEmuStatusTxt.Name = "lblEmuStatusTxt";
            this.lblEmuStatusTxt.Size = new System.Drawing.Size(142, 35);
            this.lblEmuStatusTxt.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuStatusTxt.StyleManager = this.metroStyleManager;
            this.lblEmuStatusTxt.TabIndex = 13;
            this.lblEmuStatusTxt.Text = "Download status :";
            this.lblEmuStatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmuStatusTxt.ThemeAuthor = "Narwin";
            this.lblEmuStatusTxt.ThemeName = "MetroLight";
            // 
            // lblEmuDownloadedValue
            // 
            this.lblEmuDownloadedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuDownloadedValue.IsDerivedStyle = true;
            this.lblEmuDownloadedValue.Location = new System.Drawing.Point(146, 320);
            this.lblEmuDownloadedValue.Name = "lblEmuDownloadedValue";
            this.lblEmuDownloadedValue.Size = new System.Drawing.Size(80, 35);
            this.lblEmuDownloadedValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloadedValue.StyleManager = this.metroStyleManager;
            this.lblEmuDownloadedValue.TabIndex = 12;
            this.lblEmuDownloadedValue.Text = "MB";
            this.lblEmuDownloadedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmuDownloadedValue.ThemeAuthor = "Narwin";
            this.lblEmuDownloadedValue.ThemeName = "MetroLight";
            // 
            // lblEmuDownloadSpeedValue
            // 
            this.lblEmuDownloadSpeedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuDownloadSpeedValue.IsDerivedStyle = true;
            this.lblEmuDownloadSpeedValue.Location = new System.Drawing.Point(146, 270);
            this.lblEmuDownloadSpeedValue.Name = "lblEmuDownloadSpeedValue";
            this.lblEmuDownloadSpeedValue.Size = new System.Drawing.Size(80, 35);
            this.lblEmuDownloadSpeedValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloadSpeedValue.StyleManager = this.metroStyleManager;
            this.lblEmuDownloadSpeedValue.TabIndex = 11;
            this.lblEmuDownloadSpeedValue.Text = "Mb/s";
            this.lblEmuDownloadSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmuDownloadSpeedValue.ThemeAuthor = "Narwin";
            this.lblEmuDownloadSpeedValue.ThemeName = "MetroLight";
            // 
            // lblEmuPercent
            // 
            this.lblEmuPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuPercent.IsDerivedStyle = true;
            this.lblEmuPercent.Location = new System.Drawing.Point(730, 376);
            this.lblEmuPercent.Name = "lblEmuPercent";
            this.lblEmuPercent.Size = new System.Drawing.Size(50, 25);
            this.lblEmuPercent.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuPercent.StyleManager = this.metroStyleManager;
            this.lblEmuPercent.TabIndex = 10;
            this.lblEmuPercent.Text = "0%";
            this.lblEmuPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmuPercent.ThemeAuthor = "Narwin";
            this.lblEmuPercent.ThemeName = "MetroLight";
            // 
            // EmuProgressBar
            // 
            this.EmuProgressBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.EmuProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.EmuProgressBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.EmuProgressBar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.EmuProgressBar.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EmuProgressBar.IsDerivedStyle = true;
            this.EmuProgressBar.Location = new System.Drawing.Point(50, 375);
            this.EmuProgressBar.Maximum = 100;
            this.EmuProgressBar.Minimum = 0;
            this.EmuProgressBar.Name = "EmuProgressBar";
            this.EmuProgressBar.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.EmuProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.EmuProgressBar.Size = new System.Drawing.Size(675, 25);
            this.EmuProgressBar.Style = MetroSet_UI.Enums.Style.Light;
            this.EmuProgressBar.StyleManager = this.metroStyleManager;
            this.EmuProgressBar.TabIndex = 9;
            this.EmuProgressBar.Text = "metroSetProgressBar1";
            this.EmuProgressBar.ThemeAuthor = "Narwin";
            this.EmuProgressBar.ThemeName = "MetroLight";
            this.EmuProgressBar.Value = 0;
            // 
            // lblEmuDownloadSpeed
            // 
            this.lblEmuDownloadSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuDownloadSpeed.IsDerivedStyle = true;
            this.lblEmuDownloadSpeed.Location = new System.Drawing.Point(20, 270);
            this.lblEmuDownloadSpeed.Name = "lblEmuDownloadSpeed";
            this.lblEmuDownloadSpeed.Size = new System.Drawing.Size(120, 35);
            this.lblEmuDownloadSpeed.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloadSpeed.StyleManager = this.metroStyleManager;
            this.lblEmuDownloadSpeed.TabIndex = 8;
            this.lblEmuDownloadSpeed.Text = "Download speed :";
            this.lblEmuDownloadSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmuDownloadSpeed.ThemeAuthor = "Narwin";
            this.lblEmuDownloadSpeed.ThemeName = "MetroLight";
            // 
            // lblEmuDownloaded
            // 
            this.lblEmuDownloaded.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuDownloaded.IsDerivedStyle = true;
            this.lblEmuDownloaded.Location = new System.Drawing.Point(20, 320);
            this.lblEmuDownloaded.Name = "lblEmuDownloaded";
            this.lblEmuDownloaded.Size = new System.Drawing.Size(120, 35);
            this.lblEmuDownloaded.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloaded.StyleManager = this.metroStyleManager;
            this.lblEmuDownloaded.TabIndex = 7;
            this.lblEmuDownloaded.Text = "Downloaded :";
            this.lblEmuDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmuDownloaded.ThemeAuthor = "Narwin";
            this.lblEmuDownloaded.ThemeName = "MetroLight";
            // 
            // TxtEmuSelectEmulator
            // 
            this.TxtEmuSelectEmulator.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmuSelectEmulator.IsDerivedStyle = true;
            this.TxtEmuSelectEmulator.Location = new System.Drawing.Point(20, 30);
            this.TxtEmuSelectEmulator.Name = "TxtEmuSelectEmulator";
            this.TxtEmuSelectEmulator.Size = new System.Drawing.Size(310, 35);
            this.TxtEmuSelectEmulator.Style = MetroSet_UI.Enums.Style.Light;
            this.TxtEmuSelectEmulator.StyleManager = this.metroStyleManager;
            this.TxtEmuSelectEmulator.TabIndex = 6;
            this.TxtEmuSelectEmulator.Text = "Please select an emulator :";
            this.TxtEmuSelectEmulator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtEmuSelectEmulator.ThemeAuthor = "Narwin";
            this.TxtEmuSelectEmulator.ThemeName = "MetroLight";
            // 
            // cbEmuSelecEmulator
            // 
            this.cbEmuSelecEmulator.AllowDrop = true;
            this.cbEmuSelecEmulator.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbEmuSelecEmulator.BackColor = System.Drawing.Color.Transparent;
            this.cbEmuSelecEmulator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbEmuSelecEmulator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbEmuSelecEmulator.CausesValidation = false;
            this.cbEmuSelecEmulator.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbEmuSelecEmulator.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbEmuSelecEmulator.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbEmuSelecEmulator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEmuSelecEmulator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmuSelecEmulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmuSelecEmulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmuSelecEmulator.FormattingEnabled = true;
            this.cbEmuSelecEmulator.IsDerivedStyle = true;
            this.cbEmuSelecEmulator.ItemHeight = 20;
            this.cbEmuSelecEmulator.Items.AddRange(new object[] {
            "RetroArch",
            "Mame",
            "Dolphin",
            "Cemu",
            "Yuzu",
            "DuckStation",
            "PCSX2",
            "Rpcs3",
            "PPSSPP",
            "Cxbx-Reloaded",
            "Xemu",
            "Xenia"});
            this.cbEmuSelecEmulator.Location = new System.Drawing.Point(20, 70);
            this.cbEmuSelecEmulator.MaxDropDownItems = 12;
            this.cbEmuSelecEmulator.Name = "cbEmuSelecEmulator";
            this.cbEmuSelecEmulator.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbEmuSelecEmulator.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbEmuSelecEmulator.Size = new System.Drawing.Size(260, 26);
            this.cbEmuSelecEmulator.Style = MetroSet_UI.Enums.Style.Light;
            this.cbEmuSelecEmulator.StyleManager = this.metroStyleManager;
            this.cbEmuSelecEmulator.TabIndex = 5;
            this.cbEmuSelecEmulator.ThemeAuthor = "Narwin";
            this.cbEmuSelecEmulator.ThemeName = "MetroLight";
            this.cbEmuSelecEmulator.SelectedIndexChanged += new System.EventHandler(this.CbEmuSelecEmulator_SelectedIndexChanged);
            // 
            // TxtEmuFolderDestination
            // 
            this.TxtEmuFolderDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmuFolderDestination.IsDerivedStyle = true;
            this.TxtEmuFolderDestination.Location = new System.Drawing.Point(20, 190);
            this.TxtEmuFolderDestination.Name = "TxtEmuFolderDestination";
            this.TxtEmuFolderDestination.Size = new System.Drawing.Size(310, 35);
            this.TxtEmuFolderDestination.Style = MetroSet_UI.Enums.Style.Light;
            this.TxtEmuFolderDestination.StyleManager = this.metroStyleManager;
            this.TxtEmuFolderDestination.TabIndex = 18;
            this.TxtEmuFolderDestination.Text = "Emulators folder destination";
            this.TxtEmuFolderDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtEmuFolderDestination.ThemeAuthor = "Narwin";
            this.TxtEmuFolderDestination.ThemeName = "MetroLight";
            // 
            // TabTools
            // 
            this.TabTools.BaseColor = System.Drawing.Color.White;
            this.TabTools.Controls.Add(this.pictureBox1);
            this.TabTools.Controls.Add(this.BtnToolsInstallDirectX);
            this.TabTools.Controls.Add(this.BtnToolsInstallRomsCenter);
            this.TabTools.Controls.Add(this.metroSetLabel1);
            this.TabTools.Controls.Add(this.btnToolsInstallRuntime);
            this.TabTools.Controls.Add(this.BtnToolsInstallTorrentZip);
            this.TabTools.Controls.Add(this.lblToolsStatusValue);
            this.TabTools.Controls.Add(this.lblToolsStatus);
            this.TabTools.Controls.Add(this.lblToolsDownloadedValue);
            this.TabTools.Controls.Add(this.lblToolsDownloadSpeedValue);
            this.TabTools.Controls.Add(this.ToolsProgressBar);
            this.TabTools.Controls.Add(this.lblToolDownloadSpeed);
            this.TabTools.Controls.Add(this.lblToolDownloadedTxt);
            this.TabTools.Controls.Add(this.lblToolsPercent);
            this.TabTools.Font = null;
            this.TabTools.ImageIndex = 0;
            this.TabTools.ImageKey = null;
            this.TabTools.IsDerivedStyle = true;
            this.TabTools.Location = new System.Drawing.Point(4, 42);
            this.TabTools.Name = "TabTools";
            this.TabTools.Size = new System.Drawing.Size(792, 404);
            this.TabTools.Style = MetroSet_UI.Enums.Style.Light;
            this.TabTools.StyleManager = this.metroStyleManager;
            this.TabTools.TabIndex = 2;
            this.TabTools.Text = "Tools";
            this.TabTools.ThemeAuthor = "Narwin";
            this.TabTools.ThemeName = "MetroLight";
            this.TabTools.ToolTipText = "Tools";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 171);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // BtnToolsInstallDirectX
            // 
            this.BtnToolsInstallDirectX.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallDirectX.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallDirectX.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnToolsInstallDirectX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnToolsInstallDirectX.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnToolsInstallDirectX.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnToolsInstallDirectX.HoverTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallDirectX.IsDerivedStyle = true;
            this.BtnToolsInstallDirectX.Location = new System.Drawing.Point(611, 70);
            this.BtnToolsInstallDirectX.Name = "BtnToolsInstallDirectX";
            this.BtnToolsInstallDirectX.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallDirectX.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallDirectX.NormalTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallDirectX.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnToolsInstallDirectX.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnToolsInstallDirectX.PressTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallDirectX.Size = new System.Drawing.Size(150, 26);
            this.BtnToolsInstallDirectX.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnToolsInstallDirectX.StyleManager = this.metroStyleManager;
            this.BtnToolsInstallDirectX.TabIndex = 28;
            this.BtnToolsInstallDirectX.Text = "Install DirectX";
            this.BtnToolsInstallDirectX.ThemeAuthor = "Narwin";
            this.BtnToolsInstallDirectX.ThemeName = "MetroLight";
            this.BtnToolsInstallDirectX.Click += new System.EventHandler(this.BtnToolsInstallDirectX_Click);
            // 
            // BtnToolsInstallRomsCenter
            // 
            this.BtnToolsInstallRomsCenter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallRomsCenter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallRomsCenter.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnToolsInstallRomsCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnToolsInstallRomsCenter.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnToolsInstallRomsCenter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnToolsInstallRomsCenter.HoverTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallRomsCenter.IsDerivedStyle = true;
            this.BtnToolsInstallRomsCenter.Location = new System.Drawing.Point(417, 70);
            this.BtnToolsInstallRomsCenter.Name = "BtnToolsInstallRomsCenter";
            this.BtnToolsInstallRomsCenter.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallRomsCenter.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallRomsCenter.NormalTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallRomsCenter.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnToolsInstallRomsCenter.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnToolsInstallRomsCenter.PressTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallRomsCenter.Size = new System.Drawing.Size(150, 26);
            this.BtnToolsInstallRomsCenter.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnToolsInstallRomsCenter.StyleManager = this.metroStyleManager;
            this.BtnToolsInstallRomsCenter.TabIndex = 27;
            this.BtnToolsInstallRomsCenter.Text = "Install Roms Center";
            this.BtnToolsInstallRomsCenter.ThemeAuthor = "Narwin";
            this.BtnToolsInstallRomsCenter.ThemeName = "MetroLight";
            this.BtnToolsInstallRomsCenter.Click += new System.EventHandler(this.BtnToolsInstallRomsCenter_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(35, 30);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(115, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = this.metroStyleManager;
            this.metroSetLabel1.TabIndex = 26;
            this.metroSetLabel1.Text = "Useful tools";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLight";
            // 
            // btnToolsInstallRuntime
            // 
            this.btnToolsInstallRuntime.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnToolsInstallRuntime.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnToolsInstallRuntime.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnToolsInstallRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnToolsInstallRuntime.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnToolsInstallRuntime.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnToolsInstallRuntime.HoverTextColor = System.Drawing.Color.White;
            this.btnToolsInstallRuntime.IsDerivedStyle = true;
            this.btnToolsInstallRuntime.Location = new System.Drawing.Point(35, 70);
            this.btnToolsInstallRuntime.Name = "btnToolsInstallRuntime";
            this.btnToolsInstallRuntime.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnToolsInstallRuntime.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnToolsInstallRuntime.NormalTextColor = System.Drawing.Color.White;
            this.btnToolsInstallRuntime.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnToolsInstallRuntime.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnToolsInstallRuntime.PressTextColor = System.Drawing.Color.White;
            this.btnToolsInstallRuntime.Size = new System.Drawing.Size(150, 26);
            this.btnToolsInstallRuntime.Style = MetroSet_UI.Enums.Style.Light;
            this.btnToolsInstallRuntime.StyleManager = this.metroStyleManager;
            this.btnToolsInstallRuntime.TabIndex = 25;
            this.btnToolsInstallRuntime.Text = "Install Visual Runtime";
            this.btnToolsInstallRuntime.ThemeAuthor = "Narwin";
            this.btnToolsInstallRuntime.ThemeName = "MetroLight";
            this.btnToolsInstallRuntime.Click += new System.EventHandler(this.BtnInstallRuntime_Click);
            // 
            // BtnToolsInstallTorrentZip
            // 
            this.BtnToolsInstallTorrentZip.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallTorrentZip.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallTorrentZip.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnToolsInstallTorrentZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnToolsInstallTorrentZip.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnToolsInstallTorrentZip.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnToolsInstallTorrentZip.HoverTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallTorrentZip.IsDerivedStyle = true;
            this.BtnToolsInstallTorrentZip.Location = new System.Drawing.Point(226, 70);
            this.BtnToolsInstallTorrentZip.Name = "BtnToolsInstallTorrentZip";
            this.BtnToolsInstallTorrentZip.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallTorrentZip.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnToolsInstallTorrentZip.NormalTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallTorrentZip.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnToolsInstallTorrentZip.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnToolsInstallTorrentZip.PressTextColor = System.Drawing.Color.White;
            this.BtnToolsInstallTorrentZip.Size = new System.Drawing.Size(150, 26);
            this.BtnToolsInstallTorrentZip.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnToolsInstallTorrentZip.StyleManager = this.metroStyleManager;
            this.BtnToolsInstallTorrentZip.TabIndex = 24;
            this.BtnToolsInstallTorrentZip.Text = "Install TorrentZip";
            this.BtnToolsInstallTorrentZip.ThemeAuthor = "Narwin";
            this.BtnToolsInstallTorrentZip.ThemeName = "MetroLight";
            this.BtnToolsInstallTorrentZip.Click += new System.EventHandler(this.BtnInstallTorrentZip_Click);
            // 
            // lblToolsStatusValue
            // 
            this.lblToolsStatusValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolsStatusValue.IsDerivedStyle = true;
            this.lblToolsStatusValue.Location = new System.Drawing.Point(660, 305);
            this.lblToolsStatusValue.Name = "lblToolsStatusValue";
            this.lblToolsStatusValue.Size = new System.Drawing.Size(80, 35);
            this.lblToolsStatusValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolsStatusValue.StyleManager = this.metroStyleManager;
            this.lblToolsStatusValue.TabIndex = 22;
            this.lblToolsStatusValue.Text = "Waiting ...";
            this.lblToolsStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToolsStatusValue.ThemeAuthor = "Narwin";
            this.lblToolsStatusValue.ThemeName = "MetroLight";
            // 
            // lblToolsStatus
            // 
            this.lblToolsStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolsStatus.IsDerivedStyle = true;
            this.lblToolsStatus.Location = new System.Drawing.Point(527, 305);
            this.lblToolsStatus.Name = "lblToolsStatus";
            this.lblToolsStatus.Size = new System.Drawing.Size(130, 35);
            this.lblToolsStatus.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolsStatus.StyleManager = this.metroStyleManager;
            this.lblToolsStatus.TabIndex = 21;
            this.lblToolsStatus.Text = "Download status :";
            this.lblToolsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblToolsStatus.ThemeAuthor = "Narwin";
            this.lblToolsStatus.ThemeName = "MetroLight";
            // 
            // lblToolsDownloadedValue
            // 
            this.lblToolsDownloadedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolsDownloadedValue.IsDerivedStyle = true;
            this.lblToolsDownloadedValue.Location = new System.Drawing.Point(146, 305);
            this.lblToolsDownloadedValue.Name = "lblToolsDownloadedValue";
            this.lblToolsDownloadedValue.Size = new System.Drawing.Size(80, 35);
            this.lblToolsDownloadedValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolsDownloadedValue.StyleManager = this.metroStyleManager;
            this.lblToolsDownloadedValue.TabIndex = 20;
            this.lblToolsDownloadedValue.Text = "MB";
            this.lblToolsDownloadedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToolsDownloadedValue.ThemeAuthor = "Narwin";
            this.lblToolsDownloadedValue.ThemeName = "MetroLight";
            // 
            // lblToolsDownloadSpeedValue
            // 
            this.lblToolsDownloadSpeedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolsDownloadSpeedValue.IsDerivedStyle = true;
            this.lblToolsDownloadSpeedValue.Location = new System.Drawing.Point(146, 270);
            this.lblToolsDownloadSpeedValue.Name = "lblToolsDownloadSpeedValue";
            this.lblToolsDownloadSpeedValue.Size = new System.Drawing.Size(80, 35);
            this.lblToolsDownloadSpeedValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolsDownloadSpeedValue.StyleManager = this.metroStyleManager;
            this.lblToolsDownloadSpeedValue.TabIndex = 19;
            this.lblToolsDownloadSpeedValue.Text = "Mb/s";
            this.lblToolsDownloadSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToolsDownloadSpeedValue.ThemeAuthor = "Narwin";
            this.lblToolsDownloadSpeedValue.ThemeName = "MetroLight";
            // 
            // ToolsProgressBar
            // 
            this.ToolsProgressBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ToolsProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ToolsProgressBar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ToolsProgressBar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ToolsProgressBar.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ToolsProgressBar.IsDerivedStyle = true;
            this.ToolsProgressBar.Location = new System.Drawing.Point(50, 375);
            this.ToolsProgressBar.Maximum = 100;
            this.ToolsProgressBar.Minimum = 0;
            this.ToolsProgressBar.Name = "ToolsProgressBar";
            this.ToolsProgressBar.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.ToolsProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.ToolsProgressBar.Size = new System.Drawing.Size(675, 25);
            this.ToolsProgressBar.Style = MetroSet_UI.Enums.Style.Light;
            this.ToolsProgressBar.StyleManager = this.metroStyleManager;
            this.ToolsProgressBar.TabIndex = 17;
            this.ToolsProgressBar.Text = "metroSetProgressBar1";
            this.ToolsProgressBar.ThemeAuthor = "Narwin";
            this.ToolsProgressBar.ThemeName = "MetroLight";
            this.ToolsProgressBar.Value = 0;
            // 
            // lblToolDownloadSpeed
            // 
            this.lblToolDownloadSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolDownloadSpeed.IsDerivedStyle = true;
            this.lblToolDownloadSpeed.Location = new System.Drawing.Point(20, 270);
            this.lblToolDownloadSpeed.Name = "lblToolDownloadSpeed";
            this.lblToolDownloadSpeed.Size = new System.Drawing.Size(120, 35);
            this.lblToolDownloadSpeed.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolDownloadSpeed.StyleManager = this.metroStyleManager;
            this.lblToolDownloadSpeed.TabIndex = 16;
            this.lblToolDownloadSpeed.Text = "Download speed :";
            this.lblToolDownloadSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblToolDownloadSpeed.ThemeAuthor = "Narwin";
            this.lblToolDownloadSpeed.ThemeName = "MetroLight";
            // 
            // lblToolDownloadedTxt
            // 
            this.lblToolDownloadedTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolDownloadedTxt.IsDerivedStyle = true;
            this.lblToolDownloadedTxt.Location = new System.Drawing.Point(20, 305);
            this.lblToolDownloadedTxt.Name = "lblToolDownloadedTxt";
            this.lblToolDownloadedTxt.Size = new System.Drawing.Size(120, 35);
            this.lblToolDownloadedTxt.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolDownloadedTxt.StyleManager = this.metroStyleManager;
            this.lblToolDownloadedTxt.TabIndex = 15;
            this.lblToolDownloadedTxt.Text = "Downloaded :";
            this.lblToolDownloadedTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblToolDownloadedTxt.ThemeAuthor = "Narwin";
            this.lblToolDownloadedTxt.ThemeName = "MetroLight";
            // 
            // lblToolsPercent
            // 
            this.lblToolsPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolsPercent.IsDerivedStyle = true;
            this.lblToolsPercent.Location = new System.Drawing.Point(731, 375);
            this.lblToolsPercent.Name = "lblToolsPercent";
            this.lblToolsPercent.Size = new System.Drawing.Size(50, 25);
            this.lblToolsPercent.Style = MetroSet_UI.Enums.Style.Light;
            this.lblToolsPercent.StyleManager = this.metroStyleManager;
            this.lblToolsPercent.TabIndex = 18;
            this.lblToolsPercent.Text = "0%";
            this.lblToolsPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblToolsPercent.ThemeAuthor = "Narwin";
            this.lblToolsPercent.ThemeName = "MetroLight";
            // 
            // metroSetSetTabPage1
            // 
            this.metroSetSetTabPage1.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage1.Controls.Add(this.BtnDownloadApply);
            this.metroSetSetTabPage1.Controls.Add(this.pbSelectedTheme);
            this.metroSetSetTabPage1.Controls.Add(this.pbActualTheme);
            this.metroSetSetTabPage1.Controls.Add(this.tbSettingTheme);
            this.metroSetSetTabPage1.Controls.Add(this.lblSettingActualTheme);
            this.metroSetSetTabPage1.Controls.Add(this.lblSettingTheme);
            this.metroSetSetTabPage1.Controls.Add(this.BtnThemeDownload);
            this.metroSetSetTabPage1.Controls.Add(this.cbSettingTheme);
            this.metroSetSetTabPage1.Font = null;
            this.metroSetSetTabPage1.ImageIndex = 0;
            this.metroSetSetTabPage1.ImageKey = null;
            this.metroSetSetTabPage1.IsDerivedStyle = true;
            this.metroSetSetTabPage1.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage1.Name = "metroSetSetTabPage1";
            this.metroSetSetTabPage1.Size = new System.Drawing.Size(792, 404);
            this.metroSetSetTabPage1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage1.StyleManager = this.metroStyleManager;
            this.metroSetSetTabPage1.TabIndex = 4;
            this.metroSetSetTabPage1.Text = "CoinOPS Setting";
            this.metroSetSetTabPage1.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage1.ThemeName = "MetroLight";
            this.metroSetSetTabPage1.ToolTipText = null;
            // 
            // BtnDownloadApply
            // 
            this.BtnDownloadApply.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDownloadApply.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDownloadApply.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnDownloadApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnDownloadApply.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnDownloadApply.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnDownloadApply.HoverTextColor = System.Drawing.Color.White;
            this.BtnDownloadApply.IsDerivedStyle = true;
            this.BtnDownloadApply.Location = new System.Drawing.Point(597, 361);
            this.BtnDownloadApply.Name = "BtnDownloadApply";
            this.BtnDownloadApply.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDownloadApply.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnDownloadApply.NormalTextColor = System.Drawing.Color.White;
            this.BtnDownloadApply.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnDownloadApply.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnDownloadApply.PressTextColor = System.Drawing.Color.White;
            this.BtnDownloadApply.Size = new System.Drawing.Size(90, 35);
            this.BtnDownloadApply.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnDownloadApply.StyleManager = this.metroStyleManager;
            this.BtnDownloadApply.TabIndex = 29;
            this.BtnDownloadApply.Text = "Apply";
            this.BtnDownloadApply.ThemeAuthor = "Narwin";
            this.BtnDownloadApply.ThemeName = "MetroLight";
            // 
            // pbSelectedTheme
            // 
            this.pbSelectedTheme.Location = new System.Drawing.Point(405, 123);
            this.pbSelectedTheme.Name = "pbSelectedTheme";
            this.pbSelectedTheme.Size = new System.Drawing.Size(384, 216);
            this.pbSelectedTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedTheme.TabIndex = 28;
            this.pbSelectedTheme.TabStop = false;
            // 
            // pbActualTheme
            // 
            this.pbActualTheme.Location = new System.Drawing.Point(3, 123);
            this.pbActualTheme.Name = "pbActualTheme";
            this.pbActualTheme.Size = new System.Drawing.Size(384, 216);
            this.pbActualTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualTheme.TabIndex = 27;
            this.pbActualTheme.TabStop = false;
            // 
            // tbSettingTheme
            // 
            this.tbSettingTheme.AutoCompleteCustomSource = null;
            this.tbSettingTheme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSettingTheme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSettingTheme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbSettingTheme.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSettingTheme.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tbSettingTheme.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tbSettingTheme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingTheme.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbSettingTheme.Image = null;
            this.tbSettingTheme.IsDerivedStyle = true;
            this.tbSettingTheme.Lines = null;
            this.tbSettingTheme.Location = new System.Drawing.Point(112, 70);
            this.tbSettingTheme.MaxLength = 32767;
            this.tbSettingTheme.Multiline = false;
            this.tbSettingTheme.Name = "tbSettingTheme";
            this.tbSettingTheme.ReadOnly = true;
            this.tbSettingTheme.Size = new System.Drawing.Size(220, 26);
            this.tbSettingTheme.Style = MetroSet_UI.Enums.Style.Light;
            this.tbSettingTheme.StyleManager = this.metroStyleManager;
            this.tbSettingTheme.TabIndex = 25;
            this.tbSettingTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSettingTheme.ThemeAuthor = "Narwin";
            this.tbSettingTheme.ThemeName = "MetroLight";
            this.tbSettingTheme.UseSystemPasswordChar = false;
            this.tbSettingTheme.WatermarkText = "";
            // 
            // lblSettingActualTheme
            // 
            this.lblSettingActualTheme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingActualTheme.IsDerivedStyle = true;
            this.lblSettingActualTheme.Location = new System.Drawing.Point(7, 70);
            this.lblSettingActualTheme.Name = "lblSettingActualTheme";
            this.lblSettingActualTheme.Size = new System.Drawing.Size(99, 26);
            this.lblSettingActualTheme.Style = MetroSet_UI.Enums.Style.Light;
            this.lblSettingActualTheme.StyleManager = this.metroStyleManager;
            this.lblSettingActualTheme.TabIndex = 24;
            this.lblSettingActualTheme.Text = "Actual theme :";
            this.lblSettingActualTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSettingActualTheme.ThemeAuthor = "Narwin";
            this.lblSettingActualTheme.ThemeName = "MetroLight";
            // 
            // lblSettingTheme
            // 
            this.lblSettingTheme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingTheme.IsDerivedStyle = true;
            this.lblSettingTheme.Location = new System.Drawing.Point(409, 70);
            this.lblSettingTheme.Name = "lblSettingTheme";
            this.lblSettingTheme.Size = new System.Drawing.Size(82, 26);
            this.lblSettingTheme.Style = MetroSet_UI.Enums.Style.Light;
            this.lblSettingTheme.StyleManager = this.metroStyleManager;
            this.lblSettingTheme.TabIndex = 23;
            this.lblSettingTheme.Text = "Theme :";
            this.lblSettingTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSettingTheme.ThemeAuthor = "Narwin";
            this.lblSettingTheme.ThemeName = "MetroLight";
            // 
            // BtnThemeDownload
            // 
            this.BtnThemeDownload.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnThemeDownload.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnThemeDownload.DisabledForeColor = System.Drawing.Color.Gray;
            this.BtnThemeDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnThemeDownload.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnThemeDownload.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.BtnThemeDownload.HoverTextColor = System.Drawing.Color.White;
            this.BtnThemeDownload.IsDerivedStyle = true;
            this.BtnThemeDownload.Location = new System.Drawing.Point(699, 361);
            this.BtnThemeDownload.Name = "BtnThemeDownload";
            this.BtnThemeDownload.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnThemeDownload.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnThemeDownload.NormalTextColor = System.Drawing.Color.White;
            this.BtnThemeDownload.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnThemeDownload.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnThemeDownload.PressTextColor = System.Drawing.Color.White;
            this.BtnThemeDownload.Size = new System.Drawing.Size(90, 35);
            this.BtnThemeDownload.Style = MetroSet_UI.Enums.Style.Light;
            this.BtnThemeDownload.StyleManager = this.metroStyleManager;
            this.BtnThemeDownload.TabIndex = 22;
            this.BtnThemeDownload.Text = "Download";
            this.BtnThemeDownload.ThemeAuthor = "Narwin";
            this.BtnThemeDownload.ThemeName = "MetroLight";
            this.BtnThemeDownload.Click += new System.EventHandler(this.BtnThemeDownload_Click);
            // 
            // cbSettingTheme
            // 
            this.cbSettingTheme.AllowDrop = true;
            this.cbSettingTheme.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbSettingTheme.BackColor = System.Drawing.Color.Transparent;
            this.cbSettingTheme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbSettingTheme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbSettingTheme.CausesValidation = false;
            this.cbSettingTheme.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbSettingTheme.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbSettingTheme.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbSettingTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSettingTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSettingTheme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingTheme.FormattingEnabled = true;
            this.cbSettingTheme.IsDerivedStyle = true;
            this.cbSettingTheme.ItemHeight = 20;
            this.cbSettingTheme.Items.AddRange(new object[] {
            "Animatic",
            "Flatio",
            "Pandora’s Box HD Blue",
            "Pandora’s Box HD Green",
            "RetroSpin",
            "Worlds"});
            this.cbSettingTheme.Location = new System.Drawing.Point(497, 70);
            this.cbSettingTheme.MaxDropDownItems = 12;
            this.cbSettingTheme.Name = "cbSettingTheme";
            this.cbSettingTheme.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbSettingTheme.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbSettingTheme.Size = new System.Drawing.Size(280, 26);
            this.cbSettingTheme.Style = MetroSet_UI.Enums.Style.Light;
            this.cbSettingTheme.StyleManager = this.metroStyleManager;
            this.cbSettingTheme.TabIndex = 21;
            this.cbSettingTheme.ThemeAuthor = "Narwin";
            this.cbSettingTheme.ThemeName = "MetroLight";
            this.cbSettingTheme.SelectedIndexChanged += new System.EventHandler(this.CbSettingTheme_SelectedIndexChanged);
            // 
            // fbd
            // 
            this.fbd.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblThemeTxt
            // 
            this.lblThemeTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemeTxt.IsDerivedStyle = true;
            this.lblThemeTxt.Location = new System.Drawing.Point(711, 69);
            this.lblThemeTxt.Name = "lblThemeTxt";
            this.lblThemeTxt.Size = new System.Drawing.Size(75, 25);
            this.lblThemeTxt.Style = MetroSet_UI.Enums.Style.Light;
            this.lblThemeTxt.StyleManager = this.metroStyleManager;
            this.lblThemeTxt.TabIndex = 2;
            this.lblThemeTxt.Text = "Theme :";
            this.lblThemeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThemeTxt.ThemeAuthor = "Narwin";
            this.lblThemeTxt.ThemeName = "MetroLight";
            // 
            // msThemeSwitch
            // 
            this.msThemeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.msThemeSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.msThemeSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.msThemeSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msThemeSwitch.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.msThemeSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msThemeSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.msThemeSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.msThemeSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.msThemeSwitch.IsDerivedStyle = true;
            this.msThemeSwitch.Location = new System.Drawing.Point(792, 69);
            this.msThemeSwitch.Name = "msThemeSwitch";
            this.msThemeSwitch.Size = new System.Drawing.Size(58, 22);
            this.msThemeSwitch.Style = MetroSet_UI.Enums.Style.Light;
            this.msThemeSwitch.StyleManager = this.metroStyleManager;
            this.msThemeSwitch.Switched = true;
            this.msThemeSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.msThemeSwitch.TabIndex = 6;
            this.msThemeSwitch.Text = "metroSetSwitch1";
            this.msThemeSwitch.ThemeAuthor = "Narwin";
            this.msThemeSwitch.ThemeName = "MetroLight";
            this.msThemeSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.msThemeSwitch.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.MsThemeSwitch_SwitchedChanged);
            // 
            // metroSetContextMenuStrip1
            // 
            this.metroSetContextMenuStrip1.IsDerivedStyle = true;
            this.metroSetContextMenuStrip1.Name = "metroSetContextMenuStrip1";
            this.metroSetContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.metroSetContextMenuStrip1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetContextMenuStrip1.StyleManager = null;
            this.metroSetContextMenuStrip1.ThemeAuthor = "Narwin";
            this.metroSetContextMenuStrip1.ThemeName = "MetroLite";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.IsDerivedStyle = true;
            this.lblVersion.Location = new System.Drawing.Point(770, 549);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(68, 35);
            this.lblVersion.Style = MetroSet_UI.Enums.Style.Light;
            this.lblVersion.StyleManager = this.metroStyleManager;
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "Version :";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.ThemeAuthor = "Narwin";
            this.lblVersion.ThemeName = "MetroLight";
            // 
            // lblVersionValue
            // 
            this.lblVersionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionValue.IsDerivedStyle = true;
            this.lblVersionValue.Location = new System.Drawing.Point(837, 549);
            this.lblVersionValue.Name = "lblVersionValue";
            this.lblVersionValue.Size = new System.Drawing.Size(40, 35);
            this.lblVersionValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblVersionValue.StyleManager = this.metroStyleManager;
            this.lblVersionValue.TabIndex = 17;
            this.lblVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVersionValue.ThemeAuthor = "Narwin";
            this.lblVersionValue.ThemeName = "MetroLight";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblVersionValue);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.msThemeSwitch);
            this.Controls.Add(this.lblThemeTxt);
            this.Controls.Add(this.TabSelection);
            this.Controls.Add(this.CloseControlBox);
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.metroStyleManager;
            this.Text = "CoinOPS Config Tool";
            this.ThemeName = "MetroLight";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.TabSelection.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SysLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemPictureBox)).EndInit();
            this.TabEmulators.ResumeLayout(false);
            this.TabTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroSetSetTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox CloseControlBox;
        private MetroSet_UI.Controls.MetroSetTabControl TabSelection;
        private MetroSet_UI.Child.MetroSetSetTabPage TabMain;
        private MetroSet_UI.Child.MetroSetSetTabPage TabEmulators;
        private MetroSet_UI.Child.MetroSetSetTabPage TabTools;
        private MetroSet_UI.Components.StyleManager metroStyleManager;
        private MetroSet_UI.Controls.MetroSetTextBox tbMainCopsPath;
        private MetroSet_UI.Controls.MetroSetLabel TxtMainCopsPath;
        private System.Windows.Forms.OpenFileDialog fbd;
        private MetroSet_UI.Child.MetroSetSetTabPage TabSystem;
        private MetroSet_UI.Controls.MetroSetComboBox cbSysSelSystem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MetroSet_UI.Controls.MetroSetLabel TxtEmuSelectEmulator;
        private MetroSet_UI.Controls.MetroSetComboBox cbEmuSelecEmulator;
        private MetroSet_UI.Controls.MetroSetLabel txtMainEmuPath;
        private MetroSet_UI.Controls.MetroSetTextBox tbMainEmuTxtPath;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuPercent;
        private MetroSet_UI.Controls.MetroSetProgressBar EmuProgressBar;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuDownloadSpeed;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuDownloaded;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuDownloadedValue;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuDownloadSpeedValue;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuDownloadStatus;
        private MetroSet_UI.Controls.MetroSetLabel lblEmuStatusTxt;
        private MetroSet_UI.Controls.MetroSetLabel lblToolsStatusValue;
        private MetroSet_UI.Controls.MetroSetLabel lblToolsStatus;
        private MetroSet_UI.Controls.MetroSetLabel lblToolsDownloadedValue;
        private MetroSet_UI.Controls.MetroSetLabel lblToolsDownloadSpeedValue;
        private MetroSet_UI.Controls.MetroSetProgressBar ToolsProgressBar;
        private MetroSet_UI.Controls.MetroSetLabel lblToolDownloadSpeed;
        private MetroSet_UI.Controls.MetroSetLabel lblToolDownloadedTxt;
        private MetroSet_UI.Controls.MetroSetButton bntSysAddSystem;
        private MetroSet_UI.Controls.MetroSetButton btnToolsInstallRuntime;
        private MetroSet_UI.Controls.MetroSetButton BtnToolsInstallTorrentZip;
        private MetroSet_UI.Controls.MetroSetButton BtnEmuExtract;
        private MetroSet_UI.Controls.MetroSetButton BtnEmuDownload;
        private MetroSet_UI.Controls.MetroSetTextBox lblEmuSystemType;
        private MetroSet_UI.Controls.MetroSetTextBox tbEmuFolderDestination;
        private MetroSet_UI.Controls.MetroSetLabel TxtEmuDownloadLink;
        private MetroSet_UI.Controls.MetroSetTextBox TbEmuDownloadLink;
        private MetroSet_UI.Controls.MetroSetLabel TxtEmuFolderDestination;
        private MetroSet_UI.Controls.MetroSetLabel lblToolsPercent;
        private MetroSet_UI.Controls.MetroSetLabel TxtSysSelectSystem;
        private MetroSet_UI.Controls.MetroSetButton btnMainBrowse;
        private MetroSet_UI.Controls.MetroSetLabel lblThemeTxt;
        private MetroSet_UI.Controls.MetroSetSwitch msThemeSwitch;
        private MetroSet_UI.Controls.MetroSetLabel txtMainLauncherPath;
        private MetroSet_UI.Controls.MetroSetTextBox tbMainLauncherTxtPath;
        private MetroSet_UI.Controls.MetroSetLabel txtMainCollectionPath;
        private MetroSet_UI.Controls.MetroSetTextBox tbMainColTxtPath;
        private MetroSet_UI.Controls.MetroSetButton BtnEmuOpen;
        private MetroSet_UI.Controls.MetroSetButton BtnLauncherOpen;
        private MetroSet_UI.Controls.MetroSetButton BtnCollectonOpen;
        private System.Windows.Forms.PictureBox SystemPictureBox;
        private MetroSet_UI.Controls.MetroSetLabel lblSysTxtInfo;
        private System.Windows.Forms.PictureBox SysLogoPictureBox;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage1;
        private MetroSet_UI.Controls.MetroSetLabel lblSettingTheme;
        private MetroSet_UI.Controls.MetroSetButton BtnThemeDownload;
        private MetroSet_UI.Controls.MetroSetComboBox cbSettingTheme;
        private MetroSet_UI.Controls.MetroSetTextBox tbSettingTheme;
        private MetroSet_UI.Controls.MetroSetLabel lblSettingActualTheme;
        private MetroSet_UI.Controls.MetroSetButton BtnToolsInstallDirectX;
        private MetroSet_UI.Controls.MetroSetButton BtnToolsInstallRomsCenter;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroSet_UI.Controls.MetroSetButton BtnSaveSetting;
        private System.Windows.Forms.PictureBox pbSelectedTheme;
        private System.Windows.Forms.PictureBox pbActualTheme;
        private MetroSet_UI.Controls.MetroSetButton BtnDownloadApply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroSet_UI.Controls.MetroSetLabel lblVersionValue;
        private MetroSet_UI.Controls.MetroSetLabel lblVersion;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip1;
    }
}

