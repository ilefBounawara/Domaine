using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
        public class User
        {
        [JsonPropertyName("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int Id { get; set; } 

        public string Username { get; set; }  
         public string Email { get; set; } 
         public string Password { get; set; } 
        }
   }

