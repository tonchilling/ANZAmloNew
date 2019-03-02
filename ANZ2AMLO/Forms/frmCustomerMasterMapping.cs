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
    public partial class frmCustomerMasterMapping : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerMasterMapping()
        {
            InitializeComponent();
        }

        private void frmCustomerMasterMapping_Load(object sender, EventArgs e)
        {
            List<Customer> cus = new List<Customer>();
            for (int i = 0; i < 50; i++)
            {
                cus.Add(new Customer()
                {
                    colNo = i.ToString(),
                    FileName = "File Name ",
                    ExampleValue = Guid.NewGuid().ToString().ToUpper(),
                    CMReqquired = "Reqquired",
                    LinkValue = "Link Val",
                    Priority1 = "P1",
                    Priority2 = "P2",
                    Priority3 = "P3",

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
    public class Customer
    {
        public string colNo { get; set; }
        public string FileName { get; set; }
        public string ExampleValue { get; set; }
        public string CMReqquired { get; set; }
        public string LinkValue { get; set; }
        public string Priority1 { get; set; }
        public string Priority2 { get; set; }
        public string Priority3 { get; set; }

    }
}