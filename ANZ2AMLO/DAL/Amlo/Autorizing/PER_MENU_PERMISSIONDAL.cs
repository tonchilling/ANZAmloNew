using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using DAL;
using DTO.Amlo.Autorizing;
using System.Data.SqlClient;
namespace DAL.Amlo.Autorizing
{
    /// <summary>
    /// Summary description for XCustomerDAO
    /// </summary>
    public class PER_MENU_PERMISSIONDAL : AmloBase
    {
        bool isCan = false;
        public PER_MENU_PERMISSIONDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_MENU_PERMISSION_Insert", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }

        public  bool Add(List<PER_MENU_PERMISSIONDto> objList)
        {

            List<SqlParameter> paramList = new List<SqlParameter>();

            /*@USERGROUP_MENU_OID_1 [nvarchar](50), 
	@USERGROUP_OID_2 [nvarchar](50), 
	@MENU_OID_3 [nvarchar](50), 
	@VIEW_4 [nvarchar](50), 
	@DELETE_5 [nvarchar](50), 
	@EDIT_6 [nvarchar](50), 
	@CREATE_BY_7 [nvarchar](50), 
	@CREATE_DATE_8 [nvarchar](25), 
	@UPDATE_BY_9 [nvarchar](50), 
	@UPDATE_DATE_10 [nvarchar](25), 
	@ROW_STATE_11 [nchar]*/


            isCan = false;

            try
            {
              

                OpenConection();

                foreach (PER_MENU_PERMISSIONDto obj in objList)
                {
                    paramList = new List<SqlParameter>();

                    paramList.Add(new SqlParameter("@USERGROUP_OID_1", obj.USERGROUP_OID));
                    paramList.Add(new SqlParameter("@MENU_OID_2", obj.MENU_OID));
                    paramList.Add(new SqlParameter("@VIEW_3", obj.VIEW));
                    paramList.Add(new SqlParameter("@DELETE_4", obj.DELETE));
                    paramList.Add(new SqlParameter("@EDIT_5", obj.EDIT));
                    paramList.Add(new SqlParameter("@CREATE_BY_6", obj.CREATE_BY));
                    paramList.Add(new SqlParameter("@CREATE_DATE_7", obj.CREATE_DATE));
                    paramList.Add(new SqlParameter("@UPDATE_BY_8", obj.UPDATE_BY));
                    paramList.Add(new SqlParameter("@UPDATE_DATE_9", obj.UPDATE_DATE));
                    paramList.Add(new SqlParameter("@ROW_STATE_10", obj.ROW_STATE));
                    ExcecuteNoneQuery("sp_PER_MENU_PERMISSION_Insert", paramList);
                }


                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }

        public void Save(string userGroupID, List<PER_MENU_PERMISSIONDto> objList)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();

            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = OpenConection();
                transaction = conn.BeginTransaction();

                paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@USERGROUP_OID", userGroupID));

                ExcecuteNoneQuery("sp_PER_MENU_PERMISSION_DeleteByGroup", paramList, conn, transaction);

                foreach (PER_MENU_PERMISSIONDto obj in objList)
                {
                    paramList = new List<SqlParameter>();

                    paramList.Add(new SqlParameter("@USERGROUP_OID_1", obj.USERGROUP_OID));
                    paramList.Add(new SqlParameter("@MENU_OID_2", obj.MENU_OID));
                    paramList.Add(new SqlParameter("@VIEW_3", obj.VIEW));
                    paramList.Add(new SqlParameter("@DELETE_4", obj.DELETE));
                    paramList.Add(new SqlParameter("@EDIT_5", obj.EDIT));
                    paramList.Add(new SqlParameter("@CREATE_BY_6", obj.CREATE_BY));
                    paramList.Add(new SqlParameter("@CREATE_DATE_7", obj.CREATE_DATE));
                    paramList.Add(new SqlParameter("@UPDATE_BY_8", obj.UPDATE_BY));
                    paramList.Add(new SqlParameter("@UPDATE_DATE_9", obj.UPDATE_DATE));
                    paramList.Add(new SqlParameter("@ROW_STATE_10", obj.ROW_STATE));
                    ExcecuteNoneQuery("sp_PER_MENU_PERMISSION_Insert", paramList, conn, transaction);
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public override bool Update(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_MENU_PERMISSION_Update", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }

        public override bool Delete(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_MENU_PERMISSION_Delete", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }




        public override DataTable FindByAll()
        {

            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENU_PERMISSION_FindByAll", null);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }

        public  DataTable FindMenuPermissionByUserGroup (DataTable dt)
        {

            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENU_PERMISSION_FindByUserGroup",  dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }

        public override DataTable FindByColumn(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENU_PERMISSION_FindByColumn", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }
    }
}
