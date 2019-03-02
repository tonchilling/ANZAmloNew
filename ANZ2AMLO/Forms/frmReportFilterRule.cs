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
    public partial class frmReportFilterRule : DevExpress.XtraEditors.XtraForm
    {
        public frmReportFilterRule()
        {
            InitializeComponent();
        }

        private void frmReportFilterRule_Load(object sender, EventArgs e)
        {
            List<rptMapRole> cus = new List<rptMapRole>();
            for (int i = 1; i < 50; i++)
            {
                cus.Add(new rptMapRole()
                {
                    colNo = i.ToString(),
                    TransactionType = "Transaction ",
                    FilterRuleName = Guid.NewGuid().ToString().ToUpper(),
                    LogicFilterLevel = "RQ",
                    Condition = " Val Type",
                    ActiveStatus = "Key Value",
                    Active = "LoginRemark",
                    UpdateDate = DateTime.Now
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
    public class rptMapRole
    {
        public string colNo { get; set; }
        public string TransactionType { get; set; }
        public string FilterRuleName { get; set; }
        public string LogicFilterLevel { get; set; }
        public string Condition { get; set; }
        public string ActiveStatus { get; set; }
        public string Active { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}