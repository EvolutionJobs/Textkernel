namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class LanguageSkill
    {
        [XmlElement("LanguageSkillCode")]
        public string Code { get; set; }

        [XmlElement("LanguageSkillCodeDescription")]
        public string CodeDescription { get; set; }

        [XmlElement("LanguageLevelCode")]
        public string LevelCode { get; set; }

        [XmlElement("LanguageLevelCodeDescription")]
        public string LevelCodeDescription { get; set; }

        [XmlElement("LanguageSkillFirstUsed")]
        public string FirstUsed { get; set; }

        [XmlElement("LanguageSkillLastUsed")]
        public string LastUsed { get; set; }

    }
}