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
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalWithDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalWithTaxes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commands_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressUser",
                columns: table => new
                {
                    AdresseCiviqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressUser", x => new { x.AdresseCiviqueId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_AddressUser_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressUser_CivicAddresses_AdresseCiviqueId",
                        column: x => x.AdresseCiviqueId,
                        principalTable: "CivicAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommandProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CommandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommandProducts_Commands_CommandId",
                        column: x => x.CommandId,
                        principalTable: "Commands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CommandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Commands_CommandId",
                        column: x => x.CommandId,
                        principalTable: "Commands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9c49003f-9aff-4f90-b779-662ffe77b9ac", "ba5ba9ea-f35d-46b8-8147-58675685b5c0", "buyer", "BUYER" },
                    { "fb665bdf-efb5-4b7f-82e6-b871cb44d42e", "d0e27018-045c-48eb-9275-92f9fa0cda30", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "151db628-3e5e-4fa0-914e-502bc597cbde", 0, "(450)-213-5697", "5da3931f-9a75-4785-94d0-7c3ca5a139b5", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEA4WYon+O2HWg4lZAg9hZzBMeXjnFK4+Hb+iMWsVMTnviM7hIQQfUlQPgxIPSrvAEA==", null, false, "f149b434-0359-4dd8-aa0e-f13f57820209", false, "louis.garceau@lemadrid.com" },
                    { "cc061d43-8da4-443d-8241-0aad7aa20e5e", 0, "(450)-538-3982", "8ed22ec1-c0ca-40f8-946b-ae63afbe068a", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAELgKa6i8Wpmsc4xOvOoN2a8buyURc6lgtkOb4ILwgB4Z9/oXwYJn2GES9D1aeZ2/fw==", null, false, "8f8d60f6-5daa-4b48-aa45-b13aea839bb7", false, "maxime.lefebvre@lemadrid.com" },
                    { "e7242444-622e-4690-b7ca-90646f561c5f", 0, "(450)-649-8594", "17281af6-3013-4541-a472-c0b32416cf14", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEB3NpqsfyDItne6Myz+uvO3H0qmM1/DcHd2So14mjfEsEUW4xPDkyZMwoWWC9rYwgw==", null, false, "f1bb6d25-5eb1-4a2a-8a9a-37a3eda91ba5", false, "karl.mainville@lemadrid.com" },
                    { "3c774a3d-d71d-47b1-98eb-84e0ea1ab536", 0, "(450)-773-6800", "c01a6a1d-43af-4e9e-ba4c-51efb61c3c0c", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEAxjQHjBNIAWJFo5plInHvgQ+VjnKX7XGEPPVuH/NqEd5nSHGp/kXEI6dcN9AfURKA==", null, false, "02b6367c-d868-46fa-8ff9-d9eda7e0ac4a", false, "hugo@lemadrid.com" },
                    { "71a6ee33-7cae-4e8b-941e-077560dfb61a", 0, null, "83e2a8e4-1cdb-4a45-84c1-7cbe73c459a1", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEG3c2qCS30CfVJuvYj1fOf9Pz7KYwGmGNPRPsBOXAHX75J0teAlUvnldS5bGcTcQBQ==", null, false, "7520c132-f2a1-47ac-93bb-944fad1cf0e3", false, "admin@lemadrid.com" },
                    { "ed47034f-07e5-4ca5-9f38-233f2659c46a", 0, "(450)-789-4673", "b143d3fb-8708-484e-9659-42ab06a13c6d", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEFSf9uY9ZfVTjtj0UZ3Uc2FvsyeHAmv6uwMDMNiONKP3EUgJU7EK1P6Qfx1REg4+6g==", null, false, "5978e355-d844-4369-9148-94335a4817d3", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("3f8145b0-f1f8-4b1a-8f47-12af5a6bf03b"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" },
                    { new Guid("fc34c960-1cf6-482c-8567-0486e0696416"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CommandId", "DateNaissance", "Description", "Discount", "MaxContractTime", "Name", "Path", "Photo", "Price", "ProductCategory", "Quote", "Status" },
                values: new object[,]
                {
                    { 48, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Alex Chan", "wwwroot/img/products/raceengineers/AlexChan.png", null, 1000000m, 3, "", 4 },
                    { 47, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jorn Becker", "wwwroot/img/products/raceengineers/JornBecker.png", null, 1000000m, 3, "", 0 },
                    { 46, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Chris Cronin", "wwwroot/img/products/raceengineers/ChrisCronin.png", null, 1500000m, 3, "", 0 },
                    { 45, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ben Michell", "wwwroot/img/products/raceengineers/BenMichell.png", null, 2000000m, 3, "", 0 },
                    { 41, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Ben Watkins", "wwwroot/img/products/technicalchiefs/BenWatkins.png", null, 800000m, 4, "", 4 },
                    { 43, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jan Monchaux", "wwwroot/img/products/technicalchiefs/JanMonchaux.png", null, 500000m, 4, "", 0 },
                    { 42, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Francois-Xavier Demaison", "wwwroot/img/products/technicalchiefs/FrancoisXavierDemaison.png", null, 750000m, 4, "", 0 },
                    { 49, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mattia Spini", "wwwroot/img/products/raceengineers/MattiaSpini.png", null, 1000000m, 3, "", 0 },
                    { 40, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mike Elliott", "wwwroot/img/products/technicalchiefs/MikeElliott.png", null, 1000000m, 4, "", 0 },
                    { 39, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Matt Harman", "wwwroot/img/products/technicalchiefs/MattHarman.png", null, 1000000m, 4, "", 0 },
                    { 44, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Andrew Green", "wwwroot/img/products/technicalchiefs/AndrewGreen.png", null, 400000m, 4, "", 0 },
                    { 50, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, 5, "Pierre Hamelin", "wwwroot/img/products/raceengineers/PierreHamelin.png", null, 800000m, 3, "", 4 },
                    { 54, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "James Urwin", "wwwroot/img/products/raceengineers/JamesUrwin.png", null, 400000m, 3, "", 0 },
                    { 52, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ed Regan", "wwwroot/img/products/raceengineers/EdRegan.png", null, 600000m, 3, "", 0 },
                    { 53, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gaetan Jego", "wwwroot/img/products/raceengineers/GaetanJego.png", null, 500000m, 3, "", 0 },
                    { 38, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Simone Resta", "wwwroot/img/products/technicalchiefs/SimoneResta.png", null, 1000000m, 4, "", 0 },
                    { 56, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Karel Loos", "wwwroot/img/products/raceengineers/KarelLoos.png", null, 1500000m, 3, "", 0 },
                    { 57, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Riccardo Musconi", "wwwroot/img/products/raceengineers/RiccardoMusconi.png", null, 1000000m, 3, "", 0 },
                    { 58, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Peter Bonnington", "wwwroot/img/products/raceengineers/PeterBonnington.png", null, 1000000m, 3, "", 0 },
                    { 59, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gianpiero Lambiase", "wwwroot/img/products/raceengineers/GianpieroLambiase.png", null, 1000000m, 3, "", 0 },
                    { 60, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Hugh Bird", "wwwroot/img/products/raceengineers/HughBird.png", null, 800000m, 3, "", 0 },
                    { 61, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jason Prior", "wwwroot/img/products/raceengineers/JasonPrior.png", null, 750000m, 3, "", 0 },
                    { 62, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Christopher Hayes", "wwwroot/img/products/raceengineers/CristopherHayes.png", null, 600000m, 3, "", 0 },
                    { 63, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Riccardo Adami", "wwwroot/img/products/raceengineers/RiccardoAdami.png", null, 500000m, 3, "", 0 },
                    { 64, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Xavier Marcos Pardos", "wwwroot/img/products/raceengineers/XavierMarcosPardos.png", null, 400000m, 3, "", 0 },
                    { 51, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Gary Gannon", "wwwroot/img/products/raceengineers/GaryGannon.png", null, 750000m, 3, "", 0 },
                    { 55, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, 5, "Josh Pecket", "wwwroot/img/products/raceengineers/JoshPecket.png", null, 2000000m, 3, "", 4 },
                    { 37, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 10, 5, "Enrico Cardile", "wwwroot/img/products/technicalchiefs/EnricoCardile.png", null, 1500000m, 4, "", 4 },
                    { 35, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jody Egginton", "wwwroot/img/products/technicalchiefs/JodyEgginton.png", null, 600000m, 4, "", 0 },
                    { 15, null, new DateTime(1995, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 60, 5, "Nicholas Latifi", "wwwroot/img/products/drivers/NicholasLatifi.png", null, 1000000m, 0, "", 4 },
                    { 14, null, new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Yuki Tsunoda", "wwwroot/img/products/drivers/YukiTsunoda.png", null, 750000m, 0, "", 0 },
                    { 13, null, new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 80, 5, "Pierre Gasly", "wwwroot/img/products/drivers/PierreGasly.png", null, 5000000m, 0, "", 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CommandId", "DateNaissance", "Description", "Discount", "MaxContractTime", "Name", "Path", "Photo", "Price", "ProductCategory", "Quote", "Status" },
                values: new object[,]
                {
                    { 12, null, new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Zhou Guanyu", "wwwroot/img/products/drivers/ZhouGuanyu.png", null, 1000000m, 0, "", 0 },
                    { 11, null, new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Valtteri Bottas", "wwwroot/img/products/drivers/ValtteriBottas.png", null, 10000000m, 0, "", 0 },
                    { 10, null, new DateTime(1989, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Daniel Ricciardo", "wwwroot/img/products/drivers/DanielRicciardo.png", null, 15000000m, 0, "", 0 },
                    { 16, null, new DateTime(1996, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Alexander Albon", "wwwroot/img/products/drivers/AlexanderAlbon.png", null, 2000000m, 0, "", 0 },
                    { 9, null, new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lando Norris", "wwwroot/img/products/drivers/LandoNorris.png", null, 20000000m, 0, "", 0 },
                    { 7, null, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Lewis Hamilton", "wwwroot/img/products/drivers/LewisHamilton.png", null, 40000000m, 0, "", 0 },
                    { 6, null, new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Carlos Sainz", "wwwroot/img/products/drivers/CarlosSainz.png", null, 10000000m, 0, "", 0 },
                    { 5, null, new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Charles Leclerc", "wwwroot/img/products/drivers/CharlesLeclerc.png", null, 12000000m, 0, "", 0 },
                    { 4, null, new DateTime(1990, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Checo", 0, 5, "Sergio Perez", "wwwroot/img/products/drivers/SergioPerez.png", null, 8000000m, 0, "", 0 },
                    { 3, null, new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max", 0, 5, "Max Verstappen", "wwwroot/img/products/drivers/MaxVerstappen.png", null, 25000000m, 0, "Mistakes happen, and they happen to the best of us.", 0 },
                    { 2, null, new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Esteban Ocon", "wwwroot/img/products/drivers/EstebanOcon.png", null, 5000000m, 0, "", 0 },
                    { 8, null, new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, 5, "George Russell", "wwwroot/img/products/drivers/GeorgeRussell.png", null, 5000000m, 0, "", 4 },
                    { 17, null, new DateTime(1987, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Sebastian Vettel", "wwwroot/img/products/drivers/SebastianVettel.png", null, 15000000m, 0, "", 0 },
                    { 18, null, new DateTime(1998, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 49, 5, "Lance Stroll", "wwwroot/img/products/drivers/LanceStroll.png", null, 10000000m, 0, "", 4 },
                    { 19, null, new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22, 5, "Kevin Magnussen", "wwwroot/img/products/drivers/KevinMagnussen.png", null, 6000000m, 0, "", 2 },
                    { 34, null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Renault engines", "wwwroot/img/products/powerunits/RenaultEngines.png", null, 30000000m, 2, "", 0 },
                    { 33, null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 15, 5, "Mercedes engines", "wwwroot/img/products/powerunits/MercedesEngines.png", null, 35000000m, 2, "", 2 },
                    { 32, null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Ferrari engines", "wwwroot/img/products/powerunits/FerrariEngines.png", null, 40000000m, 2, "", 0 },
                    { 31, null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Red Bull Powertrains", "wwwroot/img/products/powerunits/RedBullPowertrains.png", null, 50000000m, 2, "", 0 },
                    { 30, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mike Krack", "wwwroot/img/products/principals/MikeKrack.png", null, 1000000m, 1, "", 0 },
                    { 29, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Jost Capito", "wwwroot/img/products/principals/JostCapito.png", null, 1000000m, 1, "", 1 },
                    { 28, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 13, 5, "Christian Horner", "wwwroot/img/products/principals/ChristianHorner.png", null, 10000000m, 1, "", 4 },
                    { 27, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Toto Wolff", "wwwroot/img/products/principals/TotoWolff.png", null, 9100000m, 1, "", 0 },
                    { 26, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Andreas Seidl", "wwwroot/img/products/principals/AndreasSeidl.png", null, 2000000m, 1, "", 0 },
                    { 25, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 34, 5, "Guenther Steiner", "wwwroot/img/products/principals/GuentherSteiner.png", null, 1000000m, 1, "", 4 },
                    { 24, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Otmar Szafnauer", "wwwroot/img/products/principals/OtmarSzafnauer.png", null, 1000000m, 1, "", 0 },
                    { 23, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 25, 5, "Franz Tost", "wwwroot/img/products/principals/FranzTost.png", null, 1000000m, 1, "", 1 },
                    { 22, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Frédéric Vasseur", "wwwroot/img/products/principals/FredericVasseur.png", null, 1000000m, 1, "", 2 },
                    { 21, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mattia Binotto", "wwwroot/img/products/principals/MattiaBinotto.png", null, 3000000m, 1, "", 0 },
                    { 20, null, new DateTime(1999, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Mick Schumacher", "wwwroot/img/products/drivers/MickSchumacher.png", null, 1000000m, 0, "", 0 },
                    { 36, null, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, 5, "Pierre Washe", "wwwroot/img/products/technicalchiefs/PierreWashe.png", null, 2000000m, 4, "", 0 },
                    { 1, null, new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teflonso, the spanish GOAT", 0, 5, "Fernando Alonso", "wwwroot/img/products/drivers/FernandoAlonso.png", null, 20000000m, 0, "I am one of the best to have raced in F1. I am probably not fastest in qualifying, or the wet, but I am 9.5 in all areas. I try to benefit from that.", 0 }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("fc34c960-1cf6-482c-8567-0486e0696416"), "3c774a3d-d71d-47b1-98eb-84e0ea1ab536" },
                    { new Guid("3f8145b0-f1f8-4b1a-8f47-12af5a6bf03b"), "e7242444-622e-4690-b7ca-90646f561c5f" },
                    { new Guid("fc34c960-1cf6-482c-8567-0486e0696416"), "cc061d43-8da4-443d-8241-0aad7aa20e5e" },
                    { new Guid("fc34c960-1cf6-482c-8567-0486e0696416"), "151db628-3e5e-4fa0-914e-502bc597cbde" },
                    { new Guid("fc34c960-1cf6-482c-8567-0486e0696416"), "ed47034f-07e5-4ca5-9f38-233f2659c46a" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fb665bdf-efb5-4b7f-82e6-b871cb44d42e", "71a6ee33-7cae-4e8b-941e-077560dfb61a" },
                    { "9c49003f-9aff-4f90-b779-662ffe77b9ac", "3c774a3d-d71d-47b1-98eb-84e0ea1ab536" },
                    { "9c49003f-9aff-4f90-b779-662ffe77b9ac", "e7242444-622e-4690-b7ca-90646f561c5f" },
                    { "9c49003f-9aff-4f90-b779-662ffe77b9ac", "cc061d43-8da4-443d-8241-0aad7aa20e5e" },
                    { "9c49003f-9aff-4f90-b779-662ffe77b9ac", "151db628-3e5e-4fa0-914e-502bc597cbde" },
                    { "9c49003f-9aff-4f90-b779-662ffe77b9ac", "ed47034f-07e5-4ca5-9f38-233f2659c46a" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CommandProducts_CommandId",
                table: "CommandProducts",
                column: "CommandId");

            migrationBuilder.CreateIndex(
                name: "IX_Commands_ApplicationUserId",
                table: "Commands",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CommandId",
                table: "Products",
                column: "CommandId");
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
                name: "CommandProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CivicAddresses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Commands");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
