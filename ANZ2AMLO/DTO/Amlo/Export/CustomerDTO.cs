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
    public class Customers
    {
       public List<CustomerDTO> Customer { get; set; }
    }

        public class CustomerDTO
    {

       
        public CustomerID CustomerID { get; set; }

        [XmlAttribute]
        public string CustomerName { get; set; }
    }

    public class CustomerID
    {
        [XmlAttribute]
        public string value { get; set; }

        [XmlText]
        public string text { get; set; }
    }


}
