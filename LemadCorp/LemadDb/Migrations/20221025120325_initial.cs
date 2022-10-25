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
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Commands_CartId",
                        column: x => x.CartId,
                        principalTable: "Commands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommandProduct",
                columns: table => new
                {
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandProduct", x => new { x.CartId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CommandProduct_Commands_CartId",
                        column: x => x.CartId,
                        principalTable: "Commands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommandProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
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
                table: "AddressUser",
                columns: new[] { "AddressId", "UserId", "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("92de359d-d08b-42b1-808e-435e5af4648e"), new Guid("2033cc3d-465a-4c6c-a651-4e4dd0d4a264"), null, null },
                    { new Guid("92de359d-d08b-42b1-808e-435e5af4648e"), new Guid("b2438eb6-f410-408f-81e2-d62003dccd55"), null, null },
                    { new Guid("92de359d-d08b-42b1-808e-435e5af4648e"), new Guid("8c6d074d-a125-452e-a29b-7dfbd7b18cf4"), null, null },
                    { new Guid("92de359d-d08b-42b1-808e-435e5af4648e"), new Guid("15f0e0a2-63a3-4568-b14d-8a869b9f4d97"), null, null },
                    { new Guid("01cb6092-9f0f-4d61-80f3-c579a010b7a5"), new Guid("9bae8c5b-fa89-444a-994f-1dab919969dd"), null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "340fe630-5cb3-4a79-83ea-6ec89dbbb521", "b1aa7f5f-b682-4410-8a6f-8b760dcd1cdd", "buyer", "BUYER" },
                    { "dcc0b994-612c-4db3-900e-b5c137ffac5e", "f265ecac-e8bb-4618-abe3-ffb1066b01f5", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartId", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "873ff4ae-1477-48c8-b304-740bf56aedff", 0, null, "(450)-773-6800", "c671342e-629e-480e-85e4-eb3057cd1f0d", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEHh7sKUx5kdYGkhHeZK75I6lBfp8prpdVHXjlbaiaOmDgK/p8TSo1tK/a6CbW4EzOA==", null, false, "f73eaaf9-3de1-4013-90c0-17b025a2548e", false, new Guid("2033cc3d-465a-4c6c-a651-4e4dd0d4a264"), "hugo@lemadrid.com" },
                    { "c6f9a1bc-6887-4199-b997-d5a8c0edf4ed", 0, null, "(450)-649-8594", "0e4af7d4-ab32-490f-8777-6000c579800e", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEF2LQfDfSdJBOKH+6WatJUIJ9hL0IXTtB+MNI/479NWkHcA+6fAKiSTkFPNVL2zVWA==", null, false, "0735f732-fa80-4128-905d-9657016e107a", false, new Guid("9bae8c5b-fa89-444a-994f-1dab919969dd"), "karl.mainville@lemadrid.com" },
                    { "9ab6f5b2-7336-4ee4-8798-a926ac0ce3ad", 0, null, "(450)-538-3982", "30a90723-1533-4b55-a0f1-86f5c43623a9", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEBKxEJqALdA9dGtzJbCDSc9KD6mMnFQIUGB/rtK8Y/bmYyoejXDTIldfzGkE0kDy1w==", null, false, "a231a858-597d-40b5-80d5-7923b0371fcb", false, new Guid("b2438eb6-f410-408f-81e2-d62003dccd55"), "maxime.lefebvre@lemadrid.com" },
                    { "bdaf8d3c-2e59-4a98-a456-5fb836837dc9", 0, null, "(450)-213-5697", "86332c71-e7de-41c6-b1d4-681dfffc3057", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEO4XyuBOcPcDa+R+UqM0aXvAuE4s4480U71YKdhBP+bPqk+/suE/kpM2fxU1paZWbg==", null, false, "94cc138f-f290-4598-b4d1-922d7470a700", false, new Guid("8c6d074d-a125-452e-a29b-7dfbd7b18cf4"), "louis.garceau@lemadrid.com" },
                    { "3a736dfc-9e91-4f24-b4d7-a094650686ba", 0, null, "(450)-789-4673", "34c3b59f-e374-41b9-aa93-a3ab5833740e", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEHCwQZ3ujKsY6rUu/7C8AzQqo48gYV7/Jwc7qE/pG7U670FZnQn+SrisumBbyZ9KoQ==", null, false, "d07c427c-d495-4175-ad04-bdc5f591ed41", false, new Guid("15f0e0a2-63a3-4568-b14d-8a869b9f4d97"), "laurent.brochu@lemadrid.com" },
                    { "2dbaee2c-b197-48b2-ad9a-56d682c70a50", 0, null, null, "818b7b38-ffb2-4724-beef-1280ebc49f29", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEDMuGfNETZ4m90TMriLAaqk60Q7MS/SlbJbBT4Sn0EszFMaaxDiuwozG0ptHVDCjeA==", null, false, "41b1f8f4-4fed-47ee-9b1a-030e48fc871f", false, new Guid("aea2b484-cddc-424c-856e-5dbde029d966"), "admin@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("01cb6092-9f0f-4d61-80f3-c579a010b7a5"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" },
                    { new Guid("92de359d-d08b-42b1-808e-435e5af4648e"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" }
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
                    { "dcc0b994-612c-4db3-900e-b5c137ffac5e", "2dbaee2c-b197-48b2-ad9a-56d682c70a50" },
                    { "340fe630-5cb3-4a79-83ea-6ec89dbbb521", "873ff4ae-1477-48c8-b304-740bf56aedff" },
                    { "340fe630-5cb3-4a79-83ea-6ec89dbbb521", "c6f9a1bc-6887-4199-b997-d5a8c0edf4ed" },
                    { "340fe630-5cb3-4a79-83ea-6ec89dbbb521", "9ab6f5b2-7336-4ee4-8798-a926ac0ce3ad" },
                    { "340fe630-5cb3-4a79-83ea-6ec89dbbb521", "bdaf8d3c-2e59-4a98-a456-5fb836837dc9" },
                    { "340fe630-5cb3-4a79-83ea-6ec89dbbb521", "3a736dfc-9e91-4f24-b4d7-a094650686ba" }
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
                name: "IX_AspNetUsers_CartId",
                table: "AspNetUsers",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CommandProduct_ProductsId",
                table: "CommandProduct",
                column: "ProductsId");
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
                name: "CommandProduct");

            migrationBuilder.DropTable(
                name: "CivicAddresses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
