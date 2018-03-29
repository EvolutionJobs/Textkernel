namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class Personal
    {
        [XmlElement("FirstName", IsNullable = true)]
        public string FirstName { get; set; }

        [XmlElement("MiddleName", IsNullable = true)]
        public string MiddleName { get; set; }

        [XmlElement("LastName", IsNullable = true)]
        public string LastName { get; set; }

        [XmlElement("NationalityCode", IsNullable = true)]
        public string NationalityCode { get; set; }

        [XmlElement("NationalityCodeDescription", IsNullable = true)]
        public string NationalityCodeDescription { get; set; }

        [XmlElement("DOB", IsNullable = true)]
        public string DateOfBirth { get; set; }

        [XmlElement("Gender", IsNullable = true)]
        public string Gender { get; set; }

        [XmlElement("MaritalStatus", IsNullable = true)]
        public string MaritalStatus { get; set; }

        [XmlElement("DriversLicence", IsNullable = true)]
        public string DriversLicence { get; set; }

        [XmlElement("Address", IsNullable = true)]
        public Address Address { get; set; }
    }
}