namespace ANZ1AMLO.Forms
{
    partial class frmViewImporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewImporting));
            this.lblPathFolder = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblSourceName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gdViewDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lbRecs = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ANZ2AMLO.Forms.WaitForm1), true, true);
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbSourceType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPathFolder
            // 
            this.lblPathFolder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathFolder.Appearance.Options.UseFont = true;
            this.lblPathFolder.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPathFolder.Location = new System.Drawing.Point(133, 40);
            this.lblPathFolder.Name = "lblPathFolder";
            this.lblPathFolder.Size = new System.Drawing.Size(759, 23);
            this.lblPathFolder.TabIndex = 12;
            this.lblPathFolder.Text = "xx";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 19);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Path Folder :";
            // 
            // lblSourceName
            // 
            this.lblSourceName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceName.Appearance.Options.UseFont = true;
            this.lblSourceName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSourceName.Location = new System.Drawing.Point(133, 16);
            this.lblSourceName.Name = "lblSourceName";
            this.lblSourceName.Size = new System.Drawing.Size(702, 23);
            this.lblSourceName.TabIndex = 10;
            this.lblSourceName.Text = "xx";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Report :";
            // 
            // gdViewDetail
            // 
            this.gdViewDetail.Location = new System.Drawing.Point(26, 191);
            this.gdViewDetail.MainView = this.gridView1;
            this.gdViewDetail.Name = "gdViewDetail";
            this.gdViewDetail.Size = new System.Drawing.Size(1270, 492);
            this.gdViewDetail.TabIndex = 14;
            this.gdViewDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdViewDetail;
            this.gridView1.Name = "gridView1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem3,
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1344, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 758);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1344, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 758);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1344, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 758);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Process";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
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
            // btnView
            // 
            this.btnView.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnView.Appearance.BackColor2 = System.Drawing.Color.Chartreuse;
            this.btnView.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnView.Appearance.Options.UseBackColor = true;
            this.btnView.Appearance.Options.UseFont = true;
            this.btnView.Appearance.Options.UseForeColor = true;
            this.btnView.Location = new System.Drawing.Point(831, 73);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(133, 35);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "VIEW";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(64, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 19);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "From :";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(461, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 19);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "To :";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(132, 114);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(265, 30);
            this.dateEdit1.TabIndex = 19;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(491, 114);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit2.Properties.Appearance.Options.UseFont = true;
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(334, 30);
            this.dateEdit2.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1112, 166);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 19);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Records :";
            // 
            // lbRecs
            // 
            this.lbRecs.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecs.Appearance.Options.UseFont = true;
            this.lbRecs.Appearance.Options.UseTextOptions = true;
            this.lbRecs.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRecs.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbRecs.Location = new System.Drawing.Point(1185, 162);
            this.lbRecs.Name = "lbRecs";
            this.lbRecs.Size = new System.Drawing.Size(108, 23);
            this.lbRecs.TabIndex = 22;
            this.lbRecs.Text = "xx";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // btnImport
            // 
            this.btnImport.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.btnImport.Appearance.BackColor2 = System.Drawing.Color.LightSeaGreen;
            this.btnImport.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Appearance.Options.UseBackColor = true;
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Appearance.Options.UseForeColor = true;
            this.btnImport.Location = new System.Drawing.Point(981, 73);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(136, 35);
            this.btnImport.TabIndex = 23;
            this.btnImport.Text = "IMPORT";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1344, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 758);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 19);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Source Type :";
            // 
            // cbSourceType
            // 
            this.cbSourceType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSourceType.FormattingEnabled = true;
            this.cbSourceType.Location = new System.Drawing.Point(132, 73);
            this.cbSourceType.Name = "cbSourceType";
            this.cbSourceType.Size = new System.Drawing.Size(693, 31);
            this.cbSourceType.TabIndex = 15;
            // 
            // frmViewImporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 758);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lbRecs);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cbSourceType);
            this.Controls.Add(this.gdViewDetail);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblPathFolder);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblSourceName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewImporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewImporting";
            this.Load += new System.EventHandler(this.frmViewImporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblPathFolder;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblSourceName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gdViewDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbRecs;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ComboBox cbSourceType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}