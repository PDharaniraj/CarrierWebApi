using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CarrierWebApi.Models
{
    public class UserLogin
    {
        [Key]
        public long UserId { get; set; }
        public string? Password { get; set; }
        public string? UserEmailId { get; set; }
        public string? UserName { get; set; }
        public int? UserRole { get; set; }
        public string? Token { get; set; }



    }
}
