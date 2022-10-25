using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class initial : Migration
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CivicAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CivicAddresses", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "AddressUser",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdresseCiviqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressUser", x => new { x.AddressId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AddressUser_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddressUser_CivicAddresses_AdresseCiviqueId",
                        column: x => x.AdresseCiviqueId,
                        principalTable: "CivicAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AddressId", "UserId", "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("dc86213f-5a3a-4c28-8b4e-615b4b140a48"), new Guid("f41e620d-639e-4cf2-a26d-302ead6302cd"), null, null },
                    { new Guid("dc86213f-5a3a-4c28-8b4e-615b4b140a48"), new Guid("55ee3b18-74e4-4df8-93ac-7ac3b3d06541"), null, null },
                    { new Guid("dc86213f-5a3a-4c28-8b4e-615b4b140a48"), new Guid("65071650-e1bc-4f43-b0aa-61ed1f02cc99"), null, null },
                    { new Guid("dc86213f-5a3a-4c28-8b4e-615b4b140a48"), new Guid("f6a8e6c5-09b0-4bd6-b2e2-f3c78128c8b9"), null, null },
                    { new Guid("d00c8c87-f445-41a5-9357-5b4f9d533b06"), new Guid("2d0dc227-dc5e-4e53-9085-179fa35922d8"), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b72a13a-2f6b-4b26-a763-546fde604388", "b0a39c25-3345-4f0a-a293-51a7442c3419", "buyer", "BUYER" },
                    { "ca4659fc-7144-49a2-a12e-8cf2bcec1144", "d326ab2c-f8eb-4d75-89a8-479b857f5878", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "821a5e58-895c-4ab7-b5a8-2725ab6fb71d", 0, "(450)-773-6800", "b182d94c-ecc9-4102-b166-5b62c75f21a8", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEEPr2lCIxaEk5OfhwEhZ636lw1B0+oH99fgM4Ac+X/UTuaPrWBkEKON7jmpFIF8/bQ==", null, false, "0036b18c-beb1-474c-9a4c-d3966f0c30f3", false, new Guid("f41e620d-639e-4cf2-a26d-302ead6302cd"), "hugo@lemadrid.com" },
                    { "b8bf980f-00d7-4e7e-970a-c011b930e1e0", 0, "(450)-649-8594", "321a9d8f-13b7-4924-ad9e-4223e98fb731", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEPOVOf5E2z8Stva/3FANNnV9r3rrJmxl8ejHwaQXmjIOZId8n6aagKcf35eJN7EQhA==", null, false, "4ddca9c2-935c-40b0-97cb-3c5ab07e2975", false, new Guid("2d0dc227-dc5e-4e53-9085-179fa35922d8"), "karl.mainville@lemadrid.com" },
                    { "528ae69c-c478-4441-b932-3dd54a12e014", 0, "(450)-538-3982", "eea6e1d9-8441-45f8-b569-8dd0ea9290c8", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEDkPF8haiJ0I45AObClXy0bn/5HizxI0Z+Ygt3D5/t+5QwIwUaOLRo6Y+GxFqaS4ZA==", null, false, "55840713-bff4-4eb7-8551-9ee935de76dc", false, new Guid("55ee3b18-74e4-4df8-93ac-7ac3b3d06541"), "maxime.lefebvre@lemadrid.com" },
                    { "e068c3dc-b139-479e-8cba-00d7f6d808f0", 0, "(450)-213-5697", "966a08c8-f1b9-443b-b3d9-c3b2bb9b6c77", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEOn6ttKjsiwYw68V0/OCi8dfAfgThv3XJzSmsVDONmBuZ7/PkgCX0HCuGaAF3UzKBw==", null, false, "adae878a-1392-4c3f-8a8f-74e1e19cdcf1", false, new Guid("65071650-e1bc-4f43-b0aa-61ed1f02cc99"), "louis.garceau@lemadrid.com" },
                    { "8562f120-9efb-4d43-9293-f26abd9a02b8", 0, "(450)-789-4673", "f54dcaa6-0e9a-40aa-a2c7-34478653b2e5", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEPLyq35RTnN8FO4ZcrXuKRu2B3d3BbcqkY7inpCk4CAOm4nP4WgEugNDpdtudVDwtA==", null, false, "cc2d10ee-d264-4b99-bd68-332d165eb147", false, new Guid("f6a8e6c5-09b0-4bd6-b2e2-f3c78128c8b9"), "laurent.brochu@lemadrid.com" },
                    { "700a7763-b88f-4501-b3ef-91cf55728ba9", 0, null, "693babff-9f8c-4d7e-93cf-c00b8436b57b", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAENsFIrQ/PXBelrL5rSE+dwFGI4sezws8LExAS5UTe9gnXCm+zYXJZ7sV6YUtA19Xfg==", null, false, "5b52bc6f-2bee-4d29-8c81-ffb45a4def99", false, new Guid("d73cd9fd-b661-46d8-8f1a-f09f25459c17"), "admin@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("d00c8c87-f445-41a5-9357-5b4f9d533b06"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" },
                    { new Guid("dc86213f-5a3a-4c28-8b4e-615b4b140a48"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateNaissance", "Description", "Discount", "MaxContractTime", "Name", "Path", "Photo", "Price", "ProductCategory", "Quote", "Status" },
                values: new object[,]
                {
                    { 50, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, 5, "Pierre Hamelin", "wwwroot/img/products/raceengineers/PierreHamelin.png", null, 800000m, 3, "", 4 },
                    { 49, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mattia Spini", "wwwroot/img/products/raceengineers/MattiaSpini.png", null, 1000000m, 3, "", 0 },
                    { 48, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Alex Chan", "wwwroot/img/products/raceengineers/AlexChan.png", null, 1000000m, 3, "", 4 },
                    { 47, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jorn Becker", "wwwroot/img/products/raceengineers/JornBecker.png", null, 1000000m, 3, "", 0 },
                    { 44, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Andrew Green", "wwwroot/img/products/technicalchiefs/AndrewGreen.png", null, 400000m, 4, "", 0 },
                    { 45, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ben Michell", "wwwroot/img/products/raceengineers/BenMichell.png", null, 2000000m, 3, "", 0 },
                    { 51, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gary Gannon", "wwwroot/img/products/raceengineers/GaryGannon.png", null, 750000m, 3, "", 0 },
                    { 43, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jan Monchaux", "wwwroot/img/products/technicalchiefs/JanMonchaux.png", null, 500000m, 4, "", 0 },
                    { 42, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Francois-Xavier Demaison", "wwwroot/img/products/technicalchiefs/FrancoisXavierDemaison.png", null, 750000m, 4, "", 0 },
                    { 46, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Chris Cronin", "wwwroot/img/products/raceengineers/ChrisCronin.png", null, 1500000m, 3, "", 0 },
                    { 52, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ed Regan", "wwwroot/img/products/raceengineers/EdRegan.png", null, 600000m, 3, "", 0 },
                    { 56, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Karel Loos", "wwwroot/img/products/raceengineers/KarelLoos.png", null, 1500000m, 3, "", 0 },
                    { 54, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "James Urwin", "wwwroot/img/products/raceengineers/JamesUrwin.png", null, 400000m, 3, "", 0 },
                    { 55, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, 5, "Josh Pecket", "wwwroot/img/products/raceengineers/JoshPecket.png", null, 2000000m, 3, "", 4 },
                    { 57, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Riccardo Musconi", "wwwroot/img/products/raceengineers/RiccardoMusconi.png", null, 1000000m, 3, "", 0 },
                    { 58, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Peter Bonnington", "wwwroot/img/products/raceengineers/PeterBonnington.png", null, 1000000m, 3, "", 0 },
                    { 41, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Ben Watkins", "wwwroot/img/products/technicalchiefs/BenWatkins.png", null, 800000m, 4, "", 4 },
                    { 60, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Hugh Bird", "wwwroot/img/products/raceengineers/HughBird.png", null, 800000m, 3, "", 0 },
                    { 61, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jason Prior", "wwwroot/img/products/raceengineers/JasonPrior.png", null, 750000m, 3, "", 0 },
                    { 62, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Christopher Hayes", "wwwroot/img/products/raceengineers/CristopherHayes.png", null, 600000m, 3, "", 0 },
                    { 63, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Riccardo Adami", "wwwroot/img/products/raceengineers/RiccardoAdami.png", null, 500000m, 3, "", 0 },
                    { 64, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Xavier Marcos Pardos", "wwwroot/img/products/raceengineers/XavierMarcosPardos.png", null, 400000m, 3, "", 0 },
                    { 53, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gaetan Jego", "wwwroot/img/products/raceengineers/GaetanJego.png", null, 500000m, 3, "", 0 },
                    { 59, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gianpiero Lambiase", "wwwroot/img/products/raceengineers/GianpieroLambiase.png", null, 1000000m, 3, "", 0 },
                    { 40, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mike Elliott", "wwwroot/img/products/technicalchiefs/MikeElliott.png", null, 1000000m, 4, "", 0 },
                    { 38, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Simone Resta", "wwwroot/img/products/technicalchiefs/SimoneResta.png", null, 1000000m, 4, "", 0 },
                    { 17, new DateTime(1987, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Sebastian Vettel", "wwwroot/img/products/drivers/SebastianVettel.png", null, 15000000m, 0, "", 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateNaissance", "Description", "Discount", "MaxContractTime", "Name", "Path", "Photo", "Price", "ProductCategory", "Quote", "Status" },
                values: new object[,]
                {
                    { 16, new DateTime(1996, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Alexander Albon", "wwwroot/img/products/drivers/AlexanderAlbon.png", null, 2000000m, 0, "", 0 },
                    { 15, new DateTime(1995, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 60, 5, "Nicholas Latifi", "wwwroot/img/products/drivers/NicholasLatifi.png", null, 1000000m, 0, "", 4 },
                    { 14, new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Yuki Tsunoda", "wwwroot/img/products/drivers/YukiTsunoda.png", null, 750000m, 0, "", 0 },
                    { 13, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 80, 5, "Pierre Gasly", "wwwroot/img/products/drivers/PierreGasly.png", null, 5000000m, 0, "", 4 },
                    { 12, new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Zhou Guanyu", "wwwroot/img/products/drivers/ZhouGuanyu.png", null, 1000000m, 0, "", 0 },
                    { 11, new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Valtteri Bottas", "wwwroot/img/products/drivers/ValtteriBottas.png", null, 10000000m, 0, "", 0 },
                    { 18, new DateTime(1998, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 49, 5, "Lance Stroll", "wwwroot/img/products/drivers/LanceStroll.png", null, 10000000m, 0, "", 4 },
                    { 10, new DateTime(1989, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Daniel Ricciardo", "wwwroot/img/products/drivers/DanielRicciardo.png", null, 15000000m, 0, "", 0 },
                    { 8, new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, 5, "George Russell", "wwwroot/img/products/drivers/GeorgeRussell.png", null, 5000000m, 0, "", 4 },
                    { 7, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lewis Hamilton", "wwwroot/img/products/drivers/LewisHamilton.png", null, 40000000m, 0, "", 0 },
                    { 6, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Carlos Sainz", "wwwroot/img/products/drivers/CarlosSainz.png", null, 10000000m, 0, "", 0 },
                    { 5, new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Charles Leclerc", "wwwroot/img/products/drivers/CharlesLeclerc.png", null, 12000000m, 0, "", 0 },
                    { 4, new DateTime(1990, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Checo", 0, 5, "Sergio Perez", "wwwroot/img/products/drivers/SergioPerez.png", null, 8000000m, 0, "", 0 },
                    { 3, new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max", 0, 5, "Max Verstappen", "wwwroot/img/products/drivers/MaxVerstappen.png", null, 25000000m, 0, "Mistakes happen, and they happen to the best of us.", 0 },
                    { 2, new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Esteban Ocon", "wwwroot/img/products/drivers/EstebanOcon.png", null, 5000000m, 0, "", 0 },
                    { 9, new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lando Norris", "wwwroot/img/products/drivers/LandoNorris.png", null, 20000000m, 0, "", 0 },
                    { 39, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Matt Harman", "wwwroot/img/products/technicalchiefs/MattHarman.png", null, 1000000m, 4, "", 0 },
                    { 19, new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22, 5, "Kevin Magnussen", "wwwroot/img/products/drivers/KevinMagnussen.png", null, 6000000m, 0, "", 2 },
                    { 21, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mattia Binotto", "wwwroot/img/products/principals/MattiaBinotto.png", null, 3000000m, 1, "", 0 },
                    { 37, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Enrico Cardile", "wwwroot/img/products/technicalchiefs/EnricoCardile.png", null, 1500000m, 4, "", 4 },
                    { 36, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Pierre Washe", "wwwroot/img/products/technicalchiefs/PierreWashe.png", null, 2000000m, 4, "", 0 },
                    { 35, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jody Egginton", "wwwroot/img/products/technicalchiefs/JodyEgginton.png", null, 600000m, 4, "", 0 },
                    { 34, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Renault engines", "wwwroot/img/products/powerunits/RenaultEngines.png", null, 30000000m, 2, "", 0 },
                    { 33, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 15, 5, "Mercedes engines", "wwwroot/img/products/powerunits/MercedesEngines.png", null, 35000000m, 2, "", 2 },
                    { 32, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ferrari engines", "wwwroot/img/products/powerunits/FerrariEngines.png", null, 40000000m, 2, "", 0 },
                    { 31, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Red Bull Powertrains", "wwwroot/img/products/powerunits/RedBullPowertrains.png", null, 50000000m, 2, "", 0 },
                    { 20, new DateTime(1999, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mick Schumacher", "wwwroot/img/products/drivers/MickSchumacher.png", null, 1000000m, 0, "", 0 },
                    { 30, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mike Krack", "wwwroot/img/products/principals/MikeKrack.png", null, 1000000m, 1, "", 0 },
                    { 28, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 13, 5, "Christian Horner", "wwwroot/img/products/principals/ChristianHorner.png", null, 10000000m, 1, "", 4 },
                    { 27, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Toto Wolff", "wwwroot/img/products/principals/TotoWolff.png", null, 9100000m, 1, "", 0 },
                    { 26, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Andreas Seidl", "wwwroot/img/products/principals/AndreasSeidl.png", null, 2000000m, 1, "", 0 },
                    { 25, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 34, 5, "Guenther Steiner", "wwwroot/img/products/principals/GuentherSteiner.png", null, 1000000m, 1, "", 4 },
                    { 24, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Otmar Szafnauer", "wwwroot/img/products/principals/OtmarSzafnauer.png", null, 1000000m, 1, "", 0 },
                    { 23, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 25, 5, "Franz Tost", "wwwroot/img/products/principals/FranzTost.png", null, 1000000m, 1, "", 1 },
                    { 22, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Frédéric Vasseur", "wwwroot/img/products/principals/FredericVasseur.png", null, 1000000m, 1, "", 2 },
                    { 29, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jost Capito", "wwwroot/img/products/principals/JostCapito.png", null, 1000000m, 1, "", 1 },
                    { 1, new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teflonso, the spanish GOAT", 0, 5, "Fernando Alonso", "wwwroot/img/products/drivers/FernandoAlonso.png", null, 20000000m, 0, "I am one of the best to have raced in F1. I am probably not fastest in qualifying, or the wet, but I am 9.5 in all areas. I try to benefit from that.", 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ca4659fc-7144-49a2-a12e-8cf2bcec1144", "700a7763-b88f-4501-b3ef-91cf55728ba9" },
                    { "4b72a13a-2f6b-4b26-a763-546fde604388", "821a5e58-895c-4ab7-b5a8-2725ab6fb71d" },
                    { "4b72a13a-2f6b-4b26-a763-546fde604388", "b8bf980f-00d7-4e7e-970a-c011b930e1e0" },
                    { "4b72a13a-2f6b-4b26-a763-546fde604388", "528ae69c-c478-4441-b932-3dd54a12e014" },
                    { "4b72a13a-2f6b-4b26-a763-546fde604388", "e068c3dc-b139-479e-8cba-00d7f6d808f0" },
                    { "4b72a13a-2f6b-4b26-a763-546fde604388", "8562f120-9efb-4d43-9293-f26abd9a02b8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressUser_AdresseCiviqueId",
                table: "AddressUser",
                column: "AdresseCiviqueId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressUser_ApplicationUserId",
                table: "AddressUser",
                column: "ApplicationUserId");

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
                name: "AddressUser");

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
                name: "CivicAddresses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
