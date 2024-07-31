using System.ComponentModel.DataAnnotations;

namespace CarrierWebApi.Models
{
    public class States
    {
        [Key]
        public long? StateId { get; set; }
        public long? CountryId { get; set; }
        public string? StateCode { get; set;}
        public string? StateName { get; set; }
    }
}
