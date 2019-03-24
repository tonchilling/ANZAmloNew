using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.Spreadsheet;
using DTO.Util;
using DTO.Amlo.Importing;
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
                   // ConvertInOut2(dataTable, dvCol, worksheet, startRow, "{2:I");
                    dataTable = ConvertInOut2(dataTable, dvCol, worksheet, startRow, "{2:I");
                    #endregion
                    break;
                case "incoming":
                    dataTable = ConvertInOut2(dataTable, dvCol, worksheet, startRow, "{2:O");
                    //  dataTable = ConvertInOut(dataTable, dvCol, worksheet, startRow, "{2:O");
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
            string condition = "";
            string replaceCondition = "";
            string header = "";
            string conditionSection = "";
            DataRow newRow = null;
            Range rangeAll = worksheet.GetDataRange();
            #region incoming case
            for (int i = startRow; i <= rangeAll.RowCount - 1; i++)
            {

                tempData = worksheet.Cells[i, 0].DisplayText;
                if (tempData.IndexOf(keyType) >-1) // is in coming data ?
                {
                    header = tempData;
                    newRow = dataTable.NewRow();
                    lockRecord = true;
                }


                if (lockRecord)
                {

                    foreach (DataRowView dr in dvCol)
                    {
                        if (header.IndexOf("| {2:O103") > -1)
                        {

                        }
                        else if (header.IndexOf("| {2:O202") > -1)
                        {
                            conditionSection = "2";
                        }
                        condition = dr["Condition"+ conditionSection].ToString();
                        replaceCondition = condition;
                        bool hasData = false;

                        hasData = tempData.IndexOf(condition) > -1;

                       

                      /*  if (!hasData && condition.IndexOf("50K") > -1 && dr["ParentID"].ToString() == "")
                        {
                            hasData = tempData.IndexOf(":50F:") > -1;
                            if (hasData)
                            {
                                replaceCondition = condition.Replace("50K", "50F");
                            }

                            hasData = tempData.IndexOf(":52A:") > -1;

                            if (hasData)
                            {
                                replaceCondition = condition.Replace("50K", "52A");
                            }


                        }*/

                        replaceCondition = replaceCondition.Replace("/","");





                        if (hasData
                            ) // is in coming data ?
                        {

                            if (DTO.Util.Converting.StringToInt(dr["TotalRow" + conditionSection].ToString()) > 0)
                            {
                                mParent = string.Format("{0}{1}", dr["DID"].ToString(), dr["No"].ToString());
                                mCondition = condition;
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
                                dvFilterBySplit.RowFilter = string.Format("Condition='{0}'", condition);
                                string dataForsplit = tempData.Replace(replaceCondition.ToString(), "")
                                                                                .Replace("|", "")
                                                                                .Replace(":/", "")
                                                                                .Replace("}", "")
                                                                                .Replace("{", "").Trim();
                                foreach (DataRowView drForsplite in dvFilterBySplit)
                                {
                                    int maxLength = Converting.StringToInt(drForsplite["PositionLength" + conditionSection].ToString());

                                    newRow[drForsplite["ColumnName"].ToString()] = dataForsplit.Substring(Converting.StringToInt(drForsplite["StartPosition"].ToString())
                                                                                                   , maxLength == 0 ? ((dataForsplit.Length) - (Converting.StringToInt(drForsplite["StartPosition"].ToString()))) : maxLength);

                                }



                            }

                            else
                            {
                                newRow[dr["ColumnName"].ToString()] = tempData.Replace(replaceCondition, "")
                                                                                  .Replace("|", "")
                                                                                 .Replace(":/", "")
                                                                                .Replace("}", "")
                                                                                .Replace("{", "").Trim();
                            }
                            break;
                        }
                        else if (dr["ParentID"].ToString() != ""
                            && mParent != ""
                            && tempData.IndexOf("| :") == -1
                            && tempData.IndexOf("| {") == -1
                            && tempData.IndexOf("| -") == -1) //  :50K:
                        {
                            DataView dvFilterByParent = new DataView(dvCol.ToTable());
                            dvFilterByParent.RowFilter = string.Format("ParentID='{0}'", mParent);
                            foreach (DataRowView drForsplite in dvFilterByParent)
                            {
                                if (string.Format("{0}{1}", mCondition, stRow) == drForsplite["Condition"].ToString())
                                {
                                    newRow[drForsplite["ColumnName"].ToString()] = tempData.Replace(replaceCondition, "")
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

        static DataTable ConvertInOut2(DataTable dataTable,
                                      DataView dvCol,
                                   Worksheet worksheet, int startRow, string keyType)
        {
            string tempData = "", mParent = "", mCondition = "";
            bool lockRecord = false;
            int totalRow = 0, stRow = 1; ;
            string condition = "";
            string realData = "";
            string replaceCondition = "";
            string header = "", tranCode = "" ;
            string conditionSection = "";
            List<ImportExcelToArray> listData = new List<ImportExcelToArray>();
            DataRow newRow = null;
            ImportExcelToArray data = null;
            Range rangeAll = worksheet.GetDataRange();
            #region incoming case


            #region Keep data
            for (int i = startRow; i <= rangeAll.RowCount - 1; i++)
            {

                tempData = worksheet.Cells[i, 0].DisplayText;
                if (tempData.IndexOf(keyType) > -1) // is in coming data ?
                {
                    if (tempData.IndexOf("{2:O") > -1)
                    {
                        if (tempData.IndexOf("| {2:O103") > -1 || tempData.IndexOf("| {2:O202") > -1)
                        {
                            header = tempData;

                            data = new ImportExcelToArray();
                            data.Header = header;
                            lockRecord = true;
                        }
                    }
                    else if (tempData.IndexOf("{2:I") > -1)
                    {
                        if (tempData.IndexOf("| {2:I103") > -1 || tempData.IndexOf("| {2:I202") > -1)
                        {
                            header = tempData;

                            data = new ImportExcelToArray();
                            data.Header = header;
                            lockRecord = true;
                        }
                    }
                }






                if (lockRecord)
                {
                    if (tempData.IndexOf("|---------------------------------------") == -1)
                    {
                        data.Detail.Add(tempData);
                    }

                }


                if (tempData.IndexOf("|---------------------------------------") > -1 && lockRecord) // is in coming data ?
                {
                    listData.Add(data);
                    lockRecord = false;
                }

            }
            #endregion

            if (listData != null && listData.Count > 0)
            {
                foreach (ImportExcelToArray dataArr in listData)

                {
                    if (dataArr.Header.IndexOf("| {2:O103") > -1 || dataArr.Header.IndexOf("| {2:I103") > -1)
                    {
                        conditionSection = "";
                        tranCode = dataArr.Header.Split(':')[1].Substring(0,4);
                    }
                    else if (dataArr.Header.IndexOf("| {2:O202") > -1 || dataArr.Header.IndexOf("| {2:I202") > -1)
                    {
                        tranCode = dataArr.Header.Split(':')[1].Substring(0, 4);
                        conditionSection = "2";
                    }


                    newRow = dataTable.NewRow();

                    //  foreach (string dataExcel in dataArr.Detail)

                    //  {

                    //   DataView dvH= dvCol.RowFilter=""
                    dvCol.RowFilter = string.Format("isnull(ParentID,'')='' and DID='{0}'", dvCol[0]["DID"].ToString());
                    DataView dvH = dvCol;

                    foreach (DataRowView dr in dvH)
                    {
                        condition = dr["Condition" + conditionSection].ToString();
                        replaceCondition = condition;
                        int start = dataArr.Detail.FindIndex(s => s.IndexOf(condition) > -1);

                        if (start > -1)
                        {


                            if (DTO.Util.Converting.StringToInt(dr["TotalRow" + conditionSection].ToString()) > 0)
                            {
                                DataView dvFilterBySplit = new DataView(dvCol.Table);
                                dvFilterBySplit.RowFilter = string.Format("ParentID='{0}'", string.Format("{0}{1}", dr["DID"].ToString(), dr["No"].ToString()));

                                realData = GetRealData(dataArr.Detail[start]);

                                newRow[dr["ColumnName"].ToString()] = (dr["ColumnName"].ToString() == "TransactionCode" ? tranCode : "") + realData.Replace(replaceCondition, "")
                                                                                   .Replace("|", "")
                                                                                  .Replace(":/", "")
                                                                                 .Replace("}", "")
                                                                                 .Replace("{", "").Trim();

                                foreach (DataRowView drForsplite in dvFilterBySplit)
                                {
                                    int maxLength = Converting.StringToInt(drForsplite["PositionLength" + conditionSection].ToString());
                                    start++;

                                    if (dataArr.Detail[start].IndexOf("|    ") > -1)
                                    {
                                        realData = GetRealData(dataArr.Detail[start]);
                                        newRow[drForsplite["ColumnName"].ToString()] = realData.Replace(replaceCondition, "")
                                                                                               .Replace("|", "")
                                                                                              .Replace(":/", "")
                                                                                             .Replace("}", "")
                                                                                             .Replace("{", "").Trim();
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    // newRow[drForsplite["ColumnName"].ToString()] = dataForsplit.Substring(Converting.StringToInt(drForsplite["StartPosition"].ToString())
                                    //                                                                , maxLength == 0 ? ((dataForsplit.Length) - (Converting.StringToInt(drForsplite["StartPosition"].ToString()))) : maxLength);

                                }

                            }
                            else if (dr["StartPosition"].ToString() != "") // :32A: TransactionDate-6-YYMMDD/ CurrecyCode-3/ CurrAmount
                            {
                                DataView dvFilterBySplit = new DataView(dvCol.Table);
                                dvFilterBySplit.RowFilter = string.Format("ParentID='{0}'", string.Format("{0}{1}", dr["DID"].ToString(), dr["No"].ToString()));

                                realData = GetRealData(dataArr.Detail[start]);

                                string dataForsplit = realData.Replace(replaceCondition.ToString(), "")
                                                                                .Replace("|", "")
                                                                                .Replace(":/", "")
                                                                                .Replace("}", "")
                                                                                .Replace("{", "").Trim();
                                int maxLength = Converting.StringToInt(dr["PositionLength" + conditionSection].ToString());

                                newRow[dr["ColumnName"].ToString()] = dataForsplit.Substring(Converting.StringToInt(dr["StartPosition"].ToString())
                                                                                                   , maxLength == 0 ? ((dataForsplit.Length) - (Converting.StringToInt(dr["StartPosition"].ToString()))) : maxLength);


                                foreach (DataRowView drForsplite in dvFilterBySplit)
                                {
                                     maxLength = Converting.StringToInt(drForsplite["PositionLength" + conditionSection].ToString());
                                    realData = GetRealData(dataForsplit);
                                    newRow[drForsplite["ColumnName"].ToString()] = realData.Substring(Converting.StringToInt(drForsplite["StartPosition"].ToString())
                                                                                                   , maxLength == 0 ? ((dataForsplit.Length) - (Converting.StringToInt(drForsplite["StartPosition"].ToString()))) : maxLength);

                                }



                            }
                            else {

                                realData = GetRealData(dataArr.Detail[start]);
                                newRow[dr["ColumnName"].ToString()] = (dr["ColumnName"].ToString() == "TransactionCode" ? tranCode : "") + realData.Replace(replaceCondition, "")
                                                                                     .Replace("|", "")
                                                                                    .Replace(":/", "")
                                                                                   .Replace("}", "")
                                                                                   .Replace("{", "").Trim();
                            }

                        }

                    }


                    dataTable.Rows.Add(newRow);

                }

              

               
            }

            #endregion

            return dataTable;
        }

        static string GetRealData(string data)
        {
            string result = data;

            try
            {
                result = data.Split(':').Length == 3 ? (data.Split(':')[2].Split('/').Length > 1 ? data.Split(':')[2].Split('/')[1] : data.Split(':')[2])
                                  : data.Split('/').Length==2 ? data.Split('/')[1]: data;

            }
            catch { }
            finally { }
            return result;
        }
    }


  
}
