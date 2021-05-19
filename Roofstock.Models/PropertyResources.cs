using System.Text.Json.Serialization; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoofstockChallenge.Model{ 

    public class PropertyResources
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        
        public int IdPropertyResources { get; set; }

        [JsonPropertyName("photos")]
        public List<PhotoResource> Photos { get; set; }

        [JsonPropertyName("floorPlans")]
        public List<FloorPlanResource> FloorPlans { get; set; }

        [JsonPropertyName("threeDRenderings")]
        public List<ThreeDTourResource> ThreeDRenderings { get; set; }

        [JsonPropertyName("audios")]
        public List<AudioResource> Audios { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }

}