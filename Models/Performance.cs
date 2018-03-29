namespace Evolution.Textkernel.Models
{
    using System.Xml.Serialization;

    public class Performance
    {
        [XmlElement("PreProcessingTime")]
        public decimal? PreProcessingTime { get; set; }

        [XmlElement("ProcessingTime")]
        public decimal? ProcessingTime { get; set; }

        [XmlElement("NormalizationTime")]
        public decimal? NormalizationTime { get; set; }

        [XmlElement("TemplatingTime")]
        public decimal? TemplatingTime { get; set; }

        [XmlElement("TotalTime")]
        public decimal? TotalTime { get; set; }
    }
}