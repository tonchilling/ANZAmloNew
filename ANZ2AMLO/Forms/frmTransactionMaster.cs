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
using BAL.Amlo.Master;
using DTO.Amlo.Trans;
namespace ANZ2AMLO.Forms
{
    public partial class frmTransactionMaster : DevExpress.XtraEditors.XtraForm
    {

        TransactionMasterBAL bal = null;
        List<TransactionANZ> objResult = null;
        public frmTransactionMaster()
        {
            InitializeComponent();
        }

        private void frmTransactionMaster_Load(object sender, EventArgs e)
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

        }
    }
  

}