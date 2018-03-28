namespace Evolution.Textkernel.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;

    public class ProfileSummary
    {
        [XmlElement("CurrentJob")]
        public string CurrentJob { get; set; }

        [XmlElement("CurrentEmployer")]
        public string CurrentEmployer { get; set; }

        [XmlElement("CurrentEmployerLocation")]
        public string CurrentEmployerLocation { get; set; }

        [XmlElement("TotalExperienceYears")]
        public decimal? TotalExperienceYears { get; set; }

        [XmlElement("HighestEducationLevelCode")]
        public int? HighestEducationLevelCode { get; set; }

        [XmlElement("SummaryAmbitionSection")]
        public string SummaryAmbitionSection { get; set; }

        [XmlElement("CVComment")]
        public string CVComment { get; set; }
    }
}
