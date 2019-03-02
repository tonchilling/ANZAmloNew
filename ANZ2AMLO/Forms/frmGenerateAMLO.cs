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
    public partial class frmGenerateAMLO : DevExpress.XtraEditors.XtraForm
    {
        public frmGenerateAMLO()
        {
            InitializeComponent();
        }

        private void frmGenerateAMLO_Load(object sender, EventArgs e)
        {
            List<GenAMLOData> cus = new List<GenAMLOData>();

            for (int i = 1; i < 21; i++)
            {
                cus.Add(new GenAMLOData()
                {
                    colNo = i.ToString(),
                    CustomerID = string.Format("CusID00{0}", i.ToString()),
                    CutomerNo = string.Format("CusNo00{0}", i.ToString()),
                    CutomerAC = "AC001",
                    RegisteredBusinessName = "Company XXX .,LTD",
                    BusinessNameTH = "Name Thai",
                    CustomerName = "Customer Name",
                    RegisteredTAXID = "TaxID001",
                    TelNo = "01-000-0001",
                    RegistoerDate = DateTime.Now,
                    BusinessTypeCode = "Type001",
                    DefaultAddress = "Address 001",
                    ContractAdd = "Con Address",
                    CompanyAdd = "Company Addess",
                    RegAddress = "Reg Address"
                });
            }

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
    }
    public class GenAMLOData
    {
        public string colNo { get; set; }
        public string CutomerNo { get; set; }
        public string CustomerID { get; set; }
        public string CutomerAC { get; set; }
        public string RegisteredBusinessName { get; set; }
        public string BusinessNameTH { get; set; }
        public string CustomerName { get; set; }
        public string RegisteredTAXID { get; set; }
        public string colDID { get; set; }
        public string colHID { get; set; }
        public DateTime RegistoerDate { get; set; }
        public string BusinessTypeCode { get; set; }
        public string TelNo { get; set; }
        public string DefaultAddress { get; set; }
        public string RegAddress { get; set; }
        public string ContractAdd { get; set; }
        public string CompanyAdd { get; set; }
        public string CompanyRegisterID { get; set; }
        public string TransactorCompanyBusinessType { get; set; }
    }
}