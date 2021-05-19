using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; 
namespace RoofstockChallenge.Model{ 

    public class LeaseSummary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int IdLeaseSummary { get; set; }
        [JsonPropertyName("occupancy")]
        public string Occupancy { get; set; }

        [JsonPropertyName("leasingStatus")]
        public string LeasingStatus { get; set; }

        [JsonPropertyName("marketedRent")]
        public double? MarketedRent { get; set; }

        [JsonPropertyName("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonPropertyName("leaseStartDate")]
        public DateTime? LeaseStartDate { get; set; }

        [JsonPropertyName("leaseEndDate")]
        public DateTime? LeaseEndDate { get; set; }

        [JsonPropertyName("monthlyRent")]
        public double? MonthlyRent { get; set; }

        [JsonPropertyName("securityDepositAmount")]
        public double? SecurityDepositAmount { get; set; }

        [JsonPropertyName("hasPet")]
        public bool? HasPet { get; set; }

        [JsonPropertyName("petFeeAmount")]
        public double? PetFeeAmount { get; set; }

        [JsonPropertyName("isPetsDeposit")]
        public bool? IsPetsDeposit { get; set; }

        [JsonPropertyName("petsDepositAmount")]
        public double? PetsDepositAmount { get; set; }

        [JsonPropertyName("isLeaseConcessions")]
        public bool? IsLeaseConcessions { get; set; }

        [JsonPropertyName("isRentersInsuranceRequired")]
        public bool? IsRentersInsuranceRequired { get; set; }

        [JsonPropertyName("isSection8")]
        public bool? IsSection8 { get; set; }

        [JsonPropertyName("isTenantBackgroundChecked")]
        public bool? IsTenantBackgroundChecked { get; set; }

        [JsonPropertyName("isTenantIncomeAbove3x")]
        public bool? IsTenantIncomeAbove3x { get; set; }

        [JsonPropertyName("isTenantMayTerminateEarly")]
        public bool? IsTenantMayTerminateEarly { get; set; }

        [JsonPropertyName("isTenantPurchaseOption")]
        public bool? IsTenantPurchaseOption { get; set; }

        [ForeignKey("LeaseId")]
        public Lease Lease { get; set; }
        public int LeaseId { get; set; }
    }

}