using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO.Amlo.Autorizing
{
    public class MenuGroupDto
    {
        public static DataTable Data()
        {
            DataTable dt = new DataTable();


            /*   [MENU_OID]
          ,[OrderNo]
          ,[MENUGROUP_OID]
          ,[Name]
          ,[DESC]
          ,[SCREEN]
          ,[LINK]
          ,[PMENU_OID]
          ,[CREATE_BY]
          ,[CREATE_DATE]
          ,[UPDATE_BY]
          ,[UPDATE_DATE]
          ,[ROW_STATE]*/

            dt.Columns.Add("MENU_OID");
            dt.Columns.Add("OrderNo");
            dt.Columns.Add("MENUGROUP_OID");
            dt.Columns.Add("Name");
            dt.Columns.Add("DESC");
            dt.Columns.Add("SCREEN");
            dt.Columns.Add("LINK");
            dt.Columns.Add("PMENU_OID");
            dt.Columns.Add("Icon");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
             dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("USERGROUP_OID");
            dt.Columns.Add("VIEW");
            return dt;
        }
    }
}
