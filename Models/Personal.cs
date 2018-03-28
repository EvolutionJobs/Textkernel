namespace Evolution.Textkernel.Models
{
using System;
using System.Collections.Generic;
using System.Text;
    using System.Xml.Serialization;

    public class Personal
    {
        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("MiddleName")]
        public string MiddleName { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }
    }
}
