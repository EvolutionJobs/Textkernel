namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class EmploymentItem
    {
        [XmlElement("JobTitle")]
        public string JobTitle { get; set; }

        [XmlElement("ExperienceONET")]
        public CodeValue<string> ExperienceOccupationalInformationNetwork { get; set; }

        [XmlElement("EmployerName")]
        public string EmployerName { get; set; }

        [XmlElement("EmployerCity")]
        public string EmployerCity { get; set; }

        [XmlElement("EmployerRegion")]
        public string EmployerRegion { get; set; }

        [XmlElement("EmployerCountry")]
        public string EmployerCountry { get; set; }

        [XmlElement("YearsExperience")]
        public CodeValue<int> YearsExperience { get; set; }

        [XmlElement("JobDescription")]
        public string JobDescription { get; set; }

        [XmlElement("StartDate")]
        public string StartDate { get; set; }

        [XmlElement("EndDate")]
        public string EndDate { get; set; }

        [XmlElement("JobCode")]
        public CodeValue<int> JobCode { get; set; }

        [XmlElement("JobGroup")]
        public CodeValue<int> JobGroup { get; set; }

        [XmlElement("JobClass")]
        public CodeValue<int> JobClass { get; set; }
    }
}