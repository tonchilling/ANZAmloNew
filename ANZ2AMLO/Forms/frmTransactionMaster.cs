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

namespace ANZ2AMLO.Forms
{
    public partial class frmTransactionMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmTransactionMaster()
        {
            InitializeComponent();
        }

        private void frmTransactionMaster_Load(object sender, EventArgs e)
        {
            List<TransactionANZ> cus = new List<TransactionANZ>();
            cus.Add(new TransactionANZ()
            {
                colNo = "1",
                GroupName = "G01",
                Status = "Compleated",
                ANZCustomerInstrumentId = "CusID01",
                ANZCustomerBANKAccountNumber = "Number01",
                TransactionDate=DateTime.Now,
                TranxSendReceive="Send",
                TranxAmountTHB="750,000.01",
                TranxAmountCurrency="THB"


            });
            cus.Add(new TransactionANZ()
            {
                colNo = "2",
                GroupName = "G02",
                Status = "Reject",
                ANZCustomerInstrumentId = "CusID02",
                ANZCustomerBANKAccountNumber = "Number02",
                TransactionDate = DateTime.Now,
                TranxSendReceive = "Receive",
                TranxAmountTHB = "750,000.01",
                TranxAmountCurrency = "USD"
            });
            cus.Add(new TransactionANZ()
            {
                colNo = "3",
                GroupName = "G03",
                Status = "Pending",
                ANZCustomerInstrumentId = "CusID03",
                ANZCustomerBANKAccountNumber = "Number03",
                TransactionDate = DateTime.Now,
                TranxSendReceive = "Send",
                TranxAmountTHB = "2,850,000.01",
                TranxAmountCurrency = "THB"
            });
            cus.Add(new TransactionANZ()
            {
                colNo = "4",
                GroupName = "G04",
                Status = "Compleated",
                ANZCustomerInstrumentId = "CusID04",
                ANZCustomerBANKAccountNumber = "Number04",
                TransactionDate = DateTime.Now,
                TranxSendReceive = "Send",
                TranxAmountTHB = "90,000.01",
                TranxAmountCurrency = "THB"
            });
            this.gridView1.GridControl.DataSource = cus;
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
    }
    public class TransactionANZ
    {
        public string colNo { get; set; }
        public string GroupName { get; set; }
        public string Status { get; set; }
        public string ANZCustomerInstrumentId { get; set; }
        public string ANZCustomerBANKAccountNumber { get; set; }
        public DateTime TransactionDate { get; set; }
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
        public string BeneIdIssueBy { get; set; }


    }

}