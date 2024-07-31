using System.ComponentModel.DataAnnotations;

namespace CarrierWebApi.Models
{
    public class Countries
    {
        [Key]
        public long? CountryId { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set;}
    }
}
