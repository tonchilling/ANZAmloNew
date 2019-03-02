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
using BAL.Amlo.Importing;
using DTO.Amlo.Importing;
using DevExpress.XtraEditors;
using DevExpress.Xpf.Core;
using DevExpress.XtraSplashScreen;
using DTO.Amlo.Export;
using DTO.Amlo.Autorizing;

namespace ANZ2AMLO.Forms
{
    public partial class frmImportDataDaily : DevExpress.XtraEditors.XtraForm
    {
        public static string ReportSourceID = "";
        public static string KeyWord = "";
        string SourceMappingDID = "";

        List<string> allFile;
        List<ImportDTO> dsAll = null;
        private string reportName = "";
        SourceFile_MappingHeaderBAL bal = null;
        DataSet ds = null;
        DataView dvFilter = null;
        DataTable dtH, dtDetail, dtDetail_Col, dtDetailList;
        ImportTempBAL importBal = null;
        private void frmImportDataDaily_Load(object sender, EventArgs e)
        {
            InitialData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

               
                ImportByFile(openFileDialog1.FileName);
                if (Validate())
                {
                    btnVerify.Enabled = true;
                    btnImport.Enabled = true;
                }
                
            }
        }

        public bool ImportByFile(string fileName)
        {
            bool isCanImport = false;

            try {

                txtFileName.Text = fileName;
                //  MessageBox.Show(fileName);


            }
            catch (Exception ex)
            { }
            finally { }
            return isCanImport;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

            allFile = new List<string>();
            dsAll = new List<ImportDTO>();
            DataTable tempHeaderDT, tempDetailDT;
            ImportDTO importDTO = null;
            string[] filePaths = null;
           


            if (DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to Verify Existing File?", "Verify Existing File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              
                tempDetailDT = null;

                splashScreenManager1.ShowWaitForm();


                //  allFile.AddRange(filePaths);

                if (dtDetail != null && dtDetail.Rows.Count > 0)
                {
                    int row = 0;

                    tempHeaderDT = new DataTable("Header");
                    tempHeaderDT = dtDetail.Clone();
                    ds = new DataSet();
                    DataView dvFilterColumns = new DataView(dtDetail_Col);
                    dvFilterColumns.RowFilter = string.Format("DID='{0}'", dvFilter[0]["DID"].ToString());
                    dvFilterColumns.Sort = "No asc";

                    SourceMappingDID = dvFilter[0]["DID"].ToString();
                    importDTO = new ImportDTO();
                    importDTO.HID = dvFilter[0]["HID"].ToString();
                    importDTO.DID = dvFilter[0]["DID"].ToString();

                    tempHeaderDT.Rows.Add(dvFilter[0].Row.ItemArray);





                    tempDetailDT = DTO.Util.DevExcelUtils.ConvertExcelToDataTable(txtFileName.Text, dvFilterColumns,
                                                                                        DevExpress.Spreadsheet.DocumentFormat.Xlsx,
                                                                                         DTO.Util.Converting.StringToInt(dvFilter[0]["StartRow"].ToString()),
                                                                                          DTO.Util.Converting.StringToInt(dvFilter[0]["EndRow"].ToString()),
                                                                                           dvFilter[0]["StartColumn"].ToString(),
                                                                                          dvFilter[0]["HID"].ToString(), dvFilter[0]["KeyWord"].ToString());

                    tempHeaderDT.Rows[0]["FromTotal"] = tempDetailDT.Rows.Count;
                    //  tempHeaderDT.Rows[0]["Remark"] = txtRemark.Text;
                    ds.Tables.Add(tempHeaderDT.Copy());

                    ds.Tables.Add(tempDetailDT.Copy());
                    //  ds.Tables.Add(dtTImportHeader.Copy());



                    LoadDetail(tempDetailDT);
                    importDTO.Data = ds.Copy();
                    dsAll.Add(importDTO);

                    splashScreenManager1.CloseWaitForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Verify Existing File completely!!", "Verify Existing File", MessageBoxButtons.OK);


                    //  dtDetail.Rows[0]["FileCount"] = "test";

                }
                else {
                    splashScreenManager1.CloseWaitForm();
                }

                
            }


        }



        bool Validate()
        {

            bool isPass = true;


            if (!txtFileName.Text.Contains(txtKeyWord.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("File is not match!!", "Verify", MessageBoxButtons.OK);
                isPass = false;
            }

            return isPass;


        }

        public   void LoadDetail(DataTable dt)
        {

            gdDetail.DataSource = null;
            gridView1.Columns.Clear();
            gdDetail.DataSource = dt;
            gridView1.OptionsBehavior.Editable = false;
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataTable dtTImportHeader = ImportDTO.ImportHeaderData();
            DataTable dtTImportDetail = ImportDTO.ImportDetailData();

            importBal = new ImportTempBAL();
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Do you want to Import All?", "Import ALL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                splashScreenManager1.ShowWaitForm();

                DataRow drTImportHeader = dtTImportHeader.NewRow();
                drTImportHeader["SourceFileHID"] = ReportSourceID;
                drTImportHeader["TranDate"] = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
                DateTime nowDate = DateTime.Now;
                drTImportHeader["ReportName"] = System.IO.Path.GetFileName(txtSourceFile.Text);
                drTImportHeader["CREATE_BY"] = MyLogin.USER_LOGIN;
                drTImportHeader["Remark"] = txtRemark.Text;
                dtTImportHeader.Rows.Add(drTImportHeader);
           //     @SourceFileHID_2[nvarchar](50), 
	//@SourceFileDID_3[nvarchar](50), 

                DataRow drTImportDetail = dtTImportDetail.NewRow();
                drTImportHeader["SourceFileHID"] = ReportSourceID;
                drTImportDetail["SourceFileDID"] = SourceMappingDID;
                drTImportDetail["FilesCount"] = "1";
                drTImportDetail["FileNameList"] = "";
                drTImportDetail["HasImport"] = "Y";
                drTImportDetail["ImportStatus"] = "P";
                drTImportDetail["Remark"] = txtRemark.Text;
                drTImportDetail["ImportedRec"] = dsAll[0].Data.Tables[0].Rows[0]["FromTotal"].ToString();
                drTImportDetail["TotalRec"] = dsAll[0].Data.Tables[0].Rows[0]["FromTotal"].ToString();
                drTImportDetail["CREATE_BY"] = MyLogin.USER_LOGIN;
                dtTImportDetail.Rows.Add(drTImportDetail);


                importBal.Import(dsAll, dtTImportHeader, dtTImportDetail);
                splashScreenManager1.CloseWaitForm();
                DevExpress.XtraEditors.XtraMessageBox.Show("Import All completely!!", "Import ALL", MessageBoxButtons.OK);
            }
        }

        public frmImportDataDaily()
        {
            InitializeComponent();
        }

        void InitialData()
        {
            bal = new SourceFile_MappingHeaderBAL();


            ds = bal.FindHeaderAndDetailPK(ReportSourceID, MyLogin.USER_LOGIN);

            if (ds != null)
            {
                dtH = ds.Tables[0];
                dtDetail = ds.Tables[1];
                dtDetail_Col = ds.Tables[2];


            }
            else
            {
                dtH = null;
                dtDetail = null;
                dtDetail_Col = null;
            }

            if (dtDetail != null)
            {
                dvFilter = new DataView(dtDetail);
                dvFilter.RowFilter = string.Format("KeyWord='{0}'", KeyWord);

                if (dvFilter != null && dvFilter.Count > 0)
                {
                    txtSourceFile.Text = dvFilter[0]["SourceFileRefName"].ToString();
                    txtImport.Text = string.Format("{0},{1}", dvFilter[0]["StartRow"].ToString(), dvFilter[0]["StartColumn"].ToString());
                   txtKeyWord.Text = dvFilter[0]["KeyWord"].ToString();
                   // txtRemark.Text = "";
                  //  txtFileNameConditon.Text = dvFilter[0]["KeyWord"].ToString();
                }
            }

        }
        private void btnView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}