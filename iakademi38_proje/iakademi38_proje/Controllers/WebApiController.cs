using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace iakademi38_proje.Controllers
{
    public class WebApiController : Controller
    {
        public IActionResult PharmacyOnDuty()
        {
            /*
                https://openfiles.izmir.bel.tr/111324/docs/ibbapi-WebServisKullanimDokumani_1.0.pdf

            https://openapi.izmir.bel.tr/api/ibb/cbs/wizmirnetnoktalari

            https://acikveri.bizizmir.com/dataset/kablosuz-internet-baglanti-noktalari/resource/982875a4-2bb6-4178-8ee2-3f07641156bb

            https://acikveri.bizizmir.com/dataset/izban-banliyo-hareket-saatleri
            */

            // https://openapi.izmir.bel.tr/api/ibb/nobetcieczaneler

            string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/ibb/nobetcieczaneler");

            var pharmacy = JsonConvert.DeserializeObject<List<Pharmacy>>(json);

            return View(pharmacy);
        }

        public IActionResult CultureAndArt()
        {
            string json = new WebClient().DownloadString("https://openapi.izmir.bel.tr/api/ibb/kultursanat/etkinlikler");

            var activite = JsonConvert.DeserializeObject<List<Activite>>(json);
            return View(activite);
        }

        public IActionResult ExchangeRate()
        {
            string url = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(url);

            string usdSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            ViewBag.usdSatis = usdSatis.Substring(0, 5);

            string usdAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            ViewBag.usdAlis = usdAlis.Substring(0, 5);

            return View();

            // Only return view if Invoke component is in use
            // return View();
        }

        public IActionResult WeatherForecast()
        {
            string apikey = "52b72dad903d5a0244a91d029fce3686";
            string city = "izmir";

            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&lang=tr&units=metric&appid=" + apikey;

            XDocument weather = XDocument.Load(url);
            ViewBag.temperature = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}