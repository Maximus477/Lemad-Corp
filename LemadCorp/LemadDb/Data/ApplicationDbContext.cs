using LemadDb.Domain.Entities;
using LemadDb.Domain.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace LemadDb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Drivers> pilots { get; set; }
        public DbSet<Principals> principals { get; set; }
        public DbSet<PowerUnits> powerUnits { get; set; }
        public DbSet<TechnicalChiefs> engineers { get; set; }
        public DbSet<RaceEngineers> mechanics { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
