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
                    Name = "Buyer",
                    NormalizedName = "BUYER"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
            #endregion

            #region User

            #endregion
        }
    }
}
