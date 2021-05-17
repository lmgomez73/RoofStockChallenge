using Microsoft.EntityFrameworkCore;
using RoofstockChallenge.Model;
using System;

namespace RoofstockChallenge.Data
{
    public class RoofStockDbContext : DbContext
    {

        #region Constructors
        public RoofStockDbContext(DbContextOptions<RoofStockDbContext> options) : base(options)
        {

        }
        public RoofStockDbContext()
        {

        }
        #endregion

        #region DbSets
        public DbSet<Address> Address { get; set; }
        public DbSet<ApplianceOwnership> ApplianceOwnerships { get; set; }
        public DbSet<Diligences> Diligence { get; set; }
        public DbSet<Financial> Financial { get; set; }
        public DbSet<GoogleMapOption> googleMapOption { get; set; }
        public DbSet<Lease> Lease { get; set; }
        public DbSet<LeaseSummary> LeaseSummary { get; set; }
        public DbSet<Physical> Physical { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<PropertyResources> PropertyResources { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<UtilitiesOwnership> UtilitiesOwnership { get; set; }
        public DbSet<Valuation> Valuation { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<PropertyResources>()
            //    .ToTable("Property")
            //    .HasMany(r => r.Audios)
            //    .WithOne(r => r.PropertyResources)
            //    .HasForeignKey(r=>r.;
            
            modelBuilder.Entity<AudioResource>()
                .ToTable("Resource");
            modelBuilder.Entity<PhotoResource>()
                .ToTable("Resource");
            modelBuilder.Entity<ThreeDTourResource>()
                .ToTable("Resource");
            modelBuilder.Entity<FloorPlanResource>()
                .ToTable("Resource");
            modelBuilder.Entity<Resource>()
                .HasDiscriminator<string>(name: "ResourceType")
                .HasValue<PhotoResource>(value: Enum.GetName<ResourceType>(ResourceType.PropertyPhoto))
                .HasValue<ThreeDTourResource>(value: Enum.GetName<ResourceType>(ResourceType.Property3DTour))
                .HasValue<AudioResource>(value: Enum.GetName<ResourceType>(ResourceType.PropertyAudio))
                .HasValue<FloorPlanResource>(value: Enum.GetName<ResourceType>(ResourceType.PropertyFloorPlan));
        }
    }
}
