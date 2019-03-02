namespace ANZ2AMLO.Forms
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colunload_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colship_to_party = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcus_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexternal_delivery_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldelivery_quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsales_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpicking_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgood_movement_stat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbase_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsold_to_paty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpurchaseing_document = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgood_issue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimport_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpk_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkb_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colssa_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcustomer_material_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkb_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunloading_point = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colun_doc_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colob_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunload_status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(768, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 446);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(768, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(768, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pLinqInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(768, 422);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "unload_id ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(ANZ2AMLO.Contexts.unloading);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colunload_id,
            this.coldelivery,
            this.colitem,
            this.colship_to_party,
            this.colcus_name,
            this.colexternal_delivery_id,
            this.colmaterial,
            this.coldelivery_quantity,
            this.colsales_unit,
            this.colpicking_status,
            this.colgood_movement_stat,
            this.colplant,
            this.coldescription,
            this.colbase_unit,
            this.colsold_to_paty,
            this.colpurchaseing_document,
            this.colgood_issue_date,
            this.colimport_date,
            this.colpk_id,
            this.colkb_number,
            this.colssa_id,
            this.colcustomer_material_number,
            this.colkb_id,
            this.colunloading_point,
            this.colun_doc_id,
            this.colob_id,
            this.colunload_status});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colunload_id
            // 
            this.colunload_id.FieldName = "unload_id";
            this.colunload_id.Name = "colunload_id";
            this.colunload_id.Visible = true;
            this.colunload_id.VisibleIndex = 0;
            // 
            // coldelivery
            // 
            this.coldelivery.FieldName = "delivery";
            this.coldelivery.Name = "coldelivery";
            this.coldelivery.Visible = true;
            this.coldelivery.VisibleIndex = 1;
            // 
            // colitem
            // 
            this.colitem.FieldName = "item";
            this.colitem.Name = "colitem";
            this.colitem.Visible = true;
            this.colitem.VisibleIndex = 2;
            // 
            // colship_to_party
            // 
            this.colship_to_party.FieldName = "ship_to_party";
            this.colship_to_party.Name = "colship_to_party";
            this.colship_to_party.Visible = true;
            this.colship_to_party.VisibleIndex = 3;
            // 
            // colcus_name
            // 
            this.colcus_name.FieldName = "cus_name";
            this.colcus_name.Name = "colcus_name";
            this.colcus_name.Visible = true;
            this.colcus_name.VisibleIndex = 4;
            // 
            // colexternal_delivery_id
            // 
            this.colexternal_delivery_id.FieldName = "external_delivery_id";
            this.colexternal_delivery_id.Name = "colexternal_delivery_id";
            this.colexternal_delivery_id.Visible = true;
            this.colexternal_delivery_id.VisibleIndex = 5;
            // 
            // colmaterial
            // 
            this.colmaterial.FieldName = "material";
            this.colmaterial.Name = "colmaterial";
            this.colmaterial.Visible = true;
            this.colmaterial.VisibleIndex = 6;
            // 
            // coldelivery_quantity
            // 
            this.coldelivery_quantity.FieldName = "delivery_quantity";
            this.coldelivery_quantity.Name = "coldelivery_quantity";
            this.coldelivery_quantity.Visible = true;
            this.coldelivery_quantity.VisibleIndex = 7;
            // 
            // colsales_unit
            // 
            this.colsales_unit.FieldName = "sales_unit";
            this.colsales_unit.Name = "colsales_unit";
            this.colsales_unit.Visible = true;
            this.colsales_unit.VisibleIndex = 8;
            // 
            // colpicking_status
            // 
            this.colpicking_status.FieldName = "picking_status";
            this.colpicking_status.Name = "colpicking_status";
            this.colpicking_status.Visible = true;
            this.colpicking_status.VisibleIndex = 9;
            // 
            // colgood_movement_stat
            // 
            this.colgood_movement_stat.FieldName = "good_movement_stat";
            this.colgood_movement_stat.Name = "colgood_movement_stat";
            this.colgood_movement_stat.Visible = true;
            this.colgood_movement_stat.VisibleIndex = 10;
            // 
            // colplant
            // 
            this.colplant.FieldName = "plant";
            this.colplant.Name = "colplant";
            this.colplant.Visible = true;
            this.colplant.VisibleIndex = 11;
            // 
            // coldescription
            // 
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 12;
            // 
            // colbase_unit
            // 
            this.colbase_unit.FieldName = "base_unit";
            this.colbase_unit.Name = "colbase_unit";
            this.colbase_unit.Visible = true;
            this.colbase_unit.VisibleIndex = 13;
            // 
            // colsold_to_paty
            // 
            this.colsold_to_paty.FieldName = "sold_to_paty";
            this.colsold_to_paty.Name = "colsold_to_paty";
            this.colsold_to_paty.Visible = true;
            this.colsold_to_paty.VisibleIndex = 14;
            // 
            // colpurchaseing_document
            // 
            this.colpurchaseing_document.FieldName = "purchaseing_document";
            this.colpurchaseing_document.Name = "colpurchaseing_document";
            this.colpurchaseing_document.Visible = true;
            this.colpurchaseing_document.VisibleIndex = 15;
            // 
            // colgood_issue_date
            // 
            this.colgood_issue_date.FieldName = "good_issue_date";
            this.colgood_issue_date.Name = "colgood_issue_date";
            this.colgood_issue_date.Visible = true;
            this.colgood_issue_date.VisibleIndex = 16;
            // 
            // colimport_date
            // 
            this.colimport_date.FieldName = "import_date";
            this.colimport_date.Name = "colimport_date";
            this.colimport_date.Visible = true;
            this.colimport_date.VisibleIndex = 17;
            // 
            // colpk_id
            // 
            this.colpk_id.FieldName = "pk_id";
            this.colpk_id.Name = "colpk_id";
            this.colpk_id.Visible = true;
            this.colpk_id.VisibleIndex = 18;
            // 
            // colkb_number
            // 
            this.colkb_number.FieldName = "kb_number";
            this.colkb_number.Name = "colkb_number";
            this.colkb_number.Visible = true;
            this.colkb_number.VisibleIndex = 19;
            // 
            // colssa_id
            // 
            this.colssa_id.FieldName = "ssa_id";
            this.colssa_id.Name = "colssa_id";
            this.colssa_id.Visible = true;
            this.colssa_id.VisibleIndex = 20;
            // 
            // colcustomer_material_number
            // 
            this.colcustomer_material_number.FieldName = "customer_material_number";
            this.colcustomer_material_number.Name = "colcustomer_material_number";
            this.colcustomer_material_number.Visible = true;
            this.colcustomer_material_number.VisibleIndex = 21;
            // 
            // colkb_id
            // 
            this.colkb_id.FieldName = "kb_id";
            this.colkb_id.Name = "colkb_id";
            this.colkb_id.Visible = true;
            this.colkb_id.VisibleIndex = 22;
            // 
            // colunloading_point
            // 
            this.colunloading_point.FieldName = "unloading_point";
            this.colunloading_point.Name = "colunloading_point";
            this.colunloading_point.Visible = true;
            this.colunloading_point.VisibleIndex = 23;
            // 
            // colun_doc_id
            // 
            this.colun_doc_id.FieldName = "un_doc_id";
            this.colun_doc_id.Name = "colun_doc_id";
            this.colun_doc_id.Visible = true;
            this.colun_doc_id.VisibleIndex = 24;
            // 
            // colob_id
            // 
            this.colob_id.FieldName = "ob_id";
            this.colob_id.Name = "colob_id";
            this.colob_id.Visible = true;
            this.colob_id.VisibleIndex = 25;
            // 
            // colunload_status
            // 
            this.colunload_status.FieldName = "unload_status";
            this.colunload_status.Name = "colunload_status";
            this.colunload_status.Visible = true;
            this.colunload_status.VisibleIndex = 26;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 446);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colunload_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldelivery;
        private DevExpress.XtraGrid.Columns.GridColumn colitem;
        private DevExpress.XtraGrid.Columns.GridColumn colship_to_party;
        private DevExpress.XtraGrid.Columns.GridColumn colcus_name;
        private DevExpress.XtraGrid.Columns.GridColumn colexternal_delivery_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmaterial;
        private DevExpress.XtraGrid.Columns.GridColumn coldelivery_quantity;
        private DevExpress.XtraGrid.Columns.GridColumn colsales_unit;
        private DevExpress.XtraGrid.Columns.GridColumn colpicking_status;
        private DevExpress.XtraGrid.Columns.GridColumn colgood_movement_stat;
        private DevExpress.XtraGrid.Columns.GridColumn colplant;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colbase_unit;
        private DevExpress.XtraGrid.Columns.GridColumn colsold_to_paty;
        private DevExpress.XtraGrid.Columns.GridColumn colpurchaseing_document;
        private DevExpress.XtraGrid.Columns.GridColumn colgood_issue_date;
        private DevExpress.XtraGrid.Columns.GridColumn colimport_date;
        private DevExpress.XtraGrid.Columns.GridColumn colpk_id;
        private DevExpress.XtraGrid.Columns.GridColumn colkb_number;
        private DevExpress.XtraGrid.Columns.GridColumn colssa_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_material_number;
        private DevExpress.XtraGrid.Columns.GridColumn colkb_id;
        private DevExpress.XtraGrid.Columns.GridColumn colunloading_point;
        private DevExpress.XtraGrid.Columns.GridColumn colun_doc_id;
        private DevExpress.XtraGrid.Columns.GridColumn colob_id;
        private DevExpress.XtraGrid.Columns.GridColumn colunload_status;
    }
}