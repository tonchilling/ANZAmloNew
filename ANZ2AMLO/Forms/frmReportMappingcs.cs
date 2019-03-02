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
    public partial class frmReportMappingcs : DevExpress.XtraEditors.XtraForm
    {
        public frmReportMappingcs()
        {
            InitializeComponent();
        }

        private void frmReportMappingcs_Load(object sender, EventArgs e)
        {
            List<rptMap> cus = new List<rptMap>();
            for (int i = 1; i < 50; i++)
            {
                cus.Add(new rptMap()
                {
                    colNo = i.ToString(),
                    FieldName = "Field Name ",
                    XMLTag = Guid.NewGuid().ToString().ToUpper(),
                    Required = "RQ",
                    Valuetype = " Val Type",
                    DefaultValue = "Key Value",
                    LoginRemark = "LoginRemark",
                    ReplaceBlankValue = "P32"
                   
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
    public class rptMap
    {
        public string colNo { get; set; }
        public string XMLTag { get; set; }
        public string FieldName { get; set; }
        public string Required { get; set; }
        public string Valuetype { get; set; }
        public string DefaultValue { get; set; }
        public string LoginRemark { get; set; }
        public string ReplaceBlankValue { get; set; }
       
    }
}