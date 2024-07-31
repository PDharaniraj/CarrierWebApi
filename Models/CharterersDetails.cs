using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CarrierWebApi.Models
{
    public class CharterersDetails
    {
        [Key]
        public long CharterersId {  get; set; }
        public long? VesselId { get; set; }
        public string? CharterersCode { get; set; } 
        public string? ShipOwnerName { get; set; }
        public string? EmailID { get; set; }
        public int? State { get; set; }
        public int? Country {  get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Code {  get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 {  get; set; }
        [NotMapped] 
        public string? CountryName { get; set; }
        [NotMapped]
        public string? StateName { get; set; }
    }
}
