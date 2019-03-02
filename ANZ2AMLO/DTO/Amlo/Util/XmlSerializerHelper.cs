using System;
using System.Xml;
using System.IO;
using System.Data;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Diagnostics;
using System.Configuration;
namespace DTO.Util
{
	/// <summary>
	/// Summary description for XmlSerializerHelper.
	/// </summary>
	public class XmlSerializerHelper
	{
        public static string BookingXSLPath = "";//ConfigurationSettings.AppSettings["BookingXSLPath"];
		public XmlSerializerHelper()
		{
		}
        
		public static string SerializeObjectToString(Object Objects)
		{
			string strXml=string.Empty;
			MemoryStream memoryStream=new MemoryStream();
			XmlDocument xmlDocument=new XmlDocument();
			XmlSerializer xmlSerializer=new XmlSerializer(Objects.GetType());
			xmlSerializer.Serialize(memoryStream,Objects);
			memoryStream.Position=0;
			xmlDocument.Load(memoryStream);
			memoryStream.Close();
			strXml=xmlDocument.InnerXml;
			return strXml;
		}
        public static XmlElement SerializeObjectToXML(Object Objects)
        {
            string strXml = string.Empty;
            XmlElement xle = null;
            MemoryStream memoryStream = new MemoryStream();
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(Objects.GetType());
            xmlSerializer.Serialize(memoryStream, Objects);
            memoryStream.Position = 0;
            xmlDocument.Load(memoryStream);
            memoryStream.Close();
            xle = xmlDocument.DocumentElement;
            return xle;
        }
		public static DataSet SerializeObjectToDataSet(Object Objects)
		{
			DataSet ds=new DataSet();

			MemoryStream memoryStream=new MemoryStream();
			XmlSerializer xmlSerializer=new XmlSerializer(Objects.GetType());
			xmlSerializer.Serialize(memoryStream,Objects);
			memoryStream.Position=0;
			ds.ReadXml(memoryStream);
			memoryStream.Close();
			return ds;
		}
		public static Object DeserializeXmlToObject(Type type,string strXml)
		{
			Object obj;
			XmlReader xmlReader = null;
			
			try
			{
				xmlReader = new XmlTextReader(new StringReader(strXml));
				XmlSerializer serializer = new XmlSerializer(type);	
				obj = serializer.Deserialize(xmlReader);
			}
			finally
			{
				if(xmlReader != null)
					xmlReader.Close();
			}
			return obj;
		}

		public static XmlElement GetTransformData(XmlElement xleBooking)
		{
			return GetTransformData(xleBooking,BookingXSLPath);
		}

		public static XmlElement GetTransformData(XmlElement xleBooking,string strBookingXSLPath)
		{
			XmlElement xle = null;
			XmlTextReader reader = null;

			try 
			{
				string tmx = "<Booking>"+xleBooking.InnerXml+"</Booking>";
				MemoryStream stream = new MemoryStream();
				XslTransform xslTf = new XslTransform();
				XsltArgumentList xslArg = new XsltArgumentList();
				xslTf.Load(strBookingXSLPath);
				//DateTimeUtil objVal=new DateTimeUtil();
				//xslArg.AddExtensionObject("urn:dateFormat",objVal);

				//utility for rename flight number
				//xslArg.AddExtensionObject("urn:SegmentUtil", new SegmentUtil());
			
				//more parameter from configuration files
				//pass as xsl-parameter
				//xslArg.AddParam("BranchCode", "", ConfigurationSettings.AppSettings["branchCode"]);
				//xslArg.AddParam("CompanyCode", "", ConfigurationSettings.AppSettings["companyCode"]);


				reader = new XmlTextReader( new StringReader(tmx));
				XPathDocument doc = new XPathDocument(reader);
				//xslTf.Transform(doc,xslArg,Response.Output);
				xslTf.Transform(doc,xslArg,stream,null);
				XmlDocument xmlDoc = new XmlDocument();
				stream.Position = 0;
				xmlDoc.Load(stream);
				xmlDoc.Normalize();
				xle = xmlDoc.DocumentElement;
				Debug.WriteLine("Debug in Serialize : "+xle.InnerXml);
			} 
			catch (Exception ex)
			{
				//log.Warn(string.Format("transform failed: {0}", strBookingXSLPath), ex);
				//throw new BookingBaseException(ex.Message);
				string tt=ex.ToString();
			}
			finally
			{   //reader stream must be released.
				if(reader != null)
					reader.Close();
			}
			return xle;
		}

	}
}
