using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO.Amlo.Autorizing
{
    public class UserGroupDto
    {
        public static DataTable Data()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("USERGROUP_OID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Desc");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
             dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            return dt;
        }
    }
}
