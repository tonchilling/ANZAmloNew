using System;
using System.Xml;

namespace DTO.Util
{
	/// <summary>
	/// Summary description for ReadXmlHelper.
	/// </summary>
	public class XmlHelper
	{
		public XmlHelper()
		{
		}
		public static string ReadXmlToString(string Path,string nodeName)
		{
			string strXml=string.Empty;
			XmlElement xmlElement=null;
			XmlDocument xmlDocument=null;
			try{
				xmlDocument=new XmlDocument();
				xmlDocument.Load(Path);
				xmlElement =(XmlElement)xmlDocument.DocumentElement;
				xmlElement.Normalize();
                strXml = string.Format("<{0} xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>" + xmlElement.InnerXml + "</{0}>", nodeName);		
			}
			catch(Exception ex)
			{
				string ee=ex.ToString();
				
			}

			return strXml;
		}
		public static XmlElement ReadXmls(string Path,string nodeName)
		{
			string strXml=string.Empty;
			XmlElement xmlElement=null;
			XmlDocument xmlDocument=null;
			try
			{
				xmlDocument=new XmlDocument();
				xmlDocument.Load(Path);
				xmlElement =(XmlElement)xmlDocument.DocumentElement;
				xmlElement.Normalize();
				//strXml="<Booking xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>"+xmlElement.InnerXml+"</Booking>";		
			}
			catch(Exception ex)
			{
				string ee=ex.ToString();
				
			}

			return xmlElement;
		}
	}
}
