using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO.Amlo.Autorizing
{
    public class PER_MENU_PERMISSIONDto
    {
        string _USERGROUP_OID;
        string _MENU_OID;
        string _VIEW;
        string _DELETE;
        string _EDIT;
        string _CREATE_BY;
        string _CREATE_DATE;
        string _UPDATE_BY;
        string _UPDATE_DATE;
        string _ROW_STATE;


        public PER_MENU_PERMISSIONDto()
        {
             _USERGROUP_OID="";
             _MENU_OID = "";
             _VIEW = "";
             _DELETE = "";
             _EDIT = "";
             _CREATE_BY = "";
             _CREATE_DATE = "";
             _UPDATE_BY = "";
             _UPDATE_DATE = "";
             _ROW_STATE = "";
        }

        public string USERGROUP_OID
        {
            get { return _USERGROUP_OID; }
            set {_USERGROUP_OID=value;}
        }
        public string MENU_OID
        {
            get { return _MENU_OID; }
            set { _MENU_OID = value; }
        }
        public string VIEW
        {
            get { return _VIEW; }
            set { _VIEW = value; }
        }
        public string DELETE
        {
            get { return _DELETE; }
            set { _DELETE = value; }
        }
        public string EDIT
        {
            get { return _EDIT; }
            set { _EDIT = value; }
        }
        public string CREATE_BY
        {
            get { return _CREATE_BY; }
            set { _CREATE_BY = value; }
        }
        public string CREATE_DATE
        {
            get { return _CREATE_DATE; }
            set { _CREATE_DATE = value; }
        }
        public string UPDATE_BY
        {
            get { return _UPDATE_BY; }
            set { _UPDATE_BY = value; }
        }
        public string UPDATE_DATE
        {
            get { return _UPDATE_DATE; }
            set { _UPDATE_DATE = value; }
        }
        public string ROW_STATE
        {
            get { return _ROW_STATE; }
            set { _ROW_STATE = value; }
        }

        public static DataTable Data()
        {
            DataTable dt = new DataTable();
         
            /* [USERGROUP_OID] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[MENU_OID] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[VIEW] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[DELETE] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[EDIT] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[CREATE_BY] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[CREATE_DATE] [datetime] NULL,
	[UPDATE_BY] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[UPDATE_DATE] [datetime] NULL,
	[ROW_STATE] [nchar](2) COLLATE Thai_CI_AS NULL*/

            dt.Columns.Add("USERGROUP_OID");
            dt.Columns.Add("MENU_OID");
            dt.Columns.Add("VIEW");
            dt.Columns.Add("DELETE");
            dt.Columns.Add("EDIT");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
             dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            return dt;
        }

        public static PER_MENU_PERMISSIONDto Object()
        {
            PER_MENU_PERMISSIONDto dt = new PER_MENU_PERMISSIONDto();


            /* [USERGROUP_OID] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[MENU_OID] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[VIEW] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[DELETE] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[EDIT] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[CREATE_BY] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[CREATE_DATE] [datetime] NULL,
	[UPDATE_BY] [nvarchar](50) COLLATE Thai_CI_AS NULL,
	[UPDATE_DATE] [datetime] NULL,
	[ROW_STATE] [nchar](2) COLLATE Thai_CI_AS NULL*/

            return dt;
        }
    }
}
