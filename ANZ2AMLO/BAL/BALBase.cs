using System;
using System.Data;
using System.Configuration;
using DAL.Amlo;
using DTO.Amlo;

namespace BL
{
    /// <summary>
    /// Summary description for XBLBase
    /// </summary>
    public abstract class BALBase
    {
        static string System = "Amlo";
        public BALBase()
        {

        }

        public abstract bool Action();
        public abstract DataTable FindByAll();
        public abstract DataTable FindByColumn(object obj);

        protected abstract bool Add();
        protected abstract bool Update();
        protected abstract bool Delete();


        public static void Log(string pageName, string level, string message)
        {
            LogDAO logDAO = new LogDAO();
            LogDTO dto = new LogDTO();
            dto.System = System;
            dto.Page = pageName;
            dto.Level = level;
            dto.Message = message;
            logDAO.Add(dto);
        }

        protected DataTable ConvertPageToDataTable(DataTable dt)
        {
            DataRow dr = dt.NewRow();
            //dt.Rows.Add(dr);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        row[col.ColumnName] = myPage.Request.Form[col.ColumnName] != null ? myPage.Request.Form[col.ColumnName] : "";

            //    }
            //}
            return dt;
        }



    }
}
