namespace Evolution.Textkernel.Models
{
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
        public string TotalExperienceYears { get; set; }

        [XmlElement("HighestEducationLevelCode")]
        public string HighestEducationLevelCode { get; set; }

        [XmlElement("SummaryAmbitionSection")]
        public string SummaryAmbitionSection { get; set; }

        [XmlElement("CVComment")]
        public string CVComment { get; set; }

        [XmlElement("SalaryRangeCode")]
        public string SalaryRangeCode { get; set; }

        [XmlElement("SalaryRangeDescription")]
        public string SalaryRangeDescription { get; set; }

        [XmlElement("ProfileStatusCode")]
        public string ProfileStatusCode { get; set; }

        [XmlElement("ProfileStatusCodeDescription")]
        public string ProfileStatusCodeDescription { get; set; }

        [XmlElement("ExternalID")]
        public string ExternalID { get; set; }

        [XmlElement("ProfilePicture")]
        public ProfilePicture Picture { get; set; }
    }
}