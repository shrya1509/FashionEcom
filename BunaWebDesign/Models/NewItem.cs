using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
 

namespace BunaWebDesign.Models
{

    [XmlRoot(ElementName="row")]
    public class NewItem
    {
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Images")]
        public string Images { get; set; }
        [XmlElement(ElementName = "Price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "Product_Title")]
        public string Product_Title { get; set; }
    }

    [XmlRoot(ElementName="root")]
    public class RootCollection
    {
        [XmlElement(ElementName = "row")]
        public List<NewItem> Row { get; set; }
    }





}