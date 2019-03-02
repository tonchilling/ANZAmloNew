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
    public partial class frm000ReportWorkFlowStatus : DevExpress.XtraEditors.XtraForm
    {
        public frm000ReportWorkFlowStatus()
        {
            InitializeComponent();
        }

        private void frm000ReportWorkFlowStatus_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("TEST");
            List<ImportFileX> ImportFileCong = new List<ImportFileX>();
            ImportFileCong.Add(new ImportFileX()
            {
                colNo = "1",
                colAmountTHB = "15,000,000.00",
                colStatus = "2-Maker Draft Report",
                colAction = "Edit",
                colEndTransactionDate = "10/31/2018",
                colReportName = "1-05-9: Electronic Fund Transfer > 700,000 THB",
                colRemark = "N/A",
                colLastedUpdateBy = "Admin",
                colUpdateDateTime = DateTime.Now,
            });
            ImportFileCong.Add(new ImportFileX()
            {
                colNo = "2",
                colAmountTHB = "15,000,000.00",
                colStatus = "3-Submited to Checker",
                colAction = "Edit",
                colEndTransactionDate = "10/31/2018",
                colReportName = "1-02: Transaction Related to Asset > 5 Million THB",
                colRemark = "N/A",
                colLastedUpdateBy = "Admin",
                colUpdateDateTime = DateTime.Now,

            });
            ImportFileCong.Add(new ImportFileX()
            {
                colNo = "3",
                colAmountTHB = "15,000,000.00",
                colStatus = "4-Final",
                colAction = "Edit",
                colEndTransactionDate = "10/31/2018",
                colReportName = "1-03: Suspicious Transaction",
                colRemark = "N/A",
                colLastedUpdateBy = "Admin",
                colUpdateDateTime = DateTime.Now,

            });
            this.gridView1.GridControl.DataSource = ImportFileCong;
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
    public class ImportFileX
    {
        public string colNo { get; set; }
        public string colReportName { get; set; }
        public string colEndTransactionDate { get; set; }
        public string colAmountTHB { get; set; }
        public string colStatus { get; set; }
        public string colRemark { get; set; }
        public string colAction { get; set; }
        public string colLastedUpdateBy { get; set; }
        public DateTime colUpdateDateTime { get; set; }
  


    }
}