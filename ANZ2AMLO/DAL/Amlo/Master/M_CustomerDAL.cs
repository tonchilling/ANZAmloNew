using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO.Amlo.Master;
using DAL;
using DTO.Util;
namespace DAL.Amlo.Master
{
    public class M_CustomerDAL : AmloBase
    {
        List<M_CustomerDTO> objList = null;
        bool isCan = false;
        public M_CustomerDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            throw new NotImplementedException();
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


        public List<M_CustomerDTO> FindByObjList(object data)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            objList = new List<M_CustomerDTO>();
        
            string procName = "sp_M_Customer_FindByColumn";
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
                    objList = Converting.GetListFromDataReader<M_CustomerDTO>(reader).ToList();



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

        public DataSet FindAccountAndAddress(DataTable dt)
        {
            isCan = false;
            DataSet dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteParamToDataSet("[sp_M_Customer_FindAccountAndAddress]", dt);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                CloseConnection();
            }
            return dtObj;
        }

        public void Update(DataTable custTb, DataTable custAccTb, DataTable custAddressTb)
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = OpenConection();
                transaction = conn.BeginTransaction();

                ExcecuteNoneQuery("sp_M_Customer_Update", conn, transaction, custTb);

                if(custAccTb != null)
                {
                    foreach(DataRow custAccDr in custAccTb.Rows)
                    {
                        DataTable custAccTmpDt = custAccTb.Clone();
                        custAccTmpDt.ImportRow(custAccDr);
                        ExcecuteNoneQuery("sp_M_Customer_Account_Update", conn, transaction, custAccTmpDt);
                    }
                }
                if(custAddressTb != null)
                {
                    foreach (DataRow custAddressDr in custAddressTb.Rows)
                    {
                        DataTable custAddressTmpDt = custAddressTb.Clone();
                        custAddressTmpDt.ImportRow(custAddressDr);
                        ExcecuteNoneQuery("sp_M_Customer_Address_Update", conn, transaction, custAddressTmpDt);
                    }
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
    }
}
