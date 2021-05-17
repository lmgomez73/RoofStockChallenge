using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Score
    {
        [JsonPropertyName("conditionScore")]
        public string ConditionScore { get; set; }

        [JsonPropertyName("crimeScore")]
        public string CrimeScore { get; set; }

        [JsonPropertyName("neighborhoodScore")]
        public int NeighborhoodScore { get; set; }

        [JsonPropertyName("overallScore")]
        public string OverallScore { get; set; }

        [JsonPropertyName("qualityScore")]
        public string QualityScore { get; set; }

        [JsonPropertyName("schoolScore")]
        public string SchoolScore { get; set; }

        [JsonPropertyName("charterSchoolScore")]
        public string CharterSchoolScore { get; set; }

        [JsonPropertyName("floodRiskScore")]
        public string FloodRiskScore { get; set; }

        [JsonPropertyName("walkabilityScore")]
        public string WalkabilityScore { get; set; }
    }

}