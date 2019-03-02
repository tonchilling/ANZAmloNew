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
    public class UserGroupDAL : AmloBase
    {
        bool isCan = false;
        public UserGroupDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_USERGROUP_Insert", dt);
                isCan = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return isCan;
        }

        public override bool Update(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_USERGROUP_Update", dt);
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
                ExcecuteNoneQuery("sp_PER_USERGROUP_Delete", dt);
                isCan = true;                
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return isCan;
        }

        public override DataTable FindByAll()
        {
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_USERGROUP_FindByAll", null);
                return dtObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }

        public override DataTable FindByColumn(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_USERGROUP_FindByColumn", dt);
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
