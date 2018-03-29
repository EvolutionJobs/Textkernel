namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class SoftSkill
    {
        [XmlElement("SoftSkillName")]
        public string Name { get; set; }

        [XmlElement("SoftSkillFirstUsed")]
        public string FirstUsed { get; set; }

        [XmlElement("SoftSkillLastUsed")]
        public string LastUsed { get; set; }
    }
}