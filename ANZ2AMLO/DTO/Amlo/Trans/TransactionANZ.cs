using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo.Trans
{
    public class TransactionANZ
    {
        public string colNo { get; set; }
        public string GroupName { get; set; }
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


    }
}
