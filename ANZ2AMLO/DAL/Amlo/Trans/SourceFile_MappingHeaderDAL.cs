using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using DTO.Amlo.Importing;
using DAL;
using DTO.Amlo.Trans;
using System.Data.SqlClient;

namespace DAL.Amlo.Trans
{
    /// <summary>
    /// Summary description for XCustomerDAO
    /// </summary>
    public class SourceFile_MappingHeaderDAL : AmloBase
    {
        bool isCan = false;
        public SourceFile_MappingHeaderDAL()
        {

        }

        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingHeader_Insert", dt);
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }


        public  bool ImportAll(List<ImportDTO> dataList)
        {
            isCan = false;
            DataTable dtDetail = null;
            try
            {
                string createBy = "";
                OpenConection();
                ExcecuteNoneQueryObj("sp_Temp_ClearAll",null);
                isCan = true;
                CloseConnection();

                OpenConection();
                string ImportID = Guid.NewGuid().ToString();
                foreach (ImportDTO dto in dataList)
                {
                    createBy = dto.CREATE_BY!=null ? dto.CREATE_BY:"";
                    dto.Data.Tables[1].Columns.Add("ImportID");
                        
                    foreach (DataRow dr in dto.Data.Tables[1].Rows)
                    {
                        dr["ImportID"] = ImportID;

                    }
                   
                    if (dto.Data != null && dto.Data.Tables.Count > 1)
                    {


                        ExcecuteNoneQuery(string.Format("sp_Temp_{0}_Insert"
                            , dto.Data.Tables[0].Rows[0]["KeyWord"].ToString())
                            , dto.Data.Tables[1]);

                      
                    }

                }


             /*   if (dtImportHeader != null
                  && dtImportHeader.Rows.Count > 0)
                {
                    dtImportHeader.Rows[0]["ImportID"] = ImportID;
                    ExcecuteNoneQuery("sp_T_ImportHeader_Insert", dtImportHeader);
                }



                if (dtImportDetail != null
                    && dtImportDetail.Rows.Count > 0)
                {
                    dtImportDetail.Rows[0]["ImportID"] = ImportID;
                    ExcecuteNoneQuery("sp_T_ImportDetail_Insert", dtImportDetail);
                }*/




                ImportDTO tempDTO = new ImportDTO();
                tempDTO.ImportID = ImportID;
                tempDTO.CREATE_BY = createBy;

              

                ExcecuteNoneQueryObj("sp_Importing_TempToCustomer", tempDTO);
                
                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }


        public bool ImportAll(List<ImportDTO> dataList, DataTable dtImportHeader)
        {
            isCan = false;
            DataTable dtDetail = null;
            try
            {
                string createBy = "";
                OpenConection();
                ExcecuteNoneQueryObj("sp_Temp_ClearAll", null);
                isCan = true;
                CloseConnection();

                OpenConection();
                string ImportID = Guid.NewGuid().ToString();
                foreach (ImportDTO dto in dataList)
                {
                    createBy = dto.CREATE_BY != null ? dto.CREATE_BY : "";
                    dto.Data.Tables[1].Columns.Add("ImportID");

                    foreach (DataRow dr in dto.Data.Tables[1].Rows)
                    {
                        dr["ImportID"] = ImportID;

                    }

                    if (dto.Data != null && dto.Data.Tables.Count > 1)
                    {


                        ExcecuteNoneQuery(string.Format("sp_Temp_{0}_Insert"
                            , dto.Data.Tables[0].Rows[0]["KeyWord"].ToString())
                            , dto.Data.Tables[1]);

                        if (dto.Data.Tables.Count > 2)
                        {
                            var dtImportDetail = dto.Data.Tables[2];
                            dtImportDetail.Rows[0]["ImportID"] = ImportID;
                            ExcecuteNoneQuery("sp_T_ImportDetail_Insert", dtImportDetail);
                        }

                    }

                }

                dtImportHeader.Rows[0]["ImportID"] = ImportID;
                ExcecuteNoneQuery("sp_T_ImportHeader_Insert", dtImportHeader);


                /*   if (dtImportHeader != null
                     && dtImportHeader.Rows.Count > 0)
                   {
                       dtImportHeader.Rows[0]["ImportID"] = ImportID;
                       ExcecuteNoneQuery("sp_T_ImportHeader_Insert", dtImportHeader);
                   }



                   if (dtImportDetail != null
                       && dtImportDetail.Rows.Count > 0)
                   {
                       dtImportDetail.Rows[0]["ImportID"] = ImportID;
                       ExcecuteNoneQuery("sp_T_ImportDetail_Insert", dtImportDetail);
                   }*/




                ImportDTO tempDTO = new ImportDTO();
                tempDTO.ImportID = ImportID;
                tempDTO.CREATE_BY = createBy;



                ExcecuteNoneQueryObj("sp_Importing_TempToCustomer", tempDTO);

                isCan = true;
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return isCan;
        }


        public bool ImportAll(List<ImportDTO> dataList
                              ,DataTable dtImportHeader
                              , DataTable dtImportDetail)
        {
            isCan = false;
            DataTable dtDetail = null;
            try
            {
                string createBy = "";
                OpenConection();
                ExcecuteNoneQueryObj("sp_Temp_ClearAll", null);
                isCan = true;
                CloseConnection();

                OpenConection();
                string ImportID = Guid.NewGuid().ToString();
                foreach (ImportDTO dto in dataList)
                {
                    createBy = dto.CREATE_BY != null ? dto.CREATE_BY : "";
                    dto.Data.Tables[1].Columns.Add("ImportID");

                    foreach (DataRow dr in dto.Data.Tables[1].Rows)
                    {
                        dr["ImportID"] = ImportID;

                    }

                    if (dto.Data != null && dto.Data.Tables.Count > 1)
                    {


                        ExcecuteNoneQuery(string.Format("sp_Temp_{0}_Insert"
                            , dto.Data.Tables[0].Rows[0]["KeyWord"].ToString())
                            , dto.Data.Tables[1]);



                    }

                }

                if (dtImportHeader != null
                    && dtImportHeader.Rows.Count > 0 )
                {
                    dtImportHeader.Rows[0]["ImportID"] = ImportID;
                    ExcecuteNoneQuery("sp_T_ImportHeader_Insert", dtImportHeader);
                }



                if (dtImportDetail != null
                    && dtImportDetail.Rows.Count > 0)
                {
                    dtImportDetail.Rows[0]["ImportID"] = ImportID;
                    ExcecuteNoneQuery("sp_T_ImportDetail_Insert", dtImportDetail);
                }


                ImportDTO tempDTO = new ImportDTO();
                tempDTO.ImportID = ImportID;
                tempDTO.CREATE_BY = createBy;



                ExcecuteNoneQueryObj("sp_Importing_TempToCustomer", tempDTO);

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
                ExcecuteNoneQuery("sp_SourceFile_MappingHeader_Update", dt);
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
                ExcecuteNoneQuery("sp_SourceFile_MappingHeader_Delete", dt);
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
                DataTable dt = SourceFile_MappingHeaderDto.Data();
                DataRow dr = dt.NewRow();
                dr["ROW_STATE"] = "1";
                dt.Rows.Add(dr);

                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingHeader_FindAll", dt);
                
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
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingHeader_FindByColumn", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }


        public  DataTable FindByPK(DataTable dt)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingHeader_FindByPK", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }


        public DataTable FindByKeyWord(string tbName)
        {
            isCan = false;
            DataTable dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteToDataTable(string.Format("sp_{0}_FindByPK", tbName), null);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }

        public DataTable FindByKeyWord(string tbName, string createDate)
        {
            isCan = false;
            DataTable dtObj = null;
            List<SqlParameter> paramList = null;
            SqlParameter parameters = null;
            try
            {
                paramList = new List<SqlParameter>();
                parameters = new SqlParameter("@CreateDate", createDate);

                paramList.Add(parameters);
                OpenConection();
                dtObj = ExcecuteParamToDataTable(string.Format("sp_{0}_FindByPK", tbName), paramList);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;
        }

        public DataSet FindByKeyWord(string tbName, string createDate,string DID)
        {
            isCan = false;
            DataSet ds = null;
            DataTable dtObj = null;
            List<SqlParameter> paramList = null;
            SqlParameter parameters = null;
            try
            {
                ds = new DataSet();
                   paramList = new List<SqlParameter>();
                parameters = new SqlParameter("@CreateDate", createDate);
                paramList.Add(parameters);


                OpenConection();
                dtObj = ExcecuteParamToDataTable(string.Format("sp_{0}_FindByPK", tbName), paramList);
                ds.Tables.Add(dtObj.Copy());
                paramList = new List<SqlParameter>();
                parameters = new SqlParameter("@CreateDate", createDate);
                paramList.Add(parameters);
                parameters = new SqlParameter("@DID", DID);
                paramList.Add(parameters);
                dtObj = ExcecuteParamToDataTable(string.Format("sp_T_ImportHeader_FindByDate", tbName), paramList);
                ds.Tables.Add(dtObj.Copy());
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return ds;
        }
        public DataSet  FindHeaderAndDetailPK(DataTable dt)
        {
            isCan = false;
            DataSet dtObj = null;
            try
            {
                OpenConection();
                dtObj = ExcecuteParamToDataSet("[sp_SourceFile_MappingHeader_FindByPK]", dt);
                CloseConnection();
            }
            catch (Exception ex)
            { }
            finally
            { }
            return dtObj;

            //ExcecuteParamToDataSet

        }

     

        
    }
}
