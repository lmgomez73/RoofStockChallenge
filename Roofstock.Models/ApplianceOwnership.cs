using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class ApplianceOwnership
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdApplianceOwnership { get; set; }
        [JsonPropertyName("refrigerator")]
        public string Refrigerator { get; set; }

        [JsonPropertyName("dishwasher")]
        public string Dishwasher { get; set; }

        [JsonPropertyName("washer")]
        public string Washer { get; set; }

        [JsonPropertyName("dryer")]
        public string Dryer { get; set; }

        [JsonPropertyName("microwave")]
        public string Microwave { get; set; }

        [JsonPropertyName("stove")]
        public string Stove { get; set; }

        [ForeignKey("LeaseId")]
        public Lease Lease { get; set; }

        public int LeaseId { get; set; }
    }

}