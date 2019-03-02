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
using DTO.Util;
using BAL.Amlo.Trans;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmSourceFileMappingHeader : DevExpress.XtraEditors.XtraForm
    {
        SourceFile_MappingHeaderBAL blSourceFileMappingHeader = new SourceFile_MappingHeaderBAL();
        public PAction pageState = new PAction();
        string pKey = "";

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
            DataTable dt = blSourceFileMappingHeader.FindByColumn("", "");
            gdResult.DataSource = dt;
            gridViewResult.RefreshData();
            gdResult.RefreshDataSource();
        }

        private void clearData()
        {
            txtReportCode.Text = "";
            txtReportName.Text = "";
            txtCondition1.Text = "";
            txtCondition2.Text = "";
            txtCondition3.Text = "";
            txtCondition4.Text = "";
            txtImportFolder.Text = "";
            txtBackUpFolder.Text = "";
            txtLogFolder.Text = "";
            txtOutputFolder.Text = "";
            rdActive.Checked = false;
            rdInActive.Checked = false;
        }

        bool validateData()
        {
            bool isValidate = true;
            StringBuilder msg = new StringBuilder();

            if (txtReportCode.Text.Equals(""))
            {
                msg.AppendLine("- Please input Report Code.");
                isValidate = false;
            }

            if (txtReportName.Text.Equals(""))
            {
                msg.AppendLine("- Please input Report Name.");
                isValidate = false;
            }

            if (txtImportFolder.Text.Equals(""))
            { 
                msg.AppendLine("- Please input Import Folder.");
                isValidate = false;
            }

            if (!isValidate)
            {
                MessageBox.Show(msg.ToString(), "Source File Mapping Header Validation");
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
            if (MessageBox.Show(message, ".:Source File Mapping Header", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActionStep2(pKey, txtReportCode.Text, txtReportName.Text, txtCondition1.Text, txtCondition2.Text,
                            txtCondition3.Text, txtCondition4.Text, txtImportFolder.Text, txtBackUpFolder.Text, txtLogFolder.Text,
                            txtOutputFolder.Text, rdActive.Checked, MyLogin.USER_LOGIN);
                initialData();
            }
        }

        void ActionStep2(string HID, string ReportCode, string ReportName, string Condition1, string Condition2,
                         string Condition3, string Condition4, string ImportFolder, string BackUpFolder, string LogFolder,
                         string OutputFolder, bool rowState, string UserLogin)
        {
            if (blSourceFileMappingHeader.Action(HID, ReportCode, ReportName, Condition1, Condition2,
                                                 Condition3, Condition4, ImportFolder, BackUpFolder, LogFolder,
                                                 OutputFolder, rowState, UserLogin, pageState))
            {
                string message = "";
                switch (pageState)
                {
                    case PAction.Add: message = ActionDone.Add.Value; break;
                    case PAction.Update: message = ActionDone.Update.Value; break;
                    case PAction.Delete: message = ActionDone.Delete.Value; break;
                }
                MessageBox.Show(message, ".:Source File Mapping Header");
            }
        }

        private void deleteSourceFileMappingHeader()
        {
            pKey = gridViewResult.GetFocusedRowCellValue("HID").ToString();
            pageState = PAction.Delete;

            ActionStep1();
        }

        private void editSourceFileMappingHeader()
        {
            DataRow dr = gridViewResult.GetFocusedDataRow();
            pKey = dr["HID"].ToString();
            pageState = PAction.Update;

            txtReportCode.Text = dr["ReportCode"].ToString();
            txtReportName.Text = dr["ReportName"].ToString();
            txtCondition1.Text = dr["Condition1"].ToString();
            txtCondition2.Text = dr["Condition2"].ToString();
            txtCondition3.Text = dr["Condition3"].ToString();
            txtCondition4.Text = dr["Condition4"].ToString();
            txtImportFolder.Text = dr["ImportFolder"].ToString();
            txtBackUpFolder.Text = dr["BackUpFolder"].ToString();
            txtLogFolder.Text = dr["LogFolder"].ToString();
            txtOutputFolder.Text = dr["OutputFolder"].ToString();

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

        public frmSourceFileMappingHeader()
        {
            InitializeComponent();
        }

        private void frmSourceFileMappingHeader_Load(object sender, EventArgs e)
        {
            initialData();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pageState = PAction.Add;
            clearData();
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

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            editSourceFileMappingHeader();
            gdResult.Visible = false;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            deleteSourceFileMappingHeader();
        }
    }
}