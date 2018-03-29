namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class Address
    {
        [XmlElement("StreetName")]
        public string StreetName { get; set; }

        [XmlElement("StreetNumberBase")]
        public string StreetNumberBase { get; set; }

        [XmlElement("SecUnit")]
        public string SecUnit { get; set; }

        [XmlElement("PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement("City")]
        public string City { get; set; }

        [XmlElement("RegionCode")]
        public string RegionCode { get; set; }

        [XmlElement("RegionCodeDescription")]
        public string RegionCodeDescription { get; set; }

        [XmlElement("CountryCode")]
        public string CountryCode { get; set; }

        [XmlElement("CountryCodeDescription")]
        public string CountryCodeDescription { get; set; }
    }
}
