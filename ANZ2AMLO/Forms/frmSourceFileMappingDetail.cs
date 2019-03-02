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
    public partial class frmSourceFileMappingDetail : DevExpress.XtraEditors.XtraForm
    {
        SourceFile_MappingHeaderBAL blSourceFileMappingHeader = new SourceFile_MappingHeaderBAL();
        SourceFile_MappingDetailBAL blSourceFileMappingDetail = new SourceFile_MappingDetailBAL();
        public PAction pageState = new PAction();
        string pKey = "";

        private void loadComboBoxHeader()
        {
            DataTable dtHeaderSearch = blSourceFileMappingHeader.FindByAll();
            cbHIDSearch.DataSource = dtHeaderSearch;
            cbHIDSearch.DisplayMember = "ReportName";
            cbHIDSearch.ValueMember = "HID";

            DataTable dtHeader = dtHeaderSearch.Clone();

            dtHeader = dtHeaderSearch.Copy();
            cbHID.DataSource = dtHeaderSearch;
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
            DataTable dt = blSourceFileMappingDetail.FindByColumn(cbHIDSearch.SelectedValue.ToString(), "");
            gdResult.DataSource = dt;
            gridViewResult.RefreshData();
            gdResult.RefreshDataSource();
        }

        private void clearData()
        {
            cbHID.SelectedIndex = 0;
            txtNo.Text = "";
            txtSourceFileRefName.Text = "";
            txtKeyWord.Text = "";
            txtType.Text = "";
            txtExtFile.Text = "";
            txtStartRow.Text = "";
            txtEndRow.Text = "";
            txtStartColumn.Text = "";
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
            if (txtNo.Text.Equals(""))
            {
                msg.AppendLine("- Please input No.");
                isValidate = false;
            }

            if (txtSourceFileRefName.Text.Equals(""))
            {
                msg.AppendLine("- Please input Source File Ref Name.");
                isValidate = false;
            }

            if (!isValidate)
            {
                MessageBox.Show(msg.ToString(), "Source File Mapping Detail Validation");
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
                ActionStep2(pKey, cbHID.SelectedValue.ToString(), txtNo.Text, txtSourceFileRefName.Text, txtKeyWord.Text,
                            txtType.Text, txtExtFile.Text, txtStartRow.Text, txtEndRow.Text, txtStartColumn.Text,
                            rdActive.Checked, MyLogin.USER_LOGIN);
                initialData();
            }
        }

        void ActionStep2(string DID, string HID, string No, string SourceFileRefName, string KeyWord,
                         string Type, string ExtFile, string StartRow, string EndRow, string StartColumn,
                         bool rowState, string UserLogin)
        {
            if (blSourceFileMappingDetail.Action(DID, HID, No, SourceFileRefName, KeyWord,
                                                 Type, ExtFile, StartRow, EndRow, StartColumn,
                                                 rowState, UserLogin, pageState))
            {
                string message = "";
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:Source File Mapping Detail");
            }
        }

        private void deleteSourceFileMappingDetail()
        {
            pKey = gridViewResult.GetFocusedRowCellValue("DID").ToString();
            pageState = PAction.Delete;

            ActionStep1();
        }

        private void editSourceFileMappingDetail()
        {
            DataRow dr = gridViewResult.GetFocusedDataRow();
            pKey = dr["DID"].ToString();
            pageState = PAction.Update;

            cbHID.SelectedValue = dr["HID"].ToString();
            cbHID.Enabled = false;

            txtNo.Text = dr["No"].ToString();
            txtSourceFileRefName.Text = dr["SourceFileRefName"].ToString();
            txtKeyWord.Text = dr["KeyWord"].ToString();
            txtType.Text = dr["Type"].ToString();
            txtExtFile.Text = dr["ExtFile"].ToString();
            txtStartRow.Text = dr["StartRow"].ToString();
            txtEndRow.Text = dr["EndRow"].ToString();
            txtStartColumn.Text = dr["StartColumn"].ToString();

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

        public frmSourceFileMappingDetail()
        {
            InitializeComponent();
        }

        private void frmSourceFileMappingDetail_Load(object sender, EventArgs e)
        {
            loadComboBoxHeader();
            initialData();
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