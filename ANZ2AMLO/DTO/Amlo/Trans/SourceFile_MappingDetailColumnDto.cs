using DTO.Amlo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo.Trans
{
    class SourceFile_MappingDetailColumnDto : BaseDTO
    {
        public string DID { get; set; }
        public string No { get; set; }
        public string ColumnNo { get; set; }
        public string ColumnExcel { get; set; }
        public string ColumnName { get; set; }
        public string ParentID { get; set; }
        public string Condition { get; set; }
        public string TotalRow { get; set; }
        public string StartPosition { get; set; }
        public string PositionLength { get; set; }
        public string Desc { get; set; }

        public SourceFile_MappingDetailColumnDto()
        {
            DID = "";
            No = "";
            ColumnNo = "";
            ColumnExcel = "";
            ColumnName = "";
            ParentID = "";
            Condition = "";
            TotalRow = "";
            StartPosition = "";
            PositionLength = "";
            Desc = "";
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
            dt.Columns.Add("No");
            dt.Columns.Add("ColumnNo");
            dt.Columns.Add("ColumnExcel");
            dt.Columns.Add("ColumnName");
            dt.Columns.Add("ParentID");
            dt.Columns.Add("Condition");
            dt.Columns.Add("TotalRow");
            dt.Columns.Add("StartPosition");
            dt.Columns.Add("PositionLength");
            dt.Columns.Add("Desc");
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
