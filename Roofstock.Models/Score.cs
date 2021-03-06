using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Score
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdScore { get; set; }
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
        public Property Property { get; set; }
        public int IdProperty { get; set; }
    }

}