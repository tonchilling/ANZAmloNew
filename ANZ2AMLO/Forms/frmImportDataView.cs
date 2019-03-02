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
using DTO.Amlo.Export;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmImportDataView : DevExpress.XtraEditors.XtraForm
    {
        SourceFile_MappingDetailColumnBAL blSourceFileMappingDetailColumn = new SourceFile_MappingDetailColumnBAL();

        SourceFile_MappingHeaderBAL bal = null;
        DataSet ds = null;
        DataView dvFilter = null;
        DataTable dtH, dtDetail, dtDetail_Col,dtDetailList;
        ImportTempBAL importBal = null;
        string browseFolder = "";
        List<string> allFile;
        List<ImportDTO> dsAll = null;
        ImportDTO tempDetailDTO = null;


        public frmImportDataView()
        {
            InitializeComponent();
        }

        private void frmImportDataView_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        void InitialData()
        {
            bal = new SourceFile_MappingHeaderBAL();
            DataTable dtHeaderSearch = bal.GetDropDownList();
            ddlReportCondition.DataSource = dtHeaderSearch;
            ddlReportCondition.DisplayMember = "Text";
            ddlReportCondition.ValueMember = "Value";
            ddlReportCondition.SelectedIndex = 1;

            LoadMonth();
            LoadSourcetType(ddlReportCondition.SelectedValue.ToString());

            pnViewMapping.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bal = new SourceFile_MappingHeaderBAL();

            DataView dvFilter = new DataView(dtDetail);
            dvFilter.RowFilter = string.Format("KeyWord='{0}'", ddlSourceType.SelectedValue.ToString());

            try
            {
                ds = bal.FindByKeyWord(string.Format("Temp_{0}", ddlSourceType.SelectedValue.ToString()), dtTranDate.Value, dvFilter[0]["DID"].ToString());
            }
            catch (Exception ex)
            { }
            finally
            {

            }
            
            splashScreenManager1.ShowWaitForm();


            if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
            {
                dtDetailList = ds.Tables[0];

               
                LoadDetail(dtDetailList);
                txtRemark.Text = ds.Tables[1].Rows[0]["Remark"].ToString();
                splashScreenManager1.CloseWaitForm();
            }
            else {
                ClearDetailData();


                splashScreenManager1.CloseWaitForm();
                DevExpress.XtraEditors.XtraMessageBox.Show("Not Found Data!!", "VIEW", MessageBoxButtons.OK);
            }
          
        }

        private void ddlReportCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSourcetType(ddlReportCondition.SelectedValue.ToString());
        }

        void LoadSourcetType(string reportSourceID)
        {
            dsAll = new List<ImportDTO>();
            allFile = new List<string>();

         //   bal = new SourceFile_MappingHeaderBAL();
            ds = bal.FindHeaderAndDetailPK(reportSourceID, MyLogin.USER_LOGIN);

            if (ds != null)
            {
                dtH = ds.Tables[0];
                dtDetail = ds.Tables[1];
                dtDetail_Col = ds.Tables[2];


            }
            else {
                dtH = null;
                dtDetail = null;
                dtDetail_Col = null;
            }

          //  LoadDetail(dtDetail);


            ddlSourceType.DataSource = dtDetail;
            ddlSourceType.DisplayMember = "SourceFileRefName";
            ddlSourceType.ValueMember = "KeyWord";



        }

        private void dtTranDate_ValueChanged(object sender, EventArgs e)
        {
            LoadMonth();
        }

        private void btnViewMapping_Click(object sender, EventArgs e)
        {
            DataView dvDetail = new DataView(dtDetail);
            dvDetail.RowFilter = string.Format("KeyWord='{0}'", ddlSourceType.SelectedValue.ToString());
            string currentDID = "";
            if (dvDetail.Count > 0)
            {
                currentDID = dvDetail[0]["DID"].ToString();
            }
            if (!"".Equals(currentDID))
            {
                DataTable dt = blSourceFileMappingDetailColumn.FindByColumn(currentDID, "");
                gridViewMapping.DataSource = dt;
                gridViewMapping.RefreshDataSource();
                pnViewMapping.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select Source Type", ".:View Mapping");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnViewMapping.Visible = false;
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {

        }

        void LoadMonth()
        {
            txtMonth.Text = string.Format("{0}:{1}", dtTranDate.Value.Month, DTO.Util.Utility.GetShortMonth(dtTranDate.Value.Month));
            txtPeriod.Text = dtTranDate.Value.Month >= 1 && dtTranDate.Value.Month <= 6 ? "1st" : "2nd";
        }

        void ClearDetailData()
        {
            txtTemplateFile.Text = "";
            txtStartRowCol.Text = "";
            txtSheetName.Text = "";
            txtRemark.Text = "";

            gridView1.Columns.Clear();
            gdDetail.DataSource = null;

            gdDetail.RefreshDataSource();
            gdDetail.Refresh();
        }
        void LoadDetail(DataTable dt)
        {
            ClearDetailData();
            if (dtDetail != null)
            {
                dvFilter = new DataView(dtDetail);
                dvFilter.RowFilter = string.Format("KeyWord='{0}'", ddlSourceType.SelectedValue.ToString());

                if(dvFilter!=null && dvFilter.Count>0)
                    {
                    txtTemplateFile.Text = ""; //;dvFilter[0][""];
                    txtStartRowCol.Text = string.Format("{0},{1}",dvFilter[0]["StartRow"].ToString(), dvFilter[0]["StartColumn"].ToString());
                    txtSheetName.Text = "Export Worksheet";
                    txtRemark.Text = "";
                    txtFileNameConditon.Text = dvFilter[0]["KeyWord"].ToString();
                }
            }

            gdDetail.DataSource = null;
            gridView1.Columns.Clear();
            gdDetail.DataSource = dt;

            gdDetail.RefreshDataSource();
            gdDetail.Refresh();

            if (dt != null && dt.Rows.Count > 0)
            {
               // lbRecs.Text = dt.Rows.Count.ToString("##,##0.00");
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Not Found Data!!", "VIEW", MessageBoxButtons.OK);
                // lbRecs.Text = "0";
            }
        }

    }
}