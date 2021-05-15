using System.Text.Json.Serialization; 
using System.Collections.Generic; 
namespace RoofstockChallenge.Model{ 

    public class Root
    {
        [JsonPropertyName("properties")]
        public List<Property> Properties { get; set; }
    }

}