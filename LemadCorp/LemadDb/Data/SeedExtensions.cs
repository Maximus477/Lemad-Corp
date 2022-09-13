using LemadDb.Domain.Entities;
using LemadDb.Domain.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Data
{
    public static class SeedExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region Roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole {
                    Name = "Seller",
                    NormalizedName = "SELLER"
                },
                new IdentityRole {
                    Name = "Buyer",
                    NormalizedName = "BUYER"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
            #endregion

            #region User
            List<ApplicationUser> users = new List<ApplicationUser>()
            {
                new ApplicationUser {
                    Email = "admin@lemadrid.com",
                    EntrepriseName = "Admin"
                },
                new ApplicationUser {
                    Email = "hugolapointe@cegepsth.qc.ca",
                    EntrepriseName = "Cégep Saint-Hyacinthe"
                }
            };

            users[0].PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(users[0], "!Qwerty123");
            users[1].PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(users[1], "!Qwerty123");

            builder.Entity<ApplicationUser>().HasData(users);
            #endregion

            #region Pilots
            List<Pilots> pilots = new List<Pilots> {

            };

            builder.Entity<Pilots>().HasData(pilots);
            #endregion

            #region Principals
            List<Principals> principals = new List<Principals> {

            };

            builder.Entity<Principals>().HasData(principals);
            #endregion

            #region PowerUnits
            List<PowerUnits> powerUnits = new List<PowerUnits> {

            };

            builder.Entity<PowerUnits>().HasData(principals);
            #endregion

            #region Engineers
            List<Engineers> engineers = new List<Engineers> {

            };

            builder.Entity<Engineers>().HasData(engineers);
            #endregion

            #region Mechanics
            List<Mechanics> mechanics = new List<Mechanics> {

            };

            builder.Entity<Mechanics>().HasData(mechanics);
            #endregion
        }
    }
}
