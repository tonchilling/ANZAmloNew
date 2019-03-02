namespace ANZ2AMLO.Forms
{
    partial class frmTransectionMasterMapping
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransectionMasterMapping));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gdView = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShowOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogic1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogic2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogic3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogic4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogic5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Source File Save Status : Save @ 16/10/2018";
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
            this.gdView.Size = new System.Drawing.Size(994, 507);
            this.gdView.TabIndex = 17;
            this.gdView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.gridColumn2,
            this.colFileName,
            this.colKeyWord,
            this.colShowOrderNo,
            this.colKey,
            this.colLogic1,
            this.colLogic2,
            this.colLogic3,
            this.colLogic4,
            this.colLogic5,
            this.colDID,
            this.colHID,
            this.colAction});
            this.gridView1.GridControl = this.gdView;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mapping";
            this.gridColumn2.FieldName = "Mapping";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "Field Name";
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 1;
            this.colFileName.Width = 50;
            // 
            // colKeyWord
            // 
            this.colKeyWord.Caption = "Group";
            this.colKeyWord.FieldName = "Group";
            this.colKeyWord.MaxWidth = 100;
            this.colKeyWord.Name = "colKeyWord";
            this.colKeyWord.Visible = true;
            this.colKeyWord.VisibleIndex = 3;
            // 
            // colShowOrderNo
            // 
            this.colShowOrderNo.Caption = "Show Order No.";
            this.colShowOrderNo.FieldName = "ShowOrderNo";
            this.colShowOrderNo.MaxWidth = 50;
            this.colShowOrderNo.Name = "colShowOrderNo";
            this.colShowOrderNo.Visible = true;
            this.colShowOrderNo.VisibleIndex = 4;
            this.colShowOrderNo.Width = 50;
            // 
            // colKey
            // 
            this.colKey.Caption = "Key";
            this.colKey.FieldName = "Key";
            this.colKey.MaxWidth = 50;
            this.colKey.Name = "colKey";
            this.colKey.Visible = true;
            this.colKey.VisibleIndex = 5;
            this.colKey.Width = 50;
            // 
            // colLogic1
            // 
            this.colLogic1.Caption = "Logic 1";
            this.colLogic1.FieldName = "Logic1";
            this.colLogic1.MaxWidth = 80;
            this.colLogic1.Name = "colLogic1";
            this.colLogic1.Visible = true;
            this.colLogic1.VisibleIndex = 6;
            // 
            // colLogic2
            // 
            this.colLogic2.Caption = "Logic 2";
            this.colLogic2.FieldName = "Logic2";
            this.colLogic2.MaxWidth = 80;
            this.colLogic2.Name = "colLogic2";
            this.colLogic2.Visible = true;
            this.colLogic2.VisibleIndex = 7;
            // 
            // colLogic3
            // 
            this.colLogic3.Caption = "Logic 3";
            this.colLogic3.FieldName = "Logic3";
            this.colLogic3.Name = "colLogic3";
            this.colLogic3.Visible = true;
            this.colLogic3.VisibleIndex = 8;
            // 
            // colLogic4
            // 
            this.colLogic4.Caption = "Logic 4";
            this.colLogic4.FieldName = "Logic4";
            this.colLogic4.Name = "colLogic4";
            this.colLogic4.Visible = true;
            this.colLogic4.VisibleIndex = 9;
            // 
            // colLogic5
            // 
            this.colLogic5.Caption = "Logic 5";
            this.colLogic5.FieldName = "Logic5";
            this.colLogic5.Name = "colLogic5";
            this.colLogic5.Visible = true;
            this.colLogic5.VisibleIndex = 10;
            // 
            // colDID
            // 
            this.colDID.Caption = "DID";
            this.colDID.FieldName = "DID";
            this.colDID.MinWidth = 10;
            this.colDID.Name = "colDID";
            // 
            // colHID
            // 
            this.colHID.Caption = "HID";
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            // 
            // colAction
            // 
            this.colAction.Caption = "Action";
            this.colAction.ColumnEdit = this.btnView;
            this.colAction.FieldName = "Priotiry 3";
            this.colAction.MaxWidth = 80;
            this.colAction.Name = "colAction";
            this.colAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 11;
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
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 598);
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
            this.barButtonItem3.Caption = "Export To Excel";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(994, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 638);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(994, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(994, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 598);
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 598);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(994, 40);
            this.panelControl2.TabIndex = 19;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(994, 51);
            this.panelControl1.TabIndex = 18;
            // 
            // frmTransectionMasterMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 638);
            this.Controls.Add(this.gdView);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTransectionMasterMapping";
            this.Text = "A-004:- Transaction Master-Mapping";
            this.Load += new System.EventHandler(this.frmTransectionMasterMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gdView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyWord;
        private DevExpress.XtraGrid.Columns.GridColumn colShowOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKey;
        private DevExpress.XtraGrid.Columns.GridColumn colLogic1;
        private DevExpress.XtraGrid.Columns.GridColumn colLogic2;
        private DevExpress.XtraGrid.Columns.GridColumn colLogic3;
        private DevExpress.XtraGrid.Columns.GridColumn colLogic4;
        private DevExpress.XtraGrid.Columns.GridColumn colLogic5;
        private DevExpress.XtraGrid.Columns.GridColumn colDID;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnView;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}