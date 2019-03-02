using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO.Amlo.Trans;
using System.Data.SqlClient;

namespace DAL.Amlo.Trans
{
    class SourceFile_MappingDetailDAL : AmloBase
    {
        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingDetail_Insert", dt);
                isCan = true;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                CloseConnection();
            }
            return isCan;
        }

        public void Add(DataTable detailEditDt, DataView dvDetail2)
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = OpenConection();
                transaction = conn.BeginTransaction();
                
                string procName = "sp_SourceFile_MappingDetail_Insert";
                parameterList = GetParameterList(procName, conn, transaction, detailEditDt);
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
                string DID = command.Parameters[0].Value.ToString();

                ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_DeleteByDID", conn, transaction, detailEditDt);

                if (dvDetail2 != null)
                {
                    foreach (DataRowView rowView in dvDetail2)
                    {
                        DataRow mainDetailDr = detailEditDt.Rows[0];
                        DataTable detailColumnDt = SourceFile_MappingDetailColumnDto.Data();
                        DataRow detailColumnDr = detailColumnDt.NewRow();
                        DataRow row = rowView.Row;
                        //string DID = (String)mainDetailDr["DID"];
                        detailColumnDr["DID"] = DID;
                        detailColumnDr["No"] = row["No"];
                        detailColumnDr["ColumnNo"] = row["ColumnNo"];
                        detailColumnDr["ColumnExcel"] = row["ColumnExcel"];
                        detailColumnDr["ColumnName"] = row["ColumnName"];
                        detailColumnDr["ParentID"] = row["ParentID"];
                        detailColumnDr["Condition"] = row["Condition"];
                        detailColumnDr["TotalRow"] = row["TotalRow"];
                        detailColumnDr["StartPosition"] = row["StartPosition"];
                        detailColumnDr["PositionLength"] = row["PositionLength"];
                        detailColumnDr["Desc"] = row["Desc"];
                        detailColumnDr["CREATE_BY"] = row["CREATE_BY"];
                        detailColumnDr["CREATE_DATE"] = row["CREATE_DATE"];
                        detailColumnDr["UPDATE_BY"] = mainDetailDr["UPDATE_BY"];

                        detailColumnDt.Rows.Add(detailColumnDr);

                        ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_Insert", conn, transaction, detailColumnDt);
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

        public override bool Delete(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingDetail_Delete", dt);
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
            isCan = false;
            DataTable dtObj = null;
            try
            {
                DataTable dt = SourceFile_MappingDetailDto.Data();
                DataRow dr = dt.NewRow();
                dr["ROW_STATE"] = "1";
                dt.Rows.Add(dr);

                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingDetail_FindAll", dt);

            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }

        public DataTable FindDropDown(string HID)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                DataTable dt = SourceFile_MappingDetailDto.Data();
                DataRow dr = dt.NewRow();
                dr["HID"] = HID;
                dr["ROW_STATE"] = "1";
                dt.Rows.Add(dr);

                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingDetail_FindDropDown", dt);

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
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingDetail_FindByColumn", dt);                
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return dtObj;
        }

        public override bool Update(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingDetail_Update", dt);
                isCan = true;                
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return isCan;
        }

        public void Update(DataTable detailEditDt, DataView dvDetail2)
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = OpenConection();
                transaction = conn.BeginTransaction();

                ExcecuteNoneQuery("sp_SourceFile_MappingDetail_Update", conn, transaction, detailEditDt);
                ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_DeleteByDID", conn, transaction, detailEditDt);

                if (dvDetail2 != null)
                {
                    foreach (DataRowView rowView in dvDetail2)
                    {
                        DataRow mainDetailDr = detailEditDt.Rows[0];
                        DataTable detailColumnDt = SourceFile_MappingDetailColumnDto.Data();
                        DataRow detailColumnDr = detailColumnDt.NewRow();
                        DataRow row = rowView.Row;

                        string DID = (String)mainDetailDr["DID"];
                        detailColumnDr["DID"] = DID;
                        detailColumnDr["No"] = row["No"];
                        detailColumnDr["ColumnNo"] = row["ColumnNo"];
                        detailColumnDr["ColumnExcel"] = row["ColumnExcel"];
                        detailColumnDr["ColumnName"] = row["ColumnName"];
                        detailColumnDr["ParentID"] = row["ParentID"];
                        detailColumnDr["Condition"] = row["Condition"];
                        detailColumnDr["TotalRow"] = row["TotalRow"];
                        detailColumnDr["StartPosition"] = row["StartPosition"];
                        detailColumnDr["PositionLength"] = row["PositionLength"];
                        detailColumnDr["Desc"] = row["Desc"];
                        detailColumnDr["CREATE_BY"] = row["CREATE_BY"];
                        detailColumnDr["CREATE_DATE"] = row["CREATE_DATE"];
                        detailColumnDr["UPDATE_BY"] = mainDetailDr["UPDATE_BY"];

                        detailColumnDt.Rows.Add(detailColumnDr);

                        ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_Insert", conn, transaction, detailColumnDt);
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
