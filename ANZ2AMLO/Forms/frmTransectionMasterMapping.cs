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
    public partial class frmTransectionMasterMapping : DevExpress.XtraEditors.XtraForm
    {
        public frmTransectionMasterMapping()
        {
            InitializeComponent();
        }

        private void frmTransectionMasterMapping_Load(object sender, EventArgs e)
        {
            List<TansMap> cus = new List<TansMap>();
            for (int i = 1; i < 50; i++)
            {
                cus.Add(new TansMap()
                {
                    colNo = i.ToString(),
                    FileName = "File Name ",
                    Mapping = Guid.NewGuid().ToString().ToUpper(),
                    Group = "G NO 1",
                    ShowOrderNo = "Link Val",
                    Key = "Key Field",
                    Logic1 = "P21",
                    Logic2 = "P32",
                    Logic3 = "P33",
                    Logic4 = "P34",
                    Logic5 = "P35"
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
    public class TansMap
    {
        public string colNo { get; set; }
        public string Mapping { get; set; }
        public string FileName { get; set; }
        public string Group { get; set; }
        public string ShowOrderNo { get; set; }
        public string Key { get; set; }
        public string Logic1 { get; set; }
        public string Logic2 { get; set; }
        public string Logic3 { get; set; }
        public string Logic4 { get; set; }
        public string Logic5 { get; set; }
    }
}