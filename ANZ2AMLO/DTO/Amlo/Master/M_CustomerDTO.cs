using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
