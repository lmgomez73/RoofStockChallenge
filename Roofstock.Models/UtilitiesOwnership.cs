using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class UtilitiesOwnership
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdUtilitiesOwnership { get; set; }
        [JsonPropertyName("electric")]
        public string Electric { get; set; }

        [JsonPropertyName("gas")]
        public string Gas { get; set; }

        [JsonPropertyName("water")]
        public string Water { get; set; }

        [JsonPropertyName("garbage")]
        public string Garbage { get; set; }

        [JsonPropertyName("pool")]
        public string Pool { get; set; }

        [JsonPropertyName("landscaping")]
        public string Landscaping { get; set; }

        [JsonPropertyName("pestControl")]
        public string PestControl { get; set; }
        [ForeignKey("LeaseId")]
        public Lease Lease { get; set; }
        public int LeaseId { get; set; }
    }

}