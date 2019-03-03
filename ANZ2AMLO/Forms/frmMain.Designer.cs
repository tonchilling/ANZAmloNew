namespace ANZ2AMLO.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ANZ2AMLO.Forms.frmSplashScreen), false, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticUser = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.navBarControlMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mmUserGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.mmUser = new DevExpress.XtraNavBar.NavBarItem();
            this.mmMenuGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.mmSubMenu = new DevExpress.XtraNavBar.NavBarItem();
            this.mmMenuPermission = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navImportAll = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCustomerMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarTransactionMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGenAutoAMLO = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navSourceFileConfig = new DevExpress.XtraNavBar.NavBarItem();
            this.navSourceFileMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navCutomerMasterMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navTransactionMasterMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navReportMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navReportFilterRole = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnLogin = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 5000;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLinkContainerItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barStaticUser,
            this.barMdiChildrenListItem1,
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLinkContainerItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMdiChildrenListItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.skinBarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "Menu";
            this.barLinkContainerItem1.Id = 0;
            this.barLinkContainerItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLinkContainerItem1.ImageOptions.Image")));
            this.barLinkContainerItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Logoff";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "System Config";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Exit";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Active Form";
            this.barMdiChildrenListItem1.Id = 5;
            this.barMdiChildrenListItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem1.ImageOptions.Image")));
            this.barMdiChildrenListItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem1.ImageOptions.LargeImage")));
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Theme";
            this.skinBarSubItem1.Id = 6;
            this.skinBarSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.Image")));
            this.skinBarSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.LargeImage")));
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticUser)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticUser
            // 
            this.barStaticUser.Caption = "User : xxxx";
            this.barStaticUser.Id = 4;
            this.barStaticUser.Name = "barStaticUser";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(975, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(975, 38);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 620);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(975, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 620);
            // 
            // navBarControlMain
            // 
            this.navBarControlMain.ActiveGroup = this.navBarGroup1;
            this.navBarControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.navBarControlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControlMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup3,
            this.navBarGroup2,
            this.navBarGroup4,
            this.navBarGroup5});
            this.navBarControlMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navImportAll,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarCustomerMaster,
            this.navSourceFileConfig,
            this.navBarTransactionMaster,
            this.navSourceFileMapping,
            this.navCutomerMasterMapping,
            this.navTransactionMasterMapping,
            this.navReportMapping,
            this.navReportFilterRole,
            this.navBarGenAutoAMLO,
            this.mmUserGroup,
            this.mmUser,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.mmMenuGroup,
            this.mmSubMenu,
            this.mmMenuPermission});
            this.navBarControlMain.Location = new System.Drawing.Point(0, 24);
            this.navBarControlMain.Name = "navBarControlMain";
            this.navBarControlMain.OptionsNavPane.ExpandedWidth = 214;
            this.navBarControlMain.Size = new System.Drawing.Size(214, 620);
            this.navBarControlMain.TabIndex = 5;
            this.navBarControlMain.Text = "navBarControl1";
            this.navBarControlMain.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            this.navBarControlMain.Click += new System.EventHandler(this.navBarControlMain_Click);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "User Authorize";
            this.navBarGroup5.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mmUserGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mmUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mmMenuGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mmSubMenu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mmMenuPermission)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // mmUserGroup
            // 
            this.mmUserGroup.Caption = "User Group";
            this.mmUserGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mmUserGroup.ImageOptions.LargeImage")));
            this.mmUserGroup.Name = "mmUserGroup";
            this.mmUserGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mmUserGroup_LinkClicked);
            // 
            // mmUser
            // 
            this.mmUser.Caption = "Users";
            this.mmUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mmUser.ImageOptions.LargeImage")));
            this.mmUser.Name = "mmUser";
            this.mmUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mmUser_LinkClicked);
            // 
            // mmMenuGroup
            // 
            this.mmMenuGroup.Caption = "Menu Group";
            this.mmMenuGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mmMenuGroup.ImageOptions.LargeImage")));
            this.mmMenuGroup.Name = "mmMenuGroup";
            this.mmMenuGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mmMenuGroup_LinkClicked);
            // 
            // mmSubMenu
            // 
            this.mmSubMenu.Caption = "Sub Menu";
            this.mmSubMenu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mmSubMenu.ImageOptions.LargeImage")));
            this.mmSubMenu.Name = "mmSubMenu";
            this.mmSubMenu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mmSubMenu_LinkClicked);
            // 
            // mmMenuPermission
            // 
            this.mmMenuPermission.Caption = "Menu Permission";
            this.mmMenuPermission.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mmMenuPermission.ImageOptions.LargeImage")));
            this.mmMenuPermission.Name = "mmMenuPermission";
            this.mmMenuPermission.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mmMenuPermission_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Souce Data Management";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navImportAll),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCustomerMaster),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarTransactionMaster)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navImportAll
            // 
            this.navImportAll.Caption = "001:- Import All Source File";
            this.navImportAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navImportAll.ImageOptions.LargeImage")));
            this.navImportAll.Name = "navImportAll";
            this.navImportAll.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navImportAll_LinkClicked);
            // 
            // navBarItem10
            // 
            this.navBarItem10.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("navBarItem10.Appearance.Image")));
            this.navBarItem10.Appearance.Options.UseImage = true;
            this.navBarItem10.Caption = "002:-View Imported Source data";
            this.navBarItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem10.ImageOptions.LargeImage")));
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem10_LinkClicked);
            // 
            // navBarCustomerMaster
            // 
            this.navBarCustomerMaster.Caption = "003:-Customer Master";
            this.navBarCustomerMaster.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarCustomerMaster.ImageOptions.LargeImage")));
            this.navBarCustomerMaster.Name = "navBarCustomerMaster";
            this.navBarCustomerMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarCustomerMaster_LinkClicked);
            // 
            // navBarTransactionMaster
            // 
            this.navBarTransactionMaster.Caption = "004:-Transaction Master";
            this.navBarTransactionMaster.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarTransactionMaster.ImageOptions.LargeImage")));
            this.navBarTransactionMaster.Name = "navBarTransactionMaster";
            this.navBarTransactionMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarTransactionMaster_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "AMLO-Report";
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarGenAutoAMLO),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGenAutoAMLO
            // 
            this.navBarGenAutoAMLO.Caption = "000:- Report workflow Status";
            this.navBarGenAutoAMLO.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGenAutoAMLO.ImageOptions.LargeImage")));
            this.navBarGenAutoAMLO.Name = "navBarGenAutoAMLO";
            this.navBarGenAutoAMLO.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarGenAutoAMLO_LinkClicked);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "005:-Generate Auto AMLO-1-05-9: Electronic Fund Transfer > 700,000 THB";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "007:-AMLO-1-05-1: Cash Transaction > 2 Million THB";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "008:-AMLO-1-05-2: Transaction Related to Asset > 5 Million THB";
            this.navBarItem8.Name = "navBarItem8";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "009:-AMLO-1-05-3: Suspicious Transaction";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Process Setting";
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSourceFileConfig),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSourceFileMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCutomerMasterMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTransactionMasterMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navReportMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navReportFilterRole)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.TopVisibleLinkIndex = 1;
            // 
            // navSourceFileConfig
            // 
            this.navSourceFileConfig.Caption = "A-001:- Source File List Config";
            this.navSourceFileConfig.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navSourceFileConfig.ImageOptions.LargeImage")));
            this.navSourceFileConfig.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSourceFileConfig.ImageOptions.SmallImage")));
            this.navSourceFileConfig.Name = "navSourceFileConfig";
            this.navSourceFileConfig.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSettingCustomerSebel_LinkClicked);
            // 
            // navSourceFileMapping
            // 
            this.navSourceFileMapping.Caption = "A-002:- Source File - Mapping";
            this.navSourceFileMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navSourceFileMapping.ImageOptions.LargeImage")));
            this.navSourceFileMapping.Name = "navSourceFileMapping";
            this.navSourceFileMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSourceFileMapping_LinkClicked);
            // 
            // navCutomerMasterMapping
            // 
            this.navCutomerMasterMapping.Caption = "A-003:- Customer Master-Mapping";
            this.navCutomerMasterMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navCutomerMasterMapping.ImageOptions.LargeImage")));
            this.navCutomerMasterMapping.Name = "navCutomerMasterMapping";
            this.navCutomerMasterMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCutomerMasterMapping_LinkClicked);
            // 
            // navTransactionMasterMapping
            // 
            this.navTransactionMasterMapping.Caption = "A-004:- Transaction Master-Mapping";
            this.navTransactionMasterMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navTransactionMasterMapping.ImageOptions.LargeImage")));
            this.navTransactionMasterMapping.Name = "navTransactionMasterMapping";
            this.navTransactionMasterMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTransactionMasterMapping_LinkClicked);
            // 
            // navReportMapping
            // 
            this.navReportMapping.Caption = "A-005A:- Generate Auto Report-Mapping";
            this.navReportMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navReportMapping.ImageOptions.LargeImage")));
            this.navReportMapping.Name = "navReportMapping";
            this.navReportMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navReportMapping_LinkClicked);
            // 
            // navReportFilterRole
            // 
            this.navReportFilterRole.Caption = "A-005B:- Generate Auto Report-Filter Rule";
            this.navReportFilterRole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navReportFilterRole.ImageOptions.LargeImage")));
            this.navReportFilterRole.Name = "navReportFilterRole";
            this.navReportFilterRole.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navReportFilterRole_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Report";
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "006:- Export Report";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Validate";
            this.navBarItem3.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Export";
            this.navBarItem4.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(5, 35);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(426, 140);
            this.pictureEdit2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(124, 226);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(258, 30);
            this.txtPassword.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "USER NAME";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(124, 191);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(258, 30);
            this.txtUserName.TabIndex = 32;
            // 
            // pnLogin
            // 
            this.pnLogin.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLogin.AppearanceCaption.ForeColor = System.Drawing.Color.CadetBlue;
            this.pnLogin.AppearanceCaption.Options.UseFont = true;
            this.pnLogin.AppearanceCaption.Options.UseForeColor = true;
            this.pnLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pnLogin.Controls.Add(this.simpleButton2);
            this.pnLogin.Controls.Add(this.pictureEdit2);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.txtUserName);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Location = new System.Drawing.Point(342, 156);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(449, 307);
            this.pnLogin.TabIndex = 34;
            this.pnLogin.Text = "LOGIN";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.Red;
            this.simpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.Location = new System.Drawing.Point(258, 262);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(124, 31);
            this.simpleButton2.TabIndex = 39;
            this.simpleButton2.Text = "CANCEL";
            this.simpleButton2.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLogin.Location = new System.Drawing.Point(124, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 31);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 682);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.navBarControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANZ AMLO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnLogin)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraNavBar.NavBarControl navBarControlMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticUser;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarCustomerMaster;
        private DevExpress.XtraNavBar.NavBarItem navSourceFileConfig;
        private DevExpress.XtraNavBar.NavBarItem navImportAll;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navSourceFileMapping;
        private DevExpress.XtraNavBar.NavBarItem navBarTransactionMaster;
        private DevExpress.XtraNavBar.NavBarItem navCutomerMasterMapping;
        private DevExpress.XtraNavBar.NavBarItem navTransactionMasterMapping;
        private DevExpress.XtraNavBar.NavBarItem navReportMapping;
        private DevExpress.XtraNavBar.NavBarItem navReportFilterRole;
        private DevExpress.XtraNavBar.NavBarItem navBarGenAutoAMLO;
        private DevExpress.XtraNavBar.NavBarItem mmUserGroup;
        private DevExpress.XtraNavBar.NavBarItem mmUser;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private DevExpress.XtraNavBar.NavBarItem mmMenuGroup;
        private DevExpress.XtraNavBar.NavBarItem mmSubMenu;
        private DevExpress.XtraNavBar.NavBarItem mmMenuPermission;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.GroupControl pnLogin;
    }
}