namespace Evolution.Textkernel.Models
{
    using System;
    using System.Xml.Serialization;

    [Serializable()]
    [XmlRoot("Profile")]
    public class Profile
    {
        [XmlElement("ProfileSummary")]
        public ProfileSummary Summary { get; set; }

        [XmlElement("Personal")]
        public Personal Personal { get; set; }

        [XmlElement("ExtraInfo")]
        public ExtraInfo ExtraInfo { get; set; }

        [XmlArrayItem("EducationItem")]
        public EducationItem[] EducationHistory { get; set; }

        [XmlArrayItem("RecentEmploymentItem")]
        public EmploymentItem[] RecentEmploymentHistory { get; set; }

        [XmlArrayItem("EmploymentItem")]
        public EmploymentItem[] EmploymentHistory { get; set; }

        [XmlElement("Skills")]
        public Skills Skills { get; set; }

        [XmlArrayItem("Keyword")]
        public string[] FullTextKeywords { get; set; }

        [XmlElement("DocumentText")]
        public string DocumentText { get; set; }

        [XmlElement("DocumentHtml")]
        public string DocumentHtml { get; set; }

        [XmlElement("Performance")]
        public Performance Performance { get; set; }

        [XmlAttribute("lang")]
        public string Language { get; set; }

        [XmlAttribute("file")]
        public string File { get; set; }
    }
}