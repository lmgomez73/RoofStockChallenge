using JsonSubTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;
using RoofstockChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RoofstockChallenge.Data
{

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var properties = GetSeedData();

            #region AddressSeed
            modelBuilder.Entity<Address>().HasData(
                properties.Where(x => x.Address != null)
                .Select(x => 
                new { 
                    x.Address.IdAddress,
                    x.Address.IdProperty,
                    x.Address.Zip,
                    x.Address.ZipPlus4,
                    x.Address.Address1,
                    x.Address.Address2,
                    x.Address.City,
                    x.Address.Country,
                    x.Address.County,
                    x.Address.District,
                    x.Address.State
                })
            );

            #endregion

            #region Financial seed
            modelBuilder.Entity<Financial>().HasData(
                properties.Where(x => x.Financial != null)
                .Select(x =>
                new
                {
                    x.Financial.IdFinancial,
                    x.Financial.IdProperty,
                    x.Financial.IsCashOnly,
                    x.Financial.IsSection8,
                    x.Financial.LeaseEndDate,
                    x.Financial.LeaseStartDate,
                    x.Financial.ListPrice,
                    x.Financial.MarketValue,
                    x.Financial.MonthlyHoa,
                    x.Financial.MonthlyManagementFees,
                    x.Financial.MonthlyRent,
                    x.Financial.NetYield,
                    x.Financial.Occupancy,
                    x.Financial.RehabCosts,
                    x.Financial.RehabDate,
                    x.Financial.SalePrice,
                    x.Financial.YearlyInsuranceCost,
                    x.Financial.YearlyPropertyTaxes
                })
                );
            #endregion

            #region LeaseSeed
            modelBuilder.Entity<Lease>().HasData(
                properties.Where(x => x.Lease != null)
                .Select(x => new
                {
                    x.Lease.LeaseId,
                    x.Lease.IdProperty
                })
            );

            modelBuilder.Entity<LeaseSummary>().HasData(
                properties.Where(x => x.Lease != null && x.Lease.LeaseSummary != null)
                .Select(x => x.Lease.LeaseSummary)
                );
            modelBuilder.Entity<UtilitiesOwnership>().HasData(
                properties.Where(x => x.Lease != null && x.Lease.UtilitiesOwnership != null)
                .Select(x => x.Lease.UtilitiesOwnership)
                );

            modelBuilder.Entity<ApplianceOwnership>().HasData(
                properties.Where(x => x.Lease != null && x.Lease.ApplianceOwnership != null)
                .Select(x => x.Lease.ApplianceOwnership)
                );
            #endregion

            #region PhysicalSeed
            modelBuilder.Entity<Physical>().HasData(
                properties.Where(x => x.Physical != null)
                .Select(x =>
                new
                {
                    x.Physical.BathRooms,
                    x.Physical.BedRooms,
                    x.Physical.IdPhysical,
                    x.Physical.IdProperty,
                    x.Physical.IsPool,
                    x.Physical.LotSize,
                    x.Physical.ParcelNumber,
                    x.Physical.SquareFeet,
                    x.Physical.Stories,
                    x.Physical.Units,
                    x.Physical.YearBuilt,
                    x.Physical.ZipYearBuilt
                })
                );
            #endregion

            #region GoogleMapsOptionSeed
            modelBuilder.Entity<GoogleMapOption>().HasData(
                properties.Where(x => x.GoogleMapOption != null)
                .Select(x => new
                {
                    x.GoogleMapOption.HasStreetView,
                    x.GoogleMapOption.IdGoogleMapOption,
                    x.GoogleMapOption.IdProperty,
                    x.GoogleMapOption.PovHeading,
                    x.GoogleMapOption.PovLatitude,
                    x.GoogleMapOption.PovLongitude,
                    x.GoogleMapOption.PovPitch
                })
                );
            #endregion

            #region ScoreSeed
            modelBuilder.Entity<Score>().HasData(
                properties.Where(x => x.Score != null)
                .Select(x => new
                {
                    x.Score.CharterSchoolScore,
                    x.Score.ConditionScore,
                    x.Score.CrimeScore,
                    x.Score.FloodRiskScore,
                    x.Score.IdProperty,
                    x.Score.IdScore,
                    x.Score.NeighborhoodScore,
                    x.Score.OverallScore,
                    x.Score.QualityScore,
                    x.Score.SchoolScore,
                    x.Score.WalkabilityScore
                })
                );

            #endregion

            #region ValuationSeed


            modelBuilder.Entity<Valuation>().HasData(
                properties.Where(x => x.Valuation != null)
                .Select(x => new
                {
                    x.Valuation.AvmBpoAdjValue,
                    x.Valuation.AvmBpoDate,
                    x.Valuation.AvmBpoValue,
                    x.Valuation.IdValuation,
                    x.Valuation.IdProperty,
                    x.Valuation.RsAvmDate,
                    x.Valuation.RsAvmValue,
                    x.Valuation.RsBpoMergeValue
                })
                );
            #endregion

            #region ResourcesSeed

            modelBuilder.Entity<PropertyResources>().HasData(
                properties.Where(x => x.Resources != null)
                .Select(x =>
                new
                {
                    x.Resources.IdPropertyResources,
                    x.Resources.PropertyId
                })
                );

            modelBuilder.Entity<AudioResource>().HasData(
                properties.Where(x => x.Resources != null && x.Resources.Audios != null && x.Resources.Audios.Count > 0)
                .SelectMany(x => x.Resources.Audios)
                );
            modelBuilder.Entity<FloorPlanResource>().HasData(
                properties.Where(x => x.Resources != null && x.Resources.FloorPlans != null && x.Resources.FloorPlans.Count > 0)
                .SelectMany(x => x.Resources.FloorPlans)
                );
            modelBuilder.Entity<ThreeDTourResource>().HasData(
                properties.Where(x => x.Resources != null && x.Resources.ThreeDRenderings != null && x.Resources.ThreeDRenderings.Count > 0)
                .SelectMany(x => x.Resources.ThreeDRenderings)
                );
            modelBuilder.Entity<PhotoResource>().HasData(
                properties.Where(x => x.Resources != null && x.Resources.Photos != null && x.Resources.Photos.Count > 0)
                .SelectMany(x => x.Resources.Photos)
                );

            #endregion

            #region PropertySeed

            modelBuilder.Entity<Property>().HasData(
                properties.Where(x => x != null)
                .Select(x => new
                {
                    x.Id,
                    x.AccountId,
                    x.BuyerAccountId,
                    x.BuyerUserId,
                    x.ExternalId,
                    x.ProgramId,
                    x.IsDwellCertified,
                    x.IsAllowOffer,
                    x.IsAllowPreview,
                    x.IsFeatured,
                    x.IsRentGuaranteed,
                    x.AllowRentGuaranteedOptout,
                    x.IsSecuritized,
                    x.IsHot,
                    x.IsNew,
                    x.IsBargain,
                    x.IsDiligenceVaultUnlocked,
                    x.IsPropertyManagerOfferRetain,
                    x.IsHoa,
                    x.HasAudio,
                    x.HasDiligenceVaultDocuments,
                    x.Market,
                    x.DaysOnMarket,
                    x.Latitude,
                    x.Longitude,
                    x.PropertyName,
                    x.Description,
                    x.Highlights,
                    x.MainImageUrl,
                    x.PersonalProperties,
                    x.DiligenceVaultSummary,
                    x.FeaturedReason,
                    x.Status,
                    x.AllowedFundingTypes,
                    x.AllowableSaleTypes,
                    x.Visibility,
                    x.PriceVisibility,
                    x.PropertyType,
                    x.CertificationLevel,
                    x.EscrowClosingDate,
                    IdFinancial = (int?)(x.Financial?.IdFinancial),
                    IdPhysical = (int?)(x.Physical?.IdPhysical),
                    IdScore = (int?)(x.Score?.IdScore),
                    IdValuation = (int?)(x.Valuation?.IdValuation),
                    IdAddress = (int?)(x.Address?.IdAddress),
                    IdPropertyResources = (int?)(x.Resources?.IdPropertyResources),
                    x.Manager,
                    x.Seller,
                    x.SellerBroker,
                    x.Hoa,
                    LeaseId = (int?)(x.Lease?.LeaseId),
                    IdGoogleMapOption = (int?)(x.GoogleMapOption?.IdGoogleMapOption),
                    x.InspectionType

                }
                ));

            #endregion
        }

        public static List<Property> GetSeedData()
        {
            List<Property> properties;
            string url = "https://samplerspubcontent.blob.core.windows.net/public/properties.json";

            HttpClient client = new HttpClient();

            var json = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(JsonSubtypesConverterBuilder
                .Of(typeof(Resource), "ResourceType") 
                .RegisterSubtype(typeof(AudioResource), "PropertyAudio")
                .RegisterSubtype(typeof(FloorPlanResource), "PropertyFloorPlan")
                .RegisterSubtype(typeof(PhotoResource), "PropertyPhoto")
                .RegisterSubtype(typeof(ThreeDTourResource), "Property3DTour")
                .SerializeDiscriminatorProperty() 
                .Build());
            properties = JsonConvert.DeserializeObject<Root>(json, settings).Properties;

            GenerateIdValues(properties);
            return properties;
        }

        private static void GenerateIdValues(List<Property> properties)
        {
            #region initialize idValues
            int idAddress = 0;
            int idApplianceOwnership = 0;
            int idDiligences = 0;
            int idFinancial = 0;
            int idGoogleMapsOption = 0;
            int idLease = 0;
            int idLeaseSummary = 0;
            int idPhysical = 0;
            int idPropertyResources = 0;
            int idScore = 0;
            int idUtilitiesOwnership = 0;
            int idValuation = 0;
            int idResource = 0;
            #endregion


            foreach (Property property in properties)
            {
                if (property.Address != null)
                {
                    property.Address.IdAddress = ++idAddress;
                    property.Address.IdProperty = property.Id;
                    property.Address.Property = property;

                }
                
                if (property.Financial != null)
                {
                    property.Financial.IdFinancial = ++idFinancial;
                    property.Financial.IdProperty = property.Id;
                    property.Financial.Property = property;
                }

                if (property.GoogleMapOption != null)
                {
                    property.GoogleMapOption.IdGoogleMapOption = ++idGoogleMapsOption;
                    property.GoogleMapOption.IdProperty = property.Id;
                    property.GoogleMapOption.Property = property;
                }
                if (property.Lease != null)
                {
                    property.Lease.LeaseId = ++idLease;
                    property.Lease.IdProperty = property.Id;
                    property.Lease.Property = property;

                    if (property.Lease.LeaseSummary != null)
                    {
                        property.Lease.LeaseSummary.IdLeaseSummary = ++idLeaseSummary;
                        property.Lease.LeaseSummary.LeaseId = property.Lease.LeaseId;
                    }
                    if (property.Lease.ApplianceOwnership != null)
                    {
                        property.Lease.ApplianceOwnership.IdApplianceOwnership = ++idApplianceOwnership;
                        property.Lease.ApplianceOwnership.LeaseId = property.Lease.LeaseId;
                    }
                    if (property.Lease.UtilitiesOwnership != null)
                    {
                        property.Lease.UtilitiesOwnership.IdUtilitiesOwnership = ++idUtilitiesOwnership;
                        property.Lease.UtilitiesOwnership.LeaseId = property.Lease.LeaseId;
                    }
                }

                if (property.Physical != null)
                {
                    property.Physical.IdPhysical = ++idPhysical;
                    property.Physical.IdProperty = property.Id;
                    property.Physical.Property = property;

                }
                if (property.Resources != null)
                {
                    property.Resources.IdPropertyResources = ++idPropertyResources;
                    property.Resources.PropertyId = property.Id;
                    property.Resources.Property = property;
                    foreach (Resource resource in property.Resources.Photos)
                    {
                        resource.IdPropertyResources = property.Resources.IdPropertyResources;
                        //resource.PropertyResources = property.Resources;
                        resource.IdResource = ++idResource;
                    }
                    foreach (Resource resource in property.Resources.Audios)
                    {
                        resource.IdPropertyResources = property.Resources.IdPropertyResources;
                        //resource.PropertyResources = property.Resources;
                        resource.IdResource = ++idResource;
                    }
                    foreach (Resource resource in property.Resources.ThreeDRenderings)
                    {
                        resource.IdPropertyResources = property.Resources.IdPropertyResources;
                        //resource.PropertyResources = property.Resources;
                        resource.IdResource = ++idResource;
                    }
                    foreach (Resource resource in property.Resources.FloorPlans)
                    {
                        resource.IdPropertyResources = property.Resources.IdPropertyResources;
                        resource.IdResource = ++idResource;
                    }
                }
                if (property.Score != null)
                {
                    property.Score.IdScore = ++idScore;
                    property.Score.IdProperty = property.Id;
                    property.Score.Property = property;
                }
                if (property.Valuation != null)
                {
                    property.Valuation.IdValuation = ++idValuation;
                    property.Valuation.IdProperty = property.Id;
                    property.Valuation.Property = property;
                }
                if (property.Diligences != null)
                {
                    foreach (Diligences diligence in property.Diligences)
                    {
                        diligence.IdDiligences = ++idDiligences;
                    }
                }
            }
        }
    }
}