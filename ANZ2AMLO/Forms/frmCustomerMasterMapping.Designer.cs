namespace ANZ2AMLO.Forms
{
    partial class frmCustomerMasterMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerMasterMapping));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilePreiod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTestImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gdView = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 492);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1021, 110);
            this.panelControl2.TabIndex = 16;
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
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1021, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 602);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1021, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 562);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1021, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 562);
            // 
            // colHID
            // 
            this.colHID.Caption = "HID";
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            // 
            // colFilePreiod
            // 
            this.colFilePreiod.Caption = "CM-Required";
            this.colFilePreiod.FieldName = "CMReqquired";
            this.colFilePreiod.MaxWidth = 50;
            this.colFilePreiod.Name = "colFilePreiod";
            this.colFilePreiod.Visible = true;
            this.colFilePreiod.VisibleIndex = 3;
            this.colFilePreiod.Width = 50;
            // 
            // colDID
            // 
            this.colDID.Caption = "DID";
            this.colDID.FieldName = "DID";
            this.colDID.MinWidth = 10;
            this.colDID.Name = "colDID";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colFileName,
            this.colKeyWord,
            this.colFilePreiod,
            this.colType,
            this.colTestImport,
            this.colStatus,
            this.gridColumn1,
            this.colDID,
            this.colHID,
            this.colAction});
            this.gridView1.GridControl = this.gdView;
            this.gridView1.Name = "gridView1";
            // 
            // colNo
            // 
            this.colNo.Caption = "No";
            this.colNo.FieldName = "colNo";
            this.colNo.MaxWidth = 50;
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 50;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "File Name";
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 1;
            this.colFileName.Width = 50;
            // 
            // colKeyWord
            // 
            this.colKeyWord.Caption = "Example Value";
            this.colKeyWord.FieldName = "ExampleValue";
            this.colKeyWord.MaxWidth = 100;
            this.colKeyWord.Name = "colKeyWord";
            this.colKeyWord.Visible = true;
            this.colKeyWord.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.Caption = "Link Value";
            this.colType.FieldName = "LinkValue";
            this.colType.MaxWidth = 50;
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 4;
            this.colType.Width = 50;
            // 
            // colTestImport
            // 
            this.colTestImport.Caption = "Priority 1";
            this.colTestImport.FieldName = "Priority1";
            this.colTestImport.MaxWidth = 80;
            this.colTestImport.Name = "colTestImport";
            this.colTestImport.Visible = true;
            this.colTestImport.VisibleIndex = 5;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Priority 2";
            this.colStatus.FieldName = "Priority2";
            this.colStatus.MaxWidth = 80;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Priotiry 3";
            this.gridColumn1.FieldName = "Priority3";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // colAction
            // 
            this.colAction.Caption = "Action";
            this.colAction.ColumnEdit = this.btnView;
            this.colAction.FieldName = "View";
            this.colAction.MaxWidth = 80;
            this.colAction.Name = "colAction";
            this.colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 8;
            // 
            // btnView
            // 
            this.btnView.AutoHeight = false;
            this.btnView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "VIEW", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnView.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnView.Name = "btnView";
            this.btnView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gdView
            // 
            this.gdView.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gdView.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gdView.Location = new System.Drawing.Point(0, 91);
            this.gdView.MainView = this.gridView1;
            this.gdView.Name = "gdView";
            this.gdView.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnView});
            this.gdView.Size = new System.Drawing.Size(1021, 401);
            this.gdView.TabIndex = 14;
            this.gdView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1021, 51);
            this.panelControl1.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Source File Save Status : Save @ 16/10/2018";
            // 
            // frmCustomerMasterMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 602);
            this.Controls.Add(this.gdView);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCustomerMasterMapping";
            this.Text = "Customer Master Mapping";
            this.Load += new System.EventHandler(this.frmCustomerMasterMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gdView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyWord;
        private DevExpress.XtraGrid.Columns.GridColumn colFilePreiod;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colTestImport;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnView;
        private DevExpress.XtraGrid.Columns.GridColumn colDID;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}