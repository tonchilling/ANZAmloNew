using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Amlo.Trans;
using DTO.Amlo.Trans;
using DTO.Util;

namespace BAL.Amlo.Trans
{
    class SourceFile_MappingDetailBAL : BALBase
    {
        bool isCan = false;
        SourceFile_MappingDetailDAL dao = null;
        DataTable dt = null;
        DataRow dr = null;

        public SourceFile_MappingDetailBAL()
        {
            dao = new SourceFile_MappingDetailDAL();
        }

        public override bool Action()
        {
            throw new NotImplementedException();
        }

        public bool Action(string DID, string HID, string No, string SourceFileRefName, string KeyWord,
                           string Type, string ExtFile, string StartRow, string EndRow, string StartColumn,
                           bool rowState, string UserLogin, PAction action)
        {
            dt = SourceFile_MappingDetailDto.Data();
            dr = dt.NewRow();
            dr["DID"] = DID;
            dr["HID"] = HID;
            dr["No"] = No;
            dr["SourceFileRefName"] = SourceFileRefName;
            dr["KeyWord"] = KeyWord;
            dr["Type"] = Type;
            dr["ExtFile"] = ExtFile;
            dr["StartRow"] = StartRow;
            dr["EndRow"] = EndRow;
            dr["StartColumn"] = StartColumn;
            dr["ROW_STATE"] = rowState ? "1" : "0";
            dr["CREATE_BY"] = UserLogin;
            dr["UPDATE_BY"] = UserLogin;
            dt.Rows.Add(dr);
            switch (action)
            {
                case PAction.Add: isCan = Add(); break;
                case PAction.Update: isCan = Update(); break;
                case PAction.Delete: isCan = Delete(); break;
            }
            return isCan;
        }

        public bool Action(DataTable detailEditDt, DataView dvDetail2, PAction action)
        {
            switch (action)
            {
                case PAction.Add: isCan = Add(detailEditDt, dvDetail2); break;
                case PAction.Update: isCan = Update(detailEditDt, dvDetail2); break;
                case PAction.Delete: isCan = Delete(detailEditDt); break;
            }
            return isCan;
        }

        public override DataTable FindByAll()
        {
            return dao.FindByAll();
        }

        public DataTable FindDropDown(string HID)
        {
            return dao.FindDropDown(HID);
        }

        public override DataTable FindByColumn(object obj)
        {
            dt = SourceFile_MappingDetailDto.Data();
            dr = dt.NewRow();
            dr["HID"] = "";
            return dao.FindByColumn(dt);
        }

        public DataTable FindByColumn(string HID, string active)
        {
            dt = SourceFile_MappingDetailDto.Data();
            dr = dt.NewRow();
            dr["HID"] = HID;
            dr["ROW_STATE"] = active;
            dt.Rows.Add(dr);
            return dao.FindByColumn(dt);
        }

        protected override bool Add()
        {
            try
            {
                isCan = dao.Add(dt);
            }
            catch (Exception ex)
            {
                Log("SourceFile_MappingDetailBAL.Add", "High", ex.ToString());
            }
            return isCan;
        }

        protected bool Add(DataTable detailEditDt, DataView dvDetail2)
        {
            bool isCan = false;
            try
            {
                dao.Add(detailEditDt, dvDetail2);
                isCan = true;
            }
            catch (Exception ex)
            {
                Log("SourceFile_MappingDetailBAL.Add", "High", ex.ToString());
            }
            return isCan;
        }
        

        protected override bool Delete()
        {
            try
            {
                isCan = dao.Delete(dt);
            }
            catch (Exception ex)
            {
                Log("SourceFile_MappingDetailBAL.Delete", "High", ex.ToString());
            }
            return isCan;
        }

        protected bool Delete(DataTable detailEditDt)
        {
            bool isCan = false;
            try
            {
                dao.Delete(detailEditDt);
                isCan = true;
            }
            catch (Exception ex)
            {
                Log("SourceFile_MappingDetailBAL.Delete", "High", ex.ToString());
            }
            return isCan;
        }

        protected override bool Update()
        {
            try
            {
                isCan = dao.Update(dt);
            }
            catch (Exception ex)
            {
                Log("SourceFile_MappingDetailBAL.Update", "High", ex.ToString());
            }

            return isCan;
        }

        protected bool Update(DataTable detailEditDt, DataView dvDetail2)
        {
            bool isCan = false;
            try
            {
                dao.Update(detailEditDt, dvDetail2);
                isCan = true;
            }
            catch (Exception ex)
            {
                Log("SourceFile_MappingDetailBAL.Update", "High", ex.ToString());
            }
            return isCan;
        }
    }
}
