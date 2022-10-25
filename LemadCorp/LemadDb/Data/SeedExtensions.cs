using LemadDb.Domain.Entities;
using LemadDb.Domain.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LemadDb.Data.Enumerable;

namespace LemadDb.Data
{
    public static class SeedExtensions
    {
        private static readonly PasswordHasher<ApplicationUser> PASSWORD_HASHER = new();

        private static ApplicationUser CreateUser(this ModelBuilder builder, string email, string firstName, string lastName, string cellPhone, string password)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                FirstName = firstName,
                LastName = lastName,
                Cellphone = cellPhone,
                NormalizedUserName = email.ToUpper(),
                Email = email,
                NormalizedEmail = email.ToUpper()
            };
            user.PasswordHash = PASSWORD_HASHER.HashPassword(user, password);

            return user;
        }

        private static ApplicationUser CreateUser(string email, string password)
        {
            var user = new ApplicationUser
            {
                UserName = email,
                NormalizedEmail = email.ToUpper(),
                Email = email,
                NormalizedUserName = email.ToUpper(),
            };
            user.PasswordHash = PASSWORD_HASHER.HashPassword(user, password);
            return user;
        }

        private static IdentityRole CreateRole(string name)
        {
            return new IdentityRole
            {
                Name = name,
                NormalizedName = name.ToUpper()
            };
        }

        private static Product CreateProduct(int id, int discount, string name, decimal price, ProductStatus status, ProductCategory category, string path, int maxContract, DateTime date, string description, string quote)
        {
            return new Product
            {
                Id = id,
                Discount = discount,
                Name = name,
                Price = price,
                Status = status,
                ProductCategory = category,
                Path = path,
                MaxContractTime = maxContract,
                DateNaissance = date,
                Description = description,
                Quote = quote
            };
        }

        private static AdresseCivique CreateAddress(string address, string city, string province, string country, string postalCode)
        {
            AdresseCivique adresse = new AdresseCivique
            {
                Id = Guid.NewGuid(),
                Address = address,
                City = city,
                Province = province,
                Country = country,
                PostalCode = postalCode
            };

            return adresse;
        }

        private static void SeedProducts(this ModelBuilder builder, IEnumerable<Product> products)
        { builder.Entity<Product>().HasData(products); }

        private static void SeedUsers(this ModelBuilder builder, IEnumerable<ApplicationUser> users)
        { builder.Entity<ApplicationUser>().HasData(users); }

        private static void SeedRoles(this ModelBuilder builder, IEnumerable<IdentityRole> roles)
        { builder.Entity<IdentityRole>().HasData(roles); }

        private static void SeedAddress(this ModelBuilder builder, IEnumerable<AdresseCivique> address)
        { builder.Entity<AdresseCivique>().HasData(address); }

        private static void SeedUsersToRole(this ModelBuilder builder, IEnumerable<ApplicationUser> users, IdentityRole role)
        {
            foreach (var user in users)
            {
                builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    UserId = user.Id,
                    RoleId = role.Id
                });
            }
        }

        private static void SeedUsersToAddress(this ModelBuilder builder, IEnumerable<ApplicationUser> users, AdresseCivique address)
        {
            foreach (ApplicationUser user in users)
            {
                builder.Entity<AddressUser>().HasData(new AddressUser {
                    ApplicationUserId = user.Id,
                    AdresseCiviqueId = address.Id
                });
            }
        }

        private static void SeedImage(IEnumerable<Product> products)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=LemadDb;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                foreach (Product item in products)
                {
                    string sqlQuery = @$"UPDATE Products SET Products.Photo = (SELECT BulkColumn FROM OPENROWSET(BULK N'{new FileInfo(item.Path).FullName}', SINGLE_BLOB) AS x) WHERE Products.Id = {item.Id}";
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = sqlQuery;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }

        public static void Seed(this ModelBuilder builder)
        {
            #region Users/Roles
            List<IdentityRole> roles = new List<IdentityRole> {
                CreateRole("admin"),
                CreateRole("buyer")
            };
            SeedRoles(builder, roles);

            List<AdresseCivique> adressesCiviques = new List<AdresseCivique> {
                CreateAddress("3000 Av. Boullé", "Saint-Hyacinthe", "Québec", "Canada", "J2S 1H9"),
                CreateAddress("1899 Henri-Becquerel", "Sainte-Julie", "Québec", "Canada", "J3E 1V6")
            };
            SeedAddress(builder, adressesCiviques);

            var admins = new List<ApplicationUser>() { CreateUser("admin@lemadrid.com", "!Qwerty123") };

            var users = new List<ApplicationUser> {
                CreateUser(builder, "hugo@lemadrid.com", "Hugo", "Lapointe", "(450)-773-6800", "!Qwerty123"),
                CreateUser(builder, "karl.mainville@lemadrid.com", "Karl", "Mainville", "(450)-649-8594", "!Qwerty123"),
                CreateUser(builder, "maxime.lefebvre@lemadrid.com", "Maxime", "Lefebvre", "(450)-538-3982", "!Qwerty123"),
                CreateUser(builder, "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "!Qwerty123"),
                CreateUser(builder, "laurent.brochu@lemadrid.com", "Laurent", "Brochu", "(450)-789-4673", "!Qwerty123"),
            };

            builder.SeedUsers(admins);
            builder.SeedUsers(users);

            builder.SeedUsersToRole(admins, roles[0]);
            builder.SeedUsersToRole(users, roles[1]);

            builder.SeedUsersToAddress(new List<ApplicationUser> { users[0], users[2], users[3], users[4] }, adressesCiviques[0]);
            builder.SeedUsersToAddress(new List<ApplicationUser> { users[1] }, adressesCiviques[1]);
            #endregion

            #region Products
            List<Product> products = new List<Product> {
                CreateProduct(1, 0, "Fernando Alonso", 20000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/FernandoAlonso.png", 5, new DateTime(1981, 07, 29), "Teflonso, the spanish GOAT", "I am one of the best to have raced in F1. I am probably not fastest in qualifying, or the wet, but I am 9.5 in all areas. I try to benefit from that."),
                CreateProduct(2, 0, "Esteban Ocon", 5000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/EstebanOcon.png", 5, new DateTime(1996, 09, 17), "", ""),
                CreateProduct(3, 0, "Max Verstappen", 25000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/MaxVerstappen.png", 5, new DateTime(1997, 09, 30), "Mad Max", "Mistakes happen, and they happen to the best of us."),
                CreateProduct(4, 0, "Sergio Perez", 8000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/SergioPerez.png", 5, new DateTime(1990, 01, 26), "Checo", ""),
                CreateProduct(5, 0, "Charles Leclerc", 12000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/CharlesLeclerc.png", 5, new DateTime(1997, 10, 16), "", ""),
                CreateProduct(6, 0, "Carlos Sainz", 10000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/CarlosSainz.png", 5, new DateTime(1994, 09, 1), "", ""),
                CreateProduct(7, 0, "Lewis Hamilton", 40000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/LewisHamilton.png", 5, new DateTime(1985, 01, 07), "", ""),
                CreateProduct(8, 2, "George Russell", 5000000, ProductStatus.PROMOTION, ProductCategory.DRIVER, "wwwroot/img/products/drivers/GeorgeRussell.png", 5, new DateTime(1998, 02, 15), "", ""),
                CreateProduct(9, 0, "Lando Norris", 20000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/LandoNorris.png", 5, new DateTime(1999, 11, 13), "", ""),
                CreateProduct(10, 0, "Daniel Ricciardo", 15000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/DanielRicciardo.png", 5, new DateTime(1989, 07, 01), "", ""),
                CreateProduct(11, 0, "Valtteri Bottas", 10000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/ValtteriBottas.png", 5, new DateTime(1989, 08, 28), "", ""),
                CreateProduct(12, 0, "Zhou Guanyu", 1000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/ZhouGuanyu.png", 5, new DateTime(1999, 05, 30), "", ""),
                CreateProduct(13, 80, "Pierre Gasly", 5000000, ProductStatus.PROMOTION, ProductCategory.DRIVER, "wwwroot/img/products/drivers/PierreGasly.png", 5, new DateTime(1996, 02, 7), "", ""),
                CreateProduct(14, 0, "Yuki Tsunoda", 750000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/YukiTsunoda.png", 5, new DateTime(2000, 05, 11), "", ""),
                CreateProduct(15, 60, "Nicholas Latifi", 1000000, ProductStatus.PROMOTION, ProductCategory.DRIVER, "wwwroot/img/products/drivers/NicholasLatifi.png", 5, new DateTime(1995, 06, 29), "", ""),
                CreateProduct(16, 0, "Alexander Albon", 2000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/AlexanderAlbon.png", 5, new DateTime(1996, 03, 23), "", ""),
                CreateProduct(17, 0, "Sebastian Vettel", 15000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/SebastianVettel.png", 5, new DateTime(1987, 07, 03), "", ""),
                CreateProduct(18, 49, "Lance Stroll", 10000000, ProductStatus.PROMOTION, ProductCategory.DRIVER, "wwwroot/img/products/drivers/LanceStroll.png", 5, new DateTime(1998, 11, 29), "", ""),
                CreateProduct(19, 22, "Kevin Magnussen", 6000000, ProductStatus.UNAVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/KevinMagnussen.png", 5, new DateTime(1992, 11, 05), "", ""),
                CreateProduct(20, 0, "Mick Schumacher", 1000000, ProductStatus.AVAILABLE, ProductCategory.DRIVER, "wwwroot/img/products/drivers/MickSchumacher.png", 5, new DateTime(1999, 03, 22), "", ""),

                CreateProduct(21, 0, "Mattia Binotto", 3000000, ProductStatus.AVAILABLE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/MattiaBinotto.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(22, 0, "Frédéric Vasseur", 1000000, ProductStatus.UNAVAILABLE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/FredericVasseur.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(23, 25, "Franz Tost", 1000000, ProductStatus.INCOMMANDE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/FranzTost.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(24, 0, "Otmar Szafnauer", 1000000, ProductStatus.AVAILABLE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/OtmarSzafnauer.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(25, 34, "Guenther Steiner", 1000000, ProductStatus.PROMOTION, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/GuentherSteiner.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(26, 0, "Andreas Seidl", 2000000, ProductStatus.AVAILABLE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/AndreasSeidl.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(27, 0, "Toto Wolff", 9100000, ProductStatus.AVAILABLE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/TotoWolff.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(28, 13, "Christian Horner", 10000000, ProductStatus.PROMOTION, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/ChristianHorner.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(29, 0, "Jost Capito", 1000000, ProductStatus.INCOMMANDE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/JostCapito.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(30, 0, "Mike Krack", 1000000, ProductStatus.AVAILABLE, ProductCategory.PRINCIPAL, "wwwroot/img/products/principals/MikeKrack.png", 5, new DateTime(1990, 01, 01), "", ""),
                
                CreateProduct(31, 0, "Red Bull Powertrains", 50000000, ProductStatus.AVAILABLE, ProductCategory.POWERUNIT, "wwwroot/img/products/powerunits/RedBullPowertrains.png", 5, new DateTime(2022, 01, 01), "", ""),
                CreateProduct(32, 0, "Ferrari engines", 40000000, ProductStatus.AVAILABLE, ProductCategory.POWERUNIT, "wwwroot/img/products/powerunits/FerrariEngines.png", 5, new DateTime(2022, 01, 01), "", ""),
                CreateProduct(33, 15, "Mercedes engines", 35000000, ProductStatus.UNAVAILABLE, ProductCategory.POWERUNIT, "wwwroot/img/products/powerunits/MercedesEngines.png", 5, new DateTime(2022, 01, 01), "", ""),
                CreateProduct(34, 0, "Renault engines", 30000000, ProductStatus.AVAILABLE, ProductCategory.POWERUNIT, "wwwroot/img/products/powerunits/RenaultEngines.png", 5, new DateTime(2022, 01, 01), "", ""),
                
                CreateProduct(35, 0, "Jody Egginton", 600000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/JodyEgginton.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(36, 0, "Pierre Washe", 2000000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/PierreWashe.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(37, 10, "Enrico Cardile", 1500000, ProductStatus.PROMOTION, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/EnricoCardile.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(38, 0, "Simone Resta", 1000000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/SimoneResta.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(39, 0, "Matt Harman", 1000000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/MattHarman.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(40, 0, "Mike Elliott", 1000000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/MikeElliott.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(41, 10, "Ben Watkins", 800000, ProductStatus.PROMOTION, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/BenWatkins.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(42, 0, "Francois-Xavier Demaison", 750000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/FrancoisXavierDemaison.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(43, 0, "Jan Monchaux", 500000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/JanMonchaux.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(44, 0, "Andrew Green", 400000, ProductStatus.AVAILABLE, ProductCategory.TECHNICALCHIEF, "wwwroot/img/products/technicalchiefs/AndrewGreen.png", 5, new DateTime(1990, 01, 01), "", ""),

                CreateProduct(45, 0, "Ben Michell", 2000000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/BenMichell.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(46, 0, "Chris Cronin", 1500000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/ChrisCronin.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(47, 0, "Jorn Becker", 1000000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/JornBecker.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(48, 10, "Alex Chan", 1000000, ProductStatus.PROMOTION, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/AlexChan.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(49, 0, "Mattia Spini", 1000000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/MattiaSpini.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(50, 5, "Pierre Hamelin", 800000, ProductStatus.PROMOTION, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/PierreHamelin.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(51, 0, "Gary Gannon", 750000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/GaryGannon.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(52, 0, "Ed Regan", 600000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/EdRegan.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(53, 0, "Gaetan Jego", 500000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/GaetanJego.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(54, 0, "James Urwin", 400000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/JamesUrwin.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(55, 5, "Josh Pecket", 2000000, ProductStatus.PROMOTION, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/JoshPecket.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(56, 0, "Karel Loos", 1500000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/KarelLoos.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(57, 0, "Riccardo Musconi", 1000000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/RiccardoMusconi.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(58, 0, "Peter Bonnington", 1000000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/PeterBonnington.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(59, 0, "Gianpiero Lambiase", 1000000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/GianpieroLambiase.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(60, 0, "Hugh Bird", 800000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/HughBird.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(61, 0, "Jason Prior", 750000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/JasonPrior.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(62, 0, "Christopher Hayes", 600000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/CristopherHayes.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(63, 0, "Riccardo Adami", 500000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/RiccardoAdami.png", 5, new DateTime(1990, 01, 01), "", ""),
                CreateProduct(64, 0, "Xavier Marcos Pardos", 400000, ProductStatus.AVAILABLE, ProductCategory.RACEENGINEER, "wwwroot/img/products/raceengineers/XavierMarcosPardos.png", 5, new DateTime(1990, 01, 01), "", ""),
            };

            SeedProducts(builder, products);
            //SeedImage(products);
            #endregion
        }
    }
}
