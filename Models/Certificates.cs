using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CarrierWebApi.Models
{
    public class Certificates
    {
        [Key]
        public long CertificateId {  get; set; }
        public long? VesselId { get; set; }
        public int? DocumentType { get; set; }
        public string? DocumentReferenceNo {  get; set; }
        public DateTime? IssuedDate {  get; set; }
        public DateTime? ExpiryDate {  get; set; }
        
    }
}
