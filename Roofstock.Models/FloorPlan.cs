using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class FloorPlan
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }

        [JsonPropertyName("isPublic")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("sizeInByte")]
        public object SizeInByte { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("urlMedium")]
        public string UrlMedium { get; set; }

        [JsonPropertyName("urlSmall")]
        public string UrlSmall { get; set; }

        [JsonPropertyName("textContent")]
        public object TextContent { get; set; }
    }

}