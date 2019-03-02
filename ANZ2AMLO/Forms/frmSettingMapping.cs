using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BAL.Amlo.Trans;
using DTO.Amlo.Importing;
using DTO.Amlo.Trans;
using DTO.Util;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmSettingMapping : DevExpress.XtraEditors.XtraForm
    {

        #region Local Variable
        DataView dv = null;
        SourceFile_MappingHeaderBAL bal = null;
        SourceFile_MappingDetailBAL blSourceFileMappingDetail = new SourceFile_MappingDetailBAL();
        SourceFile_MappingDetailColumnBAL blSourceFileMappingDetailColumn = new SourceFile_MappingDetailColumnBAL();
        DataSet ds = null;
        DataTable dtH, dtDetail, dtDetail_Col;
        SourceFile_MappingDetail objHeader =null;
        public PAction pageState = new PAction();

        DataTable detailEditDt = SourceFile_MappingDetailDto.Data();
        #endregion
        public frmSettingMapping()
        {
            InitializeComponent();
        }

        private void frmSettingMapping_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            InitialData();

            DataTable dtFileType = new DataTable();
            dtFileType.Columns.Add("CODE");
            dtFileType.Columns.Add("DESC");

            cbFileType.DataSource = dtFileType;
            cbFileType.DisplayMember = "DESC";
            cbFileType.ValueMember = "CODE";

            DataRow drFileType1 = dtFileType.NewRow();
            drFileType1["DESC"] = "-- Please Select --";
            drFileType1["CODE"] = "";
            dtFileType.Rows.InsertAt(drFileType1, 0);

            DataRow drFileType2 = dtFileType.NewRow();
            drFileType2["DESC"] = "XLS";
            drFileType2["CODE"] = "xls";
            dtFileType.Rows.InsertAt(drFileType2, 1);

            DataRow drFileType3 = dtFileType.NewRow();
            drFileType3["DESC"] = "XLSX";
            drFileType3["CODE"] = "xlsx";
            dtFileType.Rows.InsertAt(drFileType3, 2);

            DataTable dtType = new DataTable();
            dtType.Columns.Add("CODE");
            dtType.Columns.Add("DESC");

            cbType.DataSource = dtType;
            cbType.DisplayMember = "DESC";
            cbType.ValueMember = "CODE";

            DataRow drType1 = dtType.NewRow();
            drType1["DESC"] = "-- Please Select --";
            drType1["CODE"] = "";
            dtType.Rows.InsertAt(drType1, 0);

            DataRow drType2 = dtType.NewRow();
            drType2["DESC"] = "Input";
            drType2["CODE"] = "I";
            dtType.Rows.InsertAt(drType2, 1);

            DataRow drType3 = dtType.NewRow();
            drType3["DESC"] = "Output";
            drType3["CODE"] = "O";
            dtType.Rows.InsertAt(drType3, 2);

            DataRow drType4 = dtType.NewRow();
            drType4["DESC"] = "P";
            drType4["CODE"] = "P";
            dtType.Rows.InsertAt(drType4, 3);

            DataRow drType5 = dtType.NewRow();
            drType5["DESC"] = "D";
            drType5["CODE"] = "D";
            dtType.Rows.InsertAt(drType5, 4);
        }
        
        void InitialData()
        {

            bal = new SourceFile_MappingHeaderBAL();
            ds = bal.FindHeaderAndDetailPK("1", MyLogin.USER_LOGIN);
            if (ds != null)
            {
                dtH = ds.Tables[0];
                dtDetail = ds.Tables[1];
                dtDetail_Col = ds.Tables[2];
            }

            SetupHeader(dtDetail);

            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = true;
            gridView1.BestFitColumns();

            gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            
        }

      


        void SetupHeader(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                gdView.DataSource = null;
                gdView.DataSource = dt;
                gridView1.RefreshData();
                gdView.RefreshDataSource();

            }

            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
        }

        public class ImportFileX
        {
            public string No { get; set; }
            public string FileName { get; set; }

            public string KeyWord { get; set; }
            public string Type { get; set; }
            public string ImportFile { get; set; }
            public string Status { get; set; }
            public string Imported { get; set; }
            public string UpdateBy { get; set; }
            public DateTime UpdateDate { get; set; }
            public string FilePreiod { get; set; }


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gdView.Visible = false;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnAdd.Enabled = false;
            pageState = PAction.Update;

            //Set data to edit datatable
            DataRow detailEditDr = null;
            if (detailEditDt.Rows.Count == 0)
            {
                detailEditDr = detailEditDt.NewRow();
                detailEditDt.Rows.Add(detailEditDr);
            }
            detailEditDr = detailEditDt.Rows[0];
            detailEditDr["DID"] = gridView1.GetFocusedRowCellValue("DID").ToString();
            detailEditDr["HID"] = gridView1.GetFocusedRowCellValue("HID").ToString();
            detailEditDr["No"] = gridView1.GetFocusedRowCellValue("No").ToString();

            dv = new DataView(dtDetail);
            dv.RowFilter = string.Format("DID='{0}'", detailEditDr["DID"]);

            if (dv != null && dv.Count > 0)
            {
                txtSourceFileRefName.Text = dv[0]["SourceFileRefName"].ToString();
                txtKeyWord.Text = dv[0]["KeyWord"].ToString();
                txtStartColumn.Text= dv[0]["StartColumn"].ToString();
                txtStartRow.Text = dv[0]["StartRow"].ToString();
                cbFileType.SelectedValue = dv[0]["ExtFile"].ToString();
                cbType.SelectedValue = dv[0]["Type"].ToString();

                DataTable dt = blSourceFileMappingDetailColumn.FindByColumn((String)detailEditDr["DID"], "");
                dv = new DataView(dt);
                //dv.RowFilter = string.Format("DID='{0}'", detailEditDr["DID"]);

                LoadDetail2(dv);
                popDetail.Location = new Point((this.MdiParent.ClientSize.Width / 2) - popDetail.Size.Width / 2, (this.MdiParent.ClientSize.Height / 2) - popDetail.Size.Height / 2);
                popDetail.Show();
            }
        }

        void LoadDetail2(DataView dvDetail2)
        {
            if (dvDetail2 != null && dvDetail2.Count > 0)
            {
                gdDetail.DataSource = dvDetail2;
                gdDetail.RefreshDataSource();
            }
            else
            {
                gdDetail.DataSource = null;
                gdDetail.RefreshDataSource();
            }          
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validateData())
            {
                splashScreenManager1.ShowWaitForm();
                ActionStep1();
            }
            gdView.Visible = true;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            btnAdd.Enabled = true;
        }

        bool validateData()
        {
            bool isValidate = true;
            StringBuilder msg = new StringBuilder();
            
            if (txtSourceFileRefName.Text.Equals(""))
            {
                msg.AppendLine("- Please input Source File Ref Name.");
                isValidate = false;
            }
            if (txtKeyWord.Text.Equals(""))
            {
                msg.AppendLine("- Please input Key Word.");
                isValidate = false;
            }

            if (!isValidate)
            {
                MessageBox.Show(msg.ToString(), "Source File Mapping Validation");
            }

            return isValidate;
        }

        void ActionStep1()
        {
            DataRow detailEditDr = detailEditDt.Rows[0];
            detailEditDr["SourceFileRefName"] = txtSourceFileRefName.Text;
            detailEditDr["KeyWord"] = txtKeyWord.Text;
            if (cbFileType.SelectedIndex > 0)
            {
                detailEditDr["ExtFile"] = cbFileType.SelectedItem.ToString();
            }
            detailEditDr["StartRow"] = txtStartRow.Text;
            detailEditDr["StartColumn"] = txtStartColumn.Text;
            detailEditDr["ExtFile"] = cbFileType.SelectedValue;
            detailEditDr["Type"] = cbType.SelectedValue;
            detailEditDr["ROW_STATE"] = "1";
            detailEditDr["CREATE_BY"] = MyLogin.USER_LOGIN;
            detailEditDr["UPDATE_BY"] = MyLogin.USER_LOGIN;

            string message = "";
            switch (pageState)
            {
                case PAction.Add: message = ActionConfirm.Add.Value; break;
                case PAction.Update: message = ActionConfirm.Update.Value; break;
                case PAction.Delete: message = ActionConfirm.Delete.Value; break;
            }
            if (MessageBox.Show(message, ".:Source File Mapping", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                /*
                DataTable detailColumnDt = SourceFile_MappingDetailColumnDto.Data();
                for (int i = 0; i < gridView2.DataRowCount; i++)
                {
                    DataRow detailColumnDr = detailColumnDt.NewRow();
                    detailColumnDr["DID"] = gridView1.GetRowCellValue(i, "DID");
                    detailColumnDr["No"] = gridView1.GetRowCellValue(i, "No");
                    detailColumnDr["ColumnNo"] = gridView1.GetRowCellValue(i, "ColumnNo");
                    detailColumnDr["ColumnExcel"] = gridView1.GetRowCellValue(i, "ColumnExcel");
                    detailColumnDr["ColumnName"] = gridView1.GetRowCellValue(i, "ColumnName");
                    detailColumnDr["ParentID"] = gridView1.GetRowCellValue(i, "ParentID");
                    detailColumnDr["Condition"] = gridView1.GetRowCellValue(i, "Condition");
                    detailColumnDr["TotalRow"] = gridView1.GetRowCellValue(i, "TotalRow");
                    detailColumnDr["StartPosition"] = gridView1.GetRowCellValue(i, "StartPosition");
                    detailColumnDr["PositionLength"] = gridView1.GetRowCellValue(i, "PositionLength");
                    detailColumnDr["Desc"] = gridView1.GetRowCellValue(i, "Desc");
                    detailColumnDr["CREATE_BY"] = gridView1.GetRowCellValue(i, "CREATE_BY");
                    detailColumnDr["CREATE_DATE"] = gridView1.GetRowCellValue(i, "CREATE_DATE");
                    detailColumnDr["UPDATE_BY"] = MyLogin.USER_LOGIN;

                    detailColumnDt.Rows.Add(detailColumnDr);                 
                }
                */
                ActionStep2(detailEditDt, (DataView)gdDetail.DataSource);
                InitialData();
                popDetail.Visible = false;
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        void ActionStep2(DataTable detailEditDt, DataView dvDetail2)
        {
            if (blSourceFileMappingDetail.Action(detailEditDt, dvDetail2, pageState))
            {
                splashScreenManager1.CloseWaitForm();
                string message = "";
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:Source File Mapping");
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnAdd.Enabled = false;
            gdView.Visible = false;
            pageState = PAction.Add;

            //Set data to edit datatable
            DataRow detailEditDr = null;
            if (detailEditDt.Rows.Count == 0)
            {
                detailEditDr = detailEditDt.NewRow();
                detailEditDt.Rows.Add(detailEditDr);
            }
            detailEditDr = detailEditDt.Rows[0];
            detailEditDr["HID"] = "1";
            
            int maxNo = int.MinValue;
            int maxDID = int.MinValue;
            foreach (DataRow dr in dtDetail.Rows)
            {
                int no = dr.Field<int>("No");
                maxNo = Math.Max(maxNo, no);

                int did = dr.Field<int>("DID");
                maxDID = Math.Max(maxDID, did);
            }

            detailEditDr["No"] = maxNo + 1;
            detailEditDr["DID"] = maxDID + 1;

            DataTable dt = SourceFile_MappingDetailColumnDto.Data();
            DataView dv = dt.DefaultView;
            gdDetail.DataSource = dv;
            gdDetail.RefreshDataSource();

            txtSourceFileRefName.Text = "";
            txtKeyWord.Text = "";
            txtStartColumn.Text = "";
            txtStartRow.Text = "";
            cbFileType.SelectedIndex = 0;
            cbType.SelectedIndex = 0;

            popDetail.Show();
        }
        
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            popDetail.Hide();
            gdView.Visible = true;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)gdDetail.DataSource;
            dv.AddNew();
            gdDetail.DataSource = dv;
            gdDetail.RefreshDataSource();
            //gridView2.AddNewRow();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            pageState = PAction.Delete;
            //Set data to edit datatable
            DataRow detailEditDr = null;
            if (detailEditDt.Rows.Count == 0)
            {
                detailEditDr = detailEditDt.NewRow();
                detailEditDt.Rows.Add(detailEditDr);
            }
            detailEditDr = detailEditDt.Rows[0];
            detailEditDr["DID"] = gridView1.GetFocusedRowCellValue("DID").ToString();
            detailEditDr["HID"] = gridView1.GetFocusedRowCellValue("HID").ToString();
            detailEditDr["No"] = gridView1.GetFocusedRowCellValue("No").ToString();

            splashScreenManager1.ShowWaitForm();
            ActionStep1();
        }

        private void btnDeleteDetailColumn_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)gdDetail.DataSource;
            if (gridView2.GetFocusedDataSourceRowIndex() > -1) { 
                dv.Delete(gridView2.GetFocusedDataSourceRowIndex());
                gdDetail.DataSource = dv;
                gdDetail.RefreshDataSource();
            }
        }

        private void btnClosePop_Click(object sender, EventArgs e)
        {
            popDetail.Hide();
            gdView.Visible = true;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            popDetail.Hide();
            gdView.Visible = true;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
        }


        SourceFile_MappingDetail GetInputData()
        {
            objHeader = new SourceFile_MappingDetail();

            objHeader.SourceFileRefName = txtSourceFileRefName.Text;
            objHeader.KeyWord = txtKeyWord.Text;
            objHeader.StartColumn = txtStartColumn.Text;
            objHeader.StartRow = txtStartRow.Text;


            return objHeader;

        }


    }
}