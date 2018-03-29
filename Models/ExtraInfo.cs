namespace Evolution.Textkernel.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;

    public class ExtraInfo
    {
        [XmlElement("TrxmlID")]
        public string TrxmlID { get; set; }

        [XmlElement("Source")]
        public string Source { get; set; }

        [XmlElement("ExtraInfo1")]
        public string ExtraInfo1 { get; set; }

        [XmlElement("ExtraInfo2")]
        public string ExtraInfo2 { get; set; }

        [XmlElement("ExtraInfo3")]
        public string ExtraInfo3 { get; set; }
    }
}
