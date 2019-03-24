using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ANZ2AMLO.Contexts;
using GreatFriends.ThaiBahtText;
using System.IO;
using System.Diagnostics;

namespace ANZ2AMLO.Forms
{
    public partial class frmGenerateAMLO : DevExpress.XtraEditors.XtraForm
    {
        public frmGenerateAMLO()
        {
            InitializeComponent();
        }

        private void frmGenerateAMLO_Load(object sender, EventArgs e)
        {
            //List<GenAMLOData> cus = new List<GenAMLOData>();

            //for (int i = 1; i < 21; i++)
            //{
            //    cus.Add(new GenAMLOData()
            //    {
            //        colNo = i.ToString(),
            //        CustomerID = string.Format("CusID00{0}", i.ToString()),
            //        CutomerNo = string.Format("CusNo00{0}", i.ToString()),
            //        CutomerAC = "AC001",
            //        RegisteredBusinessName = "Company XXX .,LTD",
            //        BusinessNameTH = "Name Thai",
            //        CustomerName = "Customer Name",
            //        RegisteredTAXID = "TaxID001",
            //        TelNo = "01-000-0001",
            //        RegistoerDate = DateTime.Now,
            //        BusinessTypeCode = "Type001",
            //        DefaultAddress = "Address 001",
            //        ContractAdd = "Con Address",
            //        CompanyAdd = "Company Addess",
            //        RegAddress = "Reg Address"
            //    });
            //}

            //this.gridView1.GridControl.DataSource = cus;
            //foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            //{
            //    item.MaxWidth = 0;
            //}

            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                var obj = (from t0 in dbc.View_IncomingAndOutgoings
                           where Convert.ToInt32(t0.valueinbahttxt) > 700000
                           select t0).ToList();
                gridView1.GridControl.DataSource = obj;


            }
            gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
        }

        private string GenXML(string Val)
        {
            StringBuilder strXML = new StringBuilder();
            //Header XML

            strXML.AppendLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");
            strXML.AppendLine(@"<ersreport version=""1.0"">");
            strXML.AppendLine(string.Format(@"<reportingdetail orgid=""{0}"" orgname=""{1}""/>", @"0107557000420", @"ธนาคารเอเอ็นแซด (ไทย) จำกัด (มหาชน)"));

            using (AnzContextsDataContext dbc = new AnzContextsDataContext())
            {
                var obj = (from t0 in dbc.View_IncomingAndOutgoings
                           where Convert.ToInt32(t0.valueinbaht) > 700000
                           select t0).ToList();

                foreach (var item in obj)
                {

                    // Detail Loop From Database
                    strXML.AppendLine(@"<report>");
                    strXML.AppendLine(string.Format(@"<reportorgdetail branchcode=""{0}"" orgname=""{1}"" telno=""{2}""/>", @"00000", @"ธนาคารเอเอ็นแซด(ไทย) จำกัด(มหาชน)", @"02 263 9700"));
                    strXML.AppendLine(string.Format(@"<dcn value=""{0}"" doctype=""{1}""/>", @"09-00107557000420-00000-256102-000191", @"1-05-9"));

                    strXML.AppendLine(string.Format(@"<person value=""{0}"" relationship=""{1}"" anothermethod=""{2}"" am_transactionmethod=""{3}"" am_customeraccno=""{4}"">", @"TRANSACTING-PERSON", @"SELF", @"TRUE", @"DOCUMENTS", @"501981"));
                    strXML.AppendLine(string.Format(@"<name type=""{0}"" firstname=""{1}"" lastname=""{2}"" nationality=""{3}""/>", @"PERSON", @"[NAV]", @"[NAV]", @"STATELESS"));
                    strXML.AppendLine(string.Format(@"<occupation companyname=""{0}"" occ_desc=""{1}"" occ_type=""{2}""/>", @"[NAV]", @"[NAV]", @"99"));
                    // contact
                    strXML.AppendLine(@"<contact type=""ADDR"">");
                    strXML.AppendLine(string.Format(@"<address no=""{0}"" subdistrict=""{1}"" district=""{2}"" province=""{3}"" zipcode=""{4}"" countrycode=""{5}"">", @"[NAV]", @"[NAV]", @"[NAV]", @"[NAV]", @"[NAV]", @"TH"));
                    strXML.AppendLine(@"<othercontact/>");
                    strXML.AppendLine(@"</address>");
                    strXML.AppendLine(@"</contact>");
                    // End contact
                    strXML.AppendLine(string.Format(@"<contact type=""{0}"" noinfo=""{1}""/>", @"COMPANY-ADDR", @"TRUE"));
                    strXML.AppendLine(string.Format(@"<contact type=""{0}"" noinfo=""{1}""/>", @"COMPANY-ADDR", @"TRUE"));
                    strXML.AppendLine(string.Format(@"<iddoc type=""{0}"" typedesc=""{1}"" idno=""{2}"" issueby=""{3}"" issuedate=""{4}"" expiredate=""{5}""/>", @"99", @"[NAV]", @"[NAV]", @"[NAV]", @"[NAV]", @"[NAV]"));
                    strXML.AppendLine(@"</person>");
                    // End person
                    strXML.AppendLine(string.Format(@"<person value=""{0}"" relationship=""{1}"">", @"RELATED-PERSON", @"COTRAN"));
                    // Upper fix Data

                    strXML.AppendLine(string.Format(@"<name type=""{0}"" firstname=""{1}"" legalpersonid=""{2}""/>", @"LEGAL", item.firstname, item.legalpersonid));
                    //If CompanyBusinessTypeDescription have value, then fix as "99" else not gen this attribute
                    strXML.AppendLine(string.Format(@"<occupation businesstype_desc=""{0}"" businesstype=""{1}""/>", @"Spinning of synthetic textile fibres", item.businesstype_code));

                    strXML.AppendLine(@"<contact type=""ADDR"">");
                    // strXML.AppendLine(string.Format(@"<address no=""{0}"" building=""{1}"" road=""{2}"" subdistrict=""{3}"" district=""{4}"" province=""{5}"" zipcode=""{6}"" countrycode=""{7}"">", @"888/164-165", @"MAHATUN PLAZA 16TH FLOOR", @"PLCENCHIT", @"PATHUMWAN", @"PATHUMWAN", @"BANGKOK", @"10330", @"TH"));
                    strXML.AppendLine(string.Format(@"<address no=""{0}"" countrycode=""{1}"">", item.address1, item.orgcountry));

                    strXML.AppendLine(@"<othercontact/>");
                    strXML.AppendLine(@"</address>");
                    strXML.AppendLine(@"</contact>");

                    strXML.AppendLine(@" <contact type=""COMPANY-ADDR"" noinfo=""TRUE"">");
                   // strXML.AppendLine(string.Format(@"<address no=""{0}"" building=""{1}"" road=""{2}"" subdistrict=""{3}"" district=""{4}"" province=""{5}"" zipcode=""{6}"" countrycode=""{7}"">", @"888/164-165", @"MAHATUN PLAZA 16TH FLOOR", @"PLCENCHIT", @"PATHUMWAN", @"PATHUMWAN", @"BANGKOK", @"10330", @"TH"));
                   // strXML.AppendLine(@"<othercontact/>");
                   // strXML.AppendLine(@"</address>");
                    strXML.AppendLine(@"</contact>");

                    strXML.AppendLine(@" <contact type=""CONTACT-ADDR"" noinfo=""TRUE"">");
                   // strXML.AppendLine(string.Format(@"<address no=""{0}"" building=""{1}"" road=""{2}"" subdistrict=""{3}"" district=""{4}"" province=""{5}"" zipcode=""{6}"" countrycode=""{7}"">", @"888/164-165", @"MAHATUN PLAZA 16TH FLOOR", @"PLCENCHIT", @"PATHUMWAN", @"PATHUMWAN", @"BANGKOK", @"10330", @"TH"));
                   // strXML.AppendLine(@"<othercontact/>");
                   // strXML.AppendLine(@"</address>");
                    strXML.AppendLine(@"</contact>");

                    strXML.AppendLine(string.Format(@"<iddoc type=""{0}"" typedesc=""{1}"" idno=""{2}"" issueby=""{3}"" issuedate=""{4}"" expiredate=""{5}""/>", @"99", @"AFFIDAVIT", item.idno, @"MINISTRY OF COMMERCE", item.issuedate, "[NOEXP]"));
                    strXML.AppendLine(@"</person>");
                    strXML.AppendLine(string.Format(@"<tsc date=""{0}"">",DateTime.Now.ToString("yyyy-MM-dd")));
                    strXML.AppendLine(@"<tscentry>");

                    strXML.AppendLine(string.Format(@"<amount valueinbaht=""{0}"" value=""{1}"" curr=""{2}"" exchangerate=""{3}"" valueinbahttxt=""{4}""/>", item.valueinbahttxt, item.value, item.curr, item.exchangerate, Convert.ToDecimal(item.valueinbaht).ThaiBahtText()));
                    strXML.AppendLine(string.Format(@"<typeoftsc transtype=""{0}"" type=""{1}""/>", @"INTERNATIONAL", @"SEND"));
                    strXML.AppendLine(string.Format(@"<transferdetail type=""{0}"" refno=""{1}"" org=""{2}"" orgcountry=""{3}"">", @"SEND", item.accountno, item.org, @"PL"));
                    strXML.AppendLine(string.Format(@"<td fullname=""{0}"" address=""{1}"" idtype=""{2}"" idtypedesc=""{3}"" idno=""{4}"" idissuer=""{5}""/>", item.fullname ,item.address, item.idtype, item.idtypedesc, item.idno, item.idissuer));
                    strXML.AppendLine(@"</transferdetail>");
                    strXML.AppendLine(string.Format(@" <transferdetail type=""{0}"" accountno=""{1}"" refno=""{2}"" org=""{3}"" orgcountry=""{4}"">", @"REC", item.accountno, item.refno, item.org, item.orgcountry));
                    strXML.AppendLine(string.Format(@"<td fullname=""{0}"" address=""{1}"" idtype=""{2}"" idtypedesc=""{3}"" idno=""{4}"" idissuer=""{5}""/>", item.fullname, item.address, item.type, item.idtypedesc, item.idno, item.idissuer));
                    strXML.AppendLine(@"</transferdetail>");
                    strXML.AppendLine(@"</tscentry>");
                    // End tscentry
                    strXML.AppendLine(string.Format(@"<totalamount valueinbaht=""{0}"" valueinbahttxt=""{1}""/>", item.valueinbaht, Convert.ToDecimal(item.valueinbaht).ThaiBahtText()));
                    strXML.AppendLine(string.Format(@"<objective>{0}</objective>", @"EXPORT BILL SETTLEMENT"));
                    strXML.AppendLine(@"</tsc>");
                    strXML.AppendLine(string.Format(@"<record date=""{0}""/>", item.TranxObjective));
                    strXML.AppendLine(@"<reporttype value=""2""/>");
                    strXML.AppendLine(@"</report>");
                }
            }

            // Footer XML

            strXML.AppendLine(@"</ersreport>");


            return strXML.ToString();
        }

        private void barGenXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                       string strOutput = GenXML("");
            string path =string.Format("{0}\\{1}.xml", txtOutput.Text, "XmlFile");
            File.WriteAllText(path, strOutput, Encoding.UTF8);

            DevExpress.XtraEditors.XtraMessageBox.Show("Generate XML Complete.", "XML");
            Process.Start("explorer.exe", txtOutput.Text);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtOutput.Text = fbd.SelectedPath;
                }
            }
        }
    }



    public class GenAMLOData
    {
        public string colNo { get; set; }
        public string CutomerNo { get; set; }
        public string CustomerID { get; set; }
        public string CutomerAC { get; set; }
        public string RegisteredBusinessName { get; set; }
        public string BusinessNameTH { get; set; }
        public string CustomerName { get; set; }
        public string RegisteredTAXID { get; set; }
        public string colDID { get; set; }
        public string colHID { get; set; }
        public DateTime RegistoerDate { get; set; }
        public string BusinessTypeCode { get; set; }
        public string TelNo { get; set; }
        public string DefaultAddress { get; set; }
        public string RegAddress { get; set; }
        public string ContractAdd { get; set; }
        public string CompanyAdd { get; set; }
        public string CompanyRegisterID { get; set; }
        public string TransactorCompanyBusinessType { get; set; }
    }

}