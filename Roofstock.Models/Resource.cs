using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 

namespace RoofstockChallenge.Model{ 

    public class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }

        [NotMapped]
        public ResourceType typeEnum {

            get { return (ResourceType)Enum.Parse<ResourceType>(ResourceType); }
            set { ResourceType = Enum.GetName<ResourceType>(value); }
        }

        [JsonPropertyName("isPublic")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("sizeInByte")]
        public long SizeInByte { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("urlMedium")]
        public string UrlMedium { get; set; }

        [JsonPropertyName("urlSmall")]
        public string UrlSmall { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }

        public PropertyResources PropertyResources{ get; set; }

    }

    public enum ResourceType
    {
        PropertyPhoto = 1,
        PropertyFloorPlan=2,
        Property3DTour=3,
        PropertyAudio = 4
    }

    public class AudioResource : Resource { }
    public class FloorPlanResource : Resource { }
    public class ThreeDTourResource : Resource { }
    public class PhotoResource : Resource { }
}