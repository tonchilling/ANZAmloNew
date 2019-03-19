using System;
using System.Collections.Generic;
using ANZ2AMLO.Contexts;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

namespace ANZ2AMLO.Forms
{
    public partial class frmCustomerMasterMapping : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerMasterMapping()
        {
            InitializeComponent();
        }

        private void frmCustomerMasterMapping_Load(object sender, EventArgs e)
        {
            AnzContextsDataContext dbc = new AnzContextsDataContext();
            dbc.DeferredLoadingEnabled = false;
            var obj = (from t0 in dbc.Customer_MappingHeaders
                       select new { ID = t0.HID, ReportName = t0.ReportName });

            this.searchLookUpEditReportName.Properties.DataSource = obj;
            this.searchLookUpEditReportName.Properties.DisplayMember = "ReportName";
            this.searchLookUpEditReportName.Properties.ValueMember = "ID";



            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            {
                item.MaxWidth = 0;
            }
            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
        }

        private void searchLookUpEditReportName_EditValueChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            if (this.searchLookUpEditReportName.EditValue != null)
            {
                txtHID.Text = this.searchLookUpEditReportName.EditValue.ToString();

                using (AnzContextsDataContext dbc = new AnzContextsDataContext())
                {
                    dbc.DeferredLoadingEnabled = false;
                    Int32 intHID = Convert.ToInt32(searchLookUpEditReportName.EditValue);

                    txtHID.Text = intHID.ToString();

                    var obj = from t0 in dbc.Customer_MappingDetails
                              where t0.HID == intHID
                              select t0;

                    this.gridView1.GridControl.DataSource = obj;

                }
            }

            gridView1.BestFitColumns();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                dbc.DeferredLoadingEnabled = false;
                Int32 intDID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("DID"));
                txtDID.Text = intDID.ToString();
                var obj = (from t0 in dbc.Customer_MappingDetails
                           where t0.DID == intDID
                           select t0).FirstOrDefault();

                txtNo.EditValue = obj.No;
                txtFieldName.Text = obj.FieldName;
                txtExampleValue.Text = obj.ExampleValue;
                chkCM_Require.Checked = Convert.ToBoolean(obj.CM_Require);
                txtLinkValue.Text = obj.Link_Value;
                txtPriority1.Text = obj.Priority1;
                txtPriority2.Text = obj.Priority2;
                txtPriority3.Text = obj.Priority3;
                btnUpdateDetail.Visible = true;
                btnSaveDetail.Visible = false;
                popupDetail.Show();
            }
        }

        private void btnCloseH_Click(object sender, EventArgs e)
        {
            popupHeader.Hide();
        }

        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            popupDetail.Hide();
        }

        private void btnUpdateHead_Click(object sender, EventArgs e)
        {
            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                dbc.DeferredLoadingEnabled = false;
                Int32 intHID = Convert.ToInt32(searchLookUpEditReportName.EditValue);

                var obj = (from t0 in dbc.Customer_MappingHeaders
                           where t0.HID == intHID
                           select t0).FirstOrDefault();
                obj.ReportCode = txtReportCode.Text;
                obj.ReportName = txtReportName.Text;
                dbc.SubmitChanges();
                popupHeader.Hide();
            }
        }

        private void btnSaveHead_Click(object sender, EventArgs e)
        {
            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                dbc.DeferredLoadingEnabled = false;
                Int32 intHID = Convert.ToInt32(searchLookUpEditReportName.EditValue);

                Customer_MappingHeader obj = new Customer_MappingHeader();
                obj.ReportCode = txtReportCode.Text;
                obj.ReportName = txtReportName.Text;
                obj.UPDATE_DATE = DateTime.Now;
                dbc.Customer_MappingHeaders.InsertOnSubmit(obj);
                dbc.SubmitChanges();
                popupHeader.Hide();

            }
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                dbc.DeferredLoadingEnabled = false;
                Int32 intDID = Convert.ToInt32(txtDID.Text);

                var obj = (from t0 in dbc.Customer_MappingDetails
                           where t0.DID == intDID
                           select t0).FirstOrDefault();
                obj.No = Convert.ToInt32(txtNo.Text);
                obj.FieldName = txtFieldName.Text;
                obj.ExampleValue = txtExampleValue.Text;
                obj.CM_Require = chkCM_Require.Checked;
                obj.Link_Value = txtLinkValue.Text;
                obj.Priority1 = txtPriority1.Text;
                obj.Priority2 = txtPriority2.Text;
                obj.Priority3 = txtPriority3.Text;
                obj.UPDATE_DATE = DateTime.Now;

                dbc.SubmitChanges();
                popupDetail.Hide();
                UpdateGrid();

            }
        }

        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                dbc.DeferredLoadingEnabled = false;
                Customer_MappingDetail obj = new Customer_MappingDetail();

                obj.No = Convert.ToInt32(txtNo.Text);
                obj.HID = Convert.ToInt32(txtHID.Text);
                obj.FieldName = txtFieldName.Text;
                obj.ExampleValue = txtExampleValue.Text;
                obj.CM_Require = chkCM_Require.Checked;
                obj.Link_Value = txtLinkValue.Text;
                obj.Priority1 = txtPriority1.Text;
                obj.Priority2 = txtPriority2.Text;
                obj.Priority3 = txtPriority3.Text;
                obj.UPDATE_DATE = DateTime.Now;
                dbc.Customer_MappingDetails.InsertOnSubmit(obj);
                dbc.SubmitChanges();
                popupDetail.Hide();
                UpdateGrid();
            }
        }

        private void btnNewHeader_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUpdateHead.Visible = false;
            btnSaveHead.Visible = true;
            popupHeader.Show();
        }

        private void btnEditHeader_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            btnUpdateHead.Visible = true;
            btnSaveHead.Visible = false;
            popupHeader.Show();
        }

        private void btnNewDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtNo.EditValue = 0;
            txtFieldName.Text = @"";
            txtExampleValue.Text = @"";
            chkCM_Require.Checked = false;
            txtLinkValue.Text = @"";
            txtPriority1.Text = @"";
            txtPriority2.Text = @"";
            txtPriority3.Text = @"";

            btnUpdateDetail.Visible = false;
            btnSaveDetail.Visible = true;
            popupDetail.Show();
        }
    }
}