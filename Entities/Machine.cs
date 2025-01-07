using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Machine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]

        public int Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int TarifId { get; set; }
    }
}
