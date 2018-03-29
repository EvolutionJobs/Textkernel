namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class CodeValue<T>
    {
        [XmlAttribute("id")]
        public T ID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}