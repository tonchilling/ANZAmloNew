namespace ANZ2AMLO.Forms
{
    partial class frmReportFilterRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportFilterRule));
            this.gdView = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilterRuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogicFilterLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
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
            this.gdView.Size = new System.Drawing.Size(997, 510);
            this.gdView.TabIndex = 23;
            this.gdView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colTransactionType,
            this.colFilterRuleName,
            this.colLogicFilterLevel,
            this.colCondition,
            this.colActiveStatus,
            this.colActive,
            this.colUpdateDate,
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
            // colTransactionType
            // 
            this.colTransactionType.Caption = "Transaction Type";
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 1;
            // 
            // colFilterRuleName
            // 
            this.colFilterRuleName.Caption = "Filter Rule Name";
            this.colFilterRuleName.FieldName = "FilterRuleName";
            this.colFilterRuleName.Name = "colFilterRuleName";
            this.colFilterRuleName.Visible = true;
            this.colFilterRuleName.VisibleIndex = 2;
            this.colFilterRuleName.Width = 50;
            // 
            // colLogicFilterLevel
            // 
            this.colLogicFilterLevel.Caption = "Logic Filter Level";
            this.colLogicFilterLevel.FieldName = "LogicFilterLevel";
            this.colLogicFilterLevel.MaxWidth = 100;
            this.colLogicFilterLevel.Name = "colLogicFilterLevel";
            this.colLogicFilterLevel.Visible = true;
            this.colLogicFilterLevel.VisibleIndex = 3;
            // 
            // colCondition
            // 
            this.colCondition.Caption = "Condition";
            this.colCondition.FieldName = "Condition";
            this.colCondition.MaxWidth = 50;
            this.colCondition.Name = "colCondition";
            this.colCondition.Visible = true;
            this.colCondition.VisibleIndex = 4;
            this.colCondition.Width = 50;
            // 
            // colActiveStatus
            // 
            this.colActiveStatus.Caption = "Active Status";
            this.colActiveStatus.FieldName = "ActiveStatus";
            this.colActiveStatus.MaxWidth = 50;
            this.colActiveStatus.Name = "colActiveStatus";
            this.colActiveStatus.Visible = true;
            this.colActiveStatus.VisibleIndex = 5;
            this.colActiveStatus.Width = 50;
            // 
            // colActive
            // 
            this.colActive.Caption = "Active / In-Active";
            this.colActive.FieldName = "Active";
            this.colActive.MaxWidth = 80;
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 6;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "Update Date / Time by";
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.MaxWidth = 80;
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.Visible = true;
            this.colUpdateDate.VisibleIndex = 7;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(997, 51);
            this.panelControl1.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Source File Save Status : Save @ 16/10/2018";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 587);
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
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.barDockControlTop.Size = new System.Drawing.Size(997, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(997, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(997, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 587);
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 601);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(997, 26);
            this.panelControl2.TabIndex = 25;
            // 
            // frmReportFilterRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 627);
            this.Controls.Add(this.gdView);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmReportFilterRule";
            this.Text = "A-005B:- Generate Auto Report-Filter Rule";
            this.Load += new System.EventHandler(this.frmReportFilterRule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colFilterRuleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLogicFilterLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDID;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnView;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
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
    }
}