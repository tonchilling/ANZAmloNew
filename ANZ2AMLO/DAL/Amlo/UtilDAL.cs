using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAL.Amlo
{
    public class UtilDAL : AmloBase
    {
        public override bool Add(DataTable dt)
        {

            throw new NotImplementedException();
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

        public  System.Data.DataTable GetDropDownList(string tableName)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
     

                OpenConection();
                dtObj = ExcecuteToDataTable("sp_"+ tableName + "_Dropdownlist", null);

            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }
    }
}
