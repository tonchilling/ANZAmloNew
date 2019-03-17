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
using ANZ2AMLO.Forms;
using BAL.Amlo.Master;
using DTO.Amlo.Master;
using DTO.Amlo.Autorizing;
using DTO.Util;

namespace ANZ1AMLO.Forms
{
    public partial class frmCustomerMaster : DevExpress.XtraEditors.XtraForm
    {
        M_CustomerBAL bal = null;
        List<M_CustomerDTO> customerObjList = null;
        M_CustomerDTO objSearh = null;
        string oid = "";
        DataRow custAccRowEdit = null;
        DataRow custAddressRowEdit = null;
        public frmCustomerMaster()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmCustomerMasterDetail frmCusDetail = new frmCustomerMasterDetail();
            frmCusDetail.ShowDialog(this);
        }

        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {

            #region old
            /* List<Customer> cus = new List<Customer>();
             cus.Add(new Customer()
             {
                 colNo = "1",
                 colCustomerID = "CusID001",
                 colCutomerNo = "CusNo001",
                 colCutomerAC = "AC001",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID001",
                 colDID = "",
                 colHID = "",
                 colTelNo = "01-000-0001",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type001",
                 colDefaultAddress = "Address 001",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "2",
                 colCustomerID = "CusID002",
                 colCutomerNo = "CusNo002",
                 colCutomerAC = "AC002",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID002",
                 colDID = "",
                 colHID = "",
                 colTelNo = "02-000-0002",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type002",
                 colDefaultAddress = "Address 002",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "3",
                 colCustomerID = "CusID003",
                 colCutomerNo = "CusNo003",
                 colCutomerAC = "AC003",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });
             cus.Add(new Customer()
             {
                 colNo = "13",
                 colCustomerID = "CusID0055",
                 colCutomerNo = "CusNo0065",
                 colCutomerAC = "AC0055",
                 colRegisteredBusinessName = "Company XXX Col.,LTD",
                 colBusinessNameTH = "Name Thai",
                 colCustomerName = "Customer Name",
                 colRegisteredTAXID = "TaxID003",
                 colDID = "",
                 colHID = "",
                 colTelNo = "03-000-0003",
                 colRegistoerDate = DateTime.Now,
                 colBusinessTypeCode = "Type003",
                 colDefaultAddress = "Address 003",
                 colContractAdd = "Con Address",
                 colCompanyAdd = "Company Addess",
                 colRegAddress = "Reg Address"
             });*/
            #endregion

            LoadData();


        }


        void LoadData()
        {
           // splashScreenManager1.ShowWaitForm();
            System.Threading.Thread.Sleep(1000);
            bal = new M_CustomerBAL();

            objSearh = new M_CustomerDTO();
            customerObjList = bal.FindByObjList(objSearh);
            this.gridView1.GridControl.DataSource = customerObjList;
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            {
                item.MaxWidth = 0;
            }
            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            System.Threading.Thread.Sleep(1000);
            //splashScreenManager1.CloseWaitForm();
         
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            oid= gridView1.GetFocusedRowCellValue("CustomerOID").ToString();
            txtCustomerID.Text = gridView1.GetFocusedRowCellValue("CustomerID").ToString();
            txtCustomerName.Text= gridView1.GetFocusedRowCellValue("CustomerName").ToString();
            txtCustomerNO.Text = gridView1.GetFocusedRowCellValue("CustomerNo").ToString();
            txtJuristicIDNo.Text = gridView1.GetFocusedRowCellValue("JuristicIDNo").ToString();
            txtRegBusinessName.Text = gridView1.GetFocusedRowCellValue("RegBusinessName").ToString();
            txtRegBusinessNameTH.Text = gridView1.GetFocusedRowCellValue("RegBusinessNameTH").ToString();
            txtPrimaryBusinessType.Text = gridView1.GetFocusedRowCellValue("PrimaryBusinessTypeCode").ToString();
            txtRegisterDate.Text = gridView1.GetFocusedRowCellValue("RegisterDate").ToString();

            DataSet ds = bal.FindAccountAndAddress(oid);
            DataTable dtAccount = ds.Tables[0];
            DataTable dtAddress = ds.Tables[1];

            gdAccount.DataSource = dtAccount;
            gdAddress.DataSource = dtAddress;
            //txtTaxID.Text = gridView1.GetFocusedRowCellValue("RegTAXID").ToString();
            //txtTel.Text = gridView1.GetFocusedRowCellValue("ContactTelNumber")!=null?gridView1.GetFocusedRowCellValue("ContactTelNumber").ToString():"";
            //txtRegisterDate.Text = gridView1.GetFocusedRowCellValue("RegisterDate").ToString();
            //txtAddress.Text = gridView1.GetFocusedRowCellValue("DefaultAddress").ToString();
            popupContainerControl1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            popupContainerControl1.Hide();
        }

        private void popupContainerControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            ANZ2AMLO.BAL.Util.XGenerate.CustomerToExcel(customerObjList, @"D:\ANZ\Output");
            System.Threading.Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
            DevExpress.XtraEditors.XtraMessageBox.Show("Export files completely!!", "EXPORTING", MessageBoxButtons.OK);
        }

        private void linkOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\ANZ\Output");
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                splashScreenManager1.ShowWaitForm();
                ActionStep1();
            }
        }

        private void btnSaveCust_EditValueChanged(object sender, EventArgs e)
        {

        }

        bool validateData()
        {
            bool isValidate = true;
            StringBuilder msg = new StringBuilder();

            if (txtCustomerNO.Text.Equals(""))
            {
                msg.AppendLine("- Please input Customer No.");
                isValidate = false;
            }
            
            if (!isValidate)
            {
                MessageBox.Show(msg.ToString(), "Customer Validation");
            }

            return isValidate;
        }

        void ActionStep1()
        {
            DataTable custTb = M_CustomerDTO.DataTable();
            DataRow custDr = custTb.NewRow();
            custDr["CustomerOID"] = oid;
            custDr["CustomerID"] = txtCustomerID.Text;
            custDr["CustomerNo"] = txtCustomerNO.Text;
            custDr["RegBusinessName"] = txtRegBusinessName.Text;
            custDr["RegBusinessNameTH"] = txtRegBusinessNameTH.Text;
            custDr["CustomerName"] = txtCustomerName.Text;
            custDr["JuristicIDNo"] = txtJuristicIDNo.Text;
            custDr["RegisterDate"] = txtRegisterDate.Text;
            custDr["PrimaryBusinessTypeCode"] = txtPrimaryBusinessType.Text;
            custDr["UPDATE_BY"] = "System";//MyLogin.USER_LOGIN;
            custTb.Rows.Add(custDr);
            
            string message = ActionConfirm.Update.Value;
            
            if (MessageBox.Show(message, ".:Customer Master", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActionStep2(custTb, (DataTable)gdAccount.DataSource, (DataTable)gdAddress.DataSource);
                LoadData();
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        void ActionStep2(DataTable custTb, DataTable custAccTb, DataTable custAddressTb)
        {
            if (bal.Update(custTb, custAccTb, custAddressTb))
            {
                splashScreenManager1.CloseWaitForm();
                string message = ActionDone.Update.Value;
                MessageBox.Show(message, ".:Customer Master");

                popupContainerControl1.Hide();
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
            }
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            custAccRowEdit = gridCustAccountResult.GetFocusedDataRow();
            txtAccountNumber.Text = custAccRowEdit["AccountNumber"].ToString();
            txtCurrencyCode.Text = custAccRowEdit["CurrencyCode"].ToString();
            txtAccountType.Text = custAccRowEdit["AccountType"].ToString();
            txtSourceBankBranch.Text = custAccRowEdit["SourceBankBranch"].ToString();
            popupContainerControl2.Show();
            popupContainerControl2.BringToFront();
        }

        private void btnSaveEditCustAcc_Click(object sender, EventArgs e)
        {
            string message = ActionConfirm.Update.Value;
            if (MessageBox.Show(message, ".:Customer Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                custAccRowEdit["AccountNumber"] = txtAccountNumber.Text;
                custAccRowEdit["CurrencyCode"] = txtCurrencyCode.Text;
                custAccRowEdit["AccountType"] = txtAccountType.Text;
                custAccRowEdit["SourceBankBranch"] = txtSourceBankBranch.Text;

                popupContainerControl2.Hide();
            }
        }

        private void btnCloseEditCustAcc_Click(object sender, EventArgs e)
        {
            popupContainerControl2.Hide();
        }

        private void btnSaveEditCustAddress_Click(object sender, EventArgs e)
        {
            string message = ActionConfirm.Update.Value;
            if (MessageBox.Show(message, ".:Customer Address", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                custAddressRowEdit["PrincipleAddress"] = txtPrincipleAddress.Text;
                custAddressRowEdit["City"] = txtCity.Text;
                custAddressRowEdit["State"] = txtState.Text;
                custAddressRowEdit["Zipcode"] = txtZipcode.Text;
                custAddressRowEdit["Country"] = txtCountry.Text;
                custAddressRowEdit["ContactNumber"] = txtContactNumber.Text;

                popupContainerControl3.Hide();
            }
        }

        private void btnCloseEditCustAddress_Click(object sender, EventArgs e)
        {
            popupContainerControl3.Hide();
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            custAddressRowEdit = gridCustAddressResult.GetFocusedDataRow();
            txtPrincipleAddress.Text = custAddressRowEdit["PrincipleAddress"].ToString();
            txtCity.Text = custAddressRowEdit["City"].ToString();
            txtState.Text = custAddressRowEdit["State"].ToString();
            txtZipcode.Text = custAddressRowEdit["Zipcode"].ToString();
            txtCountry.Text = custAddressRowEdit["Country"].ToString();
            txtContactNumber.Text = custAddressRowEdit["ContactNumber"].ToString();
            popupContainerControl3.Show();
            popupContainerControl3.BringToFront();
        }
    }
  
}