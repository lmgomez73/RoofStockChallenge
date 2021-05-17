using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Lease
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdLease { get; set; }
        [JsonPropertyName("leaseSummary")]
        public LeaseSummary LeaseSummary { get; set; }

        [JsonPropertyName("utilitiesOwnership")]
        public UtilitiesOwnership UtilitiesOwnership { get; set; }

        [JsonPropertyName("applianceOwnership")]
        public ApplianceOwnership ApplianceOwnership { get; set; }
    }

}