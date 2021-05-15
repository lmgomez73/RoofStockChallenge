using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Lease
    {
        [JsonPropertyName("leaseSummary")]
        public LeaseSummary LeaseSummary { get; set; }

        [JsonPropertyName("utilitiesOwnership")]
        public UtilitiesOwnership UtilitiesOwnership { get; set; }

        [JsonPropertyName("applianceOwnership")]
        public ApplianceOwnership ApplianceOwnership { get; set; }
    }

}