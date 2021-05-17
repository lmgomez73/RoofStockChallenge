using System;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Valuation
    {
        [JsonPropertyName("avmBpoValue")]
        public double AvmBpoValue { get; set; }

        [JsonPropertyName("avmBpoAdjValue")]
        public double AvmBpoAdjValue { get; set; }

        [JsonPropertyName("avmBpoDate")]
        public DateTime AvmBpoDate { get; set; }

        [JsonPropertyName("rsAvmValue")]
        public double RsAvmValue { get; set; }

        [JsonPropertyName("rsAvmDate")]
        public DateTime RsAvmDate { get; set; }

        [JsonPropertyName("rsBpoMergeValue")]
        public double? RsBpoMergeValue { get; set; }
    }

}