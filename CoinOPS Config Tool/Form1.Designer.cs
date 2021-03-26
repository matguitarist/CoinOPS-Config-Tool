
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
            this.txtMainEmuPath = new MetroSet_UI.Controls.MetroSetLabel();
            this.tbMainEmuTxtPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tbMainCopsPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.TxtMainCopsPath = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnMainBrowse = new MetroSet_UI.Controls.MetroSetButton();
            this.TabSystem = new MetroSet_UI.Child.MetroSetSetTabPage();
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
            this.lblDownloadSpeedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuPercent = new MetroSet_UI.Controls.MetroSetLabel();
            this.EmuProgressBar = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.lblEmuDownloadSpeed = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblEmuDownloaded = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtEmuSelectEmulator = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbEmuSelecEmulator = new MetroSet_UI.Controls.MetroSetComboBox();
            this.TxtEmuFolderDestination = new MetroSet_UI.Controls.MetroSetLabel();
            this.TabTools = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.btnToolsInstallRuntime = new MetroSet_UI.Controls.MetroSetButton();
            this.BtnToolsInstallTorrentZip = new MetroSet_UI.Controls.MetroSetButton();
            this.lblToolsStatusValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsStatus = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsDownloadedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolsDownloadSpeedValue = new MetroSet_UI.Controls.MetroSetLabel();
            this.ToolsProgressBar = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.lblToolDownloadSpeed = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblToolDownloadedTxt = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtEmuPercent = new MetroSet_UI.Controls.MetroSetLabel();
            this.fbd = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblThemeTxt = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetSwitch1 = new MetroSet_UI.Controls.MetroSetSwitch();
            this.TabSelection.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabSystem.SuspendLayout();
            this.TabEmulators.SuspendLayout();
            this.TabTools.SuspendLayout();
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
            this.TabSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabSelection.IsDerivedStyle = true;
            this.TabSelection.ItemSize = new System.Drawing.Size(100, 38);
            this.TabSelection.Location = new System.Drawing.Point(50, 100);
            this.TabSelection.Name = "TabSelection";
            this.TabSelection.SelectedIndex = 2;
            this.TabSelection.SelectedTextColor = System.Drawing.Color.White;
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
            this.TabMain.Text = "Main";
            this.TabMain.ThemeAuthor = "Narwin";
            this.TabMain.ThemeName = "MetroLight";
            this.TabMain.ToolTipText = null;
            // 
            // txtMainEmuPath
            // 
            this.txtMainEmuPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainEmuPath.IsDerivedStyle = true;
            this.txtMainEmuPath.Location = new System.Drawing.Point(20, 121);
            this.txtMainEmuPath.Name = "txtMainEmuPath";
            this.txtMainEmuPath.Size = new System.Drawing.Size(310, 35);
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
            this.tbMainEmuTxtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbMainEmuTxtPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbMainEmuTxtPath.Image = null;
            this.tbMainEmuTxtPath.IsDerivedStyle = true;
            this.tbMainEmuTxtPath.Lines = null;
            this.tbMainEmuTxtPath.Location = new System.Drawing.Point(20, 168);
            this.tbMainEmuTxtPath.MaxLength = 32767;
            this.tbMainEmuTxtPath.Multiline = false;
            this.tbMainEmuTxtPath.Name = "tbMainEmuTxtPath";
            this.tbMainEmuTxtPath.ReadOnly = false;
            this.tbMainEmuTxtPath.Size = new System.Drawing.Size(700, 26);
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
            this.tbMainCopsPath.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainCopsPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tbMainCopsPath.Image = null;
            this.tbMainCopsPath.IsDerivedStyle = true;
            this.tbMainCopsPath.Lines = null;
            this.tbMainCopsPath.Location = new System.Drawing.Point(20, 80);
            this.tbMainCopsPath.MaxLength = 32767;
            this.tbMainCopsPath.Multiline = false;
            this.tbMainCopsPath.Name = "tbMainCopsPath";
            this.tbMainCopsPath.ReadOnly = false;
            this.tbMainCopsPath.Size = new System.Drawing.Size(700, 26);
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
            this.TxtMainCopsPath.Location = new System.Drawing.Point(20, 30);
            this.TxtMainCopsPath.Name = "TxtMainCopsPath";
            this.TxtMainCopsPath.Size = new System.Drawing.Size(310, 35);
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
            this.btnMainBrowse.Location = new System.Drawing.Point(726, 79);
            this.btnMainBrowse.Name = "btnMainBrowse";
            this.btnMainBrowse.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMainBrowse.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnMainBrowse.NormalTextColor = System.Drawing.Color.White;
            this.btnMainBrowse.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMainBrowse.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnMainBrowse.PressTextColor = System.Drawing.Color.White;
            this.btnMainBrowse.Size = new System.Drawing.Size(58, 26);
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
            this.TabSystem.ToolTipText = null;
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
            this.bntSysAddSystem.Location = new System.Drawing.Point(703, 80);
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
            "Game Boy",
            "Game Boy Advance"});
            this.cbSysSelSystem.Location = new System.Drawing.Point(20, 80);
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
            this.TabEmulators.Controls.Add(this.lblDownloadSpeedValue);
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
            this.TabEmulators.ToolTipText = null;
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
            this.BtnEmuExtract.Location = new System.Drawing.Point(678, 70);
            this.BtnEmuExtract.Name = "BtnEmuExtract";
            this.BtnEmuExtract.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuExtract.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.BtnEmuExtract.NormalTextColor = System.Drawing.Color.White;
            this.BtnEmuExtract.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuExtract.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.BtnEmuExtract.PressTextColor = System.Drawing.Color.White;
            this.BtnEmuExtract.Size = new System.Drawing.Size(102, 26);
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
            this.BtnEmuDownload.Size = new System.Drawing.Size(102, 26);
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
            this.tbEmuFolderDestination.Location = new System.Drawing.Point(20, 226);
            this.tbEmuFolderDestination.MaxLength = 32767;
            this.tbEmuFolderDestination.Multiline = false;
            this.tbEmuFolderDestination.Name = "tbEmuFolderDestination";
            this.tbEmuFolderDestination.ReadOnly = false;
            this.tbEmuFolderDestination.Size = new System.Drawing.Size(760, 26);
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
            this.TxtEmuDownloadLink.Location = new System.Drawing.Point(20, 109);
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
            this.TbEmuDownloadLink.Location = new System.Drawing.Point(20, 147);
            this.TbEmuDownloadLink.MaxLength = 32767;
            this.TbEmuDownloadLink.Multiline = false;
            this.TbEmuDownloadLink.Name = "TbEmuDownloadLink";
            this.TbEmuDownloadLink.ReadOnly = false;
            this.TbEmuDownloadLink.Size = new System.Drawing.Size(760, 26);
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
            this.lblEmuDownloadStatus.Location = new System.Drawing.Point(660, 305);
            this.lblEmuDownloadStatus.Name = "lblEmuDownloadStatus";
            this.lblEmuDownloadStatus.Size = new System.Drawing.Size(80, 35);
            this.lblEmuDownloadStatus.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloadStatus.StyleManager = this.metroStyleManager;
            this.lblEmuDownloadStatus.TabIndex = 14;
            this.lblEmuDownloadStatus.Text = "Waiting ...";
            this.lblEmuDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmuDownloadStatus.ThemeAuthor = "Narwin";
            this.lblEmuDownloadStatus.ThemeName = "MetroLight";
            // 
            // lblEmuStatusTxt
            // 
            this.lblEmuStatusTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuStatusTxt.IsDerivedStyle = true;
            this.lblEmuStatusTxt.Location = new System.Drawing.Point(527, 305);
            this.lblEmuStatusTxt.Name = "lblEmuStatusTxt";
            this.lblEmuStatusTxt.Size = new System.Drawing.Size(130, 35);
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
            this.lblEmuDownloadedValue.Location = new System.Drawing.Point(146, 305);
            this.lblEmuDownloadedValue.Name = "lblEmuDownloadedValue";
            this.lblEmuDownloadedValue.Size = new System.Drawing.Size(80, 35);
            this.lblEmuDownloadedValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblEmuDownloadedValue.StyleManager = this.metroStyleManager;
            this.lblEmuDownloadedValue.TabIndex = 12;
            this.lblEmuDownloadedValue.Text = "MB";
            this.lblEmuDownloadedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmuDownloadedValue.ThemeAuthor = "Narwin";
            this.lblEmuDownloadedValue.ThemeName = "MetroLight";
            // 
            // lblDownloadSpeedValue
            // 
            this.lblDownloadSpeedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadSpeedValue.IsDerivedStyle = true;
            this.lblDownloadSpeedValue.Location = new System.Drawing.Point(146, 270);
            this.lblDownloadSpeedValue.Name = "lblDownloadSpeedValue";
            this.lblDownloadSpeedValue.Size = new System.Drawing.Size(80, 35);
            this.lblDownloadSpeedValue.Style = MetroSet_UI.Enums.Style.Light;
            this.lblDownloadSpeedValue.StyleManager = this.metroStyleManager;
            this.lblDownloadSpeedValue.TabIndex = 11;
            this.lblDownloadSpeedValue.Text = "Mb/s";
            this.lblDownloadSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDownloadSpeedValue.ThemeAuthor = "Narwin";
            this.lblDownloadSpeedValue.ThemeName = "MetroLight";
            // 
            // lblEmuPercent
            // 
            this.lblEmuPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmuPercent.IsDerivedStyle = true;
            this.lblEmuPercent.Location = new System.Drawing.Point(730, 359);
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
            this.EmuProgressBar.Location = new System.Drawing.Point(49, 359);
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
            this.lblEmuDownloaded.Location = new System.Drawing.Point(20, 305);
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
            "Mame",
            "RetroArch",
            "DuckStation",
            "PCSX2",
            "Rpcs3",
            "PPSSPP"});
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
            this.cbEmuSelecEmulator.TextChanged += new System.EventHandler(this.cbEmuSelecEmulator_TextChanged);
            // 
            // TxtEmuFolderDestination
            // 
            this.TxtEmuFolderDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmuFolderDestination.IsDerivedStyle = true;
            this.TxtEmuFolderDestination.Location = new System.Drawing.Point(20, 188);
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
            this.TabTools.Controls.Add(this.btnToolsInstallRuntime);
            this.TabTools.Controls.Add(this.BtnToolsInstallTorrentZip);
            this.TabTools.Controls.Add(this.lblToolsStatusValue);
            this.TabTools.Controls.Add(this.lblToolsStatus);
            this.TabTools.Controls.Add(this.lblToolsDownloadedValue);
            this.TabTools.Controls.Add(this.lblToolsDownloadSpeedValue);
            this.TabTools.Controls.Add(this.ToolsProgressBar);
            this.TabTools.Controls.Add(this.lblToolDownloadSpeed);
            this.TabTools.Controls.Add(this.lblToolDownloadedTxt);
            this.TabTools.Controls.Add(this.TxtEmuPercent);
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
            this.TabTools.ToolTipText = null;
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
            this.btnToolsInstallRuntime.Location = new System.Drawing.Point(20, 34);
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
            this.btnToolsInstallRuntime.Click += new System.EventHandler(this.btnInstallRuntime_Click);
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
            this.BtnToolsInstallTorrentZip.Location = new System.Drawing.Point(209, 34);
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
            this.lblToolsStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblToolsDownloadedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblToolsDownloadSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ToolsProgressBar.Location = new System.Drawing.Point(49, 359);
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
            // TxtEmuPercent
            // 
            this.TxtEmuPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmuPercent.IsDerivedStyle = true;
            this.TxtEmuPercent.Location = new System.Drawing.Point(730, 359);
            this.TxtEmuPercent.Name = "TxtEmuPercent";
            this.TxtEmuPercent.Size = new System.Drawing.Size(50, 25);
            this.TxtEmuPercent.Style = MetroSet_UI.Enums.Style.Light;
            this.TxtEmuPercent.StyleManager = this.metroStyleManager;
            this.TxtEmuPercent.TabIndex = 18;
            this.TxtEmuPercent.Text = "0%";
            this.TxtEmuPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtEmuPercent.ThemeAuthor = "Narwin";
            this.TxtEmuPercent.ThemeName = "MetroLight";
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
            this.lblThemeTxt.Location = new System.Drawing.Point(706, 60);
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
            // metroSetSwitch1
            // 
            this.metroSetSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetSwitch1.BackgroundColor = System.Drawing.Color.Empty;
            this.metroSetSwitch1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.metroSetSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetSwitch1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetSwitch1.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetSwitch1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetSwitch1.IsDerivedStyle = true;
            this.metroSetSwitch1.Location = new System.Drawing.Point(788, 63);
            this.metroSetSwitch1.Name = "metroSetSwitch1";
            this.metroSetSwitch1.Size = new System.Drawing.Size(58, 22);
            this.metroSetSwitch1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSwitch1.StyleManager = this.metroStyleManager;
            this.metroSetSwitch1.Switched = false;
            this.metroSetSwitch1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.metroSetSwitch1.TabIndex = 6;
            this.metroSetSwitch1.Text = "metroSetSwitch1";
            this.metroSetSwitch1.ThemeAuthor = "Narwin";
            this.metroSetSwitch1.ThemeName = "MetroLight";
            this.metroSetSwitch1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetSwitch1.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.metroSetSwitch1_SwitchedChanged);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroSetSwitch1);
            this.Controls.Add(this.lblThemeTxt);
            this.Controls.Add(this.TabSelection);
            this.Controls.Add(this.CloseControlBox);
            this.Name = "MainWindows";
            this.StyleManager = this.metroStyleManager;
            this.Text = "CoinOPS Config Tool";
            this.ThemeName = "MetroLight";
            this.TabSelection.ResumeLayout(false);
            this.TabMain.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            this.TabEmulators.ResumeLayout(false);
            this.TabTools.ResumeLayout(false);
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
        private MetroSet_UI.Controls.MetroSetLabel lblDownloadSpeedValue;
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
        private MetroSet_UI.Controls.MetroSetLabel TxtEmuPercent;
        private MetroSet_UI.Controls.MetroSetLabel TxtSysSelectSystem;
        private MetroSet_UI.Controls.MetroSetButton btnMainBrowse;
        private MetroSet_UI.Controls.MetroSetLabel lblThemeTxt;
        private MetroSet_UI.Controls.MetroSetSwitch metroSetSwitch1;
    }
}

