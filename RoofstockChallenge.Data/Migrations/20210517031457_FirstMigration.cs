using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoofstockChallenge.Data.Migrations
{
    public partial class FirstMigration : Migration
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
                    Stove = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplianceOwnerships", x => x.IdApplianceOwnership);
                });

            migrationBuilder.CreateTable(
                name: "Financial",
                columns: table => new
                {
                    IdFinancial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapRate = table.Column<double>(type: "float", nullable: false),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSection8 = table.Column<bool>(type: "bit", nullable: false),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaseEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    MarketValue = table.Column<double>(type: "float", nullable: false),
                    MonthlyHoa = table.Column<double>(type: "float", nullable: false),
                    MonthlyManagementFees = table.Column<double>(type: "float", nullable: false),
                    MonthlyRent = table.Column<double>(type: "float", nullable: false),
                    NetYield = table.Column<double>(type: "float", nullable: false),
                    TurnOverFee = table.Column<double>(type: "float", nullable: false),
                    RehabCosts = table.Column<double>(type: "float", nullable: false),
                    RehabDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YearlyInsuranceCost = table.Column<double>(type: "float", nullable: true),
                    YearlyPropertyTaxes = table.Column<double>(type: "float", nullable: false),
                    IsCashOnly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial", x => x.IdFinancial);
                });

            migrationBuilder.CreateTable(
                name: "googleMapOption",
                columns: table => new
                {
                    IdGoogleMapOption = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasStreetView = table.Column<bool>(type: "bit", nullable: false),
                    PovHeading = table.Column<int>(type: "int", nullable: false),
                    PovPitch = table.Column<int>(type: "int", nullable: false),
                    PovLatitude = table.Column<double>(type: "float", nullable: false),
                    PovLongitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_googleMapOption", x => x.IdGoogleMapOption);
                });

            migrationBuilder.CreateTable(
                name: "LeaseSummary",
                columns: table => new
                {
                    IdLeaseSummary = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupancy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeasingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketedRent = table.Column<double>(type: "float", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaseEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyRent = table.Column<double>(type: "float", nullable: false),
                    SecurityDepositAmount = table.Column<double>(type: "float", nullable: true),
                    HasPet = table.Column<bool>(type: "bit", nullable: false),
                    PetFeeAmount = table.Column<double>(type: "float", nullable: false),
                    IsPetsDeposit = table.Column<bool>(type: "bit", nullable: false),
                    PetsDepositAmount = table.Column<double>(type: "float", nullable: true),
                    IsLeaseConcessions = table.Column<bool>(type: "bit", nullable: true),
                    IsRentersInsuranceRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsSection8 = table.Column<bool>(type: "bit", nullable: false),
                    IsTenantBackgroundChecked = table.Column<bool>(type: "bit", nullable: false),
                    IsTenantIncomeAbove3x = table.Column<bool>(type: "bit", nullable: false),
                    IsTenantMayTerminateEarly = table.Column<bool>(type: "bit", nullable: false),
                    IsTenantPurchaseOption = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseSummary", x => x.IdLeaseSummary);
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
                    Stories = table.Column<int>(type: "int", nullable: false),
                    Units = table.Column<int>(type: "int", nullable: false),
                    YearBuilt = table.Column<int>(type: "int", nullable: false),
                    ZipYearBuilt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Physical", x => x.IdPhysical);
                });

            migrationBuilder.CreateTable(
                name: "PropertyResources",
                columns: table => new
                {
                    IdPropertyResource = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyResources", x => x.IdPropertyResource);
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
                    WalkabilityScore = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.IdScore);
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
                    PestControl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilitiesOwnership", x => x.IdUtilitiesOwnership);
                });

            migrationBuilder.CreateTable(
                name: "Valuation",
                columns: table => new
                {
                    IdValuation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvmBpoValue = table.Column<double>(type: "float", nullable: false),
                    AvmBpoAdjValue = table.Column<double>(type: "float", nullable: false),
                    AvmBpoDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RsAvmValue = table.Column<double>(type: "float", nullable: false),
                    RsAvmDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RsBpoMergeValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valuation", x => x.IdValuation);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeInByte = table.Column<long>(type: "bigint", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlMedium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlSmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyResourcesIdPropertyResource = table.Column<int>(type: "int", nullable: true),
                    PropertyResourcesIdPropertyResource1 = table.Column<int>(type: "int", nullable: true),
                    PropertyResourcesIdPropertyResource2 = table.Column<int>(type: "int", nullable: true),
                    PropertyResourcesIdPropertyResource3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource",
                        column: x => x.PropertyResourcesIdPropertyResource,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResource",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource1",
                        column: x => x.PropertyResourcesIdPropertyResource1,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResource",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource2",
                        column: x => x.PropertyResourcesIdPropertyResource2,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResource",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_PropertyResources_PropertyResourcesIdPropertyResource3",
                        column: x => x.PropertyResourcesIdPropertyResource3,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResource",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lease",
                columns: table => new
                {
                    IdLease = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaseSummaryIdLeaseSummary = table.Column<int>(type: "int", nullable: true),
                    UtilitiesOwnershipIdUtilitiesOwnership = table.Column<int>(type: "int", nullable: true),
                    ApplianceOwnershipIdApplianceOwnership = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lease", x => x.IdLease);
                    table.ForeignKey(
                        name: "FK_Lease_ApplianceOwnerships_ApplianceOwnershipIdApplianceOwnership",
                        column: x => x.ApplianceOwnershipIdApplianceOwnership,
                        principalTable: "ApplianceOwnerships",
                        principalColumn: "IdApplianceOwnership",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lease_LeaseSummary_LeaseSummaryIdLeaseSummary",
                        column: x => x.LeaseSummaryIdLeaseSummary,
                        principalTable: "LeaseSummary",
                        principalColumn: "IdLeaseSummary",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lease_UtilitiesOwnership_UtilitiesOwnershipIdUtilitiesOwnership",
                        column: x => x.UtilitiesOwnershipIdUtilitiesOwnership,
                        principalTable: "UtilitiesOwnership",
                        principalColumn: "IdUtilitiesOwnership",
                        onDelete: ReferentialAction.Restrict);
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
                    PersonalProperties = table.Column<int>(type: "int", nullable: false),
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
                    FinancialIdFinancial = table.Column<int>(type: "int", nullable: true),
                    PhysicalIdPhysical = table.Column<int>(type: "int", nullable: true),
                    ScoreIdScore = table.Column<int>(type: "int", nullable: true),
                    ValuationIdValuation = table.Column<int>(type: "int", nullable: true),
                    ResourcesIdPropertyResource = table.Column<int>(type: "int", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seller = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerBroker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaseIdLease = table.Column<int>(type: "int", nullable: true),
                    GoogleMapOptionIdGoogleMapOption = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Property_Financial_FinancialIdFinancial",
                        column: x => x.FinancialIdFinancial,
                        principalTable: "Financial",
                        principalColumn: "IdFinancial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_googleMapOption_GoogleMapOptionIdGoogleMapOption",
                        column: x => x.GoogleMapOptionIdGoogleMapOption,
                        principalTable: "googleMapOption",
                        principalColumn: "IdGoogleMapOption",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Lease_LeaseIdLease",
                        column: x => x.LeaseIdLease,
                        principalTable: "Lease",
                        principalColumn: "IdLease",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Physical_PhysicalIdPhysical",
                        column: x => x.PhysicalIdPhysical,
                        principalTable: "Physical",
                        principalColumn: "IdPhysical",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_PropertyResources_ResourcesIdPropertyResource",
                        column: x => x.ResourcesIdPropertyResource,
                        principalTable: "PropertyResources",
                        principalColumn: "IdPropertyResource",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Score_ScoreIdScore",
                        column: x => x.ScoreIdScore,
                        principalTable: "Score",
                        principalColumn: "IdScore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Valuation_ValuationIdValuation",
                        column: x => x.ValuationIdValuation,
                        principalTable: "Valuation",
                        principalColumn: "IdValuation",
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

            migrationBuilder.CreateIndex(
                name: "IX_Diligence_PropertyId",
                table: "Diligence",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_ApplianceOwnershipIdApplianceOwnership",
                table: "Lease",
                column: "ApplianceOwnershipIdApplianceOwnership");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_LeaseSummaryIdLeaseSummary",
                table: "Lease",
                column: "LeaseSummaryIdLeaseSummary");

            migrationBuilder.CreateIndex(
                name: "IX_Lease_UtilitiesOwnershipIdUtilitiesOwnership",
                table: "Lease",
                column: "UtilitiesOwnershipIdUtilitiesOwnership");

            migrationBuilder.CreateIndex(
                name: "IX_Property_AddressIdAddress",
                table: "Property",
                column: "AddressIdAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Property_FinancialIdFinancial",
                table: "Property",
                column: "FinancialIdFinancial");

            migrationBuilder.CreateIndex(
                name: "IX_Property_GoogleMapOptionIdGoogleMapOption",
                table: "Property",
                column: "GoogleMapOptionIdGoogleMapOption");

            migrationBuilder.CreateIndex(
                name: "IX_Property_LeaseIdLease",
                table: "Property",
                column: "LeaseIdLease");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PhysicalIdPhysical",
                table: "Property",
                column: "PhysicalIdPhysical");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ResourcesIdPropertyResource",
                table: "Property",
                column: "ResourcesIdPropertyResource");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ScoreIdScore",
                table: "Property",
                column: "ScoreIdScore");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ValuationIdValuation",
                table: "Property",
                column: "ValuationIdValuation");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource1",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource1");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource2",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource2");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_PropertyResourcesIdPropertyResource3",
                table: "Resource",
                column: "PropertyResourcesIdPropertyResource3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diligence");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Financial");

            migrationBuilder.DropTable(
                name: "googleMapOption");

            migrationBuilder.DropTable(
                name: "Lease");

            migrationBuilder.DropTable(
                name: "Physical");

            migrationBuilder.DropTable(
                name: "PropertyResources");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Valuation");

            migrationBuilder.DropTable(
                name: "ApplianceOwnerships");

            migrationBuilder.DropTable(
                name: "LeaseSummary");

            migrationBuilder.DropTable(
                name: "UtilitiesOwnership");
        }
    }
}
