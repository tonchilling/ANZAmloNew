namespace ANZ2AMLO.Forms
{
    partial class frmImportDataDaily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportDataDaily));
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKeyWord = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSourceFile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnVerify = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtImport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFileCount = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gdDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ANZ2AMLO.Forms.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.EditValue = "";
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(440, 25);
            this.txtType.MenuManager = this.barManager1;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(99, 20);
            this.txtType.TabIndex = 7;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1186, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 817);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1186, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 797);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1186, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 797);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Process";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(440, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Type";
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.EditValue = "";
            this.txtKeyWord.Enabled = false;
            this.txtKeyWord.Location = new System.Drawing.Point(288, 25);
            this.txtKeyWord.MenuManager = this.barManager1;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(146, 20);
            this.txtKeyWord.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(288, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Keyword ";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.EditValue = "";
            this.txtSourceFile.Enabled = false;
            this.txtSourceFile.Location = new System.Drawing.Point(12, 25);
            this.txtSourceFile.MenuManager = this.barManager1;
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(270, 20);
            this.txtSourceFile.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Source File Ref. Name :";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnImport);
            this.panelControl1.Controls.Add(this.btnVerify);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtFileName);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txtImport);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtFileCount);
            this.panelControl1.Controls.Add(this.txtType);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtKeyWord);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtSourceFile);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtRemark);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1186, 199);
            this.panelControl1.TabIndex = 12;
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(978, 21);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(170, 68);
            this.btnImport.TabIndex = 20;
            this.btnImport.Text = "Import All";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Appearance.Options.UseFont = true;
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(787, 21);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(170, 68);
            this.btnVerify.TabIndex = 19;
            this.btnVerify.Text = "Verify Existing File";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Remark";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(639, 67);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 23);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Select file";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 51);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Import Folder";
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(12, 69);
            this.txtFileName.MenuManager = this.barManager1;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.txtFileName.Size = new System.Drawing.Size(621, 20);
            this.txtFileName.TabIndex = 14;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(650, 6);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 13);
            this.labelControl11.TabIndex = 11;
            this.labelControl11.Text = "Import";
            // 
            // txtImport
            // 
            this.txtImport.EditValue = "";
            this.txtImport.Enabled = false;
            this.txtImport.Location = new System.Drawing.Point(650, 25);
            this.txtImport.MenuManager = this.barManager1;
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(104, 20);
            this.txtImport.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(545, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Files Count";
            // 
            // txtFileCount
            // 
            this.txtFileCount.EditValue = "";
            this.txtFileCount.Enabled = false;
            this.txtFileCount.Location = new System.Drawing.Point(545, 25);
            this.txtFileCount.MenuManager = this.barManager1;
            this.txtFileCount.Name = "txtFileCount";
            this.txtFileCount.Size = new System.Drawing.Size(99, 20);
            this.txtFileCount.TabIndex = 8;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(12, 114);
            this.txtRemark.MenuManager = this.barManager1;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(742, 69);
            this.txtRemark.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gdDetail
            // 
            this.gdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdDetail.Location = new System.Drawing.Point(0, 219);
            this.gdDetail.MainView = this.gridView1;
            this.gdDetail.Name = "gdDetail";
            this.gdDetail.Size = new System.Drawing.Size(1186, 598);
            this.gdDetail.TabIndex = 20;
            this.gdDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdDetail;
            this.gridView1.Name = "gridView1";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmImportDataDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 817);
            this.Controls.Add(this.gdDetail);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmImportDataDaily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Daily";
            this.Load += new System.EventHandler(this.frmImportDataDaily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtImport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFileCount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKeyWord;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSourceFile;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnVerify;
        private DevExpress.XtraGrid.GridControl gdDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}