using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace RoofstockChallenge.Model{ 

    public class Resources
    {
        [JsonPropertyName("photos")]
        public List<Photo> Photos { get; set; }

        [JsonPropertyName("floorPlans")]
        public List<FloorPlan> FloorPlans { get; set; }

        [JsonPropertyName("threeDRenderings")]
        public List<ThreeDRendering> ThreeDRenderings { get; set; }

        [JsonPropertyName("audios")]
        public List<object> Audios { get; set; }
    }

}