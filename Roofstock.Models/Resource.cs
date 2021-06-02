using JsonSubTypes;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RoofstockChallenge.Model{
    [Newtonsoft.Json.JsonConverter(typeof(JsonSubtypes), "resourceType")]
    [JsonSubtypes.KnownSubType(typeof(PhotoResource), "PropertyPhoto")]
    [JsonSubtypes.KnownSubType(typeof(FloorPlanResource), "PropertyFloorPlan")]
    [JsonSubtypes.KnownSubType(typeof(ThreeDTourResource), "Property3DTour")]
    [JsonSubtypes.KnownSubType(typeof(AudioResource), "PropertyAudio")]
    public class Resource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "IdResource")]
        public int IdResource { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }

        [NotMapped]
        public ResourceType TypeEnum {

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
        public long? SizeInByte { get; set; }

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

        
        public int IdPropertyResources { get; set; }
        
    }

}