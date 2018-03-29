namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class OtherSkill
    {
        [XmlElement("OtherSkillName")]
        public string Name { get; set; }

        [XmlElement("OtherSkillFirstUsed")]
        public string OFirstUsed { get; set; }

        [XmlElement("OtherSkillLastUsed")]
        public string LastUsed { get; set; }
    }
}