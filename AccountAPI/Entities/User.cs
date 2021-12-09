using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StockMarket.AccountAPI.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Mobile { get; set; }
        [Required]
        public string Password { get; set; }
        [JsonIgnore]
        public string Role { get; set; }= "user";
        
    }
}
