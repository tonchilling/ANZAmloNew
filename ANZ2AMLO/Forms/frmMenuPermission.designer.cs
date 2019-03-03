namespace ANZ2AMLO.Forms
{
    partial class frmMenuPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPermission));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdDetail = new DevExpress.XtraGrid.GridControl();
            this.gridDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MENU_OID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MENUGROUP_OID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USERGROUP_OID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MainMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VIEW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkView = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.EDIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.DELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnDeleteDetailColumn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbGroupSearch = new System.Windows.Forms.Label();
            this.cbUserGroupSearch = new System.Windows.Forms.ComboBox();
            this.pnAddEdit = new DevExpress.XtraEditors.PanelControl();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteDetailColumn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnAddEdit)).BeginInit();
            this.pnAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Create";
            this.btnNew.Id = 4;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Name = "btnNew";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Id = 1;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Name = "btnClose";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1335, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 566);
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
            this.btnClose,
            this.barButtonItem3,
            this.btnSave,
            this.btnNew});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1335, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1335, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 566);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Process";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdDetail);
            this.groupBox2.Location = new System.Drawing.Point(4, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(913, 404);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input data";
            // 
            // gdDetail
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gdDetail.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gdDetail.Location = new System.Drawing.Point(13, 25);
            this.gdDetail.MainView = this.gridDetail;
            this.gdDetail.MenuManager = this.barManager1;
            this.gdDetail.Name = "gdDetail";
            this.gdDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteDetailColumn,
            this.chkView,
            this.chkEdit,
            this.chkDelete});
            this.gdDetail.Size = new System.Drawing.Size(880, 366);
            this.gdDetail.TabIndex = 15;
            this.gdDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDetail});
            // 
            // gridDetail
            // 
            this.gridDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MENU_OID,
            this.MENUGROUP_OID,
            this.USERGROUP_OID,
            this.MainMenu,
            this.MenuName,
            this.DESC,
            this.VIEW,
            this.EDIT,
            this.DELETE});
            this.gridDetail.GridControl = this.gdDetail;
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // MENU_OID
            // 
            this.MENU_OID.Caption = "MENU_OID";
            this.MENU_OID.FieldName = "MENU_OID";
            this.MENU_OID.Name = "MENU_OID";
            // 
            // MENUGROUP_OID
            // 
            this.MENUGROUP_OID.Caption = "MENUGROUP_OID";
            this.MENUGROUP_OID.FieldName = "MENUGROUP_OID";
            this.MENUGROUP_OID.Name = "MENUGROUP_OID";
            // 
            // USERGROUP_OID
            // 
            this.USERGROUP_OID.Caption = "USERGROUP_OID";
            this.USERGROUP_OID.FieldName = "USERGROUP_OID";
            this.USERGROUP_OID.Name = "USERGROUP_OID";
            // 
            // MainMenu
            // 
            this.MainMenu.Caption = "Main Menu";
            this.MainMenu.FieldName = "MainMenu";
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.OptionsColumn.AllowEdit = false;
            this.MainMenu.Visible = true;
            this.MainMenu.VisibleIndex = 0;
            // 
            // MenuName
            // 
            this.MenuName.Caption = "Menu Name";
            this.MenuName.FieldName = "MenuName";
            this.MenuName.Name = "MenuName";
            this.MenuName.OptionsColumn.AllowEdit = false;
            this.MenuName.Visible = true;
            this.MenuName.VisibleIndex = 1;
            // 
            // DESC
            // 
            this.DESC.Caption = "Description";
            this.DESC.FieldName = "DESC";
            this.DESC.Name = "DESC";
            this.DESC.OptionsColumn.AllowEdit = false;
            this.DESC.Visible = true;
            this.DESC.VisibleIndex = 2;
            // 
            // VIEW
            // 
            this.VIEW.Caption = "View";
            this.VIEW.ColumnEdit = this.chkView;
            this.VIEW.FieldName = "VIEW";
            this.VIEW.Name = "VIEW";
            this.VIEW.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.VIEW.Visible = true;
            this.VIEW.VisibleIndex = 3;
            // 
            // chkView
            // 
            this.chkView.AutoHeight = false;
            this.chkView.Name = "chkView";
            this.chkView.ValueChecked = "1";
            this.chkView.ValueUnchecked = "0";
            // 
            // EDIT
            // 
            this.EDIT.Caption = "Edit";
            this.EDIT.ColumnEdit = this.chkEdit;
            this.EDIT.FieldName = "EDIT";
            this.EDIT.Name = "EDIT";
            this.EDIT.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.EDIT.Visible = true;
            this.EDIT.VisibleIndex = 4;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoHeight = false;
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.ValueChecked = "1";
            this.chkEdit.ValueUnchecked = "0";
            // 
            // DELETE
            // 
            this.DELETE.Caption = "Delete";
            this.DELETE.ColumnEdit = this.chkDelete;
            this.DELETE.FieldName = "DELETE";
            this.DELETE.Name = "DELETE";
            this.DELETE.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.DELETE.Visible = true;
            this.DELETE.VisibleIndex = 5;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoHeight = false;
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.ValueChecked = "1";
            this.chkDelete.ValueUnchecked = "0";
            // 
            // btnDeleteDetailColumn
            // 
            this.btnDeleteDetailColumn.AutoHeight = false;
            this.btnDeleteDetailColumn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteDetailColumn.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDeleteDetailColumn.Name = "btnDeleteDetailColumn";
            this.btnDeleteDetailColumn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lbGroupSearch);
            this.groupBox1.Controls.Add(this.cbUserGroupSearch);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(913, 72);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(803, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbGroupSearch
            // 
            this.lbGroupSearch.AutoSize = true;
            this.lbGroupSearch.Location = new System.Drawing.Point(35, 35);
            this.lbGroupSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGroupSearch.Name = "lbGroupSearch";
            this.lbGroupSearch.Size = new System.Drawing.Size(36, 13);
            this.lbGroupSearch.TabIndex = 6;
            this.lbGroupSearch.Text = "Group";
            // 
            // cbUserGroupSearch
            // 
            this.cbUserGroupSearch.FormattingEnabled = true;
            this.cbUserGroupSearch.Location = new System.Drawing.Point(83, 30);
            this.cbUserGroupSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbUserGroupSearch.Name = "cbUserGroupSearch";
            this.cbUserGroupSearch.Size = new System.Drawing.Size(707, 21);
            this.cbUserGroupSearch.TabIndex = 5;
            // 
            // pnAddEdit
            // 
            this.pnAddEdit.Controls.Add(this.groupBox2);
            this.pnAddEdit.Location = new System.Drawing.Point(42, 161);
            this.pnAddEdit.Name = "pnAddEdit";
            this.pnAddEdit.Size = new System.Drawing.Size(939, 433);
            this.pnAddEdit.TabIndex = 37;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Location = new System.Drawing.Point(42, 55);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(939, 100);
            this.pnlSearch.TabIndex = 38;
            // 
            // frmMenuPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 606);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnAddEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPermission";
            this.Text = "Menu Permission";
            this.Load += new System.EventHandler(this.frmMenuPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteDetailColumn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnAddEdit)).EndInit();
            this.pnAddEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGroupSearch;
        private System.Windows.Forms.ComboBox cbUserGroupSearch;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraGrid.GridControl gdDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDetail;
        private DevExpress.XtraGrid.Columns.GridColumn MENU_OID;
        private DevExpress.XtraGrid.Columns.GridColumn MainMenu;
        private DevExpress.XtraGrid.Columns.GridColumn MENUGROUP_OID;
        private DevExpress.XtraGrid.Columns.GridColumn MenuName;
        private DevExpress.XtraGrid.Columns.GridColumn DESC;
        private DevExpress.XtraGrid.Columns.GridColumn USERGROUP_OID;
        private DevExpress.XtraGrid.Columns.GridColumn VIEW;
        private DevExpress.XtraGrid.Columns.GridColumn EDIT;
        private DevExpress.XtraGrid.Columns.GridColumn DELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteDetailColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDelete;
        private DevExpress.XtraEditors.PanelControl pnAddEdit;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
    }
}