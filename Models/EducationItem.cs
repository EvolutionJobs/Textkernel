namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class EducationItem
    {
        [XmlElement("EducationLevelDescription")]
        public string EducationLevelDescription { get; set; }

        [XmlElement("InstituteName")]
        public string InstituteName { get; set; }

        [XmlElement("EducationLevelCode")]
        public string EducationLevelCode { get; set; }

        [XmlElement("Major")]
        public string Major { get; set; }

        [XmlElement("GPA")]
        public string GradePointAverage { get; set; }

        [XmlElement("StartDate")]
        public string StartDate { get; set; }

        [XmlElement("EndDate")]
        public string EndDate { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }
    }
}
