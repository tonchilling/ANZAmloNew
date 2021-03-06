﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BAL.Amlo.Master;
using DTO.Amlo.Trans;
using DTO.Util;
namespace ANZ2AMLO.Forms
{
    public partial class frmTransactionMaster : DevExpress.XtraEditors.XtraForm
    {

        TransactionMasterBAL bal = null;
        List<TransactionMasterDTO> objResult = null;

        DataTable dTable = null;
        DataRow dRow = null;
        public frmTransactionMaster()
        {
            InitializeComponent();
        }

        private void frmTransactionMaster_Load(object sender, EventArgs e)
        {
            InitialData();

            popDetail.Location = new Point((this.MdiParent.ClientSize.Width / 2) - popDetail.Size.Width / 2, popDetail.Location.Y);
        }

        public void InitialData()
        {

            bal = new TransactionMasterBAL();
            objResult = bal.FindByObjList(null);
            this.gridView1.GridControl.DataSource = objResult;
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

        private void gdView_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ANZ2AMLO.BAL.Util.XGenerate.TransactionToExcel(objResult, @"D:\ANZ\Output");
            System.Threading.Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
            DevExpress.XtraEditors.XtraMessageBox.Show("Export files completely!!", "EXPORTING", MessageBoxButtons.OK);
        }

        private void linkOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\ANZ\Output");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearText();

            txtGroupName.Text = gridView1.GetFocusedRowCellValue("GroupName").ToString();
         /*  public string colNo { get; set; }
        public string GroupName { get; set; }
        public string Status { get; set; }
        public string ANZCustomerInstrumentId { get; set; }
        public string ANZCustomerBANKAccountNumber { get; set; }
        public string TransactionDate { get; set; }
        public string TranxSendReceive { get; set; }
        public string TranxAmountTHB { get; set; }
        public string TranxAmountCurrency { get; set; }
        public string TranxExchangeRate { get; set; }
        public string TranxObjective { get; set; }
        public string ANZCustomerRegisterID { get; set; }
        public string ANZCutomerBusinessCode { get; set; }
        public string ANZCutomerRegisterAddress { get; set; }
        public string ANZCutomerRegisterAddressCountry { get; set; }
        public string ANZCustomerRegisterDate { get; set; }
        public string SendBankAccountNumber { get; set; }
        public string SendTranxRefNo { get; set; }
        public string SendBankName { get; set; }
        public string SendBankCountry { get; set; }
        public string SendName { get; set; }
        public string SendAddress { get; set; }
        public string SendDescription { get; set; }
        public string SendIdNo { get; set; }
        public string SendIdIssueBy { get; set; }
        public string BeneBankAccountNumber { get; set; }
        public string BeneTranxRefNo { get; set; }
        public string BeneBankName { get; set; }
        public string BeneBankCountry { get; set; }
        public string BeneName { get; set; }
        public string BeneAddress { get; set; }

        public string BeneIdDescription { get; set; }
        public string BeneIdNo { get; set; }
        public string BeneIdIssueBy { get; set; }*/

            txtDepartment.Text= gridView1.GetFocusedRowCellValue("Department") != null ? gridView1.GetFocusedRowCellValue("Department").ToString():"";
            txtInstrumentId.Text = gridView1.GetFocusedRowCellValue("ANZCustomerInstrumentId") != null ?  gridView1.GetFocusedRowCellValue("ANZCustomerInstrumentId").ToString() : "";
            txtBANKAccount.Text = gridView1.GetFocusedRowCellValue("ANZCustomerBANKAccountNumber") != null ?  gridView1.GetFocusedRowCellValue("ANZCustomerBANKAccountNumber").ToString() : "";
            txtTransactionDate.Text = gridView1.GetFocusedRowCellValue("TransactionDate") != null ?  gridView1.GetFocusedRowCellValue("TransactionDate").ToString():"";
            txtTranxSendReceive.Text = gridView1.GetFocusedRowCellValue("TranxSendReceive") != null ?  gridView1.GetFocusedRowCellValue("TranxSendReceive").ToString() : "";
            txtTranxAmountTHB.Text = gridView1.GetFocusedRowCellValue("TranxAmountTHB")!=null? gridView1.GetFocusedRowCellValue("TranxAmountTHB").ToString():"";
            txtCurrency.Text = gridView1.GetFocusedRowCellValue("TranxAmountCurrency") != null ? gridView1.GetFocusedRowCellValue("TranxAmountCurrency").ToString() : "";
            txtExchangeRate.Text = gridView1.GetFocusedRowCellValue("TranxExchangeRate") != null ? gridView1.GetFocusedRowCellValue("TranxExchangeRate").ToString() : "";
            txtObjective.Text = gridView1.GetFocusedRowCellValue("TranxObjective") != null ? gridView1.GetFocusedRowCellValue("TranxObjective").ToString() : "";

            txtANZRegisterID.Text = gridView1.GetFocusedRowCellValue("ANZCustomerRegisterID") != null ? gridView1.GetFocusedRowCellValue("ANZCustomerRegisterID").ToString() : "";
            txtANZBusinessCode.Text = gridView1.GetFocusedRowCellValue("ANZCutomerBusinessCode") != null ? gridView1.GetFocusedRowCellValue("ANZCutomerBusinessCode").ToString() : "";
            txtANZAddress.Text = gridView1.GetFocusedRowCellValue("ANZCutomerRegisterAddress") != null ? gridView1.GetFocusedRowCellValue("ANZCutomerRegisterAddress").ToString() : "";
            txtANZCountry.Text = gridView1.GetFocusedRowCellValue("ANZCutomerRegisterAddressCountry") != null ? gridView1.GetFocusedRowCellValue("ANZCutomerRegisterAddressCountry").ToString() : "";
            txtANZRegisterDate.Text = gridView1.GetFocusedRowCellValue("ANZCustomerRegisterDate") != null ? gridView1.GetFocusedRowCellValue("ANZCustomerRegisterDate").ToString() : "";
            txtSendAccountNumber.Text = gridView1.GetFocusedRowCellValue("SendBankAccountNumber") != null ? gridView1.GetFocusedRowCellValue("SendBankAccountNumber").ToString() : "";
            txtSendName.Text = gridView1.GetFocusedRowCellValue("SendName") != null ? gridView1.GetFocusedRowCellValue("SendName").ToString() : "";
            txtSendBankName.Text = gridView1.GetFocusedRowCellValue("SendBankName") != null ? gridView1.GetFocusedRowCellValue("SendBankName").ToString() : "";
            txtSendTranxRefNo.Text = gridView1.GetFocusedRowCellValue("SendTranxRefNo") != null ? gridView1.GetFocusedRowCellValue("SendTranxRefNo").ToString() : "";
            txtSendAddress.Text = gridView1.GetFocusedRowCellValue("SendAddress") != null ? gridView1.GetFocusedRowCellValue("SendAddress").ToString() : "";
            txtSendBankCountry.Text = gridView1.GetFocusedRowCellValue("SendBankCountry") != null ? gridView1.GetFocusedRowCellValue("SendBankCountry").ToString() : "";
            txtSendDescription.Text = gridView1.GetFocusedRowCellValue("SendDescription") != null ? gridView1.GetFocusedRowCellValue("SendDescription").ToString() : "";
            txtBeneAccountNumber.Text = gridView1.GetFocusedRowCellValue("BeneBankAccountNumber") != null ? gridView1.GetFocusedRowCellValue("SendBankAccountNumber").ToString() : "";
            txtBeneName.Text = gridView1.GetFocusedRowCellValue("BeneName") != null ? gridView1.GetFocusedRowCellValue("BeneName").ToString() : "";
            txtBeneBankName.Text = gridView1.GetFocusedRowCellValue("BeneBankName") != null ? gridView1.GetFocusedRowCellValue("BeneBankName").ToString() : "";
            txtBeneTranxRefNo.Text = gridView1.GetFocusedRowCellValue("BeneTranxRefNo") != null ? gridView1.GetFocusedRowCellValue("BeneTranxRefNo").ToString() : "";
            txtBeneAddress.Text = gridView1.GetFocusedRowCellValue("BeneAddress") != null ? gridView1.GetFocusedRowCellValue("BeneAddress").ToString() : "";
            txtBeneBankCountry.Text = gridView1.GetFocusedRowCellValue("BeneBankCountry") != null ? gridView1.GetFocusedRowCellValue("BeneBankCountry").ToString() : "";
            txtBeneDescription.Text = gridView1.GetFocusedRowCellValue("BeneIdDescription") != null ? gridView1.GetFocusedRowCellValue("BeneIdDescription").ToString() : "";



            popDetail.Visible = true;
        }

        void ClearText()
        {
            foreach (Control c in popDetail.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            popDetail.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MessageDto.SaveMsg, "Saving", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveData();
            }
               
        }


        void SaveData()
        {
            dTable = TransactionMasterDTO.CreateDataTable();

            dRow = dTable.NewRow();

            dRow["TranOID"]=

            //  dRow["FileType"]=
            // dRow["GroupName"]=
            // dRow["ANZCustomerId"]=
            // dRow["CustRegisterName"]=
            //  dRow["CustCompanyAddress"]=
            // dRow["CustCompanyAddressCountry"]=
            // dRow["CustContractAddress"]=
            // dRow["CustContractAddressCountry"]=
            //  dRow["TransactionMethod"]=
            //  dRow["BeneTranxRefNo"]=
            // dRow["BeneBankName"]= 
            //dRow["SendIdType"]=
            // dRow["SendIdNo"]=
            // dRow["SendIdIssueBy"]=
            // dRow["BeneIdNo"]=
            // dRow["BeneIdIssueBy"]=
            // dRow["Remark"]=
            // dRow["MappingSourceDB"] =
            //dRow["BeneIdType"]=
            dRow["CustomerInstrumentId"]= txtInstrumentId.Text; // PK
            dRow["CustomerBankAccountNumber"]= txtBANKAccount.Text; // PK
          
            dRow["CustRegisterID"]= txtANZRegisterID.Text;
            dRow["CustBusinessCode"] = txtANZBusinessCode.Text;
            dRow["CustRegisterAddress"]= txtANZAddress.Text;
            dRow["CustRegisterAddressCountry"]= txtANZCountry.Text;

            dRow["CustRegisterDate"]= Utility.ConvertFormatDatetime(txtANZRegisterDate.Text);
   
            dRow["TransactionDate"] = Utility.ConvertFormatDatetime(txtTransactionDate.Text);
            dRow["TranxAmountThb"]= txtTranxAmountTHB.Text;
            dRow["TranxAmountCurrency"] = txtCurrency.Text;
            dRow["TranxCurrency"]= txtCurrency.Text;
            dRow["TranxExchangeRate"]= txtExchangeRate.Text;
            dRow["TranxCurrency"] = txtANZCountry.Text;
            dRow["TranxAmountThbInThWord"] = "";
            dRow["TranxInternationalOrDomestic"]= "";
            dRow["TranxSendReceive"]= txtTranxSendReceive.Text;
            dRow["TranxObjective"]= txtObjective.Text;
            dRow["SendTranxRefNo"] = txtSendTranxRefNo.Text;
            dRow["SendBankName"]= txtSendBankName.Text;
            dRow["SendBankCountry"]= txtSendBankCountry.Text;
            dRow["SendBankAccountNo"] = txtSendAccountNumber.Text;
            dRow["SendName"]= txtSendName.Text;
            dRow["SendAddress"]= txtSendAddress.Text;
            dRow["SendIdDescription"]= txtSendDescription.Text;
            dRow["BeneBankAccountNo"]= txtBeneAccountNumber.Text;
            dRow["BeneBankCountry"]= txtBeneBankCountry.Text;
            dRow["BeneName"]= txtBeneName.Text;
            dRow["BeneBankName"] = txtBeneBankName.Text;
            dRow["BeneTranxRefNo"] = txtBeneTranxRefNo.Text;
            
            dRow["BeneAddress"] = txtBeneAddress.Text;
            dRow["BeneIdDescription"]= txtBeneDescription.Text;

            dTable.Rows.Add(dRow);

            bal = new TransactionMasterBAL();
            if (bal.Add(dTable))
            {
                MessageBox.Show(MessageDto.SaveSuccess, "Saving");
                popDetail.Visible = false;
                InitialData();
            }

        }
    }
  

}