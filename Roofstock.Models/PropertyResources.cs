using System.Text.Json.Serialization; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoofstockChallenge.Model{ 

    public class PropertyResources
    {

        [JsonPropertyName("photos")]
        public List<Resource> Photos { get; set; }

        [JsonPropertyName("floorPlans")]
        public List<Resource> FloorPlans { get; set; }

        [JsonPropertyName("threeDRenderings")]
        public List<Resource> ThreeDRenderings { get; set; }

        [JsonPropertyName("audios")]
        public List<Resource> Audios { get; set; }

        public Property Property { get; set; }
    }

}