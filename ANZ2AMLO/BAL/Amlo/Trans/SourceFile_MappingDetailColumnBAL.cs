using BL;
using DAL.Amlo.Trans;
using DTO.Amlo.Trans;
using DTO.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Amlo.Trans
{
    class SourceFile_MappingDetailColumnBAL : BALBase
    {
        bool isCan = false;
        SourceFile_MappingDetailColumnDAL dao = null;
        DataTable dt = null;
        DataRow dr = null;

        public SourceFile_MappingDetailColumnBAL()
        {
            dao = new SourceFile_MappingDetailColumnDAL();
        }

        public override bool Action()
        {
            throw new NotImplementedException();
        }

        public bool Action(string DID, string No, string ColumnNo, string ColumnExcel, string ColumnName,
                           string ParentID, string Condition, string TotalRow, string StartPosition, string PositionLength,
                           string Desc, bool rowState, string UserLogin, PAction action)
        {
            dt = SourceFile_MappingDetailColumnDto.Data();
            dr = dt.NewRow();
            dr["DID"] = DID;
            dr["No"] = No;
            dr["ColumnNo"] = ColumnNo;
            dr["ColumnExcel"] = ColumnExcel;
            dr["ColumnName"] = ColumnName;
            dr["ParentID"] = ParentID;
            dr["Condition"] = Condition;
            dr["TotalRow"] = TotalRow;
            dr["PositionLength"] = PositionLength;
            dr["StartPosition"] = StartPosition;
            dr["Desc"] = Desc;
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

        public override DataTable FindByAll()
        {
            return dao.FindByAll();
        }

        public override DataTable FindByColumn(object obj)
        {
            dt = SourceFile_MappingDetailColumnDto.Data();
            dr = dt.NewRow();
            dr["HID"] = "";
            return dao.FindByColumn(dt);
        }

        public DataTable FindByColumn(String DID, string active)
        {
            dt = SourceFile_MappingDetailColumnDto.Data();
            dr = dt.NewRow();
            dr["DID"] = DID;
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
    }
}
