using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO.Amlo.Trans;
using DAL;
using DTO.Util;
namespace DAL.Amlo.Trans
{
    public class TransactionMasterDAL : AmloBase
    {
        List<TransactionMasterDTO> objList = null;
        bool isCan = false;
        public TransactionMasterDAL()
        {

        }

        public override bool Add(DataTable dt)
        {

            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_T_Transaction_Insert", dt);
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
            throw new NotImplementedException();
        }

        public override DataTable FindByAll()
        {
            throw new NotImplementedException();
        }

        public override DataTable FindByColumn(DataTable dt)
        {
            throw new NotImplementedException();
        }


        public List<TransactionMasterDTO> FindByObjList(object data)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            objList = new List<TransactionMasterDTO>();
           
            string procName = "sp_GetTransaction_FindByAll";
            try
            {
           
                adapter = new SqlDataAdapter();
                SqlConnection conn = OpenConection();
                if (data != null)
                {

                    parameterList.AddRange(GetParameters(procName, data).ToArray());
                }
                command = new SqlCommand(procName, conn);
                command.CommandType = CommandType.StoredProcedure;
                if (data != null)
                {



                    command.Parameters.AddRange(parameterList.ToArray());
                }



                using (SqlDataReader reader = command.ExecuteReader())
                {
                    objList = Converting.GetListFromDataReader<TransactionMasterDTO>(reader).ToList();
                }



                }
            catch (Exception ex) { }
            finally
            {
                CloseConnection();
            }
            return objList;
        }

        public override bool Update(DataTable dt)
        {
            throw new NotImplementedException();
        }

    
    }
}
