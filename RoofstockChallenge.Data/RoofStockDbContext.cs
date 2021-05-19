using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RoofstockChallenge.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;

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
        public DbSet<GoogleMapOption> GoogleMapOption { get; set; }
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
            modelBuilder.Entity<Lease>()
                .HasOne(x => x.ApplianceOwnership)
                .WithOne(x => x.Lease)
                .HasForeignKey<ApplianceOwnership>(x => x.LeaseId);
            modelBuilder.Entity<Lease>()
                .HasOne(x => x.LeaseSummary)
                .WithOne(x => x.Lease)
                .HasForeignKey<LeaseSummary>(x => x.LeaseId);
            modelBuilder.Entity<Lease>()
                .HasOne(x => x.UtilitiesOwnership)
                .WithOne(x => x.Lease)
                .HasForeignKey<UtilitiesOwnership>(x => x.LeaseId);


            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Resources)
                .WithOne(p => p.Property)
                .HasForeignKey<PropertyResources>(x => x.PropertyId);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Lease)
                .WithOne(p => p.Property)
                .HasForeignKey<Lease>(x => x.IdProperty);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Address)
                .WithOne(p => p.Property)
                .HasForeignKey<Address>(x => x.IdProperty);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Physical)
                .WithOne(p => p.Property)
                .HasForeignKey<Physical>(x => x.IdProperty);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Financial)
                .WithOne(p => p.Property)
                .HasForeignKey<Financial>(x => x.IdProperty);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.GoogleMapOption)
                .WithOne(p => p.Property)
                .HasForeignKey<GoogleMapOption>(x => x.IdProperty);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Score)
                .WithOne(p => p.Property)
                .HasForeignKey<Score>(x => x.IdProperty);
            modelBuilder.Entity<Property>()
                .HasOne(pr => pr.Valuation)
                .WithOne(p => p.Property)
                .HasForeignKey<Valuation>(x => x.IdProperty);


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
            modelBuilder.Seed();
        }
    }
}
