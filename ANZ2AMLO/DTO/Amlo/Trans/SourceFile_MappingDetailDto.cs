using DTO.Amlo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo.Trans
{
    class SourceFile_MappingDetailDto : BaseDTO
    {
        public string DID { get; set; }
        public string HID { get; set; }
        public string No { get; set; }
        public string SourceFileRefName { get; set; }
        public string KeyWord { get; set; }
        public string Type { get; set; }
        public string ExtFile { get; set; }
        public string StartRow { get; set; }
        public string EndRow { get; set; }
        public string StartColumn { get; set; }

        public SourceFile_MappingDetailDto()
        {
            DID = "";
            HID = "";
            No = "";
            SourceFileRefName = "";
            KeyWord = "";
            Type = "";
            ExtFile = "";
            StartRow = "";
            EndRow = "";
            StartColumn = "";
            CREATE_BY = "";
            CREATE_DATE = "";
            UPDATE_BY = "";
            UPDATE_DATE = "";
            ROW_STATE = "";
        }

        public static DataTable Data()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("DID");
            dt.Columns.Add("HID");
            dt.Columns.Add("No");
            dt.Columns.Add("SourceFileRefName");
            dt.Columns.Add("KeyWord");
            dt.Columns.Add("Type");
            dt.Columns.Add("ExtFile");
            dt.Columns.Add("StartRow");
            dt.Columns.Add("EndRow");
            dt.Columns.Add("StartColumn");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("Active");
            
            return dt;
        }
    }
}

