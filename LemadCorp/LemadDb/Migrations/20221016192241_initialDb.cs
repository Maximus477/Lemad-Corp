using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntrepriseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    MaxContractTime = table.Column<int>(type: "int", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "105c01fb-267f-4437-a095-4e88170ba754", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "436d8f73-e129-4d07-ba19-c5cc19750c28", 0, "a1e86012-aab5-4de6-8d15-57c3a92b31a8", "hugo@lemadrid.com", false, "Cegep de Saint-Hyacinthe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEFporoJ0IoTMgzx5aIkLzhbTGS1phY3JlLJxJRU5tCGZ8unm3VpfOPrMZxAEbTpUsg==", null, false, null, "8d303eb3-00f2-4496-851c-2e1ab1dca588", false, "hugo@lemadrid.com" },
                    { "4f024328-1cd0-4d35-b95b-477189461eb3", 0, "45713f8b-0cf2-4dc3-b181-6a6d16a2e5d2", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEIKr5zTr7nOcHDChULgftNlPMwxpeRCCiDnesZEWJ8Cc5HLFLj2P1RtWuUV0XjjPgA==", null, false, null, "001c2192-3c47-4f07-b984-9d7b071fe7b3", false, "admin@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateNaissance", "Description", "Discount", "MaxContractTime", "Name", "Path", "Photo", "Price", "ProductCategory", "Quote", "Status" },
                values: new object[,]
                {
                    { 64, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Xavier Marcos Pardos", "wwwroot/img/products/raceengineers/XavierMarcosPardos.png", null, 400000m, 3, "", 0 },
                    { 36, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Pierre Washe", "wwwroot/img/products/technicalchiefs/PierreWashe.png", null, 2000000m, 4, "", 0 },
                    { 37, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Enrico Cardile", "wwwroot/img/products/technicalchiefs/EnricoCardile.png", null, 1500000m, 4, "", 0 },
                    { 38, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Simone Resta", "wwwroot/img/products/technicalchiefs/SimoneResta.png", null, 1000000m, 4, "", 0 },
                    { 39, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Matt Harman", "wwwroot/img/products/technicalchiefs/MattHarman.png", null, 1000000m, 4, "", 0 },
                    { 40, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mike Elliott", "wwwroot/img/products/technicalchiefs/MikeElliott.png", null, 1000000m, 4, "", 0 },
                    { 41, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ben Watkins", "wwwroot/img/products/technicalchiefs/BenWatkins.png", null, 800000m, 4, "", 0 },
                    { 42, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Francois-Xavier Demaison", "wwwroot/img/products/technicalchiefs/FrancoisXavierDemaison.png", null, 750000m, 4, "", 0 },
                    { 43, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jan Monchaux", "wwwroot/img/products/technicalchiefs/JanMonchaux.png", null, 500000m, 4, "", 0 },
                    { 44, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Andrew Green", "wwwroot/img/products/technicalchiefs/AndrewGreen.png", null, 400000m, 4, "", 0 },
                    { 45, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ben Michell", "wwwroot/img/products/raceengineers/BenMichell.png", null, 2000000m, 3, "", 0 },
                    { 46, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Chris Cronin", "wwwroot/img/products/raceengineers/ChrisCronin.png", null, 1500000m, 3, "", 0 },
                    { 47, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jorn Becker", "wwwroot/img/products/raceengineers/JornBecker.png", null, 1000000m, 3, "", 0 },
                    { 48, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Alex Chan", "wwwroot/img/products/raceengineers/AlexChan.png", null, 1000000m, 3, "", 0 },
                    { 49, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mattia Spini", "wwwroot/img/products/raceengineers/MattiaSpini.png", null, 1000000m, 3, "", 0 },
                    { 51, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gary Gannon", "wwwroot/img/products/raceengineers/GaryGannon.png", null, 750000m, 3, "", 0 },
                    { 52, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ed Regan", "wwwroot/img/products/raceengineers/EdRegan.png", null, 600000m, 3, "", 0 },
                    { 53, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gaetan Jego", "wwwroot/img/products/raceengineers/GaetanJego.png", null, 500000m, 3, "", 0 },
                    { 54, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "James Urwin", "wwwroot/img/products/raceengineers/JamesUrwin.png", null, 400000m, 3, "", 0 },
                    { 55, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Josh Pecket", "wwwroot/img/products/raceengineers/JoshPecket.png", null, 2000000m, 3, "", 0 },
                    { 56, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Karel Loos", "wwwroot/img/products/raceengineers/KarelLoos.png", null, 1500000m, 3, "", 0 },
                    { 57, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Riccardo Musconi", "wwwroot/img/products/raceengineers/RiccardoMusconi.png", null, 1000000m, 3, "", 0 },
                    { 58, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Peter Bonnington", "wwwroot/img/products/raceengineers/PeterBonnington.png", null, 1000000m, 3, "", 0 },
                    { 59, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gianpiero Lambiase", "wwwroot/img/products/raceengineers/GianpieroLambiase.png", null, 1000000m, 3, "", 0 },
                    { 60, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Hugh Bird", "wwwroot/img/products/raceengineers/HughBird.png", null, 800000m, 3, "", 0 },
                    { 61, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jason Prior", "wwwroot/img/products/raceengineers/JasonPrior.png", null, 750000m, 3, "", 0 },
                    { 62, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Christopher Hayes", "wwwroot/img/products/raceengineers/CristopherHayes.png", null, 600000m, 3, "", 0 },
                    { 63, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Riccardo Adami", "wwwroot/img/products/raceengineers/RiccardoAdami.png", null, 500000m, 3, "", 0 },
                    { 35, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jody Egginton", "wwwroot/img/products/technicalchiefs/JodyEgginton.png", null, 600000m, 4, "", 0 },
                    { 50, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Pierre Hamelin", "wwwroot/img/products/raceengineers/PierreHamelin.png", null, 800000m, 3, "", 0 },
                    { 34, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Renault engines", "wwwroot/img/products/powerunits/RenaultEngines.png", null, 30000000m, 2, "", 0 },
                    { 32, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ferrari engines", "wwwroot/img/products/powerunits/FerrariEngines.png", null, 40000000m, 2, "", 0 },
                    { 2, new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Esteban Ocon", "wwwroot/img/products/drivers/EstebanOcon.png", null, 5000000m, 0, "", 0 },
                    { 3, new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max", 0, 5, "Max Verstappen", "wwwroot/img/products/drivers/MaxVerstappen.png", null, 25000000m, 0, "Mistakes happen, and they happen to the best of us.", 0 },
                    { 4, new DateTime(1990, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Checo", 0, 5, "Sergio Perez", "wwwroot/img/products/drivers/SergioPerez.png", null, 8000000m, 0, "", 0 },
                    { 5, new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Charles Leclerc", "wwwroot/img/products/drivers/CharlesLeclerc.png", null, 12000000m, 0, "", 0 },
                    { 6, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Carlos Sainz", "wwwroot/img/products/drivers/CarlosSainz.png", null, 10000000m, 0, "", 0 },
                    { 7, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lewis Hamilton", "wwwroot/img/products/drivers/LewisHamilton.png", null, 40000000m, 0, "", 0 },
                    { 8, new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "George Russell", "wwwroot/img/products/drivers/GeorgeRussell.png", null, 5000000m, 0, "", 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateNaissance", "Description", "Discount", "MaxContractTime", "Name", "Path", "Photo", "Price", "ProductCategory", "Quote", "Status" },
                values: new object[,]
                {
                    { 9, new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lando Norris", "wwwroot/img/products/drivers/LandoNorris.png", null, 20000000m, 0, "", 0 },
                    { 10, new DateTime(1989, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Daniel Ricciardo", "wwwroot/img/products/drivers/DanielRicciardo.png", null, 15000000m, 0, "", 0 },
                    { 11, new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Valtteri Bottas", "wwwroot/img/products/drivers/ValtteriBottas.png", null, 10000000m, 0, "", 0 },
                    { 12, new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Zhou Guanyu", "wwwroot/img/products/drivers/ZhouGuanyu.png", null, 1000000m, 0, "", 0 },
                    { 13, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Pierre Gasly", "wwwroot/img/products/drivers/PierreGasly.png", null, 5000000m, 0, "", 0 },
                    { 14, new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Yuki Tsunoda", "wwwroot/img/products/drivers/YukiTsunoda.png", null, 750000m, 0, "", 0 },
                    { 15, new DateTime(1995, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Nicholas Latifi", "wwwroot/img/products/drivers/NicholasLatifi.png", null, 1000000m, 0, "", 0 },
                    { 33, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mercedes engines", "wwwroot/img/products/powerunits/MercedesEngines.png", null, 35000000m, 2, "", 0 },
                    { 16, new DateTime(1996, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Alexander Albon", "wwwroot/img/products/drivers/AlexanderAlbon.png", null, 2000000m, 0, "", 0 },
                    { 18, new DateTime(1998, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lance Stroll", "wwwroot/img/products/drivers/LanceStroll.png", null, 10000000m, 0, "", 0 },
                    { 19, new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Kevin Magnussen", "wwwroot/img/products/drivers/KevinMagnussen.png", null, 6000000m, 0, "", 0 },
                    { 20, new DateTime(1999, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mick Schumacher", "wwwroot/img/products/drivers/MickSchumacher.png", null, 1000000m, 0, "", 0 },
                    { 21, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mattia Binotto", "wwwroot/img/products/principals/MattiaBinotto.png", null, 3000000m, 1, "", 0 },
                    { 22, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Frédéric Vasseur", "wwwroot/img/products/principals/FredericVasseur.png", null, 1000000m, 1, "", 0 },
                    { 23, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Franz Tost", "wwwroot/img/products/principals/FranzTost.png", null, 1000000m, 1, "", 0 },
                    { 24, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Otmar Szafnauer", "wwwroot/img/products/principals/OtmarSzafnauer.png", null, 1000000m, 1, "", 0 },
                    { 25, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Guenther Steiner", "wwwroot/img/products/principals/GuentherSteiner.png", null, 1000000m, 1, "", 0 },
                    { 26, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Andreas Seidl", "wwwroot/img/products/principals/AndreasSeidl.png", null, 2000000m, 1, "", 0 },
                    { 27, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Toto Wolff", "wwwroot/img/products/principals/TotoWolff.png", null, 9100000m, 1, "", 0 },
                    { 28, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Christian Horner", "wwwroot/img/products/principals/ChristianHorner.png", null, 10000000m, 1, "", 0 },
                    { 29, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jost Capito", "wwwroot/img/products/principals/JostCapito.png", null, 1000000m, 1, "", 0 },
                    { 30, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mike Krack", "wwwroot/img/products/principals/MikeKrack.png", null, 1000000m, 1, "", 0 },
                    { 31, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Red Bull Powertrains", "wwwroot/img/products/powerunits/RedBullPowertrains.png", null, 50000000m, 2, "", 0 },
                    { 17, new DateTime(1987, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Sebastian Vettel", "wwwroot/img/products/drivers/SebastianVettel.png", null, 15000000m, 0, "", 0 },
                    { 1, new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teflonso, the spanish GOAT", 0, 5, "Fernando Alonso", "wwwroot/img/products/drivers/FernandoAlonso.png", null, 20000000m, 0, "I am one of the best to have raced in F1. I am probably not fastest in qualifying, or the wet, but I am 9.5 in all areas. I try to benefit from that.", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "4f024328-1cd0-4d35-b95b-477189461eb3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "436d8f73-e129-4d07-ba19-c5cc19750c28" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
