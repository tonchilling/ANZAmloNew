using System;
using System.Data;
using DTO.Util;
using DAL.Amlo.Autorizing;
using DTO.Amlo.Autorizing;

namespace BL.Amlo.Autorizing
{
    /// <summary>
    /// Summary description for XCustomerBL
    /// </summary>
    public class MenuGroupBL : BALBase
    {
        bool isCan = false;
        MenuGroupDAL dao = null;
        DataTable dt=null;
        DataRow dr = null;
        public MenuGroupBL()
        {

            dao = new MenuGroupDAL();
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

        public bool Action(string MENU_OID, string MENUGROUP_OID, string Name, string DESC
                      , string SCREEN, string LINK,  string UserLogin, bool rowState, PAction action)
        {
            /* 
             * [MENU_OID]
      ,[OrderNo]
      ,[MENUGROUP_OID]
      ,[Name]
      ,[DESC]
      ,[SCREEN]
      ,[LINK]
      ,[PMENU_OID]
      ,[CREATE_BY]
      ,[CREATE_DATE]
      ,[UPDATE_BY]
      ,[UPDATE_DATE]
      ,[ROW_STATE]*/
            dt = MenuGroupDto.Data();
            dr = dt.NewRow();
            dr["MENU_OID"] = MENU_OID;
            dr["OrderNo"] = 0;
            dr["MENUGROUP_OID"] = MENUGROUP_OID;
            dr["Name"] = Name;
            dr["Desc"] = DESC;
            dr["SCREEN"] = SCREEN;
            dr["LINK"] = LINK;
            dr["Icon"] = "";
            dr["PMENU_OID"] = MENUGROUP_OID;
            dr["CREATE_BY"] = UserLogin;
            dr["CREATE_DATE"] = "";
            dr["UPDATE_BY"] = UserLogin;
            dr["UPDATE_DATE"] = "";
            dr["ROW_STATE"] = rowState ? "1" : "0";
            dt.Rows.Add(dr);
            switch (action)
            {
                case PAction.Add: isCan = Add(); break;
                case PAction.Update: isCan = Update(); break;
                case PAction.Delete: isCan = Delete(); break;

            }
            return isCan;
        }

        public bool Action(string MENU_OID, string MENUGROUP_OID, string Name, string DESC
                          ,string SCREEN,string LINK,string IconName, string UserLogin, bool rowState, PAction action)
        {
            /* 
             * [MENU_OID]
      ,[OrderNo]
      ,[MENUGROUP_OID]
      ,[Name]
      ,[DESC]
      ,[SCREEN]
      ,[LINK]
      ,[PMENU_OID]
      ,[CREATE_BY]
      ,[CREATE_DATE]
      ,[UPDATE_BY]
      ,[UPDATE_DATE]
      ,[ROW_STATE]*/
            dt = MenuGroupDto.Data();
            dr = dt.NewRow();
            dr["MENU_OID"] = MENU_OID;
            dr["OrderNo"] = 0;
            dr["MENUGROUP_OID"] = MENUGROUP_OID;
            dr["Name"] = Name;
            dr["Desc"] = DESC;
            dr["SCREEN"] = SCREEN;
            dr["LINK"] = LINK;
            dr["Icon"] = IconName;
            dr["PMENU_OID"] =MENUGROUP_OID;
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

        public  DataTable FindMenuPermissionByUserGroup(string userGroupOID)
        {
            dt = MenuGroupDto.Data();
            dr = dt.NewRow();
            dr["USERGROUP_OID"] = userGroupOID;
            dt.Rows.Add(dr);
            return dao.FindMenuPermissionByUserGroup(dt);
        }

        public DataTable FindByColumn( )
        {
            dt = MenuGroupDto.Data();
            dr = dt.NewRow();
            dr["Name"] = "";
            return dao.FindByColumn(dt);
        }

        public  DataTable FindMainMenu()
        {
          
            return dao.FindMainMenu();
        }

        public DataTable FindMenu(string name,string mainMenu, string active)
        {

            dt = MenuGroupDto.Data();
            dr = dt.NewRow();
            dr["Name"] = name;
            dr["MENUGROUP_OID"] = mainMenu;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindMenu(dt);
        }



        /// <summary>
        /// active =1 /0 if active is empty then show all
        /// </summary>
        /// <param name="name"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public  DataTable FindByColumn(string name,string active)
        {
            dt = MenuGroupDto.Data();
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
            return dao.FindByColumn(dt);
        }
    }
}
