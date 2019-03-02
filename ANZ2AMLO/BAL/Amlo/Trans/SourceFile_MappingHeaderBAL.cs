using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DAL.Amlo.Trans;
using System.Data;
using DTO.Amlo.Trans;
using DTO.Util;
using DAL.Amlo;
namespace BAL.Amlo.Trans
{
    public class SourceFile_MappingHeaderBAL : BALBase
    {
        bool isCan = false;
        SourceFile_MappingHeaderDAL dao = null;
        UtilDAL utilDAL = null;
        DataTable dt = null;
        DataRow dr = null;
        public SourceFile_MappingHeaderBAL()
        {

            dao = new SourceFile_MappingHeaderDAL();
        }

        public override bool Action()
        {
            //switch (myPage.Request.Form["status"])
            //{
            //    case "add": isCan = Add(); break;
            //    case "update": isCan = Update(); break;
            //    case "delete": isCan = Delete(); break;

            //}
            return isCan;
        }

        public bool Action(string HID, string ReportCode, string ReportName, string Condition1, string Condition2,
                           string Condition3, string Condition4, string ImportFolder, string BackUpFolder, string LogFolder,
                           string OutputFolder, bool rowState, string UserLogin, PAction action)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["HID"] = HID;
            dr["ReportCode"] = ReportCode;
            dr["ReportName"] = ReportName;
            dr["Condition1"] = Condition1;
            dr["Condition2"] = Condition2;
            dr["Condition3"] = Condition3;
            dr["Condition4"] = Condition4;
            dr["ImportFolder"] = ImportFolder;
            dr["BackUpFolder"] = BackUpFolder;
            dr["LogFolder"] = LogFolder;
            dr["OutputFolder"] = OutputFolder;
            dr["ROW_STATE"] = rowState ? "1" : "0";
            dr["CREATE_BY"] = UserLogin;
            dr["UPDATE_BY"] = UserLogin;
            dt.Rows.Add(dr);
            switch (action)
            {
                case PAction.Add: isCan = Add(); break;
                case PAction.Update: isCan = Update(); break;
                case PAction.Delete: isCan = Delete(); break;
            }
            return isCan;
        }

        public override DataTable FindByAll()
        {

            return dao.FindByAll();
        }


        public  DataTable FindByKeyWord(string keyWord)
        {

            return dao.FindByKeyWord(keyWord);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="createDate">Datetime</param>
        /// <returns></returns>
        public DataTable FindByKeyWord(string keyWord,string createDate)
        {

            return dao.FindByKeyWord(keyWord, createDate);
        }

        public DataTable FindByKeyWord(string keyWord, DateTime createDate)
        {

            string yyyyMMdd = string.Format("{0}{1}{2}", createDate.Year.ToString(),createDate.Month.ToString("##00"), createDate.Day.ToString("##00"));
            return dao.FindByKeyWord(keyWord, yyyyMMdd);
        }
        public DataSet   FindByKeyWord(string keyWord, DateTime createDate,string DID)
        {

            string yyyyMMdd = string.Format("{0}{1}{2}", createDate.Year.ToString(), createDate.Month.ToString("##00"), createDate.Day.ToString("##00"));
            return dao.FindByKeyWord(keyWord, yyyyMMdd, DID);
        }
        public DataTable GetDropDownList()
        {
            utilDAL = new UtilDAL();
            return utilDAL.GetDropDownList("SourceFile_MappingHeader");
        }


        public bool Action(List<SourceFile_MappingHeaderDto> objectList)
        {



            try
            {
               // dao.Add(objectList);
            }
            catch (Exception ex)
            {

                Log("SourceFile_MappingHeaderBAL.Action", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }





      
        public override DataTable FindByColumn(object dto)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["Name"] = "";
            return dao.FindByColumn(dt);
        }

        public  DataSet FindHeaderAndDetailPK(string HID, string userName)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["HID"] = HID;
            dr["UPDATE_BY"] = userName;
            dt.Rows.Add(dr);
            return dao.FindHeaderAndDetailPK(dt);
        }



        /// <summary>
        /// active =1 /0 if active is empty then show all
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public DataTable FindByColumn(string name, string active)
        {
            dt = SourceFile_MappingHeaderDto.Data();
            dr = dt.NewRow();
            dr["ReportName"] = name;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindByColumn(dt);
        }

        protected override bool Add()
        {

            try
            {
                isCan = dao.Add(dt);
            }
            catch (Exception ex)
            {

                Log("PER_MENU_PERMISSIONBL.Add", "High", ex.ToString());
            }
            finally
            { }
            return isCan;


        }

        protected override bool Update()
        {

            try
            {
                isCan = dao.Update(dt);
            }
            catch (Exception ex)
            {

                Log("PER_MENU_PERMISSIONBL.Update", "High", ex.ToString());
            }
            finally
            { }

            return isCan;

        }

        protected override bool Delete()
        {

            try
            {
                isCan = dao.Delete(dt);
            }
            catch (Exception ex)
            {

                Log("PER_MENU_PERMISSIONBL.Delete", "High", ex.ToString());
            }
            finally
            { }


            return isCan;

        }
    }
}
