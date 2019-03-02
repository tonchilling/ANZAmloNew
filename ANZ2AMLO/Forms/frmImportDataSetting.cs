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
    public partial class frmImportDataSetting : DevExpress.XtraEditors.XtraForm
    {
        public frmImportDataSetting()
        {
            InitializeComponent();
        }

        private void frmImportDataSetting_Load(object sender, EventArgs e)
        {
            List<ImportFile> ImportFileCong = new List<ImportFile>();
            ImportFileCong.Add(new ImportFile()
            {
                colNo = "1",
                Type = "File",
                Import = "Import",
                Imported = "Imported",
                KeyWord = "Keyword",
                SourceFileRefName = "c:\\import\\file1.xls",
                Status = "Pass",
                UpdateBy = "Admin",
                UpdateDate = DateTime.Now,
                FilePreiod = "01-15-2018"
            });
            ImportFileCong.Add(new ImportFile()
            {
                colNo = "2",
                Type = "File",
                Import = "Import",
                Imported = "Imported",
                KeyWord = "Keyword",
                SourceFileRefName = "c:\\import\\file1.xls",
                Status = "Pass",
                UpdateBy = "Admin",
                UpdateDate = DateTime.Now,
                FilePreiod = "01-15-2018"

            });
            ImportFileCong.Add(new ImportFile()
            {
                colNo = "3",
                Type = "File",
                Import = "Import",
                Imported = "Imported",
                KeyWord = "Keyword",
                SourceFileRefName = "c:\\import\\file1.xls",
                Status = "Pass",
                UpdateBy = "Admin",
                UpdateDate = DateTime.Now,
                FilePreiod = "01-15-2018"

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
    public class ImportFile
    {
        public string colNo { get; set; }
        public string SourceFileRefName { get; set; }

        public string KeyWord { get; set; }
        public string Type { get; set; }
        public string Import { get; set; }
        public string Status { get; set; }
        public string Imported { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string FilePreiod { get; set; }


    }

}