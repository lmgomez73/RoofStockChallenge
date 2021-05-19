using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoofstockChallenge.Data.Migrations
{
    public partial class roofstockdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    IdAddress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipPlus4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.IdAddress);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    BuyerAccountId = table.Column<int>(type: "int", nullable: true),
                    BuyerUserId = table.Column<int>(type: "int", nullable: true),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDwellCertified = table.Column<bool>(type: "bit", nullable: false),
                    IsAllowOffer = table.Column<bool>(type: "bit", nullable: false),
                    IsAllowPreview = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsRentGuaranteed = table.Column<bool>(type: "bit", nullable: false),
                    AllowRentGuaranteedOptout = table.Column<bool>(type: "bit", nullable: false),
                    IsSecuritized = table.Column<bool>(type: "bit", nullable: false),
                    IsHot = table.Column<bool>(type: "bit", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: false),
                    IsBargain = table.Column<bool>(type: "bit", nullable: true),
                    IsDiligenceVaultUnlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsPropertyManagerOfferRetain = table.Column<bool>(type: "bit", nullable: true),
                    IsHoa = table.Column<bool>(type: "bit", nullable: true),
                    HasAudio = table.Column<bool>(type: "bit", nullable: false),
                    HasDiligenceVaultDocuments = table.Column<bool>(type: "bit", nullable: false),
                    Market = table.Column<int>(type: "int", nullable: false),
                    DaysOnMarket = table.Column<int>(type: "int", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Highlights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalProperties = table.Column<int>(type: "int", nullable: true),
                    DiligenceVaultSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedFundingTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowableSaleTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceVisibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificationLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscrowClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressIdAddress = table.Column<int>(type: "int", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerBroker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectionType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_Address_AddressIdAddress",
                        column: x => x.AddressIdAddress,
                        principalTable: "Address",
                        principalColumn: "IdAddress",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diligence",
                columns: table => new
                {
                    IdDiligences = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diligence", x => x.IdDiligences);
                    table.ForeignKey(
                        name: "FK_Diligence_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Financial",
                columns: table => new
                {
                    IdFinancial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapRate = table.Column<double>(type: "float", nullable: true),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSection8 = table.Column<bool>(type: "bit", nullable: false),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaseEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListPrice = table.Column<double>(type: "float", nullable: true),
                    SalePrice = table.Column<double>(type: "float", nullable: true),
                    MarketValue = table.Column<double>(type: "float", nullable: true),
                    MonthlyHoa = table.Column<double>(type: "float", nullable: true),
                    MonthlyManagementFees = table.Column<double>(type: "float", nullable: true),
                    MonthlyRent = table.Column<double>(type: "float", nullable: true),
                    NetYield = table.Column<double>(type: "float", nullable: true),
                    TurnOverFee = table.Column<double>(type: "float", nullable: true),
                    RehabCosts = table.Column<double>(type: "float", nullable: true),
                    RehabDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearlyInsuranceCost = table.Column<double>(type: "float", nullable: true),
                    YearlyPropertyTaxes = table.Column<double>(type: "float", nullable: true),
                    IsCashOnly = table.Column<bool>(type: "bit", nullable: true),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial", x => x.IdFinancial);
                    table.ForeignKey(
                        name: "FK_Financial_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoogleMapOption",
                columns: table => new
                {
                    IdGoogleMapOption = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasStreetView = table.Column<bool>(type: "bit", nullable: false),
                    PovHeading = table.Column<int>(type: "int", nullable: false),
                    PovPitch = table.Column<int>(type: "int", nullable: false),
                    PovLatitude = table.Column<double>(type: "float", nullable: false),
                    PovLongitude = table.Column<double>(type: "float", nullable: false),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleMapOption", x => x.IdGoogleMapOption);
                    table.ForeignKey(
                        name: "FK_GoogleMapOption_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lease",
                columns: table => new
                {
                    LeaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lease", x => x.LeaseId);
                    table.ForeignKey(
                        name: "FK_Lease_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Physical",
                columns: table => new
                {
                    IdPhysical = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BathRooms = table.Column<double>(type: "float", nullable: false),
                    BedRooms = table.Column<double>(type: "float", nullable: false),
                    ParcelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPool = table.Column<bool>(type: "bit", nullable: false),
                    LotSize = table.Column<int>(type: "int", nullable: true),
                    SquareFeet = table.Column<int>(type: "int", nullable: false),
                    Stories = table.Column<int>(type: "int", nullable: true),
                    Units = table.Column<int>(type: "int", nullable: true),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
                    ZipYearBuilt = table.Column<int>(type: "int", nullable: true),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physical", x => x.IdPhysical);
                    table.ForeignKey(
                        name: "FK_Physical_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyResources",
                columns: table => new
                {
                    IdPropertyResources = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyResources", x => x.IdPropertyResources);
                    table.ForeignKey(
                        name: "FK_PropertyResources_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    IdScore = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrimeScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighborhoodScore = table.Column<int>(type: "int", nullable: false),
                    OverallScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualityScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharterSchoolScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloodRiskScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalkabilityScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.IdScore);
                    table.ForeignKey(
                        name: "FK_Score_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Valuation",
                columns: table => new
                {
                    IdValuation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvmBpoValue = table.Column<double>(type: "float", nullable: true),
                    AvmBpoAdjValue = table.Column<double>(type: "float", nullable: true),
                    AvmBpoDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RsAvmValue = table.Column<double>(type: "float", nullable: true),
                    RsAvmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RsBpoMergeValue = table.Column<double>(type: "float", nullable: true),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valuation", x => x.IdValuation);
                    table.ForeignKey(
                        name: "FK_Valuation_Property_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplianceOwnerships",
                columns: table => new
                {
                    IdApplianceOwnership = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Refrigerator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dishwasher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Washer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dryer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Microwave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stove = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplianceOwnerships", x => x.IdApplianceOwnership);
                    table.ForeignKey(
                        name: "FK_ApplianceOwnerships_Lease_LeaseId",
                        column: x => x.LeaseId,
                        principalTable: "Lease",
                        principalColumn: "LeaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaseSummary",
                columns: table => new
                {
                    IdLeaseSummary = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeasingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketedRent = table.Column<double>(type: "float", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaseEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MonthlyRent = table.Column<double>(type: "float", nullable: true),
                    SecurityDepositAmount = table.Column<double>(type: "float", nullable: true),
                    HasPet = table.Column<bool>(type: "bit", nullable: true),
                    PetFeeAmount = table.Column<double>(type: "float", nullable: true),
                    IsPetsDeposit = table.Column<bool>(type: "bit", nullable: true),
                    PetsDepositAmount = table.Column<double>(type: "float", nullable: true),
                    IsLeaseConcessions = table.Column<bool>(type: "bit", nullable: true),
                    IsRentersInsuranceRequired = table.Column<bool>(type: "bit", nullable: true),
                    IsSection8 = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantBackgroundChecked = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantIncomeAbove3x = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantMayTerminateEarly = table.Column<bool>(type: "bit", nullable: true),
                    IsTenantPurchaseOption = table.Column<bool>(type: "bit", nullable: true),
                    LeaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseSummary", x => x.IdLeaseSummary);
                    table.ForeignKey(
                        name: "FK_LeaseSummary_Lease_LeaseId",
                        column: x => x.LeaseId,
                        principalTable: "Lease",
                        principalColumn: "LeaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilitiesOwnership",
                columns: table => new
                {
                    IdUtilitiesOwnership = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Electric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Water = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Garbage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landscaping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PestControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilitiesOwnership", x => x.IdUtilitiesOwnership);
                    table.ForeignKey(
                        name: "FK_UtilitiesOwnership_Lease_LeaseId",
                        column: x => x.LeaseId,
                        principalTable: "Lease",
                        principalColumn: "LeaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    IdResource = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeInByte = table.Column<long>(type: "bigint", nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPropertyResources = table.Column<int>(type: "int", nullable: false),
                    AudioResource_PropertyResourcesIdPropertyResources = table.Column<int>(type: "int", nullable: true),
                    FloorPlanResource_PropertyResourcesIdPropertyResources = table.Column<int>(type: "int", nullable: true),
                    PropertyResourcesIdPropertyResources = table.Column<int>(type: "int", nullable: true),
                    ThreeDTourResource_PropertyResourcesIdPropertyResources = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.IdResource);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_AudioResource_PropertyResourcesIdPropertyResources",
                        column: x => x.AudioResource_PropertyResourcesIdPropertyResources,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResources",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_FloorPlanResource_PropertyResourcesIdPropertyResources",
                        column: x => x.FloorPlanResource_PropertyResourcesIdPropertyResources,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResources",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResources",
                        column: x => x.PropertyResourcesIdPropertyResources,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResources",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_ThreeDTourResource_PropertyResourcesIdPropertyResources",
                        column: x => x.ThreeDTourResource_PropertyResourcesIdPropertyResources,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResources",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Address1", "Address2", "City", "Country", "County", "District", "State", "Zip", "ZipPlus4" },
                values: new object[,]
                {
                    { 1, "000-X Moneta Way", "", "San Francisco", "USA", "test", null, "CA", "94112", null },
                    { 2, "524 Burlington Avenue NE", null, "Palm Bay", "USA", null, null, "FL", "32907", null },
                    { 3, "935 Alabama Street", null, "Titusville", "USA", "Brevard", null, "FL", "32796", null },
                    { 4, "1762 NW Glenridge Street", null, "Palm Bay", "USA", null, null, "FL", "32907", null },
                    { 5, "726 Lime Avenue NW", null, "Palm Bay", "USA", null, null, "FL", "32907", null },
                    { 6, "4200 Skyway Dr", null, "Cocoa", "USA", "Brevard", null, "FL", "32927", "8661" },
                    { 7, "3281 Kent Drive", null, "Melbourne", "USA", null, null, "FL", "32935", null },
                    { 8, "718 Reading Street SE", null, "Palm Bay", "USA", null, null, "FL", "32909", null },
                    { 9, "971 Fairhaven Street NE", null, "Palm Bay", "USA", null, null, "FL", "32907", null },
                    { 10, "1359 Carr Circle NE", null, "Palm Bay", "USA", null, null, "FL", "32905", null }
                });

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "Id", "AccountId", "AddressIdAddress", "AllowRentGuaranteedOptout", "AllowableSaleTypes", "AllowedFundingTypes", "BuyerAccountId", "BuyerUserId", "CertificationLevel", "DaysOnMarket", "Description", "DiligenceVaultSummary", "EscrowClosingDate", "ExternalId", "FeaturedReason", "HasAudio", "HasDiligenceVaultDocuments", "Highlights", "Hoa", "InspectionType", "IsAllowOffer", "IsAllowPreview", "IsBargain", "IsDiligenceVaultUnlocked", "IsDwellCertified", "IsFeatured", "IsHoa", "IsHot", "IsNew", "IsPropertyManagerOfferRetain", "IsRentGuaranteed", "IsSecuritized", "Latitude", "Longitude", "MainImageUrl", "Manager", "Market", "PersonalProperties", "PriceVisibility", "ProgramId", "PropertyName", "PropertyType", "Seller", "SellerBroker", "Status", "Visibility" },
                values: new object[,]
                {
                    { 1625006, 100213, null, false, "Individual, Bulk", "All", null, null, null, 617, "", null, null, null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 37.712330000000001, -122.4511, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/ef034b62-47e6-4d44-911c-54a5f3c3270d_image_1387552138145_640.jpg", null, 1007, null, "ShowPrice", null, null, "Unspecified", null, null, "CertificationRejected", "None" },
                    { 1625007, 100214, null, false, "Individual, Bulk", "All", 100247, 100350, "Certified", 56, "\r\n* List price is approximately 60% of peak value from late 2006\r\n* Estimated market rent is $165/month above current rent\r\n* 10 miles from Florida Institute of Technology & 15 miles from Melbourne Beach\r\n", "<ul><li>Property Valuation:<br/>$117,000</li><li>Estimated Market Rent: $1,150</li><li>Inspection Report:<br/>Estimated Repairs: $1,100</li></ul>", new DateTime(2016, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 28.01022, -80.659450000000007, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/93c9795a-54db-4bca-8d53-2e021b5d64fb_1-_Front_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" },
                    { 1625008, 0, null, false, null, null, null, null, null, null, null, null, null, null, null, false, false, null, null, null, false, false, null, false, false, false, null, false, false, null, false, false, null, null, null, null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "OffMarket", "None" },
                    { 1625009, 100214, null, false, "Individual, Bulk", "All", 100247, 100350, "Certified", 56, "\r\n* List price is approximately 60% of peak value from late 2006\r\n* Estimated market rent is $150/month above current rent\r\n* 10 miles from Florida Institute of Technology & 15 miles from Melbourne Beach\r\n", "<ul><li>Property Valuation:<br/>$109,000</li><li>Estimated Market Rent: $1,050</li><li>Inspection Report:<br/>Estimated Repairs: $1,000</li></ul>", new DateTime(2016, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 28.019100000000002, -80.725040000000007, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/52f33546-ce40-4611-9b8a-619a094b990a_1_-_front_img1366x768-0_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" },
                    { 1625011, 100214, null, false, "Individual, Bulk", "All", 100247, 100350, "Certified", 56, "\r\n* List price is approximately 60% of peak value from mid-2006\r\n* Estimated market rent is $170/month above current rent\r\n* Per inspection report roof has more than ten years of remaining life\r\n* 20 miles from Cape Canaveral Air Force Station & 20 miles from Cocoa Beach\r\n", "<ul><li>Property Valuation:<br/>$128,000</li><li>Estimated Market Rent: $1,140</li><li>Inspection Report:<br/>Estimated Repairs: $475</li></ul>", new DateTime(2016, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, null, false, false, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 28.473659999999999, -80.787729999999996, "https://roofstock-cdn.azureedge.net/public/properties/1625011/photo/01178d1e-af9b-4c75-ab46-0d097fb7d9ac_1_-_front_exterior_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" },
                    { 1625012, 100214, null, false, "Individual, Bulk", "All", 101076, 101236, "Certified", 95, "\r\n* List price is approximately 60% of peak value from late 2006\r\n* Per inspection report roof has 1-3 years of estimated remaining life. List price has taken this into account.\r\n* Estimated market rent is well above current rent\r\n* 6.5 miles from Indian Harbour Beach & 15 miles from Cocoa Beach\r\n\r\n", "<ul><li>Property Valuation:<br/>$124,000</li><li>Estimated Market Rent: $1,200</li><li>Inspection Report:<br/>Estimated Repairs: $700</li></ul>", new DateTime(2016, 4, 25, 17, 0, 0, 0, DateTimeKind.Utc), null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 28.160219999999999, -80.647199999999998, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/477c17c1-7784-4055-87a6-ef25505e82ac_1_-_Frontimg1366x768-0_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" },
                    { 1625010, 100214, null, false, "Individual, Bulk", "All", 100247, 100350, "Certified", 56, "\r\n* List price is approximately 60% of peak value from late 2006\r\n* Estimated market rent is $80/month above current rent\r\n* Rent increased to $970 on 10/27/2015\r\n* 5 miles from melbourne beach & 10 miles from orlando/melbourne international airport\r\n\r\n\r\n", "<ul><li>Property Valuation:<br/>$109,000</li><li>Estimated Market Rent: $1,040</li><li>Inspection Report:<br/>Estimated Repairs: $1,425</li></ul>", new DateTime(2016, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 28.01491, -80.703059999999994, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/5a1bc5e6-08fb-4a26-a65a-cc118f27a67e_1_-_img1366x768-2_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" },
                    { 1625014, 100214, null, false, "Individual, Bulk", "All", 100247, 100350, "Certified", 56, "\r\n* List price is approximately 60% of peak value from mid-2006\r\n* Estimated market rent is $150/month above current rent\r\n* Less than 2 miles from Eastern Florida State College & 15 miles from Melbourne Beach\r\n", "<ul><li>Property Valuation:<br/>$117,000</li><li>Estimated Market Rent: $980</li><li>Inspection Report:<br/>Estimated Repairs: $350</li></ul>", new DateTime(2016, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 28.000119999999999, -80.645060000000001, "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/198e7500-62bc-4696-8a00-72be6155b491_1_-_img1366x768-1_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" },
                    { 1625015, 0, null, false, null, null, null, null, null, null, null, null, null, null, null, false, false, null, null, null, false, false, null, false, false, false, null, false, false, null, false, false, null, null, null, null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "OffMarket", "None" },
                    { 1625013, 100214, null, false, "Individual, Bulk", "All", 100247, 100350, "Certified", 56, "\r\n* List price is approximately 65% of peak value from early 2007\r\n* Estimated market rent is $50.00/month above current rent\r\n* Per inspection report both the roof and a/c have more than ten years of remaining useful life\r\n* 20 miles from Melbourne Beach & 10 miles from the Florida Institute of Technology\r\n* Built in 2002\r\n", "<ul><li>Property Valuation:<br/>$120,000</li><li>Estimated Market Rent: $1,040</li><li>Inspection Report:<br/>Estimated Repairs: $450</li></ul>", new DateTime(2016, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), null, null, false, true, null, null, null, false, false, false, false, false, false, false, true, false, false, false, false, 27.92746, -80.652289999999994, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/6410835f-a97e-4388-bd46-0e2b82bc24c9_1_-_img1366x768-2_640.jpg", null, 1001, null, "ShowPrice", null, null, "Unspecified", null, null, "Sold", "Public" }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[,]
                {
                    { 34, "image/jpeg", null, "2 - kitchen_1280.jpg", "8948d553-38c3-47e8-9d18-beecd58b7981", 122579, 6, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/8948d553-38c3-47e8-9d18-beecd58b7981_2_-_kitchen_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/8948d553-38c3-47e8-9d18-beecd58b7981_2_-_kitchen_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/8948d553-38c3-47e8-9d18-beecd58b7981_2_-_kitchen_320.jpg" },
                    { 35, "image/jpeg", null, "3-dinning kitchen_1280.jpg", "a14d7149-f87c-4e30-bcfe-0fd05c413cd1", 122581, 6, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/a14d7149-f87c-4e30-bcfe-0fd05c413cd1_3-dinning_kitchen_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/a14d7149-f87c-4e30-bcfe-0fd05c413cd1_3-dinning_kitchen_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/a14d7149-f87c-4e30-bcfe-0fd05c413cd1_3-dinning_kitchen_320.jpg" },
                    { 36, "image/jpeg", null, "4- 3281 Kent Drive_1280.jpg", "1b29dacc-e9f4-489d-9228-f308cd4c6e46", 122583, 6, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/1b29dacc-e9f4-489d-9228-f308cd4c6e46_4-_3281_Kent_Drive_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/1b29dacc-e9f4-489d-9228-f308cd4c6e46_4-_3281_Kent_Drive_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/1b29dacc-e9f4-489d-9228-f308cd4c6e46_4-_3281_Kent_Drive_320.jpg" },
                    { 37, "image/jpeg", null, "5 - Bathroom_1280.jpg", "3cf3ad35-ca2f-4322-a362-d912af01d8b7", 122585, 6, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/3cf3ad35-ca2f-4322-a362-d912af01d8b7_5_-_Bathroom_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/3cf3ad35-ca2f-4322-a362-d912af01d8b7_5_-_Bathroom_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/3cf3ad35-ca2f-4322-a362-d912af01d8b7_5_-_Bathroom_320.jpg" },
                    { 40, "image/jpeg", null, "1 - img1366x768-2_1280.jpg", "6410835f-a97e-4388-bd46-0e2b82bc24c9", 122587, 7, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/6410835f-a97e-4388-bd46-0e2b82bc24c9_1_-_img1366x768-2_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/6410835f-a97e-4388-bd46-0e2b82bc24c9_1_-_img1366x768-2_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/6410835f-a97e-4388-bd46-0e2b82bc24c9_1_-_img1366x768-2_320.jpg" },
                    { 41, "image/jpeg", null, "2 - kitchen_1280.jpg", "29a682d1-a331-4961-9a91-3233d37f37ff", 122589, 7, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/29a682d1-a331-4961-9a91-3233d37f37ff_2_-_kitchen_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/29a682d1-a331-4961-9a91-3233d37f37ff_2_-_kitchen_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/29a682d1-a331-4961-9a91-3233d37f37ff_2_-_kitchen_320.jpg" },
                    { 42, "image/jpeg", null, "3 living room1_1280.jpg", "fa81d63e-83dd-4004-863c-f2423d853fa2", 122591, 7, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/fa81d63e-83dd-4004-863c-f2423d853fa2_3_living_room1_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/fa81d63e-83dd-4004-863c-f2423d853fa2_3_living_room1_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/fa81d63e-83dd-4004-863c-f2423d853fa2_3_living_room1_320.jpg" },
                    { 43, "image/jpeg", null, "4 - _1280.jpg", "11908fce-576f-40fd-a52a-97429caa3fea", 122593, 7, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/11908fce-576f-40fd-a52a-97429caa3fea_4_-__1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/11908fce-576f-40fd-a52a-97429caa3fea_4_-__640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/11908fce-576f-40fd-a52a-97429caa3fea_4_-__320.jpg" },
                    { 44, "image/jpeg", null, "5-room_1280.jpg", "0f1d6479-d383-48c9-b8cf-e579d44be66a", 122595, 7, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/0f1d6479-d383-48c9-b8cf-e579d44be66a_5-room_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/0f1d6479-d383-48c9-b8cf-e579d44be66a_5-room_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/0f1d6479-d383-48c9-b8cf-e579d44be66a_5-room_320.jpg" },
                    { 45, "image/jpeg", null, "6bathroom1_1280.jpg", "0a779120-4af7-43e7-ad20-9901fe4accb3", 122597, 7, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/0a779120-4af7-43e7-ad20-9901fe4accb3_6bathroom1_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/0a779120-4af7-43e7-ad20-9901fe4accb3_6bathroom1_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/0a779120-4af7-43e7-ad20-9901fe4accb3_6bathroom1_320.jpg" },
                    { 49, "image/jpeg", null, "2- range_1280.jpg", "3cc86862-cb7d-4bc2-aec6-104b90ba5f34", 122601, 8, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/3cc86862-cb7d-4bc2-aec6-104b90ba5f34_2-_range_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/3cc86862-cb7d-4bc2-aec6-104b90ba5f34_2-_range_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/3cc86862-cb7d-4bc2-aec6-104b90ba5f34_2-_range_320.jpg" },
                    { 50, "image/jpeg", null, "3 - master bedroom 1_1280.jpg", "a1708af2-a246-4673-9b24-0c215ab2179e", 122603, 8, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/a1708af2-a246-4673-9b24-0c215ab2179e_3_-_master_bedroom_1_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/a1708af2-a246-4673-9b24-0c215ab2179e_3_-_master_bedroom_1_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/a1708af2-a246-4673-9b24-0c215ab2179e_3_-_master_bedroom_1_320.jpg" },
                    { 51, "image/jpeg", null, "4 - 971 Fairhaven Street NE-2_1280.jpg", "22712e12-60b5-4a11-8391-19087bb188d2", 122605, 8, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/22712e12-60b5-4a11-8391-19087bb188d2_4_-_971_Fairhaven_Street_NE-2_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/22712e12-60b5-4a11-8391-19087bb188d2_4_-_971_Fairhaven_Street_NE-2_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/22712e12-60b5-4a11-8391-19087bb188d2_4_-_971_Fairhaven_Street_NE-2_320.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "ThreeDTourResource_PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[,]
                {
                    { 38, "application/octet-stream", null, "3281 Kent Drive_480p.mp4", "fbba169f-b3f6-4422-a9f6-cf251d0d108a", 118807, 6, true, null, "Property3DTour", null, null, "https://rs1pub1content.blob.core.windows.net/public/properties/1625012/photo/fbba169f-b3f6-4422-a9f6-cf251d0d108a_3281_Kent_Drive_480p.mp4", null, null },
                    { 31, "application/octet-stream", null, "726_LimeAvenueNW_480p.mp4", "77ddfc6c-e95d-49e8-bd8f-77ef255750d1", 118755, 4, true, null, "Property3DTour", null, null, "https://rs1pub1content.blob.core.windows.net/public/properties/1625010/photo/77ddfc6c-e95d-49e8-bd8f-77ef255750d1_726_LimeAvenueNW_480p.mp4", null, null },
                    { 24, "application/octet-stream", null, "1762_NWGlenridgeStreet_480p.mp4", "3daa239b-a637-4d55-8fb4-fff307e2c64f", 118725, 3, true, null, "Property3DTour", null, null, "https://rs1pub1content.blob.core.windows.net/public/properties/1625009/photo/3daa239b-a637-4d55-8fb4-fff307e2c64f_1762_NWGlenridgeStreet_480p.mp4", null, null },
                    { 14, "application/octet-stream", null, "524_BurlingtonAveNE_480p.mp4", "12d712e5-bf21-42a4-bc9d-83fa5224e8a4", 118675, 2, true, null, "Property3DTour", null, null, "https://rs1pub1content.blob.core.windows.net/public/properties/1625007/photo/12d712e5-bf21-42a4-bc9d-83fa5224e8a4_524_BurlingtonAveNE_480p.mp4", null, null }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[,]
                {
                    { 33, "image/jpeg", null, "1 - Frontimg1366x768-0_1280.jpg", "477c17c1-7784-4055-87a6-ef25505e82ac", 122577, 6, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/477c17c1-7784-4055-87a6-ef25505e82ac_1_-_Frontimg1366x768-0_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/477c17c1-7784-4055-87a6-ef25505e82ac_1_-_Frontimg1366x768-0_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/477c17c1-7784-4055-87a6-ef25505e82ac_1_-_Frontimg1366x768-0_320.jpg" },
                    { 48, "image/jpeg", null, "1 - img1366x768-1_1280.jpg", "198e7500-62bc-4696-8a00-72be6155b491", 122599, 8, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/198e7500-62bc-4696-8a00-72be6155b491_1_-_img1366x768-1_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/198e7500-62bc-4696-8a00-72be6155b491_1_-_img1366x768-1_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/198e7500-62bc-4696-8a00-72be6155b491_1_-_img1366x768-1_320.jpg" },
                    { 30, "image/jpeg", null, "5bathroom_1280.jpg", "4c823cca-ce71-453e-8634-7da675303814", 122561, 4, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/4c823cca-ce71-453e-8634-7da675303814_5bathroom_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/4c823cca-ce71-453e-8634-7da675303814_5bathroom_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/4c823cca-ce71-453e-8634-7da675303814_5bathroom_320.jpg" },
                    { 23, "image/jpeg", null, "9-back porch_1280.jpg", "a5eccfbf-b72d-4f6b-8aae-a7ce9c0f3725", 122551, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/a5eccfbf-b72d-4f6b-8aae-a7ce9c0f3725_9-back_porch_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/a5eccfbf-b72d-4f6b-8aae-a7ce9c0f3725_9-back_porch_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/a5eccfbf-b72d-4f6b-8aae-a7ce9c0f3725_9-back_porch_320.jpg" },
                    { 28, "image/jpeg", null, "3 _1280.jpg", "2091c6f5-e280-41f8-83b6-2e32b053e668", 122557, 4, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/2091c6f5-e280-41f8-83b6-2e32b053e668_3__1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/2091c6f5-e280-41f8-83b6-2e32b053e668_3__640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/2091c6f5-e280-41f8-83b6-2e32b053e668_3__320.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "FloorPlanResource_PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[,]
                {
                    { 7, "image/jpeg", null, "215 Chiquita Cape Coral - no logo_1280.jpg", "11d6adae-5cd3-4f26-b25c-f9e7a86e7d29", 110005, 1, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/11d6adae-5cd3-4f26-b25c-f9e7a86e7d29_215_Chiquita_Cape_Coral_-_no_logo_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/11d6adae-5cd3-4f26-b25c-f9e7a86e7d29_215_Chiquita_Cape_Coral_-_no_logo_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/11d6adae-5cd3-4f26-b25c-f9e7a86e7d29_215_Chiquita_Cape_Coral_-_no_logo_320.jpg" },
                    { 15, "image/jpeg", null, "im-524-burlington_1280.jpg", "4cbef504-cb56-47ef-a0ce-868f49582a12", 118673, 2, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/4cbef504-cb56-47ef-a0ce-868f49582a12_im-524-burlington_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/4cbef504-cb56-47ef-a0ce-868f49582a12_im-524-burlington_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/4cbef504-cb56-47ef-a0ce-868f49582a12_im-524-burlington_320.jpg" },
                    { 25, "image/jpeg", null, "im-1762-glenridge_1280.jpg", "0927ad26-5cde-4cf0-b982-f7e213e7fdc5", 118723, 3, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/0927ad26-5cde-4cf0-b982-f7e213e7fdc5_im-1762-glenridge_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/0927ad26-5cde-4cf0-b982-f7e213e7fdc5_im-1762-glenridge_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/0927ad26-5cde-4cf0-b982-f7e213e7fdc5_im-1762-glenridge_320.jpg" },
                    { 32, "image/jpeg", null, "im-726-lime_1280.jpg", "62bc8367-de82-4925-8139-fe31f10f5665", 118753, 4, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/62bc8367-de82-4925-8139-fe31f10f5665_im-726-lime_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/62bc8367-de82-4925-8139-fe31f10f5665_im-726-lime_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/62bc8367-de82-4925-8139-fe31f10f5665_im-726-lime_320.jpg" },
                    { 39, "image/jpeg", null, "im-3281-kent_1280.jpg", "5eb2494c-2ecc-44a4-bc29-b3757f1c2308", 118805, 6, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/5eb2494c-2ecc-44a4-bc29-b3757f1c2308_im-3281-kent_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/5eb2494c-2ecc-44a4-bc29-b3757f1c2308_im-3281-kent_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625012/photo/5eb2494c-2ecc-44a4-bc29-b3757f1c2308_im-3281-kent_320.jpg" },
                    { 47, "image/jpeg", null, "im-718-reading_1280.jpg", "c6531332-f4f1-4baf-be70-cfac06b5dc2d", 118829, 7, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/c6531332-f4f1-4baf-be70-cfac06b5dc2d_im-718-reading_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/c6531332-f4f1-4baf-be70-cfac06b5dc2d_im-718-reading_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625013/photo/c6531332-f4f1-4baf-be70-cfac06b5dc2d_im-718-reading_320.jpg" },
                    { 53, "image/jpeg", null, "971 Fairhaven_1280.jpg", "7757db77-dbe5-415f-a5aa-17739de0b078", 118855, 8, true, null, "PropertyFloorPlan", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/7757db77-dbe5-415f-a5aa-17739de0b078_971_Fairhaven_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/7757db77-dbe5-415f-a5aa-17739de0b078_971_Fairhaven_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625014/photo/7757db77-dbe5-415f-a5aa-17739de0b078_971_Fairhaven_320.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[,]
                {
                    { 1, "image/jpeg", null, "image_1387552138145_1280.jpg", "ef034b62-47e6-4d44-911c-54a5f3c3270d", 110007, 1, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/ef034b62-47e6-4d44-911c-54a5f3c3270d_image_1387552138145_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/ef034b62-47e6-4d44-911c-54a5f3c3270d_image_1387552138145_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/ef034b62-47e6-4d44-911c-54a5f3c3270d_image_1387552138145_320.jpg" },
                    { 2, "image/jpeg", null, "image_1387552141964_1280.jpg", "241378bb-4a9e-4715-9a54-570662f0c397", 110009, 1, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/241378bb-4a9e-4715-9a54-570662f0c397_image_1387552141964_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/241378bb-4a9e-4715-9a54-570662f0c397_image_1387552141964_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/241378bb-4a9e-4715-9a54-570662f0c397_image_1387552141964_320.jpg" },
                    { 3, "image/jpeg", null, "image_1387552143775_1280.jpg", "edacfedc-e8c3-48b3-bbcd-2ab8a2dc913e", 110011, 1, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/edacfedc-e8c3-48b3-bbcd-2ab8a2dc913e_image_1387552143775_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/edacfedc-e8c3-48b3-bbcd-2ab8a2dc913e_image_1387552143775_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/edacfedc-e8c3-48b3-bbcd-2ab8a2dc913e_image_1387552143775_320.jpg" },
                    { 4, "image/jpeg", null, "image_1387552146102_1280.jpg", "cffaf6b7-0d88-4f5e-a7c1-2eea5a340b47", 110013, 1, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/cffaf6b7-0d88-4f5e-a7c1-2eea5a340b47_image_1387552146102_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/cffaf6b7-0d88-4f5e-a7c1-2eea5a340b47_image_1387552146102_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/cffaf6b7-0d88-4f5e-a7c1-2eea5a340b47_image_1387552146102_320.jpg" },
                    { 5, "image/jpeg", null, "image_1387552150042_1280.jpg", "e5a38ffb-dff0-4404-a8c5-ec15a0d7e2b8", 110015, 1, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/e5a38ffb-dff0-4404-a8c5-ec15a0d7e2b8_image_1387552150042_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/e5a38ffb-dff0-4404-a8c5-ec15a0d7e2b8_image_1387552150042_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/e5a38ffb-dff0-4404-a8c5-ec15a0d7e2b8_image_1387552150042_320.jpg" },
                    { 6, "image/jpeg", null, "image_1387552150575_1280.jpg", "bb9b2c88-6ee1-42ff-8260-e98ebd5bcd3c", 110017, 1, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/bb9b2c88-6ee1-42ff-8260-e98ebd5bcd3c_image_1387552150575_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/bb9b2c88-6ee1-42ff-8260-e98ebd5bcd3c_image_1387552150575_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625006/photo/bb9b2c88-6ee1-42ff-8260-e98ebd5bcd3c_image_1387552150575_320.jpg" },
                    { 8, "image/jpeg", null, "1- Front_1280.jpg", "93c9795a-54db-4bca-8d53-2e021b5d64fb", 122525, 2, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/93c9795a-54db-4bca-8d53-2e021b5d64fb_1-_Front_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/93c9795a-54db-4bca-8d53-2e021b5d64fb_1-_Front_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/93c9795a-54db-4bca-8d53-2e021b5d64fb_1-_Front_320.jpg" },
                    { 9, "image/jpeg", null, "2 - dinning room_1280.jpg", "c4a11ed8-4aa7-4da8-b3ee-9e8e278bd2b1", 122527, 2, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/c4a11ed8-4aa7-4da8-b3ee-9e8e278bd2b1_2_-_dinning_room_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/c4a11ed8-4aa7-4da8-b3ee-9e8e278bd2b1_2_-_dinning_room_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/c4a11ed8-4aa7-4da8-b3ee-9e8e278bd2b1_2_-_dinning_room_320.jpg" },
                    { 10, "image/jpeg", null, "3 - living_1280.jpg", "78ac2c8b-391b-4431-a67b-6e07f9124a98", 122529, 2, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/78ac2c8b-391b-4431-a67b-6e07f9124a98_3_-_living_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/78ac2c8b-391b-4431-a67b-6e07f9124a98_3_-_living_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/78ac2c8b-391b-4431-a67b-6e07f9124a98_3_-_living_320.jpg" },
                    { 11, "image/jpeg", null, "4 - living room_1280.jpg", "dc8906b0-e6b0-4b71-b89f-8119f8e85ab3", 122531, 2, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/dc8906b0-e6b0-4b71-b89f-8119f8e85ab3_4_-_living_room_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/dc8906b0-e6b0-4b71-b89f-8119f8e85ab3_4_-_living_room_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/dc8906b0-e6b0-4b71-b89f-8119f8e85ab3_4_-_living_room_320.jpg" },
                    { 12, "image/jpeg", null, "5 - 524 Burlington Ave NE (2)_1280.jpg", "23775248-876a-424d-8c87-076ffb57f864", 122533, 2, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/23775248-876a-424d-8c87-076ffb57f864_5_-_524_Burlington_Ave_NE_(2)_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/23775248-876a-424d-8c87-076ffb57f864_5_-_524_Burlington_Ave_NE_(2)_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/23775248-876a-424d-8c87-076ffb57f864_5_-_524_Burlington_Ave_NE_(2)_320.jpg" },
                    { 13, "image/jpeg", null, "6 bathrm_1280.jpg", "5b3ffc2c-e22c-4d1f-a885-f0d224cd9558", 122535, 2, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/5b3ffc2c-e22c-4d1f-a885-f0d224cd9558_6_bathrm_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/5b3ffc2c-e22c-4d1f-a885-f0d224cd9558_6_bathrm_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625007/photo/5b3ffc2c-e22c-4d1f-a885-f0d224cd9558_6_bathrm_320.jpg" },
                    { 16, "image/jpeg", null, "1 - front img1366x768-0_1280.jpg", "52f33546-ce40-4611-9b8a-619a094b990a", 122537, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/52f33546-ce40-4611-9b8a-619a094b990a_1_-_front_img1366x768-0_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/52f33546-ce40-4611-9b8a-619a094b990a_1_-_front_img1366x768-0_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/52f33546-ce40-4611-9b8a-619a094b990a_1_-_front_img1366x768-0_320.jpg" },
                    { 17, "image/jpeg", null, "2 - kitchen_1280.jpg", "8557140b-0e71-4f05-ab2f-93dec5f02b56", 122539, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/8557140b-0e71-4f05-ab2f-93dec5f02b56_2_-_kitchen_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/8557140b-0e71-4f05-ab2f-93dec5f02b56_2_-_kitchen_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/8557140b-0e71-4f05-ab2f-93dec5f02b56_2_-_kitchen_320.jpg" },
                    { 18, "image/jpeg", null, "3 - dinning_1280.jpg", "364feb01-42ec-4e28-a8a9-878a3a695a5d", 122541, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/364feb01-42ec-4e28-a8a9-878a3a695a5d_3_-_dinning_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/364feb01-42ec-4e28-a8a9-878a3a695a5d_3_-_dinning_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/364feb01-42ec-4e28-a8a9-878a3a695a5d_3_-_dinning_320.jpg" },
                    { 19, "image/jpeg", null, "4 - 1359 Carr Circle NE-2_1280.jpg", "ca8e2c24-2820-4e6e-b6f9-f05aeb48b3ff", 122543, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/ca8e2c24-2820-4e6e-b6f9-f05aeb48b3ff_4_-_1359_Carr_Circle_NE-2_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/ca8e2c24-2820-4e6e-b6f9-f05aeb48b3ff_4_-_1359_Carr_Circle_NE-2_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/ca8e2c24-2820-4e6e-b6f9-f05aeb48b3ff_4_-_1359_Carr_Circle_NE-2_320.jpg" },
                    { 20, "image/jpeg", null, "5- Living room_1280.jpg", "e76e122a-ec14-4b0b-8ad6-cc2a36572f18", 122545, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/e76e122a-ec14-4b0b-8ad6-cc2a36572f18_5-_Living_room_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/e76e122a-ec14-4b0b-8ad6-cc2a36572f18_5-_Living_room_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/e76e122a-ec14-4b0b-8ad6-cc2a36572f18_5-_Living_room_320.jpg" },
                    { 21, "image/jpeg", null, "7 - master bath_1280.jpg", "04f77933-0c02-4d5a-9a9b-188c41907649", 122547, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/04f77933-0c02-4d5a-9a9b-188c41907649_7_-_master_bath_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/04f77933-0c02-4d5a-9a9b-188c41907649_7_-_master_bath_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/04f77933-0c02-4d5a-9a9b-188c41907649_7_-_master_bath_320.jpg" },
                    { 22, "image/jpeg", null, "8bedroon view_1280.jpg", "946a6744-604d-4b7a-a741-196b49da4422", 122549, 3, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/946a6744-604d-4b7a-a741-196b49da4422_8bedroon_view_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/946a6744-604d-4b7a-a741-196b49da4422_8bedroon_view_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625009/photo/946a6744-604d-4b7a-a741-196b49da4422_8bedroon_view_320.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "ThreeDTourResource_PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[] { 46, "application/octet-stream", null, "718_ReadingSt_480p.mp4", "b69944cf-0533-45e2-879d-30fa67009788", 118831, 7, true, null, "Property3DTour", null, null, "https://rs1pub1content.blob.core.windows.net/public/properties/1625013/photo/b69944cf-0533-45e2-879d-30fa67009788_718_ReadingSt_480p.mp4", null, null });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[,]
                {
                    { 26, "image/jpeg", null, "1 - img1366x768-2_1280.jpg", "5a1bc5e6-08fb-4a26-a65a-cc118f27a67e", 122553, 4, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/5a1bc5e6-08fb-4a26-a65a-cc118f27a67e_1_-_img1366x768-2_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/5a1bc5e6-08fb-4a26-a65a-cc118f27a67e_1_-_img1366x768-2_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/5a1bc5e6-08fb-4a26-a65a-cc118f27a67e_1_-_img1366x768-2_320.jpg" },
                    { 27, "image/jpeg", null, "2 - kitchen_1280.jpg", "bb927da2-0b19-48b9-859a-0aa63ca77e86", 122555, 4, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/bb927da2-0b19-48b9-859a-0aa63ca77e86_2_-_kitchen_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/bb927da2-0b19-48b9-859a-0aa63ca77e86_2_-_kitchen_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/bb927da2-0b19-48b9-859a-0aa63ca77e86_2_-_kitchen_320.jpg" },
                    { 29, "image/jpeg", null, "4- 726 Lime Avenue NW-2_1280.jpg", "a81f65bd-e300-46b7-90a7-be93605c03ad", 122559, 4, true, null, "PropertyPhoto", null, null, "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/a81f65bd-e300-46b7-90a7-be93605c03ad_4-_726_Lime_Avenue_NW-2_1280.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/a81f65bd-e300-46b7-90a7-be93605c03ad_4-_726_Lime_Avenue_NW-2_640.jpg", "https://roofstock-cdn.azureedge.net/public/properties/1625010/photo/a81f65bd-e300-46b7-90a7-be93605c03ad_4-_726_Lime_Avenue_NW-2_320.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "IdResource", "ContentType", "Description", "Filename", "Guid", "Id", "IdPropertyResources", "IsPublic", "ThreeDTourResource_PropertyResourcesIdPropertyResources", "ResourceType", "SizeInByte", "TextContent", "Url", "UrlMedium", "UrlSmall" },
                values: new object[] { 52, "application/octet-stream", null, "971_Fairhaven_Street_480p.mp4", "d2cfa64c-db1f-4571-8438-03bd1f5f4c67", 118857, 8, true, null, "Property3DTour", null, null, "https://rs1pub1content.blob.core.windows.net/public/properties/1625014/photo/d2cfa64c-db1f-4571-8438-03bd1f5f4c67_971_Fairhaven_Street_480p.mp4", null, null });

            migrationBuilder.InsertData(
                table: "Financial",
                columns: new[] { "IdFinancial", "CapRate", "IdProperty", "IsCashOnly", "IsSection8", "LeaseEndDate", "LeaseStartDate", "ListPrice", "MarketValue", "MonthlyHoa", "MonthlyManagementFees", "MonthlyRent", "NetYield", "Occupancy", "RehabCosts", "RehabDate", "SalePrice", "TurnOverFee", "YearlyInsuranceCost", "YearlyPropertyTaxes" },
                values: new object[,]
                {
                    { 1, null, 1625006, false, false, new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 189000.0, null, null, null, 1599.0, null, "Occupied", null, null, null, null, 600.0, 8000.0 },
                    { 5, null, 1625011, false, false, new DateTime(2016, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 114000.0, null, null, null, 920.0, null, "Occupied", null, null, null, null, 999.0, 2127.0 },
                    { 7, null, 1625013, false, false, new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 108000.0, null, null, null, 950.0, null, "Occupied", null, null, null, null, null, 2349.0 },
                    { 8, null, 1625014, false, false, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 100000.0, null, null, null, 800.0, null, "Occupied", null, null, null, null, 999.0, 2065.0 },
                    { 3, null, 1625009, false, false, new DateTime(2016, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102000.0, null, null, null, 850.0, null, "Occupied", null, null, null, null, 999.0, 2084.0 },
                    { 2, null, 1625007, false, false, new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 107000.0, null, null, null, 895.0, null, "Occupied", null, null, null, null, 999.0, 2349.0 },
                    { 4, null, 1625010, false, false, new DateTime(2016, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 104000.0, null, null, null, 970.0, null, "Occupied", null, null, null, null, 999.0, 2160.0 },
                    { 6, null, 1625012, false, false, new DateTime(2016, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000.0, null, null, null, 1025.0, null, "Occupied", null, null, null, null, 999.0, 2291.0 }
                });

            migrationBuilder.InsertData(
                table: "GoogleMapOption",
                columns: new[] { "IdGoogleMapOption", "HasStreetView", "IdProperty", "PovHeading", "PovLatitude", "PovLongitude", "PovPitch" },
                values: new object[,]
                {
                    { 4, true, 1625010, 94, 28.01491, -80.7030599, 0 },
                    { 3, true, 1625009, -179, 28.019096000000001, -80.725044999999994, 0 },
                    { 5, true, 1625011, -4, 28.473658, -80.787734, 0 },
                    { 6, true, 1625012, 79, 28.160216999999999, -80.647201899999999, 0 },
                    { 2, true, 1625007, -86, 28.010216, -80.659445000000005, 0 },
                    { 7, true, 1625013, 136, 27.927464000000001, -80.652288999999996, 0 },
                    { 1, true, 1625006, 335, 37.712753300000003, -122.44896559999999, 0 },
                    { 8, true, 1625014, -7, 28.000118000000001, -80.645056999999994, 0 }
                });

            migrationBuilder.InsertData(
                table: "Lease",
                columns: new[] { "LeaseId", "IdProperty" },
                values: new object[,]
                {
                    { 5, 1625011 },
                    { 6, 1625012 },
                    { 7, 1625013 },
                    { 8, 1625014 },
                    { 4, 1625010 },
                    { 1, 1625006 },
                    { 3, 1625009 },
                    { 2, 1625007 }
                });

            migrationBuilder.InsertData(
                table: "Physical",
                columns: new[] { "IdPhysical", "BathRooms", "BedRooms", "IdProperty", "IsPool", "LotSize", "ParcelNumber", "SquareFeet", "Stories", "Units", "YearBuilt", "ZipYearBuilt" },
                values: new object[,]
                {
                    { 3, 2.0, 3.0, 1625009, false, 10018, "28 3628KN019190000200", 1270, null, null, 1986, null },
                    { 7, 2.0, 3.0, 1625013, false, 10018, "29 3729GU011600000400 ", 1461, null, null, 2002, null },
                    { 4, 2.0, 3.0, 1625010, false, 10454, "28 3626KN021490000800 ", 1346, null, null, 1986, null },
                    { 1, 2.5, 2.0, 1625006, false, null, "", 1200, null, null, 1952, null },
                    { 8, 2.0, 3.0, 1625014, false, 9583, "28 3732FS002890002200", 1140, null, null, 1992, null },
                    { 5, 2.0, 3.0, 1625011, false, 11761, "23-35-23-JM-00052.0-0007.00", 1438, null, null, 1987, null },
                    { 6, 2.0, 4.0, 1625012, false, 7840, "27 370550000040000500", 1492, null, null, 1977, null },
                    { 2, 2.0, 4.0, 1625007, false, 15681, "28 3731FR001790001200", 1512, null, null, 1980, null }
                });

            migrationBuilder.InsertData(
                table: "PropertyResources",
                columns: new[] { "IdPropertyResources", "PropertyId" },
                values: new object[,]
                {
                    { 3, 1625009 },
                    { 1, 1625006 },
                    { 6, 1625012 },
                    { 8, 1625014 },
                    { 2, 1625007 },
                    { 5, 1625011 },
                    { 4, 1625010 },
                    { 7, 1625013 }
                });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "IdScore", "CharterSchoolScore", "ConditionScore", "CrimeScore", "FloodRiskScore", "IdProperty", "NeighborhoodScore", "OverallScore", "QualityScore", "SchoolScore", "WalkabilityScore" },
                values: new object[,]
                {
                    { 5, "A-", null, "D-", null, 1625011, 5, null, null, "B+", null },
                    { 2, null, null, "B", null, 1625007, 4, null, null, "B", null }
                });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "IdScore", "CharterSchoolScore", "ConditionScore", "CrimeScore", "FloodRiskScore", "IdProperty", "NeighborhoodScore", "OverallScore", "QualityScore", "SchoolScore", "WalkabilityScore" },
                values: new object[,]
                {
                    { 6, null, null, "C+", null, 1625012, 4, null, null, "B", null },
                    { 1, "", null, "", "", 1625006, 4, null, null, "", null },
                    { 8, null, null, "B", null, 1625014, 4, null, null, "B", null },
                    { 4, null, null, "B", null, 1625010, 4, null, null, "B", null },
                    { 3, null, null, "B", null, 1625009, 4, null, null, "B-", null },
                    { 7, "B", null, "B", null, 1625013, 5, null, null, "B+", null }
                });

            migrationBuilder.InsertData(
                table: "Valuation",
                columns: new[] { "IdValuation", "AvmBpoAdjValue", "AvmBpoDate", "AvmBpoValue", "IdProperty", "RsAvmDate", "RsAvmValue", "RsBpoMergeValue" },
                values: new object[,]
                {
                    { 4, null, null, null, 1625010, null, 110000.0, 109000.0 },
                    { 6, null, null, null, 1625012, null, 120000.0, 124000.0 },
                    { 5, null, null, null, 1625011, null, 120000.0, 128000.0 },
                    { 3, null, null, null, 1625009, null, 106000.0, 109000.0 },
                    { 2, null, null, null, 1625007, null, 120000.0, 117000.0 },
                    { 1, null, null, null, 1625006, null, 200000.0, null },
                    { 7, null, null, null, 1625013, null, 120000.0, 120000.0 },
                    { 8, null, null, null, 1625014, null, 117000.0, 117000.0 }
                });

            migrationBuilder.InsertData(
                table: "ApplianceOwnerships",
                columns: new[] { "IdApplianceOwnership", "Dishwasher", "Dryer", "LeaseId", "Microwave", "Refrigerator", "Stove", "Washer" },
                values: new object[,]
                {
                    { 1, "Unspecified", "Unspecified", 1, "Unspecified", "Unspecified", "Unspecified", "Unspecified" },
                    { 7, "Owner", "Tenant", 7, "Owner", "Owner", "Owner", "Tenant" },
                    { 8, "Owner", "Tenant", 8, "Owner", "Owner", "Owner", "Tenant" },
                    { 2, "Owner", "Tenant", 2, "Tenant", "Owner", "Owner", "Tenant" },
                    { 5, "Owner", "Tenant", 5, "Tenant", "Owner", "Owner", "Tenant" },
                    { 3, "Owner", "Tenant", 3, "Owner", "Owner", "Owner", "Tenant" },
                    { 6, "Owner", "Tenant", 6, "Tenant", "Owner", "Owner", "Tenant" },
                    { 4, "Owner", "Tenant", 4, "Owner", "Owner", "Owner", "Tenant" }
                });

            migrationBuilder.InsertData(
                table: "LeaseSummary",
                columns: new[] { "IdLeaseSummary", "HasPet", "IsLeaseConcessions", "IsPetsDeposit", "IsRentersInsuranceRequired", "IsSection8", "IsTenantBackgroundChecked", "IsTenantIncomeAbove3x", "IsTenantMayTerminateEarly", "IsTenantPurchaseOption", "LeaseEndDate", "LeaseId", "LeaseStartDate", "LeasingStatus", "MarketedRent", "MonthlyRent", "Occupancy", "PaymentStatus", "PetFeeAmount", "PetsDepositAmount", "SecurityDepositAmount" },
                values: new object[,]
                {
                    { 5, null, null, true, true, false, true, true, null, null, new DateTime(2016, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2015, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 920.0, "Occupied", "Current", null, 0.0, 1750.0 },
                    { 8, null, null, false, true, false, true, true, null, null, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 800.0, "Occupied", "Current", null, 0.0, 1200.0 },
                    { 7, null, null, true, true, false, true, true, null, null, new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 950.0, "Occupied", "Current", null, 0.0, 950.0 },
                    { 3, null, null, false, true, false, true, true, null, null, new DateTime(2016, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 850.0, "Occupied", "Current", null, null, 1238.0 },
                    { 2, null, null, false, true, false, true, true, null, null, new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 895.0, "Occupied", "Current", null, null, 895.0 },
                    { 1, null, false, false, false, false, false, false, null, null, new DateTime(2017, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1599.0, "Occupied", null, null, null, null },
                    { 4, null, null, false, true, false, true, true, null, null, new DateTime(2016, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 970.0, "Occupied", "Current", null, null, 940.0 },
                    { 6, null, null, true, true, false, true, true, null, null, new DateTime(2016, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2014, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1025.0, "Occupied", "Current", null, null, 1200.0 }
                });

            migrationBuilder.InsertData(
                table: "UtilitiesOwnership",
                columns: new[] { "IdUtilitiesOwnership", "Electric", "Garbage", "Gas", "Landscaping", "LeaseId", "PestControl", "Pool", "Water" },
                values: new object[,]
                {
                    { 7, "Tenant", "Tenant", "Tenant", "Tenant", 7, "Tenant", "NotApplicable", "Tenant" },
                    { 4, "Tenant", "Tenant", "Tenant", "Tenant", 4, "Tenant", "NotApplicable", "Tenant" },
                    { 5, "Tenant", "Tenant", "Tenant", "Tenant", 5, "Tenant", "NotApplicable", "Tenant" },
                    { 3, "Tenant", "Tenant", "Tenant", "Tenant", 3, "Tenant", "NotApplicable", "Tenant" },
                    { 2, "Tenant", "Tenant", "Tenant", "Tenant", 2, "Tenant", "NotApplicable", "Tenant" },
                    { 1, "Unspecified", "Unspecified", "Unspecified", "Unspecified", 1, "Unspecified", "Unspecified", "Unspecified" },
                    { 6, "Tenant", "Tenant", "Tenant", "Tenant", 6, "Tenant", "NotApplicable", "Tenant" },
                    { 8, "Tenant", "Tenant", "Tenant", "Tenant", 8, "Tenant", "NotApplicable", "Tenant" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplianceOwnerships_LeaseId",
                table: "ApplianceOwnerships",
                column: "LeaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diligence_PropertyId",
                table: "Diligence",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Financial_IdProperty",
                table: "Financial",
                column: "IdProperty",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GoogleMapOption_IdProperty",
                table: "GoogleMapOption",
                column: "IdProperty",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lease_IdProperty",
                table: "Lease",
                column: "IdProperty",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaseSummary_LeaseId",
                table: "LeaseSummary",
                column: "LeaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Physical_IdProperty",
                table: "Physical",
                column: "IdProperty",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Property_AddressIdAddress",
                table: "Property",
                column: "AddressIdAddress");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyResources_PropertyId",
                table: "PropertyResources",
                column: "PropertyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resource_AudioResource_PropertyResourcesIdPropertyResources",
                table: "Resource",
                column: "AudioResource_PropertyResourcesIdPropertyResources");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_FloorPlanResource_PropertyResourcesIdPropertyResources",
                table: "Resource",
                column: "FloorPlanResource_PropertyResourcesIdPropertyResources");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResources",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResources");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ThreeDTourResource_PropertyResourcesIdPropertyResources",
                table: "Resource",
                column: "ThreeDTourResource_PropertyResourcesIdPropertyResources");

            migrationBuilder.CreateIndex(
                name: "IX_Score_IdProperty",
                table: "Score",
                column: "IdProperty",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UtilitiesOwnership_LeaseId",
                table: "UtilitiesOwnership",
                column: "LeaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Valuation_IdProperty",
                table: "Valuation",
                column: "IdProperty",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplianceOwnerships");

            migrationBuilder.DropTable(
                name: "Diligence");

            migrationBuilder.DropTable(
                name: "Financial");

            migrationBuilder.DropTable(
                name: "GoogleMapOption");

            migrationBuilder.DropTable(
                name: "LeaseSummary");

            migrationBuilder.DropTable(
                name: "Physical");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "UtilitiesOwnership");

            migrationBuilder.DropTable(
                name: "Valuation");

            migrationBuilder.DropTable(
                name: "PropertyResources");

            migrationBuilder.DropTable(
                name: "Lease");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
