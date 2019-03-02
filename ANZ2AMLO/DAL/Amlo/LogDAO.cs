using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAL.Amlo
{
    public class LogDAO : AmloBase
    {
        public override bool Add(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_M_Log_Insert", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }

           
            return isCan;
        }

        public  bool Add(object dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_M_Log_Insert", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }


            return isCan;
        }

        public override bool Update(DataTable data)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(DataTable data)
        {
            throw new NotImplementedException();
        }

        public override System.Data.DataTable FindByAll()
        {
            throw new NotImplementedException();
        }

        public override System.Data.DataTable FindByColumn(DataTable data)
        {
            throw new NotImplementedException();
        }
    }
}
