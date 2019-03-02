using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Configuration;  

using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Summary description for XDAOBase
    /// </summary>
    public abstract class AmloBase
    {
        string _conStr = "";

        protected bool isCan = false;
        protected SqlConnection connection = null;
        protected SqlCommand command = null;
        protected SqlDataAdapter adapter = null;
        protected SqlDataReader reader = null;
        protected List<SqlParameter[]> parameterList = null;

        public AmloBase()
        {
            //_conStr = System.Configuration.ConfigurationSettings.AppSettings["CurrentDB"];

            //  _conStr = System.Configuration.ConfigurationManager.ConnectionStrings["dbanz2amloConnectionString"].ConnectionString;

            _conStr = System.Configuration.ConfigurationManager.AppSettings["CurrentDB"];
        }

        public abstract bool Add(DataTable dt);
        public abstract bool Update(DataTable dt);
        public abstract bool Delete(DataTable dt);
        public abstract DataTable FindByAll();
        public abstract DataTable FindByColumn(DataTable dt);

        protected string SetConnection
        {
            set { _conStr = value; }
        }
        protected SqlConnection OpenConection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection = new SqlConnection(_conStr);
            connection.Open();
            return connection;

        }
        protected void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        protected void ExcecuteNoneQuery(string procName, SqlConnection conn, SqlTransaction transaction, DataTable dt)
        {
            parameterList = GetParameterList(procName, conn, transaction, dt);
            command = new SqlCommand(procName, conn, transaction);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter[] param in parameterList)
            {
                SqlParameter[] tempArr = new SqlParameter[param.Length];
                param.CopyTo(tempArr, 0);

                command.Parameters.Clear();
                command.Parameters.AddRange(tempArr);
                command.ExecuteNonQuery();
            }
        }
        protected bool ExcecuteNoneQuery(string procName, DataTable dt)
        {
            isCan = false;

            parameterList = GetParameterList(procName, dt);
            command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter[] param in parameterList)
            {
                SqlParameter[] tempArr = new SqlParameter[param.Length];
                param.CopyTo(tempArr,0);
                 
                command.Parameters.Clear();
                command.Parameters.AddRange(tempArr);
                command.ExecuteNonQuery();
                isCan = true;
            }
            return isCan;

        }

        protected bool ExcecuteNoneQueryByMulti(string procName, DataTable dt)
        {
            isCan = false;

            parameterList = GetParameterList(procName, dt);
            foreach (SqlParameter[] param in parameterList)
            {
                List<SqlParameter> tempParam = new List<SqlParameter>();
                param.CopyTo(tempParam.ToArray(), 1);
                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(tempParam.ToArray());
                command.ExecuteNonQuery();
                isCan = true;
            }
            return isCan;

        }

        protected bool ExcecuteNoneQuerys(string procName, DataTable dt)
        {
            isCan = false;

            parameterList = GetParameterList(procName, dt);
            foreach (SqlParameter[] param in parameterList)
            {
                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(param);
                command.ExecuteNonQuery();
                isCan = true;
            }
            return isCan;

        }

        protected bool ExcecuteNoneQueryObj(string procName, object dt)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            SqlParameter param = null;

            if (dt != null)
            {
                parameterList.AddRange(GetParameters(procName, dt).ToArray());
            }
            command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (dt != null)
            {
                //parameterList.Add(new SqlParameter("@ERROR_CODE", SqlDbType.Int));
                if (parameterList[parameterList.Count - 1].ParameterName == "@ERROR_CODE")
                {
                    parameterList[parameterList.Count - 1].Value = 0;
                }
                command.Parameters.AddRange(parameterList.ToArray());

            }
            command.ExecuteNonQuery();
            isCan = true;

            return isCan;
        }

        protected bool ExcecuteNoneQuery(string procName, object dt)
        {
            List<SqlParameter> parameterList = new List<SqlParameter>();
            SqlParameter param = null;

            if (dt != null)
            {
                parameterList.AddRange(GetParameters(procName, dt).ToArray());
            }
            command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (dt != null)
            {
                //parameterList.Add(new SqlParameter("@ERROR_CODE", SqlDbType.Int));
                if (parameterList[parameterList.Count - 1].ParameterName == "@ERROR_CODE")
                {
                    parameterList[parameterList.Count - 1].Value = 0;
                }
                command.Parameters.AddRange(parameterList.ToArray());

            }
            command.ExecuteNonQuery();
            isCan = true;

            return isCan;
        }


        protected object ExcecuteScalar(string procName, DataTable dt)
        {
            isCan = false;
            object result = null;
            parameterList = GetParameterList(procName, dt);
            foreach (SqlParameter[] param in parameterList)
            {
                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(param);
              result=  command.ExecuteScalar();
                isCan = true;
            }
            return result;

        }


        protected bool ExcecuteNoneQuery(string procName,List< SqlParameter> paramList)
        {
            isCan = false;

            command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter param in paramList)
            {
                
                command.Parameters.Add(param);
              
            }
            command.ExecuteNonQuery();
            isCan = true;
            return isCan;

        }

        protected DataTable ExcecuteToDataTable(string procName, DataTable dt)
        {
            isCan = false;
            DataTable dataObj = new DataTable();
            adapter = new SqlDataAdapter();

            if (dt != null)
            {
                parameterList = GetParameterList(procName, dt);
                foreach (SqlParameter[] param in parameterList)
                {
                    command = new SqlCommand(procName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(param);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataObj);
                    isCan = true;
                }
            }
            else
            {

                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(dataObj);

            }
            return dataObj;

        }

        protected DataTable ExcecuteParamToDataTable(string procName, List<SqlParameter> paramList)
        {
            isCan = false;
            DataTable dataObj = new DataTable();
            adapter = new SqlDataAdapter();

            if (paramList != null)
            {

                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter param in paramList)
                {
                  
                    command.Parameters.Add(param);
                   
                }
                adapter.SelectCommand = command;
                adapter.Fill(dataObj);
                isCan = true;
            }
            else
            {

                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(dataObj);

            }
            return dataObj;

        }

        protected DataSet ExcecuteParamToDataSet(string procName, DataTable dt)
        {
            isCan = false;
            DataSet dataObj = new DataSet();
            adapter = new SqlDataAdapter();

            if (dt != null)
            {
                parameterList = GetParameterList(procName, dt);
                foreach (SqlParameter[] param in parameterList)
                {
                    command = new SqlCommand(procName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(param);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataObj);
                    isCan = true;
                }
            }
            else
            {

                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(dataObj);

            }
            return dataObj;

        }

        protected DataSet ExcecuteParamToDataSet(string procName, List<SqlParameter> paramList)
        {
            isCan = false;
            DataSet dataObj = new DataSet();
            adapter = new SqlDataAdapter();

            if (paramList != null)
            {

                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter param in paramList)
                {

                    command.Parameters.Add(param);

                }
                adapter.SelectCommand = command;
                adapter.Fill(dataObj);
                isCan = true;
            }
            else
            {

                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(dataObj);

            }
            return dataObj;

        }


        protected List<SqlParameter[]> GetParameterList(string procName, DataTable dt)
        {
            parameterList = new List<SqlParameter[]>();
            List<SqlParameter> paramList = null;
            List<SqlParameter> paramResultList = null;
            SqlParameter[] parameters = null;
            SqlParameter parameter = null;
            SqlParameter newParameter = null;
            try
            {
                paramResultList = new List<SqlParameter>();
                command = new SqlCommand(procName, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(command);
                parameters = new SqlParameter[command.Parameters.Count];
                command.Parameters.CopyTo(parameters, 0);
                command.Parameters.Clear();
                paramList = new List<SqlParameter>();
                paramList.AddRange(parameters);
                paramList.RemoveAt(0);


                foreach (SqlParameter param in paramList)
                {
                    param.Value = "";
                }
                foreach (DataRow dr in dt.Rows)
                {
                    paramResultList = new List<SqlParameter>();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        parameter = paramList.Find(delegate(SqlParameter p)
                        {
                            return p.ParameterName.IndexOf(string.Format("@{0}", dc.ColumnName))>-1 ;
                        });

                        if (parameter != null)
                        {
                            parameter.Value = dr[dc];
                            
                            paramResultList.Add(new SqlParameter(parameter.ParameterName,parameter.Value));
                        }
                    }
                    parameterList.Add(paramResultList.ToArray());
                    
                }

            }
            catch (Exception ex)
            { throw ex; }
            finally
            { }

            return parameterList;


        }

        protected List<SqlParameter[]> GetParameterList(string procName, SqlConnection conn, SqlTransaction transaction, DataTable dt)
        {
            parameterList = new List<SqlParameter[]>();
            List<SqlParameter> paramList = null;
            List<SqlParameter> paramResultList = null;
            SqlParameter[] parameters = null;
            SqlParameter parameter = null;
            try
            {
                paramResultList = new List<SqlParameter>();
                command = new SqlCommand(procName, conn, transaction);
                command.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(command);
                parameters = new SqlParameter[command.Parameters.Count];
                command.Parameters.CopyTo(parameters, 0);
                command.Parameters.Clear();
                paramList = new List<SqlParameter>();
                paramList.AddRange(parameters);
                paramList.RemoveAt(0);
                
                foreach (SqlParameter param in paramList)
                {
                    param.Value = "";
                }
                foreach (DataRow dr in dt.Rows)
                {
                    paramResultList = new List<SqlParameter>();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        parameter = paramList.Find(delegate (SqlParameter p)
                        {
                            return p.ParameterName.IndexOf(string.Format("@{0}", dc.ColumnName)) > -1;
                        });

                        if (parameter != null)
                        {
                            parameter.Value = dr[dc];

                            paramResultList.Add(new SqlParameter(parameter.ParameterName, parameter.Value));
                        }
                    }
                    parameterList.Add(paramResultList.ToArray());

                }

            }
            catch (Exception ex)
            { throw ex; }
            finally
            { }

            return parameterList;
        }

        protected List<SqlParameter> GetParameters(string procName, object obj)
        {

            var properties = obj.GetType().GetProperties();

            SqlParameter parameter = null;

            SqlParameter[] paramArray = null;
            List<SqlParameter> parameterList = new List<SqlParameter>();
            command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(command);

            paramArray = new SqlParameter[command.Parameters.Count];
            command.Parameters.CopyTo(paramArray, 0);
            command.Parameters.Clear();
            parameterList.AddRange(paramArray);
            parameterList.RemoveAt(0);



            foreach (var property in properties)
            {
                parameter = parameterList.Find(delegate (SqlParameter p)
                {
                    return p.ParameterName.ToLower().IndexOf(property.Name.ToLower()) > -1;
                });

                if (parameter != null)
                {
                    parameter.Value = (parameter.Value == null || parameter.Value == "") ? property.GetValue(obj, null) : parameter.Value;
                    if (parameter.Value == null)
                    {
                        if (parameter.SqlDbType == SqlDbType.VarChar || parameter.SqlDbType == SqlDbType.NVarChar)
                        {
                            parameter.Value = "";
                        }
                    }
                }
            }


            return parameterList;
        }
        
        protected void ExcecuteNoneQuery(string procName, List<SqlParameter> paramList, SqlConnection conn, SqlTransaction transaction)
        {
            command = new SqlCommand(procName, conn, transaction);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter param in paramList)
            {
                command.Parameters.Add(param);
            }
            command.ExecuteNonQuery();
        }


    }
}
