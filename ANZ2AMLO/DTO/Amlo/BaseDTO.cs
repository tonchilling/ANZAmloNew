using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo
{
   public  class BaseDTO
    {
        string _CREATE_BY;
        string _CREATE_DATE;
        string _UPDATE_BY;
        string _UPDATE_DATE;
        string _ROW_STATE;
        string _Active;
        string _VIEW;
        string _EDIT;
        string _DELETE;

        public BaseDTO()
        {
            _CREATE_BY = "";
            _CREATE_DATE = "";
            _UPDATE_BY = "";
            _UPDATE_DATE = "";
            _ROW_STATE = "";
            _Active = "";
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

        public string Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
    }
}
