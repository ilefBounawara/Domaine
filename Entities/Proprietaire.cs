using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Proprietaire
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
            [JsonPropertyName("Id")]
            public int Id { get; set; }

            [JsonPropertyName("Nom")]
            public string Nom { get; set; }

            [JsonPropertyName("Prenom")]
            public string Prenom { get; set; }

            [JsonPropertyName("Email")]
            public string Email { get; set; }

            [JsonPropertyName("LaverieId")]
            public int LaverieId { get; set; }
        }
    }

