namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class ComputerSkill
    {
        [XmlElement("ComputerSkillName")]
        public string Name { get; set; }

        [XmlElement("ComputerSkillDuration")]
        public string Duration { get; set; }

        [XmlElement("ComputerSkillFirstUsed")]
        public string FirstUsed { get; set; }

        [XmlElement("ComputerSkillLastUsed")]
        public string LastUsed { get; set; }

        [XmlElement("ComputerSkillDurationCode")]
        public CodeValue<int> DurationCode { get; set; }
    }
}