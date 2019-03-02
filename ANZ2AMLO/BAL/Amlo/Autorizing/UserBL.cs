using System;
using System.Data;
using System.Configuration;
using System.Web;

using BL;
using DTO.Util;
using DTO.Amlo.Autorizing;
using DAL.Amlo.Autorizing;

namespace BAL.Amlo.Autorizing
{
    /// <summary>
    /// Summary description for XCustomerBL
    /// </summary>
    public class UserBL : BALBase
    {
        bool isCan = false;
        UserDAL dao = null;
        DataTable dt=null;
        DataRow dr = null;
        public UserBL()
        {
            dao = new UserDAL();
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
        
        public  bool Action(string USER_OID
                            ,string USERGROUP_OID
                            ,string USER_LOGIN
                            ,string FName
                            ,string LName
                            ,string Position
                            ,string Addr1
                            ,string Telephone
                            ,string Email
                            ,string PASSWORD
                            ,bool rowState
                            ,string userLogin
                            ,PAction action )
        {
            dt = UserDto.Data();
            dr = dt.NewRow();
            dr["USER_OID"] =USER_OID;
            dr["USERGROUP_OID"] =USERGROUP_OID;
            dr["USER_LOGIN"] =USER_LOGIN;
            dr["FName"] =FName;
            dr["LName"] = LName; 
            dr["Position"] =Position;
            dr["Addr1"] = Addr1;
            dr["Telephone"] = Telephone;
            dr["Email"] =Email;
            dr["PASSWORD"] =PASSWORD;
            dr["MAX_SESSION"] ="";
            dr["SESSION_TIME_OUT"]="" ;
            dr["CREATE_BY"] =userLogin;
            dr["CREATE_DATE"] ="";
            dr["UPDATE_BY"] =userLogin;
            dr["UPDATE_DATE"] = "";
            dr["ROW_STATE"]  = rowState?"1":"0";
            dr["Active"] ="";
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
            dt=UserDto.Data();
            dr = dt.NewRow();
            dr["FName"] = "";
            return dao.FindByColumn(dt);
        }

        /// <summary>
        /// active =1 /0 if active is empty then show all
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public  DataTable FindByColumn(string fname,string usergroup_OID ,string active)
        {
            dt = UserDto.Data();
            dr = dt.NewRow();
            dr["FName"] = fname;
            dr["USERGROUP_OID"] = usergroup_OID;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindByColumn(dt);
        }



        public  DataTable FindByPK(string User_Oid)
        {
            dt = UserDto.Data();
            dr = dt.NewRow();
            dr["USER_OID"] = User_Oid;
            dt.Rows.Add(dr);
            return dao.FindByPK(dt);
        }

        public DataTable UserLogin(string userName,string password)
        {
            dt = UserDto.Data();
            dr = dt.NewRow();
            dr["USER_LOGIN"] = userName;
            dr["PASSWORD"] = password;
            dt.Rows.Add(dr);
            return dao.FindByUserLogin(dt);
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
            dr["FName"] = "";
            return dao.FindByColumn(dt);
        }
    }
}
