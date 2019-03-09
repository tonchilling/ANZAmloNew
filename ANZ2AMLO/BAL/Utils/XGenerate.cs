using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Amlo.Master;
using DTO.Amlo.Trans;
using DTO.Amlo.Export;
using DevExpress.Spreadsheet;
using System.IO;
namespace ANZ2AMLO.BAL.Util
{
   public class XGenerate
    {
        public static string AmloCustomerToXml(List<M_CustomerDTO> customerList, string path)
        {

            #region local variable 
            List<AmloToCustomer> customerResultList = null;
            AmloToCustomer customerData = null;


            customerData = new AmloToCustomer();
            List<reportingdetail> reportingDetailList = new List<reportingdetail>();
            List<report> reportList = new List<report>();
            report report = null;
            reportingdetail reportingdetailData = null;

            List<person> personList = new List<person>();
            person personData = null;


            List<contact> contactList = new List<contact>();
            contact contactData = null;
            address addressData = null;
            #endregion


            foreach (M_CustomerDTO customerObj in customerList)
            {
                reportingdetailData = new reportingdetail() { orgid = customerObj.JuristicIDNo, orgname = customerObj.RegBusinessName };

                reportingDetailList.Add(reportingdetailData);


                #region report
                //<report>
                report = new report();
                contactList = new List<contact>();
                personList = new List<person>();
                //<reportorgdetail branchcode="00000" orgname="ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)" telno="022639700"/>
                report.reportingdetail = new reportingdetail() { branchcode = customerObj.CustomerNo, orgname = customerObj.RegBusinessName, telno = customerObj.TelNo };

                //<dcn value="09-00107557000420-00000-255912-000084" doctype="1-05-9" revision="" date="" refdocno="" refdoctype=""/>
                report.dcn = new dcn() { value = "09-00107557000420-00000-255912-000084", doctype = "1-05-9", revision = "", date = "", refdocno = "", refdoctype = "" };

                //<reporttype value="2"/>
                report.reportType = new reportType() { value = "2" };
                #endregion

                #region Personal
                personData = new person()
                {
                    anothermethod = "TRUE",
                    am_transactionmethod = "DOCUMENT",
                    value = "TRANSACTING-PERSON",
                    relationship = "SELF",
                    relationshipdesc = ""
                };


                personData.personName = new personName()
                {
                    type = "LEGAL",
                    title = "",
                    firstname = "[NAV]",
                    middlename = "",
                    lastname = "",
                    dateofbirth = "",
                    nationality = "STATELESS",
                    legalpersonid = "[NAV]"
                };

                personData.occupation = new occupation() { companyname = customerObj.RegBusinessName, businesstype = customerObj.PrimaryBusinessTypeCode, businesstype_desc = customerObj.PrimaryBusinessTypeDescription, occ_type = "99", occ_desc = "[NAV]", };

                foreach (M_Customer_Address custAdd in customerObj.AddressList)
                {

                    addressData = new address()
                    {
                        no = "[NAV]",
                        moo = "",
                        building = "",
                        soi = "",
                        road = "",
                        subdistrict = "[NAV]",
                        address1 = custAdd.PrincipleAddress,
                        address2 = "",
                        district = "[NAV]",
                        province = custAdd.City,
                        zipcode = custAdd.Zipcode,
                        countrycode = "TH"
                    };

                    contactData = new contact() { type = "ADDR", address = addressData };

                    contactList.Add(contactData);

                    /* contactData = new contact() { type = "COMPANY-ADDR", noinfo = "TRUE" };
                     contactList.Add(contactData);
                     contactData = new contact() { type = "CONTACT-ADDR", noinfo = "TRUE" };
                     contactList.Add(contactData);
                     */
                    break;

                }

                personData.contact = contactList;
                personList.Add(personData);
                #endregion

                report.person = personList;

                reportList.Add(report);
            }

            customerData.reportingdetail = reportingDetailList;
            customerData.report = reportList;
            string data = string.Format("{0}", DTO.Util.XmlSerializerHelper.SerializeObjectToString(customerData));

            DTO.Util.Utility.WriteObject2File(path,string.Format("Customer{0}",DateTime.Now.ToString("yyMMddHHmm")), data,"xml");

            return data;
        }

        public static bool TransactionToExcel(List<TransactionANZ> tranList, string path)
        {
            bool result = false;
            Workbook workBook = new Workbook();
            Worksheet worksheet = workBook.Worksheets[0];
            worksheet.Cells[0, 0].SetValueFromText("No");
            worksheet.Cells[0, 1].SetValueFromText("Group Name");
            worksheet.Cells[0, 2].SetValueFromText("ANZ Customer InstrumentId");
            worksheet.Cells[0, 3].SetValueFromText("ANZ Customer BANKAccount Number");
            worksheet.Cells[0, 4].SetValueFromText("Transaction Date");
            worksheet.Cells[0, 5].SetValueFromText("TranxSendReceive");
            worksheet.Cells[0, 6].SetValueFromText("TranxAmount THB");
            worksheet.Cells[0, 7].SetValueFromText("Tranx Amount Currency");
            worksheet.Cells[0, 8].SetValueFromText("Tranx Exchange Rate");
            worksheet.Cells[0, 9].SetValueFromText("Tranx Objective");
            worksheet.Cells[0, 10].SetValueFromText("ANZ Customer Register Name");
            worksheet.Cells[0, 11].SetValueFromText("ANZ Customer Register ID");
            worksheet.Cells[0, 12].SetValueFromText("ANZ Cutomer Business Code");
            worksheet.Cells[0, 13].SetValueFromText("ANZ Cutomer Register Address");
            worksheet.Cells[0, 14].SetValueFromText("ANZ Cutomer Register Address Country");
            worksheet.Cells[0, 15].SetValueFromText("ANZ Customer Register Date");
            worksheet.Cells[0, 16].SetValueFromText("Send Bank Account Number");
            worksheet.Cells[0, 17].SetValueFromText("Send Tranx Ref No");
            worksheet.Cells[0, 18].SetValueFromText("Send Bank Name");
            worksheet.Cells[0, 19].SetValueFromText("Send Bank Country");
            worksheet.Cells[0, 20].SetValueFromText("Send Name");
            worksheet.Cells[0, 21].SetValueFromText("Send Address");
            worksheet.Cells[0, 22].SetValueFromText("Send Description");
            worksheet.Cells[0, 23].SetValueFromText("Send Id No");
            worksheet.Cells[0, 24].SetValueFromText("Send Id Issue By");
            worksheet.Cells[0, 25].SetValueFromText("Bene Bank Account Number");
            worksheet.Cells[0, 26].SetValueFromText("Bene Tranx Ref No");
            worksheet.Cells[0, 27].SetValueFromText("Bene Bank Name");
            worksheet.Cells[0, 28].SetValueFromText("Bene Bank Country");
            worksheet.Cells[0, 29].SetValueFromText("Bene Name");
            worksheet.Cells[0, 30].SetValueFromText("Bene Address");
            worksheet.Cells[0, 31].SetValueFromText("Bene Id Description");
            worksheet.Cells[0, 32].SetValueFromText("Bene Id No");
            worksheet.Cells[0, 33].SetValueFromText("Bene Id Issue By");

            int row = 1, col = 0;
            string addr, acc;
            foreach (TransactionANZ tranObj in tranList)
            {
                addr = "";
                acc = "";
               worksheet.Cells[row, 0].SetValueFromText(Convert.ToString(row + 1));
                worksheet.Cells[row, 1].SetValueFromText("");
                worksheet.Cells[row, 2].SetValueFromText(tranObj.ANZCustomerInstrumentId);
                worksheet.Cells[row, 3].SetValueFromText(tranObj.ANZCustomerBANKAccountNumber);
                worksheet.Cells[row, 4].SetValueFromText(tranObj.TransactionDate);
                worksheet.Cells[row, 5].SetValueFromText(tranObj.TranxSendReceive);
                worksheet.Cells[row, 6].SetValueFromText(tranObj.TranxAmountTHB);
                worksheet.Cells[row, 7].SetValueFromText(tranObj.TranxAmountCurrency);
                worksheet.Cells[row, 8].SetValueFromText(tranObj.TranxExchangeRate);
                worksheet.Cells[row, 9].SetValueFromText(tranObj.TranxObjective);
                worksheet.Cells[row,10].SetValueFromText(tranObj.ANZCustomerRegisterID);
                worksheet.Cells[row, 11].SetValueFromText(tranObj.ANZCutomerBusinessCode);
                worksheet.Cells[row, 12].SetValueFromText(tranObj.ANZCutomerRegisterAddress);
                worksheet.Cells[row, 13].SetValueFromText(tranObj.ANZCutomerRegisterAddressCountry);
                worksheet.Cells[row, 14].SetValueFromText(tranObj.ANZCustomerRegisterDate);
                worksheet.Cells[row, 15].SetValueFromText(tranObj.SendBankAccountNumber);
                worksheet.Cells[row, 16].SetValueFromText(tranObj.SendTranxRefNo);
                worksheet.Cells[row, 17].SetValueFromText(tranObj.SendBankName);
                worksheet.Cells[row, 18].SetValueFromText(tranObj.SendBankCountry);
                worksheet.Cells[row, 19].SetValueFromText(tranObj.SendName);
                worksheet.Cells[row, 20].SetValueFromText(tranObj.SendAddress);
                worksheet.Cells[row, 21].SetValueFromText(tranObj.SendDescription);
                worksheet.Cells[row, 22].SetValueFromText(tranObj.SendIdNo);
                worksheet.Cells[row, 23].SetValueFromText(tranObj.SendIdIssueBy);
                worksheet.Cells[row, 24].SetValueFromText(tranObj.BeneBankAccountNumber);
                worksheet.Cells[row, 25].SetValueFromText(tranObj.BeneTranxRefNo);
                worksheet.Cells[row, 26].SetValueFromText(tranObj.BeneBankName);
                worksheet.Cells[row, 27].SetValueFromText(tranObj.BeneBankCountry);
                worksheet.Cells[row, 28].SetValueFromText(tranObj.BeneName);
                worksheet.Cells[row, 29].SetValueFromText(tranObj.BeneAddress);
                worksheet.Cells[row, 30].SetValueFromText(tranObj.BeneIdDescription);
                worksheet.Cells[row, 31].SetValueFromText(tranObj.BeneIdNo);
                worksheet.Cells[row, 32].SetValueFromText(tranObj.BeneIdIssueBy);
                row++;
            }



            string fullpath = string.Format(@"{0}\Transaction{1}.xlsx", path, DateTime.Now.ToString("yyMMddHHmm"));
            using (FileStream stream = new FileStream(fullpath,
     FileMode.Create, FileAccess.ReadWrite))
            {
                workBook.SaveDocument(stream, DocumentFormat.Xlsx);
            }


            return result;

        }

        public static bool CustomerToExcel(List<M_CustomerDTO> customerList, string path)
        {
            bool result = false;
            Workbook workBook = new Workbook();
            Worksheet worksheet = workBook.Worksheets[0];
            worksheet.Cells[0,0].SetValueFromText("No");
            worksheet.Cells[0, 1].SetValueFromText("Customer No");
            worksheet.Cells[0, 2].SetValueFromText("Customer ID");
            worksheet.Cells[0, 3].SetValueFromText("ID Number");
            worksheet.Cells[0, 4].SetValueFromText("Register business name");
            worksheet.Cells[0, 5].SetValueFromText("Register business name TH");
            worksheet.Cells[0, 6].SetValueFromText("Customer Name(MIDANZ)");
            worksheet.Cells[0, 7].SetValueFromText("Register Date");
            worksheet.Cells[0, 8].SetValueFromText("Primary Bussiness Type Code");
            worksheet.Cells[0, 9].SetValueFromText("Address");
            worksheet.Cells[0, 10].SetValueFromText("Account");

            int row = 1, col = 0;
            string addr, acc;
            foreach (M_CustomerDTO customerObj in customerList)
            {
                addr = "";
                acc = "";
                worksheet.Cells[row, 0].SetValueFromText(Convert.ToString(row+1));
                worksheet.Cells[row, 1].SetValueFromText(customerObj.CustomerNo);
                worksheet.Cells[row, 2].SetValueFromText(customerObj.CustomerID);
                worksheet.Cells[row, 3].SetValueFromText(customerObj.JuristicIDNo);
                worksheet.Cells[row, 4].SetValueFromText(customerObj.RegBusinessName);
                worksheet.Cells[row, 5].SetValueFromText(customerObj.RegBusinessNameTH);
                worksheet.Cells[row, 6].SetValueFromText(customerObj.CustomerName);
                worksheet.Cells[row, 7].SetValueFromText(customerObj.RegisterDate);
                worksheet.Cells[row, 8].SetValueFromText(customerObj.PrimaryBusinessTypeCode);

                if (customerObj != null && customerObj.AddressList != null)
                {
                    foreach (M_Customer_Address add in customerObj.AddressList)
                    {
                        addr += add.PrincipleAddress + ";";
                    }
                    if (addr.Length > 0)
                    {
                        addr = addr.Substring(0, addr.Length-1);
                    }
                }
                worksheet.Cells[row, 9].SetValueFromText(addr);

                if (customerObj != null && customerObj.AccountList != null)
                {
                    foreach (M_Customer_Account accountA in customerObj.AccountList)
                    {
                        acc += accountA.AccountNumber + ";";
                    }
                    if (acc.Length > 0)
                    {
                        acc = acc.Substring(0, acc.Length - 1);
                    }
                }
                worksheet.Cells[row, 10].SetValueFromText(acc);


                row++;
            }

            

            string fullpath = string.Format(@"{0}\Customer{1}.xlsx", path, DateTime.Now.ToString("yyMMddHHmm"));
            using (FileStream stream = new FileStream(fullpath,
     FileMode.Create, FileAccess.ReadWrite))
            {
                workBook.SaveDocument(stream, DocumentFormat.Xlsx);
            }


            return result;

        }
    }
}
