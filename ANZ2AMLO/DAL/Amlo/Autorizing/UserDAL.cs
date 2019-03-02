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
    public class UserDAL : AmloBase
    {
        bool isCan = false;
        public UserDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_USER_Insert", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }

        public override bool Update(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_PER_USER_Update", dt);
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
                ExcecuteNoneQuery("sp_PER_USER_Delete", dt);
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
                dtObj = ExcecuteToDataTable("sp_PER_USER_FindByAll", new DataTable());
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
                dtObj = ExcecuteToDataTable("sp_PER_USER_FindByColumn", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }


        public DataTable FindByPK(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_USER_FindByPK", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }

        public DataTable FindByUserLogin(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_PER_USER_Login", dt);
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
