using System;
using System.Data;
using System.Configuration;
using System.Web;
using DAL.Amlo.Autorizing;
using DTO.Amlo.Autorizing;
using DTO.Util;
using BL;

namespace BAL.Amlo.Autorizing
{
    /// <summary>
    /// Summary description for XCustomerBL
    /// </summary>
    public class UserGroupBL : BALBase
    {
        bool isCan = false;
        UserGroupDAL dao = null;
        DataTable dt=null;
        DataRow dr = null;
        public UserGroupBL()
        {
            dao = new UserGroupDAL();
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


        public  bool Action(string USERGROUP_OID,string Name,string Desc,string UserLogin,bool rowState,PAction action )
        {
          /* 
           * [USERGROUP_OID], 
	[Name], 
	[Desc], 
	[CREATE_BY], 
	[CREATE_DATE], 
	[UPDATE_BY], 
	[UPDATE_DATE], 
	[ROW_STATE]*/
            dt = UserGroupDto.Data();
            dr = dt.NewRow();
            dr["USERGROUP_OID"] = USERGROUP_OID;
            dr["Name"] = Name;
            dr["Desc"] = Desc;
            dr["CREATE_BY"] = UserLogin;
	dr["CREATE_DATE"] = "";
    dr["UPDATE_BY"] = UserLogin; 
	dr["UPDATE_DATE"] = "";
    dr["ROW_STATE"] = rowState?"1":"0";
    dt.Rows.Add(dr);
            switch (action)
            {
                case  PAction.Add: isCan = Add(); break;
                case PAction.Update: isCan = Update(); break;
                case PAction.Delete: isCan = Delete(); break;

            }
            return isCan;
        }



        public override DataTable FindByAll()
        {
            return dao.FindByAll();
        }

        public DataTable FindByColumn( )
        {
            dt=UserGroupDto.Data();
            dr = dt.NewRow();
            dr["Name"] = "";
            return dao.FindByColumn(dt);
        }

        /// <summary>
        /// active =1 /0 if active is empty then show all
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public  DataTable FindByColumn(string name,string active)
        {
            dt = UserGroupDto.Data();
            dr = dt.NewRow();
            dr["Name"] = name;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindByColumn(dt);
        }

        protected override bool Add()
        {
            return dao.Add(dt);
        }

        protected override bool Update()
        {
            return dao.Update(dt);
        }

        protected override bool Delete()
        {
            return dao.Delete(dt);
        }

        public override DataTable FindByColumn(object obj)
        {
            DataTable dt = (DataTable)obj;
            dr = dt.NewRow();
            dr["Name"] = "";
            return dao.FindByColumn(dt);
        }
    }
}
