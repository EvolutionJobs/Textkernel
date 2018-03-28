namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class ProfilePicture
    {
        [XmlElement("Base64Content")]
        public string Base64Content { get; set; }

        [XmlElement("Filename")]
        public string Filename { get; set; }

        [XmlElement("ContentType")]
        public string ContentType { get; set; }
    }
}