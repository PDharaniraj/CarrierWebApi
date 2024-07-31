using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CarrierWebApi.Models
{
    public class ShipOwnerDetails
    {
        [Key]
      
        public long ShipOwnerDetailsId {  get; set; }
        public long? VesselId {  get; set; }
        public string? ShipOwnerName {  get; set; }
        public string? EmailID { get; set; }
        public string? MobileNo {  get; set; }
        public string? Address { get; set; }
        public int? PostalCode {  get; set; }
        public string? City { get; set; }
        public int? State {  get; set; }
        public int? Country { get; set; }
        [NotMapped]
        public string? CountryName { get; set; }
        [NotMapped]
        public string? StateName { get; set; }
    }
}
