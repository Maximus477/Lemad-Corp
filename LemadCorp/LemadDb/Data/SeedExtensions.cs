using LemadDb.Domain.Entities;
using LemadDb.Domain.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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

            #region Products
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Discount = 0,
                    Name = "Fernando Alonso",
                    Price = 20000000,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/FernandoAlonso.png").FullName
                },
                new Product
                {
                    Id = 2,
                    Discount = 0,
                    Name = "Esteban Ocon",
                    Price = 5000000,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/EstebanOcon.png").FullName
                },
                new Product
                {
                    Id = 3,
                    Discount = 0,
                    Name = "Max Verstappen",
                    Price = 25000000,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/MaxVerstappen.png").FullName
                },
                new Product
                {
                    Id = 4,
                    Discount = 0,
                    Name = "Sergio Perez",
                    Price = 8000000,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/SergioPerez.png").FullName
                },
                new Product
                {
                    Id = 5,
                    Discount = 0,
                    Name = "Charles Leclerc",
                    Price = 12000000,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/CharlesLeclerc.png").FullName
                },
                new Product
                {
                    Id = 6,
                    Discount = 0,
                    Name = "Carlos Sainz",
                    Price = 10000000,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/CarlosSainz.png").FullName
                },
                new Product
                {
                    Id = 7,
                    Name = "Lewis Hamilton",
                    Price = 40000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/LewisHamilton.png").FullName
                },
                new Product
                {
                    Id = 8,
                    Name = "George Russell",
                    Price = 5000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/GeorgeRussell.png").FullName
                },
                new Product
                {
                    Id = 9,
                    Name = "Lando Norris",
                    Price = 20000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/LandoNorris.png").FullName
                },
                new Product
                {
                    Id = 10,
                    Name = "Daniel Ricciardo",
                    Price = 15000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/DanielRicciardo.png").FullName
                },
                new Product
                {
                    Id = 11,
                    Name = "Valtteri Bottas",
                    Price = 10000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/ValtteriBottas.png").FullName
                },
                new Product
                {
                    Id = 12,
                    Name = "Zhou Guanyu",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/ZhouGuanyu.png").FullName
                },
                new Product
                {
                    Id = 13,
                    Name = "Pierre Gasly",
                    Price = 5000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/PierreGasly.png").FullName
                },
                new Product
                {
                    Id = 14,
                    Name = "Yuki Tsunoda",
                    Price = 750000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/YukiTsunoda.png").FullName
                },
                new Product
                {
                    Id = 15,
                    Name = "Nicholas Latifi",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/NicholasLatifi.png").FullName
                },
                new Product
                {
                    Id = 16,
                    Name = "Alexander Albon",
                    Price = 2000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/AlexanderAlbon.png").FullName
                },
                new Product
                {
                    Id = 17,
                    Name = "Sebastian Vettel",
                    Price = 15000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/SebastianVettel.png").FullName
                },
                new Product
                {
                    Id = 18,
                    Name = "Lance Stroll",
                    Price = 10000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/LanceStroll.png").FullName
                },
                new Product
                {
                    Id = 19,
                    Name = "Kevin Magnussen",
                    Price = 6000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/KevinMagnussen.png").FullName
                },
                new Product
                {
                    Id = 20,
                    Name = "Mick Schumacher",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.DRIVER,
                    Path = new FileInfo("wwwroot/img/products/drivers/MickSchumacher.png").FullName
                },
                new Product
                {
                    Id = 21,
                    Name = "Mattia Binotto",
                    Price = 3000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/MattiaBinotto.png").FullName
                },
                new Product
                {
                    Id = 22,
                    Name = "Frédéric Vasseur",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/FredericVasseur.png").FullName
                },
                new Product
                {
                    Id = 23,
                    Name = "Franz Tost",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/FranzTost.png").FullName
                },
                new Product
                {
                    Id = 24,
                    Name = "Otmar Szafnauer",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/OtmarSzafnauer.png").FullName
                },
                new Product
                {
                    Id = 25,
                    Name = "Guenther Steiner",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/GuentherSteiner.png").FullName
                },
                new Product
                {
                    Id = 26,
                    Name = "Andreas Seidl",
                    Price = 2000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/AndreasSeidl.png").FullName
                },
                new Product
                {
                    Id = 27,
                    Name = "Toto Wolff",
                    Price = 9100000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/TotoWolff.png").FullName
                },
                new Product
                {
                    Id = 28,
                    Name = "Christian Horner",
                    Price = 10000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/ChristianHorner.png").FullName
                },
                new Product
                {
                    Id = 29,
                    Name = "Jost Capito",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/JostCapito.png").FullName
                },
                new Product
                {
                    Id = 30,
                    Name = "Mike Krack",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.PRINCIPAL,
                    Path = new FileInfo("wwwroot/img/products/principals/MikeKrack.png").FullName
                },
                new Product
                {
                    Id = 31,
                    Name = "Red Bull Powertrains",
                    Price = 50000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.POWERUNIT,
                    Path = new FileInfo("wwwroot/img/products/powerunits/RedBullPowertrains.png").FullName
                },
                new Product
                {
                    Id = 32,
                    Name = "Ferrari engines",
                    Price = 40000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.POWERUNIT,
                    Path = new FileInfo("wwwroot/img/products/powerunits/FerrariEngines.png").FullName
                },
                new Product
                {
                    Id = 33,
                    Name = "Mercedes engines",
                    Price = 35000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.POWERUNIT,
                    Path = new FileInfo("wwwroot/img/products/powerunits/MercedesEngines.png").FullName
                },
                new Product
                {
                    Id = 34,
                    Name = "Renault engines",
                    Price = 30000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.POWERUNIT,
                    Path = new FileInfo("wwwroot/img/products/powerunits/RenaultEngines.png").FullName
                },
                new Product
                {
                    Id = 35,
                    Name = "Jody Egginton",
                    Price = 600000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/JodyEgginton.png").FullName
                },
                new Product
                {
                    Id = 36,
                    Name = "Pierre Washe",
                    Price = 2000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/PierreWashe.png").FullName
                },
                new Product
                {
                    Id = 37,
                    Name = "Enrico Cardile",
                    Price = 1500000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/EnricoCardile.png").FullName
                },
                new Product
                {
                    Id = 38,
                    Name = "Simone Resta",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/SimoneResta.png").FullName
                },
                new Product
                {
                    Id = 39,
                    Name = "Matt Harman",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/MattHarman.png").FullName
                },
                new Product
                {
                    Id = 40,
                    Name = "Mike Elliott",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/MikeElliott.png").FullName
                },
                new Product
                {
                    Id = 41,
                    Name = "Ben Watkins",
                    Price = 800000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/BenWatkins.png").FullName
                },
                new Product
                {
                    Id = 42,
                    Name = "Francois-Xavier Demaison",
                    Price = 750000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/FrancoisXavierDemaison.png").FullName
                },
                new Product
                {
                    Id = 43,
                    Name = "Jan Monchaux",
                    Price = 500000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/JanMonchaux.png").FullName
                },
                new Product
                {
                    Id = 44,
                    Name = "Andrew Green",
                    Price = 400000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.TECHNICALCHIEF,
                    Path = new FileInfo("wwwroot/img/products/technicalchiefs/AndrewGreen.png").FullName
                },
                new Product
                {
                    Id = 45,
                    Name = "Ben Michell",
                    Price = 2000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/BenMichell.png").FullName
                },
                new Product
                {
                    Id = 46,
                    Name = "Chris Cronin",
                    Price = 1500000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/ChrisCronin.png").FullName
                },
                new Product
                {
                    Id = 47,
                    Name = "Jorn Becker",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/JornBecker.png").FullName
                },
                new Product
                {
                    Id = 48,
                    Name = "Alex Chan",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/AlexChan.png").FullName
                },
                new Product
                {
                    Id = 49,
                    Name = "Mattia Spini",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/MattiaSpini.png").FullName
                },
                new Product
                {
                    Id = 50,
                    Name = "Pierre Hamelin",
                    Price = 800000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/PierreHamelin.png").FullName
                },
                new Product
                {
                    Id = 51,
                    Name = "Gary Gannon",
                    Price = 750000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/GaryGannon.png").FullName
                },
                new Product
                {
                    Id = 52,
                    Name = "Ed Regan",
                    Price = 600000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/EdRegan.png").FullName
                },
                new Product
                {
                    Id = 53,
                    Name = "Gaetan Jego",
                    Price = 500000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/GaetanJego.png").FullName
                },
                new Product
                {
                    Id = 54,
                    Name = "James Urwin",
                    Price = 400000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/JamesUrwin.png").FullName
                },
                new Product
                {
                    Id = 55,
                    Name = "Josh Pecket",
                    Price = 2000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/JoshPecket.png").FullName
                },
                new Product
                {
                    Id = 56,
                    Name = "Karel Loos",
                    Price = 1500000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/KarelLoos.png").FullName
                },
                new Product
                {
                    Id = 57,
                    Name = "Riccardo Musconi",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/RiccardoMusconi.png").FullName
                },
                new Product
                {
                    Id = 58,
                    Name = "Peter Bonnington",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/PeterBonnington.png").FullName
                },
                new Product
                {
                    Id = 59,
                    Name = "Gianpiero Lambiase",
                    Price = 1000000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/GianpieroLambiase.png").FullName
                },
                new Product
                {
                    Id = 60,
                    Name = "Hugh Bird",
                    Price = 800000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/HughBird.png").FullName
                },
                new Product
                {
                    Id = 61,
                    Name = "Jason Prior",
                    Price = 750000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/JasonPrior.png").FullName
                },
                new Product
                {
                    Id = 62,
                    Name = "Christopher Hayes",
                    Price = 600000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/CristopherHayes.png").FullName
                },
                new Product
                {
                    Id = 63,
                    Name = "Riccardo Adami",
                    Price = 500000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/RiccardoAdami.png").FullName
                },
                new Product
                {
                    Id = 64,
                    Name = "Xavier Marcos Pardos",
                    Price = 400000,
                    Discount = 0,
                    Status = Status.ProductStatus.AVAILABLE,
                    ProductCategory = Category.ProductCategory.RACEENGINEER,
                    Path = new FileInfo("wwwroot/img/products/raceengineers/XavierMarcosPardos.png").FullName
                },
            };

            builder.Entity<Product>().HasData(products);
            #endregion
        }
    }
}
