using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace DTO.Amlo.Export
{
    public class CustomerDTO
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
        public List<M_Customer_Account> AccountList { get; set; }
        public List<M_Customer_Address> AddressList { get; set; }

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
    }

}
