﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoofstockChallenge.Data;

namespace RoofstockChallenge.Data.Migrations
{
    [DbContext(typeof(RoofStockDbContext))]
    partial class RoofStockDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoofstockChallenge.Model.Address", b =>
                {
                    b.Property<int>("IdAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipPlus4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAddress");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.ApplianceOwnership", b =>
                {
                    b.Property<int>("IdApplianceOwnership")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dishwasher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dryer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Microwave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Refrigerator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stove")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Washer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdApplianceOwnership");

                    b.ToTable("ApplianceOwnerships");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Diligences", b =>
                {
                    b.Property<int>("IdDiligences")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("IdDiligences");

                    b.HasIndex("PropertyId");

                    b.ToTable("Diligence");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Financial", b =>
                {
                    b.Property<int>("IdFinancial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CapRate")
                        .HasColumnType("float");

                    b.Property<bool>("IsCashOnly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSection8")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LeaseEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LeaseStartDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("MarketValue")
                        .HasColumnType("float");

                    b.Property<double>("MonthlyHoa")
                        .HasColumnType("float");

                    b.Property<double>("MonthlyManagementFees")
                        .HasColumnType("float");

                    b.Property<double>("MonthlyRent")
                        .HasColumnType("float");

                    b.Property<double>("NetYield")
                        .HasColumnType("float");

                    b.Property<string>("Occupancy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RehabCosts")
                        .HasColumnType("float");

                    b.Property<DateTime>("RehabDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<double>("TurnOverFee")
                        .HasColumnType("float");

                    b.Property<double?>("YearlyInsuranceCost")
                        .HasColumnType("float");

                    b.Property<double>("YearlyPropertyTaxes")
                        .HasColumnType("float");

                    b.HasKey("IdFinancial");

                    b.ToTable("Financial");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.GoogleMapOption", b =>
                {
                    b.Property<int>("IdGoogleMapOption")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasStreetView")
                        .HasColumnType("bit");

                    b.Property<int>("PovHeading")
                        .HasColumnType("int");

                    b.Property<double>("PovLatitude")
                        .HasColumnType("float");

                    b.Property<double>("PovLongitude")
                        .HasColumnType("float");

                    b.Property<int>("PovPitch")
                        .HasColumnType("int");

                    b.HasKey("IdGoogleMapOption");

                    b.ToTable("googleMapOption");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Lease", b =>
                {
                    b.Property<int>("IdLease")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApplianceOwnershipIdApplianceOwnership")
                        .HasColumnType("int");

                    b.Property<int?>("LeaseSummaryIdLeaseSummary")
                        .HasColumnType("int");

                    b.Property<int?>("UtilitiesOwnershipIdUtilitiesOwnership")
                        .HasColumnType("int");

                    b.HasKey("IdLease");

                    b.HasIndex("ApplianceOwnershipIdApplianceOwnership");

                    b.HasIndex("LeaseSummaryIdLeaseSummary");

                    b.HasIndex("UtilitiesOwnershipIdUtilitiesOwnership");

                    b.ToTable("Lease");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.LeaseSummary", b =>
                {
                    b.Property<int>("IdLeaseSummary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasPet")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLeaseConcessions")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPetsDeposit")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRentersInsuranceRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSection8")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTenantBackgroundChecked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTenantIncomeAbove3x")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTenantMayTerminateEarly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTenantPurchaseOption")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LeaseEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LeaseStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeasingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MarketedRent")
                        .HasColumnType("float");

                    b.Property<double>("MonthlyRent")
                        .HasColumnType("float");

                    b.Property<string>("Occupancy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PetFeeAmount")
                        .HasColumnType("float");

                    b.Property<double?>("PetsDepositAmount")
                        .HasColumnType("float");

                    b.Property<double?>("SecurityDepositAmount")
                        .HasColumnType("float");

                    b.HasKey("IdLeaseSummary");

                    b.ToTable("LeaseSummary");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Physical", b =>
                {
                    b.Property<int>("IdPhysical")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BathRooms")
                        .HasColumnType("float");

                    b.Property<double>("BedRooms")
                        .HasColumnType("float");

                    b.Property<bool>("IsPool")
                        .HasColumnType("bit");

                    b.Property<int?>("LotSize")
                        .HasColumnType("int");

                    b.Property<string>("ParcelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SquareFeet")
                        .HasColumnType("int");

                    b.Property<int>("Stories")
                        .HasColumnType("int");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.Property<int>("YearBuilt")
                        .HasColumnType("int");

                    b.Property<int>("ZipYearBuilt")
                        .HasColumnType("int");

                    b.HasKey("IdPhysical");

                    b.ToTable("Physical");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressIdAddress")
                        .HasColumnType("int");

                    b.Property<bool>("AllowRentGuaranteedOptout")
                        .HasColumnType("bit");

                    b.Property<string>("AllowableSaleTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllowedFundingTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BuyerAccountId")
                        .HasColumnType("int");

                    b.Property<int?>("BuyerUserId")
                        .HasColumnType("int");

                    b.Property<string>("CertificationLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DaysOnMarket")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiligenceVaultSummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EscrowClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinancialIdFinancial")
                        .HasColumnType("int");

                    b.Property<int?>("GoogleMapOptionIdGoogleMapOption")
                        .HasColumnType("int");

                    b.Property<bool>("HasAudio")
                        .HasColumnType("bit");

                    b.Property<bool>("HasDiligenceVaultDocuments")
                        .HasColumnType("bit");

                    b.Property<string>("Highlights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InspectionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAllowOffer")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAllowPreview")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBargain")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiligenceVaultUnlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDwellCertified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsHoa")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHot")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPropertyManagerOfferRetain")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRentGuaranteed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSecuritized")
                        .HasColumnType("bit");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<int?>("LeaseIdLease")
                        .HasColumnType("int");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("MainImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Market")
                        .HasColumnType("int");

                    b.Property<int>("PersonalProperties")
                        .HasColumnType("int");

                    b.Property<int?>("PhysicalIdPhysical")
                        .HasColumnType("int");

                    b.Property<string>("PriceVisibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResourcesIdPropertyResource")
                        .HasColumnType("int");

                    b.Property<int?>("ScoreIdScore")
                        .HasColumnType("int");

                    b.Property<string>("Seller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerBroker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ValuationIdValuation")
                        .HasColumnType("int");

                    b.Property<string>("Visibility")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressIdAddress");

                    b.HasIndex("FinancialIdFinancial");

                    b.HasIndex("GoogleMapOptionIdGoogleMapOption");

                    b.HasIndex("LeaseIdLease");

                    b.HasIndex("PhysicalIdPhysical");

                    b.HasIndex("ResourcesIdPropertyResource");

                    b.HasIndex("ScoreIdScore");

                    b.HasIndex("ValuationIdValuation");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.PropertyResources", b =>
                {
                    b.Property<int>("IdPropertyResource")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("IdPropertyResource");

                    b.ToTable("PropertyResources");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<int?>("PropertyResourcesIdPropertyResource")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyResourcesIdPropertyResource1")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyResourcesIdPropertyResource2")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyResourcesIdPropertyResource3")
                        .HasColumnType("int");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SizeInByte")
                        .HasColumnType("bigint");

                    b.Property<string>("TextContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlMedium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSmall")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyResourcesIdPropertyResource");

                    b.HasIndex("PropertyResourcesIdPropertyResource1");

                    b.HasIndex("PropertyResourcesIdPropertyResource2");

                    b.HasIndex("PropertyResourcesIdPropertyResource3");

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Score", b =>
                {
                    b.Property<int>("IdScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CharterSchoolScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConditionScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrimeScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloodRiskScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeighborhoodScore")
                        .HasColumnType("int");

                    b.Property<string>("OverallScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualityScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WalkabilityScore")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdScore");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.UtilitiesOwnership", b =>
                {
                    b.Property<int>("IdUtilitiesOwnership")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Electric")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Garbage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Landscaping")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PestControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Water")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUtilitiesOwnership");

                    b.ToTable("UtilitiesOwnership");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Valuation", b =>
                {
                    b.Property<int>("IdValuation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AvmBpoAdjValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("AvmBpoDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("AvmBpoValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("RsAvmDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("RsAvmValue")
                        .HasColumnType("float");

                    b.Property<double?>("RsBpoMergeValue")
                        .HasColumnType("float");

                    b.HasKey("IdValuation");

                    b.ToTable("Valuation");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Diligences", b =>
                {
                    b.HasOne("RoofstockChallenge.Model.Property", null)
                        .WithMany("Diligences")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Lease", b =>
                {
                    b.HasOne("RoofstockChallenge.Model.ApplianceOwnership", "ApplianceOwnership")
                        .WithMany()
                        .HasForeignKey("ApplianceOwnershipIdApplianceOwnership");

                    b.HasOne("RoofstockChallenge.Model.LeaseSummary", "LeaseSummary")
                        .WithMany()
                        .HasForeignKey("LeaseSummaryIdLeaseSummary");

                    b.HasOne("RoofstockChallenge.Model.UtilitiesOwnership", "UtilitiesOwnership")
                        .WithMany()
                        .HasForeignKey("UtilitiesOwnershipIdUtilitiesOwnership");

                    b.Navigation("ApplianceOwnership");

                    b.Navigation("LeaseSummary");

                    b.Navigation("UtilitiesOwnership");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Property", b =>
                {
                    b.HasOne("RoofstockChallenge.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressIdAddress");

                    b.HasOne("RoofstockChallenge.Model.Financial", "Financial")
                        .WithMany()
                        .HasForeignKey("FinancialIdFinancial");

                    b.HasOne("RoofstockChallenge.Model.GoogleMapOption", "GoogleMapOption")
                        .WithMany()
                        .HasForeignKey("GoogleMapOptionIdGoogleMapOption");

                    b.HasOne("RoofstockChallenge.Model.Lease", "Lease")
                        .WithMany()
                        .HasForeignKey("LeaseIdLease");

                    b.HasOne("RoofstockChallenge.Model.Physical", "Physical")
                        .WithMany()
                        .HasForeignKey("PhysicalIdPhysical");

                    b.HasOne("RoofstockChallenge.Model.PropertyResources", "Resources")
                        .WithMany()
                        .HasForeignKey("ResourcesIdPropertyResource");

                    b.HasOne("RoofstockChallenge.Model.Score", "Score")
                        .WithMany()
                        .HasForeignKey("ScoreIdScore");

                    b.HasOne("RoofstockChallenge.Model.Valuation", "Valuation")
                        .WithMany()
                        .HasForeignKey("ValuationIdValuation");

                    b.Navigation("Address");

                    b.Navigation("Financial");

                    b.Navigation("GoogleMapOption");

                    b.Navigation("Lease");

                    b.Navigation("Physical");

                    b.Navigation("Resources");

                    b.Navigation("Score");

                    b.Navigation("Valuation");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Resource", b =>
                {
                    b.HasOne("RoofstockChallenge.Model.PropertyResources", null)
                        .WithMany("Audios")
                        .HasForeignKey("PropertyResourcesIdPropertyResource");

                    b.HasOne("RoofstockChallenge.Model.PropertyResources", null)
                        .WithMany("FloorPlans")
                        .HasForeignKey("PropertyResourcesIdPropertyResource1");

                    b.HasOne("RoofstockChallenge.Model.PropertyResources", null)
                        .WithMany("Photos")
                        .HasForeignKey("PropertyResourcesIdPropertyResource2");

                    b.HasOne("RoofstockChallenge.Model.PropertyResources", null)
                        .WithMany("ThreeDRenderings")
                        .HasForeignKey("PropertyResourcesIdPropertyResource3");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.Property", b =>
                {
                    b.Navigation("Diligences");
                });

            modelBuilder.Entity("RoofstockChallenge.Model.PropertyResources", b =>
                {
                    b.Navigation("Audios");

                    b.Navigation("FloorPlans");

                    b.Navigation("Photos");

                    b.Navigation("ThreeDRenderings");
                });
#pragma warning restore 612, 618
        }
    }
}
