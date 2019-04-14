using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO.Amlo.Trans
{
    public class TransactionMasterDTO
    {
        public string colNo { get; set; }
        public string GroupName { get; set; }
        public string Department { get; set; }
        public string FileType { get; set; }
        public string Status { get; set; }
        public string ANZCustomerInstrumentId { get; set; }
        public string ANZCustomerBANKAccountNumber { get; set; }
        public string TransactionDate { get; set; }
        public string TranxSendReceive { get; set; }
        public string TranxAmountTHB { get; set; }
        public string TranxAmountCurrency { get; set; }
        public string TranxExchangeRate { get; set; }
        public string TranxObjective { get; set; }
        public string ANZCustomerRegisterID { get; set; }
        public string ANZCutomerBusinessCode { get; set; }
        public string ANZCutomerRegisterAddress { get; set; }
        public string ANZCutomerRegisterAddressCountry { get; set; }
        public string ANZCustomerRegisterDate { get; set; }
        public string SendBankAccountNumber { get; set; }
        public string SendTranxRefNo { get; set; }
        public string SendBankName { get; set; }
        public string SendBankCountry { get; set; }
        public string SendName { get; set; }
        public string SendAddress { get; set; }
        public string SendDescription { get; set; }
        public string SendIdNo { get; set; }
        public string SendIdIssueBy { get; set; }
        public string BeneBankAccountNumber { get; set; }
        public string BeneTranxRefNo { get; set; }
        public string BeneBankName { get; set; }
        public string BeneBankCountry { get; set; }
        public string BeneName { get; set; }
        public string BeneAddress { get; set; }

        public string BeneIdDescription { get; set; }
        public string BeneIdNo { get; set; }
        public string BeneIdIssueBy { get; set; }



        public static DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("TranOID");

            dt.Columns.Add("FileType");
            dt.Columns.Add("GroupName");
            dt.Columns.Add("Department");
            dt.Columns.Add("CustomerInstrumentId");
            dt.Columns.Add("CustomerBankAccountNumber");
            dt.Columns.Add("ANZCustomerId");
            dt.Columns.Add("CustRegisterName");
            dt.Columns.Add("CustRegisterID");
            dt.Columns.Add("CustBusinessCode");
            dt.Columns.Add("CustRegisterAddress");
            dt.Columns.Add("CustRegisterAddressCountry");
            dt.Columns.Add("CustCompanyAddress");
            dt.Columns.Add("CustCompanyAddressCountry");
            dt.Columns.Add("CustContractAddress");
            dt.Columns.Add("CustContractAddressCountry");
            dt.Columns.Add("CustRegisterDate");
            dt.Columns.Add("TransactionMethod");
            dt.Columns.Add("TransactionDate");
            dt.Columns.Add("TranxAmountThb");
            dt.Columns.Add("TranxAmountCurrency");
            dt.Columns.Add("TranxCurrency");
            dt.Columns.Add("TranxExchangeRate");
            dt.Columns.Add("TranxAmountThbInThWord");
            dt.Columns.Add("TranxInternationalOrDomestic");
            dt.Columns.Add("TranxSendReceive");
            dt.Columns.Add("TranxObjective");
            dt.Columns.Add("SendTranxRefNo");
            dt.Columns.Add("SendBankName");
            dt.Columns.Add("SendBankCountry");
            dt.Columns.Add("SendBankAccountNo");
            dt.Columns.Add("SendName");
            dt.Columns.Add("SendAddress");
            dt.Columns.Add("SendIdType");
            dt.Columns.Add("SendIdDescription");
            dt.Columns.Add("SendIdNo");
            dt.Columns.Add("SendIdIssueBy");
            dt.Columns.Add("BeneBankAccountNo");
            dt.Columns.Add("BeneTranxRefNo");
            dt.Columns.Add("BeneBankName");
            dt.Columns.Add("BeneBankCountry");
            dt.Columns.Add("BeneName");
            dt.Columns.Add("BeneAddress");
            dt.Columns.Add("BeneIdType");
            dt.Columns.Add("BeneIdDescription");
            dt.Columns.Add("BeneIdNo");
            dt.Columns.Add("BeneIdIssueBy");
            dt.Columns.Add("Remark");
            dt.Columns.Add("MappingSourceDB");
            dt.Columns.Add("CREATE_BY");
            dt.Columns.Add("CREATE_DATE");
            dt.Columns.Add("UPDATE_BY");
            dt.Columns.Add("UPDATE_DATE");
            dt.Columns.Add("ROW_STATE");
            dt.Columns.Add("Active");


            /*  dt.Columns.Add("ImportID");
                  dt.Columns.Add("SourceFileHID");
                  dt.Columns.Add("TranDate");
                  dt.Columns.Add("ReportName");
                  dt.Columns.Add("Remark");
                  dt.Columns.Add("CREATE_BY");
                  dt.Columns.Add("CREATE_DATE");
                  dt.Columns.Add("UPDATE_BY");
                  dt.Columns.Add("UPDATE_DATE");
                  dt.Columns.Add("ROW_STATE");*/

            return dt;
        }

    }


}
