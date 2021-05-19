using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class Valuation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdValuation { get; set; }

        [JsonPropertyName("avmBpoValue")]
        public double? AvmBpoValue { get; set; }

        [JsonPropertyName("avmBpoAdjValue")]
        public double? AvmBpoAdjValue { get; set; }

        [JsonPropertyName("avmBpoDate")]
        public DateTime? AvmBpoDate { get; set; }

        [JsonPropertyName("rsAvmValue")]
        public double? RsAvmValue { get; set; }

        [JsonPropertyName("rsAvmDate")]
        public DateTime? RsAvmDate { get; set; }

        [JsonPropertyName("rsBpoMergeValue")]
        public double? RsBpoMergeValue { get; set; }
        public Property Property { get; set; }
        public int IdProperty { get; set; }
    }

}