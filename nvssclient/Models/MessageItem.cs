using System;
using System.Text.Json.Serialization;

namespace NVSSClient.Models
{

    public enum MessageStatus 
    {
        Pending,
        Sent,
        Acknowledged,
        Error,
        AcknowledgedAndCoded
    }
    public class MessageItem : BaseEntity
    {
        public long Id { get; set; }
        public String Uid { get; set; }
        public String StateAuxiliaryIdentifier { get; set; }
        public uint? CertificateNumber { get; set; }
        public String DeathJurisdictionID { get; set; }
        public uint? DeathYear {get; set;}
        public String Message {get; set;}
        public int Retries { get; set; }
        public String Status { get; set; }   
        public DateTime ? ExpirationDate { get; set; }
    }
}