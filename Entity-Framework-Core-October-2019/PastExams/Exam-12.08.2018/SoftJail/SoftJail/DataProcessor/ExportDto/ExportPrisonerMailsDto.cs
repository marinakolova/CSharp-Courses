﻿namespace SoftJail.DataProcessor.ExportDto
{
    using System.Xml.Serialization;

    [XmlType("Prisoner")]
    public class ExportPrisonerMailsDto
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "IncarcerationDate")]
        public string IncarcerationDate { get; set; }

        [XmlArray(ElementName = "EncryptedMessages")]
        public ExportEncryptedMessageDto[] EncryptedMessages { get; set; }
    }
}
