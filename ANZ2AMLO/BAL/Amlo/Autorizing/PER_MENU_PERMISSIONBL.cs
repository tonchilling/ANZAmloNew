using System;
using System.Data;
using System.Configuration;
using System.Web;

using BL;
using DAL.Amlo.Autorizing;
using DTO.Amlo.Autorizing;
using DTO.Util;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace BAL.Amlo.Autorizing
{
    /// <summary>
    /// Summary description for XCustomerBL
    /// </summary>
    public class PER_MENU_PERMISSIONBL : BALBase
    {
        bool isCan = false;
        PER_MENU_PERMISSIONDAL dao = null;
        DataTable dt=null;
        DataRow dr = null;
        public PER_MENU_PERMISSIONBL()
        {

            dao = new PER_MENU_PERMISSIONDAL();
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


        public bool Action(List<PER_MENU_PERMISSIONDto> objectList)
        {



            try
            {
                dao.Add(objectList);
             }
            catch (Exception ex)
            {

                Log("PER_MENU_PERMISSIONBL.Action", "High", ex.ToString());
            }
            finally
            { }
            return isCan;
        }

        public bool Save(string userGroupID, List<PER_MENU_PERMISSIONDto> objectList)
        {
            try
            {
                dao.Save(userGroupID, objectList);
            }
            catch (Exception ex)
            {
                Log("PER_MENU_PERMISSIONBL.Action", "High", ex.ToString());
                throw ex;
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

        public override DataTable FindByColumn(object obj )
        {
            dt = MenuGroupDto.Data();
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
            dt = MenuGroupDto.Data();
            dr = dt.NewRow();
            dr["Name"] = name;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindByColumn(dt);
        }

        protected override bool Add()
        {

            try
            {
                isCan= dao.Add(dt);
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
