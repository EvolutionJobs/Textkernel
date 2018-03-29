namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class Skills
    {
        [XmlArrayItem("LanguageSkill")]
        public LanguageSkill[] LanguageSkills { get; set; }

        [XmlArrayItem("ComputerSkill")]
        public ComputerSkill[] ComputerSkills { get; set; }

        [XmlArrayItem("SoftSkill")]
        public SoftSkill[] SoftSkills { get; set; }

        [XmlArrayItem("OtherSkill")]
        public OtherSkill[] OtherSkills { get; set; }

        [XmlArrayItem("Hobby")]
        public string[] Hobbies { get; set; }
    }
}