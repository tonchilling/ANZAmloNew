using DTO.Amlo.Trans;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Amlo.Trans
{
    class SourceFile_MappingDetailColumnDAL : AmloBase
    {
        public override bool Add(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_Insert", dt);
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

        public override bool Delete(DataTable dt)
        {
            isCan = false;
            try
            {
                OpenConection();
                ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_Delete", dt);
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
                DataTable dt = SourceFile_MappingDetailColumnDto.Data();
                DataRow dr = dt.NewRow();
                dr["ROW_STATE"] = "1";
                dt.Rows.Add(dr);

                OpenConection();
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingDetailColumn_FindByAll", dt);
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
                dtObj = ExcecuteToDataTable("sp_SourceFile_MappingDetailColumn_FindByColumn", dt);
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
                ExcecuteNoneQuery("sp_SourceFile_MappingDetailColumn_Update", dt);
                isCan = true;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { CloseConnection(); }
            return isCan;
        }
    }
}
