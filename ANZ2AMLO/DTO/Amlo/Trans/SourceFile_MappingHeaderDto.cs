using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO.Amlo.Trans
{
    public class SourceFile_MappingHeaderDto: BaseDTO
    {
        string _HID;
        string _ReportCode;
        string _ReportName;
        string _Condition1;
        string _Condition2;
        string _Condition3;
        string _Condition4;
        string _ImportFolder;
        string _BackUpFolder;
        string _LogFolder;
        string _OutputFolder;
      
        public SourceFile_MappingHeaderDto()
        {
            HID = "";
            ReportCode = "";
            ReportName = "";
            Condition2 = "";
            Condition3 = "";
            Condition4 = "";
            ImportFolder = "";
            BackUpFolder = "";
            LogFolder = "";
            OutputFolder = "";
            CREATE_BY = "";
            CREATE_DATE = "";
            UPDATE_BY = "";
            UPDATE_DATE = "";
            ROW_STATE = "";
        }

        public string HID { get; set; }
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public string Condition1 { get; set; }
        public string Condition2 { get; set; }
        public string Condition3 { get; set; }
        public string Condition4 { get; set; }
        public string ImportFolder { get; set; }
        public string BackUpFolder { get; set; }
        public string LogFolder { get; set; }
        public string OutputFolder { get; set; }
        
        public static DataTable Data()
        {
            DataTable dt = new DataTable();
            
            dt.Columns.Add("HID"); 
	        dt.Columns.Add("ReportCode");  
	        dt.Columns.Add("ReportName");
	        dt.Columns.Add("Condition1"); 
	        dt.Columns.Add("Condition2"); 
	        dt.Columns.Add("Condition3");
	        dt.Columns.Add("Condition4"); 
	        dt.Columns.Add("ImportFolder"); 
	        dt.Columns.Add("BackUpFolder"); 
	        dt.Columns.Add("LogFolder"); 
	        dt.Columns.Add("OutputFolder");
	        dt.Columns.Add("CREATE_BY"); 
	        dt.Columns.Add("CREATE_DATE"); 
	        dt.Columns.Add("UPDATE_BY"); 
	        dt.Columns.Add("UPDATE_DATE");
	        dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("Active");
            return dt;
        }
    }

    public class SourceFile_MappingDetail
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
        public string CREATE_BY { get; set; }
        public string CREATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public string UPDATE_DATE { get; set; }
        public string ROW_STATE { get; set; }
        public List<SourceFile_MappingDetail_Column> DetailList { get; set; }

    }

    public class SourceFile_MappingDetail_Column
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
        public string CREATE_BY { get; set; }
        public string CREATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public string ROW_STATE { get; set; }
    }
}
