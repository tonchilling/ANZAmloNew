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
using DTO.Util;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmSourceFileMappingDetailColumn : DevExpress.XtraEditors.XtraForm
    {
        SourceFile_MappingHeaderBAL blSourceFileMappingHeader = new SourceFile_MappingHeaderBAL();
        SourceFile_MappingDetailBAL blSourceFileMappingDetail = new SourceFile_MappingDetailBAL();
        SourceFile_MappingDetailColumnBAL blSourceFileMappingDetailColumn = new SourceFile_MappingDetailColumnBAL();
        public PAction pageState = new PAction();
        string pDID = "";
        string pNo = "";
        string searchHID = "";

        private void loadComboBoxHeader()
        {
            DataTable dtHeaderSearch = blSourceFileMappingHeader.FindByAll();
            cbHIDSearch.DataSource = dtHeaderSearch;
            cbHIDSearch.DisplayMember = "ReportName";
            cbHIDSearch.ValueMember = "HID";

            DataTable dtHeader = dtHeaderSearch.Clone();

            dtHeader = dtHeaderSearch.Copy();
            cbHID.DataSource = dtHeader;
            cbHID.DisplayMember = "ReportName";
            cbHID.ValueMember = "HID";

            DataRow drHeaderSearch = dtHeaderSearch.NewRow();
            drHeaderSearch["ReportName"] = "-- Please Select --";
            drHeaderSearch["HID"] = 0;
            dtHeaderSearch.Rows.InsertAt(drHeaderSearch, 0);

            DataRow drHeader = dtHeader.NewRow();
            drHeader["ReportName"] = "-- Please Select --";
            drHeader["HID"] = 0;
            dtHeader.Rows.InsertAt(drHeader, 0);
            
            cbHIDSearch.SelectedIndex = 0;
            cbHID.SelectedIndex = 0;

            cbHIDSearch.SelectedIndexChanged += new System.EventHandler(cbHIDSearch_OnChanged);
            cbHID.SelectedIndexChanged += new System.EventHandler(cbHID_OnChanged);
        }

        private void loadComboBoxDetailSearch()
        {
            DataTable dtDetailSearch = blSourceFileMappingDetail.FindDropDown(cbHIDSearch.SelectedValue.ToString());
            cbDIDSearch.DataSource = dtDetailSearch;
            cbDIDSearch.DisplayMember = "No";
            cbDIDSearch.ValueMember = "DID";

            DataTable dtDetail = dtDetailSearch.Clone();

            dtDetail = dtDetailSearch.Copy();
            cbDID.DataSource = dtDetail;
            cbDID.DisplayMember = "No";
            cbDID.ValueMember = "DID";

            DataRow drDetailSearch = dtDetailSearch.NewRow();
            drDetailSearch["No"] = "-- Please Select --";
            drDetailSearch["DID"] = 0;
            dtDetailSearch.Rows.InsertAt(drDetailSearch, 0);

            DataRow drDetail = dtDetail.NewRow();
            drDetail["No"] = "-- Please Select --";
            drDetail["DID"] = 0;
            dtDetail.Rows.InsertAt(drDetail, 0);

            cbDIDSearch.SelectedIndex = 0;
            cbDID.SelectedIndex = 0;
        }

        private void loadComboBoxDetailModify()
        {
            DataTable dtDetailSearch = blSourceFileMappingDetail.FindDropDown(cbHID.SelectedValue.ToString());
            cbDIDSearch.DataSource = dtDetailSearch;
            cbDIDSearch.DisplayMember = "No";
            cbDIDSearch.ValueMember = "DID";

            DataTable dtDetail = dtDetailSearch.Clone();

            dtDetail = dtDetailSearch.Copy();
            cbDID.DataSource = dtDetail;
            cbDID.DisplayMember = "No";
            cbDID.ValueMember = "DID";

            DataRow drDetailSearch = dtDetailSearch.NewRow();
            drDetailSearch["No"] = "-- Please Select --";
            drDetailSearch["DID"] = 0;
            dtDetailSearch.Rows.InsertAt(drDetailSearch, 0);

            DataRow drDetail = dtDetail.NewRow();
            drDetail["No"] = "-- Please Select --";
            drDetail["DID"] = 0;
            dtDetail.Rows.InsertAt(drDetail, 0);

            cbDIDSearch.SelectedIndex = 0;
            cbDID.SelectedIndex = 0;
        }

        void initialData()
        {
            BindingGridviewAsPaging();
            pnAddEdit.Visible = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            btnNew.Enabled = true;
            this.Refresh();
        }

        void BindingGridviewAsPaging()
        {
            string DID = "";
            if(cbDIDSearch.SelectedValue != null)
            {
                DID = cbDIDSearch.SelectedValue.ToString();
            }
            searchHID = cbHIDSearch.SelectedValue.ToString();
            if (DID != "") {
                DataTable dt = blSourceFileMappingDetailColumn.FindByColumn(DID, "");
                gdResult.DataSource = dt;
                gridViewResult.RefreshData();
                gdResult.RefreshDataSource();
            }
        }

        private void clearData()
        {
            cbHID.SelectedIndex = 0;
            if (cbDID.Items.Count > 0)
            {
                cbDID.SelectedIndex = 0;
            }
            txtNo.Text = "";
            txtColumnNo.Text = "";
            txtColumnExcel.Text = "";
            txtColumnName.Text = "";
            txtParentID.Text = "";
            txtCondition.Text = "";
            txtTotalRow.Text = "";
            txtStartPosition.Text = "";
            txtPositionLength.Text = "";
            txtDesc.Text = "";
            rdActive.Checked = false;
            rdInActive.Checked = false;
        }

        bool validateData()
        {
            bool isValidate = true;
            StringBuilder msg = new StringBuilder();

            if (cbHID.SelectedIndex == 0)
            {
                msg.AppendLine("- Please select Report Name.");
                isValidate = false;
            }
            if (cbDID.SelectedIndex == 0)
            {
                msg.AppendLine("- Please select Detail.");
                isValidate = false;
            }
            if (txtNo.Text.Equals(""))
            {
                msg.AppendLine("- Please input No.");
                isValidate = false;
            }

            if (txtColumnNo.Text.Equals(""))
            {
                msg.AppendLine("- Please input Column No.");
                isValidate = false;
            }

            if (!isValidate)
            {
                MessageBox.Show(msg.ToString(), "Source File Mapping Detail Comumn Validation");
            }

            return isValidate;
        }

        void ActionStep1()
        {
            string message = "";
            switch (pageState)
            {
                case PAction.Add: message = ActionConfirm.Add.Value; break;
                case PAction.Update: message = ActionConfirm.Update.Value; break;
                case PAction.Delete: message = ActionConfirm.Delete.Value; break;
            }
            if (MessageBox.Show(message, ".:Source File Mapping Detail", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActionStep2(cbDID.SelectedValue.ToString(), txtNo.Text, txtColumnNo.Text, txtColumnExcel.Text, txtColumnName.Text,
                            txtParentID.Text, txtCondition.Text, txtTotalRow.Text, txtStartPosition.Text, txtPositionLength.Text,
                            txtDesc.Text, rdActive.Checked, MyLogin.USER_LOGIN);
                initialData();
            }
        }

        void ActionStep2(string DID, string No, string ColumnNo, string ColumnExcel, string ColumnName,
                         string ParentID, string Condition, string TotalRow, string StartPosition, string PositionLength,
                         string Desc, bool rowState, string UserLogin)
        {
            if (blSourceFileMappingDetailColumn.Action(DID, No, ColumnNo, ColumnExcel, ColumnName,
                                                 ParentID, Condition, TotalRow, StartPosition, PositionLength,
                                                 Desc, rowState, UserLogin, pageState))
            {
                string message = "";
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:Source File Mapping Detail Column");
            }
        }

        private void deleteSourceFileMappingDetail()
        {
            pDID = gridViewResult.GetFocusedRowCellValue("DID").ToString();
            pNo = gridViewResult.GetFocusedRowCellValue("No").ToString();
            pageState = PAction.Delete;

            ActionStep1();
        }

        private void editSourceFileMappingDetail()
        {
            DataRow dr = gridViewResult.GetFocusedDataRow();
            pDID = dr["DID"].ToString();
            pNo = dr["No"].ToString();
            pageState = PAction.Update;

            cbHID.SelectedValue = searchHID;
            cbHID.Enabled = false;
            cbDID.SelectedValue = dr["DID"].ToString();
            cbDID.Enabled = false;

            txtNo.Text = dr["No"].ToString();
            txtColumnNo.Text = dr["ColumnNo"].ToString();
            txtColumnExcel.Text = dr["ColumnExcel"].ToString();
            txtColumnName.Text = dr["ColumnName"].ToString();
            txtParentID.Text = dr["ParentID"].ToString();
            txtCondition.Text = dr["Condition"].ToString();
            txtTotalRow.Text = dr["TotalRow"].ToString();
            txtPositionLength.Text = dr["PositionLength"].ToString();
            txtDesc.Text = dr["Desc"].ToString();

            string status = dr["ROW_STATE"].ToString();

            if ("1".Equals(status.Trim()))
            {
                rdActive.Checked = true;
            }
            else if ("0".Equals(status.Trim()))
            {
                rdInActive.Checked = true;
            }

            pnAddEdit.Visible = true;
            btnSave.Enabled = false;
        }

        public frmSourceFileMappingDetailColumn()
        {
            InitializeComponent();
        }

        private void frmSourceFileMappingDetailColumn_Load(object sender, EventArgs e)
        {
            loadComboBoxHeader();
            initialData();
        }
        
        private void cbHIDSearch_OnChanged(object sender, EventArgs e)
        {
            if(cbHIDSearch.SelectedIndex != 0)
            {
                loadComboBoxDetailSearch();
            }
        }

        private void cbHID_OnChanged(object sender, EventArgs e)
        {
            if (cbHID.SelectedIndex != 0)
            {
                loadComboBoxDetailModify();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingGridviewAsPaging();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageState = PAction.Add;
            clearData();
            cbHID.Enabled = true;
            cbDID.Enabled = true;
            btnSave.Enabled = true;
            pnAddEdit.Visible = true;
            gdResult.Visible = false;
            btnClose.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validateData())
            {
                ActionStep1();
                gdResult.Visible = true;
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnAddEdit.Visible = false;
            btnSave.Enabled = false;
            gdResult.Visible = true;
            btnClose.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editSourceFileMappingDetail();
            gdResult.Visible = false;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteSourceFileMappingDetail();
        }
    }
}