using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class GoogleMapOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdGoogleMapOption { get; set; }
        [JsonPropertyName("hasStreetView")]
        public bool HasStreetView { get; set; }

        [JsonPropertyName("povHeading")]
        public int PovHeading { get; set; }

        [JsonPropertyName("povPitch")]
        public int PovPitch { get; set; }

        [JsonPropertyName("povLatitude")]
        public double PovLatitude { get; set; }

        [JsonPropertyName("povLongitude")]
        public double PovLongitude { get; set; }
        public Property Property { get; set; }
        public int IdProperty { get; set; }
    }

}