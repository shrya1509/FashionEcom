using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BunaWebDesign.Models;
using System.Xml.Serialization;
using System.Xml;

namespace BunaWebDesign.Controllers
{
    public class CollectionsController : Controller
    {
        //s
        // GET: /collections/

        public ActionResult Index()
        {
            RootCollection root = LoadXml();
            //root.Row.Shuffle();
            ViewData["data"] = root;
            return View();
        }

        public RootCollection LoadXml()
        {
            RootCollection root;
            var serializer = new XmlSerializer(typeof(RootCollection));
            string path = System.Web.HttpContext.Current.Server.MapPath("~/xmldata/");
            using (var reader = XmlReader.Create(path + "\\design.xml"))
            {
                root = (RootCollection)serializer.Deserialize(reader);
                // do whatever you wanted to do with those locations
            }

            return root;


        }


    }
}
