using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo.Importing
{
  public  class ImportDTO: BaseDTO
    {
        public string HID { get; set; }
        public string DID { get; set; }
        public string ImportID { get; set; }
        public DataSet Data { get; set; }

        public static DataTable ImportHeaderData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ImportID");
            dt.Columns.Add("SourceFileHID");
            dt.Columns.Add("TranDate");
            dt.Columns.Add("ReportName");
            dt.Columns.Add("Remark");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");

            return dt;
        }

        public static DataTable ImportDetailData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ImportID");
            dt.Columns.Add("SourceFileHID");
            dt.Columns.Add("SourceFileDID");
            dt.Columns.Add("FilesCount");
            dt.Columns.Add("FileNameList");
            dt.Columns.Add("HasImport");
            dt.Columns.Add("ImportStatus");
            dt.Columns.Add("ImportedRec");
            dt.Columns.Add("TotalRec");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("Remark");

            return dt;
        }
    }
}
