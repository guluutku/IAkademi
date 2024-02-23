using System;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.ViewComponents
{
	public class Exchange : ViewComponent
	{
		public string Invoke()
		{
			string url = "http://www.tcmb.gov.tr/kurlar/today.xml";

			var xmlDoc = new XmlDocument();
			xmlDoc.Load(url);

			string dolar = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

			string usdSatis = dolar.Substring(0, 5);

			return $"{usdSatis}";
        }
	}
}

