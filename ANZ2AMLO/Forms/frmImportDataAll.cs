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
using BAL.Amlo.Trans;
using DTO.Amlo.Importing;

using DevExpress.XtraEditors;
using DevExpress.Xpf.Core;
using DevExpress.XtraSplashScreen;
using DTO.Amlo.Export;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmImportDataAll : DevExpress.XtraEditors.XtraForm
    {
        SourceFile_MappingHeaderBAL bal = null;
        DataSet ds = null;
        DataTable dtH, dtDetail;
        string browseFolder = "";
        List<string> allFile;
        List<ImportDTO> dsAll = null;
        ImportDTO tempDetailDTO = null;
        string lbStatus = "";

        public frmImportDataAll()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmImportDataDaily frmImportDaily = new frmImportDataDaily();
            frmImportDaily.ShowDialog(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmImportDataView frmDataView = new frmImportDataView();
            frmDataView.ShowDialog(this);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportData();
        }

        void ImportData()
        {
            DataTable tempHeaderDT, tempDetailDT;
            ImportDTO importDTO = null;
            string[] filePaths = System.IO.Directory.GetFiles(string.Format(@"{0}", browseFolder));

            allFile.AddRange(filePaths);
            if (dtDetail != null && dtDetail.Rows.Count > 0)
            {
                int row = 0;
                foreach (DataRow dr in dtDetail.Rows)
                {
                    SetupProgressBar();

                    string keyWord = dr["KeyWord"].ToString();
                    if (keyWord != "")
                    {
                        tempHeaderDT = new DataTable("Header");
                        tempHeaderDT = dtDetail.Clone();
                        List<string> selectFile = allFile.FindAll(f => f.Contains(keyWord));
                        if (selectFile != null && selectFile.Count > 0)
                        {
                            dr["FileCount"] = selectFile.Count;
                            dr["FileNameList"] = selectFile[0];
                            dr["Imported"] = "N";


                            tempHeaderDT.Rows.Add(dr.ItemArray);
                            importDTO = new ImportDTO();
                            importDTO.HID = dr["HID"].ToString();
                            importDTO.DID = dr["DID"].ToString();
                            ds = new DataSet();

                            pStatus.PerformStep();
                            pStatus.Update();

                            ds.Tables.Add(tempHeaderDT.Copy());
                            lblStatus.Text = string.Format("Loading : {0}", dr["SourceFileRefName"].ToString());
                            lblStatus.Refresh();
                            txtReportCondtion.Text = string.Format("{0}{1}", dr["SourceFileRefName"].ToString()
                                                                                     , dr["Desc"].ToString()); 
                            tempDetailDT = DTO.Util.DevExcelUtils.ConvertExcelToDataTable(selectFile[0],
                                                                                       DevExpress.Spreadsheet.DocumentFormat.Xlsx,
                                                                                        DTO.Util.Converting.StringToInt(dr["StartRow"].ToString()),
                                                                                         DTO.Util.Converting.StringToInt(dr["EndRow"].ToString()),
                                                                                          dr["StartColumn"].ToString(),
                                                                                         dr["HID"].ToString());

                            dr["Import"] = tempDetailDT.Rows.Count;
                            ds.Tables.Add(tempDetailDT.Copy());

                            dr["Imported"] = tempDetailDT.Rows.Count;
                            importDTO.Data = ds.Copy();
                            dsAll.Add(importDTO);
                            gridView1.SetRowCellValue(row, "FileCount", (object)dr["FileCount"].ToString());
                            gridView1.SetRowCellValue(row, "FileNameList", (object)dr["FileNameList"].ToString());
                            gridView1.SetRowCellValue(row, "Imported", (object)dr["Imported"].ToString());

                        }




                    }


                    pStatus.Increment(5);
                    pStatus.Update();



                    gridView1.MoveNext();

                    gridView1.RefreshData();
                    gdView.Refresh();
                    pStatus.Increment(10);

                    pStatus.Update();
                    row++;
                    LoadDetail(dtDetail);
                    // pStatus.Text = string.Format("Loading : {0}",dr["SourceFileRefName"].ToString());
                    System.Threading.Thread.Sleep(1000);


                    dtDetail.AcceptChanges();

                }

                lblStatus.Text = string.Format("Loading {0} files completetly!", allFile.Count);

                //  dtDetail.Rows[0]["FileCount"] = "test";
            }
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

                SetupHeader(dtH);
                LoadDetail(dtDetail);




            }


            gridView1.RowCellStyle += GridView1_RowCellStyle;

        }


        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            if (dtDetail.Rows[e.RowHandle]["FileCount"].ToString() != "")
            {
                e.Appearance.BackColor = Color.LawnGreen;
            }
        }
        void LoadDetail(DataTable dt)
        {
            gdView.DataSource = null;
            gdView.DataSource = dt;
            gridView1.RefreshData();
            gdView.RefreshDataSource();
        }

        void LoadDetailInFile(DataTable dt)
        {
            
            gdView.DataSource = null;
            gridView1.Columns.Clear();
            gdView.DataSource = dt;

            gdView.RefreshDataSource();
            gdView.Refresh();
        }

        void SetupProgressBar()
        {
            pStatus.Properties.Step = 1;
            pStatus.Properties.PercentView = true;
            pStatus.Properties.Maximum = 10;
            pStatus.Properties.Minimum = 0;
            pStatus.Position = 0;
        }

        private void frmImportDataAll_Load(object sender, EventArgs e)
        {
            InitailData();
        }

        private void pStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = lbStatus;
        }

        private void btnView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            tempDetailDTO = dsAll.Find(o => o.DID == gridView1.GetFocusedRowCellValue("DID").ToString());
            if (tempDetailDTO != null)
            {
                lblDetail.Text = tempDetailDTO.Data.Tables[0].Rows[0]["SourceFileRefName"].ToString();
                LoadDetailInFile(tempDetailDTO.Data.Tables[1]);
                popDetail.Width = 1120;
                popDetail.Show();

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* importBal = new ImportTempBAL();
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to save?", "SAVING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                splashScreenManager1.ShowWaitForm();
                importBal.Import(dsAll);
                splashScreenManager1.CloseWaitForm();
            }*/
        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        void SetupHeader(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                browseFolder = dt.Rows[0]["ImportFolder"].ToString();
              //  lblPathFolder.Text = dt.Rows[0]["ImportFolder"].ToString();
               // lblSourceName.Text = dt.Rows[0]["ReportName"].ToString();
            }
        }
    }
}