using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Physical
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdPhysical { get; set; }
        [JsonPropertyName("bathRooms")]
        public double BathRooms { get; set; }

        [JsonPropertyName("bedRooms")]
        public double BedRooms { get; set; }

        [JsonPropertyName("parcelNumber")]
        public string ParcelNumber { get; set; }

        [JsonPropertyName("isPool")]
        public bool IsPool { get; set; }

        [JsonPropertyName("lotSize")]
        public int? LotSize { get; set; }

        [JsonPropertyName("squareFeet")]
        public int SquareFeet { get; set; }

        [JsonPropertyName("stories")]
        public int? Stories { get; set; }

        [JsonPropertyName("units")]
        public int? Units { get; set; }

        [JsonPropertyName("yearBuilt")]
        public int YearBuilt { get; set; }

        [JsonPropertyName("zipYearBuilt")]
        public int? ZipYearBuilt { get; set; }

        public Property Property { get; set; }
        public int IdProperty { get; set; }
    }

}