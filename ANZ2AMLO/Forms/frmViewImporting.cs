using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using BAL.Amlo.Trans;
using BAL.Amlo.Importing;
using DTO.Amlo.Importing;
using DevExpress.XtraEditors;
using DevExpress.Xpf.Core;
using DevExpress.XtraSplashScreen;
using DTO.Amlo.Autorizing;
namespace ANZ1AMLO.Forms
{
    public partial class frmViewImporting : DevExpress.XtraEditors.XtraForm
    {
        SourceFile_MappingHeaderBAL bal = null;
        DataSet ds = null;
        DataView dvFilter = null;
        DataTable dtH, dtDetail, dtDetail_Col;
        ImportTempBAL importBal = null;
        string browseFolder = "";
        List<string> allFile;
        List<ImportDTO> dsAll = null;
        ImportDTO tempDetailDTO = null;
        string lbStatus = "";

        public frmViewImporting()
        {
            InitializeComponent();
        }

        private void frmViewImporting_Load(object sender, EventArgs e)
        {
            InitailData();
        }

        void InitailData()
        {
            dsAll = new List<ImportDTO>();
            allFile = new List<string>();

            bal = new SourceFile_MappingHeaderBAL();
            ds = bal.FindHeaderAndDetailPK(null, MyLogin.USER_LOGIN);

            if (ds != null)
            {
                dtH = ds.Tables[0];
                dtDetail = ds.Tables[1];
                dtDetail_Col = ds.Tables[2];

                SetupHeader(dtH);
                LoadSourcetType(dtDetail);




            }


         

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            bal = new SourceFile_MappingHeaderBAL();
            dtDetail = bal.FindByKeyWord(string.Format("Temp_{0}",cbSourceType.SelectedValue.ToString()));
            splashScreenManager1.ShowWaitForm();
            LoadDetail(dtDetail);
            splashScreenManager1.CloseWaitForm();

        }

        void LoadDetail(DataTable dt)
        {
            gdViewDetail.DataSource = null;
            gridView1.Columns.Clear();
            gdViewDetail.DataSource = dt;

            gdViewDetail.RefreshDataSource();
            gdViewDetail.Refresh();

            if (dt != null && dt.Rows.Count > 0)
            {
                lbRecs.Text = dt.Rows.Count.ToString("##,##0.00");
            }
            else {
                lbRecs.Text = "0";
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        void LoadSourcetType(DataTable dt)
        {
            cbSourceType.DataSource = dt;
            cbSourceType.DisplayMember = "SourceFileRefName";
            cbSourceType.ValueMember = "KeyWord";



        }

        void SetupHeader(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                browseFolder = dt.Rows[0]["ImportFolder"].ToString();
                lblPathFolder.Text = dt.Rows[0]["ImportFolder"].ToString();
                lblSourceName.Text = dt.Rows[0]["ReportName"].ToString();
            }
        }

    }
}