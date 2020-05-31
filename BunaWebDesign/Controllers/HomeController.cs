using BunaWebDesign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace BunaWebDesign.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            RootHome root = LoadXml();
            ViewData["data"] = root;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public RootHome LoadXml()
        {
            ////https://stackoverflow.com/questions/14912483/what-is-the-easiest-way-to-convert-this-xml-document-to-my-object

            RootHome root;
            var serializer = new XmlSerializer(typeof(RootHome));

            string path = System.Web.HttpContext.Current.Server.MapPath("~/xmldata/");
            using (var reader = XmlReader.Create(path+"\\products.xml"))
            {
                root = (RootHome)serializer.Deserialize(reader);
                
                // do whatever you wanted to do with those locations
            }
            return root;
        }
    }
}
