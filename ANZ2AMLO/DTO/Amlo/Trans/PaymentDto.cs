using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo.Trans
{
   public class PaymentDto
    {

        public string ImportID { get; set; }
        public string InstrumentId { get; set; }
        public string AccountNumber { get; set; }
        public string OrderingParty { get; set; }
        public string BeneficiaryAccountNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryAddress1 { get; set; }
        public string BeneficiaryAddress2 { get; set; }
        public string BeneficiaryAddress3 { get; set; }
        public string BeneficiaryBank { get; set; }
        public string BeneficiaryBankName { get; set; }
        public string InstrumentCurrency { get; set; }
        public string BeneficiaryAmount { get; set; }
        public string ValueDate { get; set; }
        public string Status { get; set; }
        public string DateTimeHistoryStatusCreated { get; set; }
        public string PaymentMethodTypeDescription { get; set; }
        public string CentralBankReporting1 { get; set; }
        public string CentralBankReporting2 { get; set; }
        public string CentralBankReporting3 { get; set; }
        public string FXRate { get; set; }
        public string CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }

    }
}
