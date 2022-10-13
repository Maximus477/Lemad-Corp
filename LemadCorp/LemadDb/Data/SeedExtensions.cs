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

            #region Drivers
            List<Drivers> drivers = new List<Drivers> {
                new Drivers { Id = 1, Discount = 0, FirstName = "Fernando", LastName = "Alonso", Price = 20000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 2, Discount = 0, FirstName = "Esteban", LastName = "Ocon", Price = 5000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 3, Discount = 0, FirstName = "Max", LastName = "Verstappen", Price = 25000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 4, Discount = 0, FirstName = "Sergio", LastName = "Perez", Price = 8000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 5, Discount = 0, FirstName = "Charles", LastName = "Leclerc", Price = 12000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 6, Discount = 0, FirstName = "Carlos", LastName = "Sainz", Price = 10000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 7, Discount = 0, FirstName = "Lewis", LastName = "Hamilton", Price = 40000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 8, Discount = 0, FirstName = "George", LastName = "Russell", Price = 5000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 9, Discount = 0, FirstName = "Lando", LastName = "Norris", Price = 20000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 10, Discount = 0, FirstName = "Daniel", LastName = "Ricciardo", Price = 15000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 11, Discount = 0, FirstName = "Valtteri", LastName = "Bottas", Price = 10000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 12, Discount = 0, FirstName = "Zhou", LastName = "Guanyu", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 13, Discount = 0, FirstName = "Pierre", LastName = "Gasly", Price = 5000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 14, Discount = 0, FirstName = "Yuki", LastName = "Tsunoda", Price = 750000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 15, Discount = 0, FirstName = "Nicholas", LastName = "Latifi", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 16, Discount = 0, FirstName = "Alexander", LastName = "Albon", Price = 2000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 17, Discount = 0, FirstName = "Sebastian", LastName = "Vettel", Price = 15000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 18, Discount = 0, FirstName = "Lance", LastName = "Stroll", Price = 10000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 19, Discount = 0, FirstName = "Kevin", LastName = "Magnussen", Price = 6000000, Status = Status.ProductStatus.AVAILABLE },
                new Drivers { Id = 20, Discount = 0, FirstName = "Mick", LastName = "Schumacher", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
            };

            builder.Entity<Drivers>().HasData(drivers);
            #endregion

            #region Principals
            List<Principals> principals = new List<Principals> {
                new Principals { Id = 1, Discount = 0, FirstName = "Mattias", LastName = "Binotto", Price = 3000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 2, Discount = 0, FirstName = "Frédéric", LastName = "Vasseur", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 3, Discount = 0, FirstName = "Franz", LastName = "Tost", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 4, Discount = 0, FirstName = "Otmar", LastName = "Szafnauer", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 5, Discount = 0, FirstName = "Guenther", LastName = "Steiner", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 6, Discount = 0, FirstName = "Andreas", LastName = "Seidl", Price = 2000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 7, Discount = 0, FirstName = "Toto", LastName = "Wolff", Price = 9100000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 8, Discount = 0, FirstName = "Christian", LastName = "Horner", Price = 10000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 9, Discount = 0, FirstName = "Jost", LastName = "Capito", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new Principals { Id = 10, Discount = 0, FirstName = "Mike", LastName = "Krack", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
            };

            builder.Entity<Principals>().HasData(principals);
            #endregion

            #region PowerUnits
            List<PowerUnits> powerUnits = new List<PowerUnits> {
                new PowerUnits { Id = 1, Discount = 0, Name = "Red Bull Powertrains", Price = 50000000, Status = Status.ProductStatus.AVAILABLE },
                new PowerUnits { Id = 2, Discount = 0, Name = "Ferrari engines", Price = 40000000, Status = Status.ProductStatus.AVAILABLE },
                new PowerUnits { Id = 3, Discount = 0, Name = "Mercedes engines", Price = 35000000, Status = Status.ProductStatus.AVAILABLE },
                new PowerUnits { Id = 4, Discount = 0, Name = "Renault engines", Price = 30000000, Status = Status.ProductStatus.AVAILABLE },
            };

            builder.Entity<PowerUnits>().HasData(powerUnits);
            #endregion

            #region TechnicalChiefs
            List<TechnicalChiefs> technicalChiefs = new List<TechnicalChiefs> {
                new TechnicalChiefs { Id = 1, Discount = 0, FirstName = "Pierre", LastName = "Wache", Price = 2000000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 2, Discount = 0, FirstName = "Enrico", LastName = "Cardile", Price = 1500000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 3, Discount = 0, FirstName = "Simone", LastName = "Resta", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 4, Discount = 0, FirstName = "Matt", LastName = "Harman", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 5, Discount = 0, FirstName = "Mike", LastName = "Elliott", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 6, Discount = 0, FirstName = "Ben", LastName = "Watkins", Price = 800000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 7, Discount = 0, FirstName = "Francois-Xavier", LastName = "Demaison", Price = 750000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 8, Discount = 0, FirstName = "Jody", LastName = "Egginton", Price = 600000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 9, Discount = 0, FirstName = "Jan", LastName = "Monchaux", Price = 500000, Status = Status.ProductStatus.AVAILABLE },
                new TechnicalChiefs { Id = 10, Discount = 0, FirstName = "Andrew", LastName = "Green", Price = 400000, Status = Status.ProductStatus.AVAILABLE },
            };

            builder.Entity<TechnicalChiefs>().HasData(technicalChiefs);
            #endregion

            #region RaceEngineers
            List<RaceEngineers> raceEngineers = new List<RaceEngineers> {
                new RaceEngineers { Id = 1, Discount = 0, FirstName = "Ben", LastName = "Michell", Price = 2000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 2, Discount = 0, FirstName = "Chris", LastName = "Cronin", Price = 1500000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 3, Discount = 0, FirstName = "Jorn", LastName = "Becker", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 4, Discount = 0, FirstName = "Alex", LastName = "Chan", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 5, Discount = 0, FirstName = "Mattia", LastName = "Spini", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 6, Discount = 0, FirstName = "Pierre", LastName = "Hamelin", Price = 800000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 7, Discount = 0, FirstName = "Gary", LastName = "Gannon", Price = 750000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 8, Discount = 0, FirstName = "Ed", LastName = "Regan", Price = 600000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 9, Discount = 0, FirstName = "Gaetan", LastName = "Jego", Price = 500000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 10, Discount = 0, FirstName = "James", LastName = "Urwin", Price = 400000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 11, Discount = 0, FirstName = "Josh", LastName = "Peckett", Price = 2000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 12, Discount = 0, FirstName = "Karel", LastName = "Loos", Price = 1500000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 13, Discount = 0, FirstName = "Riccardo", LastName = "Musconi", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 14, Discount = 0, FirstName = "Peter", LastName = "Bonnington", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 15, Discount = 0, FirstName = "Gianpiero", LastName = "Lambiase", Price = 1000000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 16, Discount = 0, FirstName = "Hugh", LastName = "Bird", Price = 800000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 17, Discount = 0, FirstName = "Jason", LastName = "Prior", Price = 750000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 18, Discount = 0, FirstName = "Christopher", LastName = "Hayes", Price = 600000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 19, Discount = 0, FirstName = "Riccardo", LastName = "Adami", Price = 500000, Status = Status.ProductStatus.AVAILABLE },
                new RaceEngineers { Id = 20, Discount = 0, FirstName = "Xavier Marcos", LastName = "Padros", Price = 400000, Status = Status.ProductStatus.AVAILABLE },
            };

            builder.Entity<RaceEngineers>().HasData(raceEngineers);
            #endregion
        }
    }
}
