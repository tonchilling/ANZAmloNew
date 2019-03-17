using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;

namespace DTO.Amlo.Master
{
    public class M_CustomerDTO
    {
        public string CustomerOID { get; set; }
        public string No { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerID { get; set; }
        public string CustomerACNo { get; set; }
        public string RegBusinessName { get; set; }
        public string RegBusinessNameTH { get; set; }
        public string CustomerName { get; set; }
        public string JuristicIDNo { get; set; }
        public string RegTAXID { get; set; }
        public string DID { get; set; }
        public string HID { get; set; }
        public string RegisterDate { get; set; }
        public string PrimaryBusinessTypeCode { get; set; }
        public string PrimaryBusinessTypeDescription { get; set; }
        public string ContactTelNumber { get; set; }
        public string DefaultAddress { get; set; }
        public string RegisterAddres { get; set; }
        public string ContactAddress { get; set; }
        public string CompanyAddress { get; set; }
        public string TelNo { get; set; }
        public string Active { get; set; }
        public string SourceFile_MappingDetailID { get; set; }
        public string SourceFile_MappingDetailName { get; set; }
        public List<M_Customer_Account> AccountList { get; set; }
        public List<M_Customer_Address> AddressList { get; set; }

        public static DataTable DataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CustomerOID");
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("CustomerNo");
            dt.Columns.Add("RegBusinessName");
            dt.Columns.Add("RegBusinessNameTH");
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("JuristicIDNo");
            dt.Columns.Add("RegisterDate");
            dt.Columns.Add("PrimaryBusinessTypeCode");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("SourceFile_MappingDetailID");
            dt.Columns.Add("ImportID");

            return dt;
        }

    }

    public class M_Customer_Account
    {
        public string CustomerOID { get; set; }
        public string AccountNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string AccountType { get; set; }
        public string SourceBankBranch { get; set; }
        public string CREATE_BY { get; set; }
        public string CREATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public string UPDATE_DATE { get; set; }
        public string ROW_STATE { get; set; }
        public string ImportID { get; set; }

        public static DataTable DataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CustomerOID");
            dt.Columns.Add("AccountNumber");
            dt.Columns.Add("CurrencyCode");
            dt.Columns.Add("AccountType");
            dt.Columns.Add("SourceBankBranch");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("ImportID");

            return dt;
        }
    }

    public class M_Customer_Address
    {

        public string AddressOID { get; set; }
        public string RelateCustomerKYCID { get; set; }
        public string CustomerOID { get; set; }
        public string PrincipleAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string CREATE_BY { get; set; }
        public string CREATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public string UPDATE_DATE { get; set; }
        public string ROW_STATE { get; set; }
        public string ImportID { get; set; }

        public static DataTable DataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("AddressOID");
            dt.Columns.Add("CustomerKYCID");
            dt.Columns.Add("CustomerOID");
            dt.Columns.Add("PrincipleAddress");
            dt.Columns.Add("City");
            dt.Columns.Add("State");
            dt.Columns.Add("Zipcode");
            dt.Columns.Add("Country");
            dt.Columns.Add("ContactNumber");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("ImportID");

            return dt;
        }
    }
}
