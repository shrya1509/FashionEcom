using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace BunaWebDesign.Models
{
    [XmlRoot(ElementName = "row")]
    public class Row
    {
        [XmlElement(ElementName = "Product_Code")]
        public string Product_Code { get; set; }
        [XmlElement(ElementName = "Product_Title")]
        public string Product_Title { get; set; }
        [XmlElement(ElementName = "SKU")]
        public string SKU { get; set; }
        [XmlElement(ElementName = "Parent_SKU")]
        public string Parent_SKU { get; set; }
        [XmlElement(ElementName = "Price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; }
        [XmlElement(ElementName = "Size")]
        public string Size { get; set; }
        [XmlElement(ElementName = "images")]
        public string Images { get; set; }
        [XmlElement(ElementName = "Description1")]
        public string Description1 { get; set; }
        [XmlElement(ElementName = "Description2")]
        public string Description2 { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class RootHome
    {
        [XmlElement(ElementName = "row")]
        public List<Row> Row { get; set; }
    }

}