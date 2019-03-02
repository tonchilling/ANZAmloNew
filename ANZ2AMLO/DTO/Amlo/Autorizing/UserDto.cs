using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO.Amlo.Autorizing
{
    public class UserDto
    {
        public static DataTable Data()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("USER_OID"); 
	 dt.Columns.Add("USERGROUP_OID");  
	 dt.Columns.Add("USER_LOGIN");
	 dt.Columns.Add("FName"); 
	 dt.Columns.Add("LName"); 
	 dt.Columns.Add("Position");
	 dt.Columns.Add("Addr1"); 
	 dt.Columns.Add("Telephone"); 
	 dt.Columns.Add("Email"); 
	 dt.Columns.Add("PASSWORD"); 
	 dt.Columns.Add("MAX_SESSION");
	 dt.Columns.Add("SESSION_TIME_OUT"); 
	 dt.Columns.Add("CREATE_BY"); 
	 dt.Columns.Add("CREATE_DATE"); 
	 dt.Columns.Add("UPDATE_BY"); 
	 dt.Columns.Add("UPDATE_DATE");
	 dt.Columns.Add("ROW_STATE");
     dt.Columns.Add("Active");
            return dt;
        }
    }
}
