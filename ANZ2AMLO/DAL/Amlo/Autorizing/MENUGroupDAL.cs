using System;
using System.Data;
using System.Configuration;
using System.Web;

using DAL;
namespace DAL.Amlo.Autorizing
{
    /// <summary>
    /// Summary description for XCustomerDAO
    /// </summary>
    public class MenuGroupDAL : AmloBase
    {
        bool isCan = false;
        public MenuGroupDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_MENU_Insert", dt);
                isCan = true;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return isCan;
        }

        public override bool Update(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_MENU_Update", dt);
                isCan = true;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return isCan;
        }

        public override bool Delete(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_MENU_Delete", dt);
                isCan = true;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return isCan;
        }




        public  DataTable FindMainMenu()
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENUGROUP_FindByMainMenu", null);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }

        public DataTable FindMenu(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENU_FindMenu",  dt);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }



        public override DataTable FindByAll()
        {

            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENU_FindByAll",null);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
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
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }

        public override DataTable FindByColumn(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_MENU_FindByColumn", dt);                
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }
    }
}
