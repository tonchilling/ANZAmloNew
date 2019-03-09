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

    [XmlRoot("ersreport")]
    public class AmloToCustomer
    {
       
        [XmlElement("reportingdetail")]
        public List<reportingdetail> reportingdetail { get; set; }

       [XmlElement("report")]
        public List<report> report { get; set; }
      
    }


    public class record
    {

        [XmlAttribute]
        public string date { get; set; }
    }

        public class reportingdetail
    {



        [XmlAttribute]
        public string orgid { get; set; }

        [XmlAttribute]
        public string orgname { get; set; }

        [XmlAttribute]
        public string telno { get; set; }

        [XmlAttribute]
        public string branchcode { get; set; }
        

    }

    public class report
    {

        [XmlElement("reportingdetail")]
        public reportingdetail reportingdetail { get; set; }

        [XmlElement("dcn")]
        public dcn dcn { get; set; }

        [XmlElement("reporttype")]
        public reportType reportType { get; set; }



        [XmlElement("person")]
        public List<person> person { get; set; }

        [XmlElement("tsc")]
        public tsc tsc { get; set; }

        [XmlElement("record")]
        public record record { get; set; }

        
        // <dcn value="09-00107557000420-00000-255912-000084" doctype="1-05-9" revision="" date="" refdocno="" refdoctype=""/>
    }


    public class reportType
    {
        [XmlAttribute]
        public string value { get; set; }

    }
        public class dcn
    {
        [XmlAttribute]
        public string value { get; set; }

        [XmlAttribute]
        public string doctype { get; set; }

        [XmlAttribute]
        public string revision { get; set; }

        [XmlAttribute]
        public string date { get; set; }

        [XmlAttribute]
        public string refdocno { get; set; }

        [XmlAttribute]
        public string refdoctype { get; set; }

    }

    public class reporttype
    {
        [XmlAttribute]
        public string value { get; set; }
    }


    public class person
    {
        [XmlAttribute]
        public string anothermethod { get; set; }

        [XmlAttribute]
        public string am_transactionmethod { get; set; }

        [XmlAttribute]
        public string am_customeraccno { get; set; }

        [XmlAttribute]
        public string value { get; set; }

        [XmlAttribute]
        public string relationship { get; set; }

        [XmlAttribute]
        public string relationshipdesc { get; set; }

        [XmlElement("name")]
        public personName personName { get; set; }

        [XmlElement("occupation")]
        public occupation occupation { get; set; }
       

        [XmlElement(ElementName = "contact")]
        public List<contact> contact { get; set; }

        public iddoc iddoc { get; set; }

        /* <person anothermethod = "TRUE"
      *  am_transactionmethod="DOCUMENT" am_customeraccno="100032" value="TRANSACTING-PERSON" relationship="SELF" relationshipdesc="">
  <name type = "LEGAL" title="" firstname="[NAV]" middlename="" lastname="" dateofbirth="" nationality="STATELESS" legalpersonid="[NAV]"/>
  <occupation companyname = "" businesstype="" businesstype_desc="" occ_type="99" occ_desc="[NAV]"/>
  ﻿
  <contact type = "ADDR" >
  <address no="[NAV]" moo="" building="" soi="" road="" subdistrict="[NAV]" address1=""
  address2="" district="[NAV]" province="[NAV]" zipcode="[NAV]" countrycode="TH"/>
  </contact>
  <contact type = "COMPANY-ADDR" noinfo="TRUE"/>
  <contact type = "CONTACT-ADDR" noinfo="TRUE"/>
  <iddoc type = "99" typedesc="[NAV]" idno="[NAV]" issueby="[NAV]" issuedate="[NAV]" expiredate="[NAV]"/>
  </person>*/

    }

    public class personName
    {
        [XmlAttribute]
        public string type { get; set; }


        [XmlAttribute]
        public string title { get; set; }

        [XmlAttribute]
        public string firstname { get; set; }


        [XmlAttribute]
        public string middlename { get; set; }

        [XmlAttribute]
        public string lastname { get; set; }

        [XmlAttribute]
        public string dateofbirth { get; set; }

        [XmlAttribute]
        public string nationality { get; set; }

        [XmlAttribute]
        public string legalpersonid { get; set; }

    }

    public class occupation
    {
        [XmlAttribute]
        public string companyname { get; set; }

        [XmlAttribute]
        public string businesstype { get; set; }

        [XmlAttribute]
        public string businesstype_desc { get; set; }

        [XmlAttribute]
        public string occ_type { get; set; }

        [XmlAttribute]
        public string occ_desc { get; set; }
    }

    public class contact
    {
        [XmlAttribute]
        public string type { get; set; }

        [XmlAttribute]
        public string noinfo { get; set; }

        
        public address address { get; set; }
    }

    public class address
    {
        [XmlAttribute]
        public string no { get; set; }

        [XmlAttribute]
        public string moo { get; set; }

        [XmlAttribute]
        public string building { get; set; }

        [XmlAttribute]
        public string soi { get; set; }

        [XmlAttribute]
        public string road { get; set; }

        [XmlAttribute]
        public string subdistrict { get; set; }

        [XmlAttribute]
        public string address1 { get; set; }

        [XmlAttribute]
        public string address2 { get; set; }

        [XmlAttribute]
        public string district { get; set; }

        [XmlAttribute]
        public string province { get; set; }

        [XmlAttribute]
        public string zipcode { get; set; }

        [XmlAttribute]
        public string countrycode { get; set; }
    }

    public class iddoc
    {
        [XmlAttribute]
        public string type { get; set; }

        [XmlAttribute]
        public string typedesc { get; set; }

        [XmlAttribute]
        public string idno { get; set; }

        [XmlAttribute]
        public string issueby { get; set; }

        [XmlAttribute]
        public string issuedate { get; set; }

        [XmlAttribute]
        public string expiredate { get; set; }

    }



    public class tsc
    {
       
        public tscentry tscentry { get; set; }
    public  totalamount  totalamount { get; set; }

        public benfperson benfperson { get; set; }

        public objective objective { get; set; }

        public records record { get; set; }
    }



    public class tscentry
    {
        public typeoftsc typeoftsc { get; set; }

        public List<transferdetail> transferdetail { get; set; }
        public amount amount { get; set; }
    }

    /*
<tsc date="2559-12-22">
<tscentry>
 <typeoftsc transtype="DOMESTIC" type="SEND" desc=""/>
 <transferdetail type="SEND" accountno="100032" refno="FTB1612220002" org="ANZ BANK (THAI) PUBLIC CO LTD" orgcountry="TH">
 <td fullname="MINOR INTERNATIONAL PUBLIC CO LTD" address="99 BERLI JUCKER BUILDING 16TH FLOOR SOI RUBIA" contactaddress="SUKHUMVIT 42 PRAKANONG KLONGTOEY BANGKOK 10110" idtype="OTHER" idtypedesc="AFFIDAVIT" idno="0107536000919" idissuer="MINISTRY OF COMMERCE" idexpiredate="" dateofbirth="" placeofbirth=""/>
</transferdetail>
<transferdetail type="REC" accountno="0126321007"
     refno="FTB1612220002" 
      org="CITIBANK N.A."
      orgcountry="TH">
  <td fullname = "MINOR INTERNATIONAL PUBLIC CO LTD" 
      address="BANGKOK"
  contactaddress=""
  idtype="OTHER" 
  idtypedesc="AFFIDAVIT"
  idno="0107536000919" 
  idissuer="MINISTRY OF COMMERCE" 
  idexpiredate="" 
  dateofbirth="" 
  placeofbirth="" />
</transferdetail>
<amount valueinbaht="199999850.00" valueinbahttxt="หนึ่งร้อยเก้าสิบเก้าล้านเก้าแสนเก้าหมื่นเก้าพันแปดร้อยห้าสิบบาทถ้วน"/>
</tscentry>
<totalamount valueinbaht="199999850.00" valueinbahttxt="หนึ่งร้อยเก้าสิบเก้าล้านเก้าแสนเก้าหมื่นเก้าพันแปดร้อยห้าสิบบาทถ้วน"/>
<!--  Data From Head  -->
<benfperson firstname="[NAV]" middlename="" lastname=""/>
<objective type=""> NEW LOAN DRAWDOWN ON 22 DECEMBER 2016. </objective>
<!--  ส่วนที่ 4  -->
</tsc>
<record date="2559-12-22"/>
*/


    public class typeoftsc
    {
        [XmlAttribute]
        public string transtype { get; set; }

        [XmlAttribute]
        public string type { get; set; }

        [XmlAttribute]
        public string desc { get; set; }
    }


    public class objective
    {
        [XmlAttribute]
        public string type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }


    public class transferdetail
    {
        [XmlAttribute]
        public string type { get; set; }

        [XmlAttribute]
        public string accountno { get; set; }

        [XmlAttribute]
        public string refno { get; set; }

        [XmlAttribute]
        public string org { get; set; }

        [XmlAttribute]
        public string orgcountry { get; set; }

        public td td { get; set; }
    }

    public class td
    {
        [XmlAttribute]
        public string fullname { get; set; }

        [XmlAttribute]
        public string address { get; set; }

        [XmlAttribute]
        public string contactaddress { get; set; }

        [XmlAttribute]
        public string idtype { get; set; }

        [XmlAttribute]
        public string idtypedesc { get; set; }

        [XmlAttribute]
        public string idno { get; set; }

        [XmlAttribute]
        public string idissuer { get; set; }

        [XmlAttribute]
        public string idexpiredate { get; set; }

        [XmlAttribute]
        public string dateofbirth { get; set; }

        [XmlAttribute]
        public string placeofbirth { get; set; }

    }

    public class records
    {
        [XmlAttribute]
        public string date { get; set; }
    }

    // <benfperson firstname = "[NAV]" middlename="" lastname=""/>
    public class benfperson
    {
        [XmlAttribute]
        public string firstname { get; set; }

        [XmlAttribute]
        public string middlename { get; set; }
    }


    public class amount
    {
        [XmlAttribute]
        public string valueinbaht { get; set; }

        [XmlAttribute]
        public string valueinbahttxt { get; set; }
    }


    public class totalamount
    {
        [XmlAttribute]
        public string valueinbaht { get; set; }

        [XmlAttribute]
        public string valueinbahttxt { get; set; }
    }







}
