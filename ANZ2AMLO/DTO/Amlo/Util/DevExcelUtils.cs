using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.Spreadsheet;
using DTO.Util;
namespace DTO.Util
{
   public class DevExcelUtils
    {


        public static DataTable ConvertExcelToDataTable(string filepath
                                                      , DocumentFormat docType
                                                       ,int StartRow
                                                       , int EndRow
                                                        , string StartColumn
                                                        ,string KeyHID)
        {
            var startRow = StartRow;
            Workbook workBook = new Workbook();

            workBook.LoadDocument(filepath);

            Worksheet worksheet = workBook.Worksheets[0];
             Range rangeAll = worksheet.GetDataRange();

            string lastHeader = worksheet.Columns[rangeAll.ColumnCount - 1].Heading;
           int columnIndex= worksheet.Columns[StartColumn].Index+1;
            int tempColumn = 0;
            Range range = null;
            if (EndRow > 0)
                range = worksheet.Range.Parse(string.Format("{0}{1}:{3}{2}", StartColumn, startRow, startRow, lastHeader));
            else
             range = worksheet.Range.Parse(string.Format("{0}{1}:{2}{1}", StartColumn, startRow, lastHeader));
           
          
            DataTable dataTable = worksheet.CreateDataTable(range, true);
          //  dataTable.Columns.Add("DID");
            foreach (DataColumn dc in dataTable.Columns)
            {
                dc.DataType = typeof(String);
            }
            RowCollection rowAll = worksheet.Rows;

            int colNumber = range.CurrentRegion.ColumnCount-(columnIndex-1);
            for (int i = startRow; i <= rangeAll.RowCount - 1; i++)
            {
                DataRow newRow = dataTable.NewRow();

                tempColumn = columnIndex;
                //  Row row= rowAll[i];
                for (int j = 0; j <= colNumber - 1; j++)
                {

                    newRow[j] = worksheet.Cells[i, tempColumn].DisplayText;
                    tempColumn++;

                }
                 dataTable.Rows.Add(newRow);
            }

            worksheet = null;
            workBook.Dispose();

            return dataTable;
        }


        public static DataTable ConvertExcelToDataTable(string filepath
                                                  , DataView dvCol
                                                  , DocumentFormat docType
                                                   , int StartRow
                                                   , int EndRow
                                                    , string StartColumn
                                                    , string KeyHID
                                                    , string KeyWord)
        {
            var startRow = StartRow;
            Workbook workBook = new Workbook();

            workBook.LoadDocument(filepath);

            Worksheet worksheet = workBook.Worksheets[0];
            Range rangeAll = worksheet.GetDataRange();

            string lastHeader = worksheet.Columns[rangeAll.ColumnCount - 1].Heading;
            int columnIndex = worksheet.Columns[StartColumn].Index + 1;
            int tempColumn = 0;
            Range range = null;
            if (EndRow > 0)
                range = worksheet.Range.Parse(string.Format("{0}{1}:{3}{2}", StartColumn, startRow, startRow, lastHeader));
            else
                range = worksheet.Range.Parse(string.Format("{0}{1}:{2}{1}", StartColumn, startRow, lastHeader));


            DataTable dataTable = new DataTable();

            if (dvCol != null && dvCol.Count > 0)
            {
                dvCol.Sort = "No asc";
                foreach (DataRowView dr in dvCol)
                {
                    dataTable.Columns.Add(dr["ColumnName"].ToString());
                }
            }
            //  dataTable.Columns.Add("DID");
            foreach (DataColumn dc in dataTable.Columns)
            {
                dc.DataType = typeof(String);
            }
            RowCollection rowAll = worksheet.Rows;

            int colNumber = range.CurrentRegion.ColumnCount - (columnIndex - 1);
           
            DataRow newRow = null;
          
            
            switch (KeyWord.ToLower())
            {

                case "outgoing":
                    #region outgoing case
                    dataTable = ConvertInOut(dataTable, dvCol, worksheet, startRow, "{2:I");
                    #endregion
                    break;
                case "incoming":
                    dataTable= ConvertInOut(dataTable, dvCol, worksheet, startRow, "{2:O");
                    break;
                 default:

                    #region normal case
                    for (int i = startRow; i <= rangeAll.RowCount - 1; i++)
            {
                newRow = dataTable.NewRow();

                tempColumn = columnIndex;
                //  Row row= rowAll[i];
                foreach (DataRowView dr in dvCol)
                {

                    newRow[dr["ColumnName"].ToString()] = worksheet.Cells[i, Utility.ConvertToInt(dr["ColumnNo"].ToString())].DisplayText;
                    tempColumn++;

                }
                dataTable.Rows.Add(newRow);
            }
                    #endregion

                    break;
        }

            worksheet = null;
            workBook.Dispose();

            return dataTable;
        }


        static DataTable ConvertInOut(DataTable dataTable,
                                        DataView dvCol,
                                     Worksheet worksheet, int startRow, string keyType)
        {
            string tempData = "", mParent = "", mCondition = "";
            bool lockRecord = false;
            int totalRow = 0, stRow = 1; ;

            DataRow newRow = null;
            Range rangeAll = worksheet.GetDataRange();
            #region incoming case
            for (int i = startRow; i <= rangeAll.RowCount - 1; i++)
            {

                tempData = worksheet.Cells[i, 0].DisplayText;
                if (tempData.IndexOf(keyType) == 2) // is in coming data ?
                {
                    newRow = dataTable.NewRow();
                    lockRecord = true;
                }


                if (lockRecord)
                {

                    foreach (DataRowView dr in dvCol)
                    {


                        if (tempData.IndexOf(dr["Condition"].ToString()) > -1
                            ) // is in coming data ?
                        {

                            if (DTO.Util.Converting.StringToInt(dr["TotalRow"].ToString()) > 0)
                            {
                                mParent = string.Format("{0}{1}", dr["DID"].ToString(), dr["No"].ToString());
                                mCondition = dr["Condition"].ToString();
                                stRow = 1;
                            }
                            else
                            {
                                mParent = "";
                                mCondition = "";
                            }


                            if (dr["StartPosition"].ToString() != "") // :32A: TransactionDate-6-YYMMDD/ CurrecyCode-3/ CurrAmount
                            {
                                DataView dvFilterBySplit = new DataView(dvCol.ToTable());
                                dvFilterBySplit.RowFilter = string.Format("Condition='{0}'", dr["Condition"].ToString());
                                string dataForsplit = tempData.Replace(dr["Condition"].ToString(), "")
                                                                                .Replace("|", "")
                                                                                .Replace(":/", "")
                                                                                .Replace("}", "")
                                                                                .Replace("{", "").Trim();
                                foreach (DataRowView drForsplite in dvFilterBySplit)
                                {
                                    int maxLength = Converting.StringToInt(drForsplite["PositionLength"].ToString());

                                    newRow[drForsplite["ColumnName"].ToString()] = dataForsplit.Substring(Converting.StringToInt(drForsplite["StartPosition"].ToString())
                                                                                                   , maxLength == 0 ? ((dataForsplit.Length) - (Converting.StringToInt(drForsplite["StartPosition"].ToString()))) : maxLength);

                                }



                            }

                            else
                            {
                                newRow[dr["ColumnName"].ToString()] = tempData.Replace(dr["Condition"].ToString(), "")
                                                                                  .Replace("|", "")
                                                                                 .Replace(":/", "")
                                                                                .Replace("}", "")
                                                                                .Replace("{", "").Trim();
                            }
                            break;
                        }
                        else if (dr["ParentID"].ToString() != ""
                            && mParent != ""
                            && tempData.IndexOf("| :") == -1) //  :50K:
                        {
                            DataView dvFilterByParent = new DataView(dvCol.ToTable());
                            dvFilterByParent.RowFilter = string.Format("ParentID='{0}'", mParent);
                            foreach (DataRowView drForsplite in dvFilterByParent)
                            {
                                if (string.Format("{0}{1}", mCondition, stRow) == drForsplite["Condition"].ToString())
                                {
                                    newRow[drForsplite["ColumnName"].ToString()] = tempData.Replace(drForsplite["Condition"].ToString(), "")
                                                                            .Replace("|", "")
                                                                                 .Replace(":/", "")
                                                                                .Replace("}", "")
                                                                                .Replace("{", "").Trim();
                                    break;
                                }

                            }

                            stRow++;
                            break;

                        }

                    }
                }


                if (tempData.IndexOf("|---------------------------------------") > -1 && lockRecord) // is in coming data ?
                {
                    dataTable.Rows.Add(newRow);
                    lockRecord = false;
                }

            }

            #endregion

            return dataTable;
        }


    }
}
