namespace Evolution.Textkernel.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;

    [Serializable()]
    [XmlRoot("Profile")]
    public class Profile
    {
        [XmlElement("ProfileSummary")]
        public ProfileSummary Summary { get; set; }

        [XmlElement("Personal")]
        public Personal Personal { get; set; }
    }
}
