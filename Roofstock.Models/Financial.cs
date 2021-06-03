using System.Text.Json.Serialization; 
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoofstockChallenge.Model{ 

    public class Financial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdFinancial { get; set; }
        [JsonPropertyName("capRate")]
        public double? CapRate { get; set; }

        [JsonPropertyName("occupancy")]
        public string Occupancy { get; set; }

        [JsonPropertyName("isSection8")]
        public bool IsSection8 { get; set; }

        [JsonPropertyName("leaseStartDate")]
        public DateTime? LeaseStartDate { get; set; }

        [JsonPropertyName("leaseEndDate")]
        public DateTime? LeaseEndDate { get; set; }

        [JsonPropertyName("listPrice")]
        public double? ListPrice { get; set; }

        [JsonPropertyName("salePrice")]
        public double? SalePrice { get; set; }

        [JsonPropertyName("marketValue")]
        public double? MarketValue { get; set; }

        [JsonPropertyName("monthlyHoa")]
        public double? MonthlyHoa { get; set; }

        [JsonPropertyName("monthlyManagementFees")]
        public double? MonthlyManagementFees { get; set; }

        [JsonPropertyName("monthlyRent")]
        public double? MonthlyRent { get; set; }

        [JsonPropertyName("netYield")]
        public double? NetYield { get; set; }

        [JsonPropertyName("turnOverFee")]
        public double? TurnOverFee { get; set; }

        [JsonPropertyName("rehabCosts")]
        public double? RehabCosts { get; set; }

        [JsonPropertyName("rehabDate")]
        public DateTime? RehabDate { get; set; }

        [JsonPropertyName("yearlyInsuranceCost")]
        public double? YearlyInsuranceCost { get; set; }

        [JsonPropertyName("yearlyPropertyTaxes")]
        public double? YearlyPropertyTaxes { get; set; }

        [JsonPropertyName("isCashOnly")]
        public bool? IsCashOnly { get; set; }

        public Property Property { get; set; }
        public int IdProperty { get; set; }
    }

}