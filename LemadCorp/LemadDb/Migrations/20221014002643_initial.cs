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
                    Discount = table.Column<byte>(type: "tinyint", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                values: new object[,]
                {
                    { "f94aa649-5fe4-4b90-ad6c-ec38e49a1998", "81111bed-2dfe-454d-b26a-8abc43404c6f", "Buyer", "BUYER" },
                    { "28a65325-1753-4846-bcfa-6d9a9cc87c85", "56df0cac-7713-4b52-ad0f-21d183a5ec6f", "Seller", "SELLER" },
                    { "2cf308e5-2064-4591-969d-977f7add0f34", "295f6406-dcf5-437a-9ae7-e86057ba04cf", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f2a2d25e-ebef-4f38-9eb5-16ece6575dcd", 0, "c686bf92-0270-4f86-94e1-f9cdf200c487", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEA4Bk5j9iSvz6e1WuxtrNH2DuffIomozOsvgvWMqs0B3jVKEsb14RDrQTfPJw1WY6A==", null, false, null, "da27d61e-e199-4a09-8935-413cc5612466", false, null },
                    { "8081537e-9cdb-49c6-a2d8-6830d16d3b4a", 0, "e9a039f4-94e5-4790-b04d-3e4d47bcf28e", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEJDewDVlVCQg/slCy8wUIqhrNiFO4pdeZaq11uwHLVtTlGN7fSdgYO+ZfEwS6D6Qsg==", null, false, null, "c67efd2f-04d5-4032-91c9-d731668d1c3b", false, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discount", "Name", "Photo", "Price", "ProductCategory", "Status" },
                values: new object[,]
                {
                    { 37, (byte)0, "Enrico Cardile", null, 1500000m, 4, 0 },
                    { 38, (byte)0, "Simone Resta", null, 1000000m, 4, 0 },
                    { 39, (byte)0, "Matt Harman", null, 1000000m, 4, 0 },
                    { 40, (byte)0, "Mike Elliott", null, 1000000m, 4, 0 },
                    { 41, (byte)0, "Ben Watkins", null, 800000m, 4, 0 },
                    { 42, (byte)0, "Francois-Xavier Demaison", null, 750000m, 4, 0 },
                    { 43, (byte)0, "Jan Monchaux", null, 500000m, 4, 0 },
                    { 44, (byte)0, "Andrew Green", null, 400000m, 4, 0 },
                    { 45, (byte)0, "Ben Michell", null, 2000000m, 3, 0 },
                    { 46, (byte)0, "Chris Cronin", null, 1500000m, 3, 0 },
                    { 47, (byte)0, "Jorn Becker", null, 1000000m, 3, 0 },
                    { 48, (byte)0, "Alex Chan", null, 1000000m, 3, 0 },
                    { 49, (byte)0, "Mattia Spini", null, 1000000m, 3, 0 },
                    { 51, (byte)0, "Gary Gannon", null, 750000m, 3, 0 },
                    { 36, (byte)0, "Pierre Wache", null, 2000000m, 4, 0 },
                    { 53, (byte)0, "Gaetan Jego", null, 500000m, 3, 0 },
                    { 54, (byte)0, "James Urwin", null, 400000m, 3, 0 },
                    { 55, (byte)0, "Josh Peckett", null, 2000000m, 3, 0 },
                    { 56, (byte)0, "Karel Loos", null, 1500000m, 3, 0 },
                    { 57, (byte)0, "Riccardo Musconi", null, 1000000m, 3, 0 },
                    { 58, (byte)0, "Peter Bonnington", null, 1000000m, 3, 0 },
                    { 59, (byte)0, "Gianpiero Lambiase", null, 1000000m, 3, 0 },
                    { 60, (byte)0, "Hugh Bird", null, 800000m, 3, 0 },
                    { 61, (byte)0, "Jason Prior", null, 750000m, 3, 0 },
                    { 62, (byte)0, "Christopher Hayes", null, 600000m, 3, 0 },
                    { 63, (byte)0, "Riccardo Adami", null, 500000m, 3, 0 },
                    { 64, (byte)0, "Xavier Marcos Padros", null, 400000m, 3, 0 },
                    { 50, (byte)0, "Pierre Hamelin", null, 800000m, 3, 0 },
                    { 52, (byte)0, "Ed Regan", null, 600000m, 3, 0 },
                    { 35, (byte)0, "Jody Egginton", null, 600000m, 4, 0 },
                    { 33, (byte)0, "Mercedes engines", null, 35000000m, 2, 0 },
                    { 2, (byte)0, "Esteban Ocon", null, 5000000m, 0, 0 },
                    { 3, (byte)0, "Max Verstappen", null, 25000000m, 0, 0 },
                    { 4, (byte)0, "Sergio Perez", null, 8000000m, 0, 0 },
                    { 5, (byte)0, "Charles Leclerc", null, 12000000m, 0, 0 },
                    { 6, (byte)0, "Carlos Sainz", null, 10000000m, 0, 0 },
                    { 7, (byte)0, "Lewis Hamilton", null, 40000000m, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Discount", "Name", "Photo", "Price", "ProductCategory", "Status" },
                values: new object[,]
                {
                    { 8, (byte)0, "George Russell", null, 5000000m, 0, 0 },
                    { 9, (byte)0, "Lando Norris", null, 20000000m, 0, 0 },
                    { 10, (byte)0, "Daniel Ricciardo", null, 15000000m, 0, 0 },
                    { 11, (byte)0, "Valtteri Bottas", null, 10000000m, 0, 0 },
                    { 12, (byte)0, "Zhou Guanyu", null, 1000000m, 0, 0 },
                    { 13, (byte)0, "Pierre Gasly", null, 5000000m, 0, 0 },
                    { 14, (byte)0, "Yuki Tsunoda", null, 750000m, 0, 0 },
                    { 15, (byte)0, "Nicholas Latifi", null, 1000000m, 0, 0 },
                    { 16, (byte)0, "Alexander Albon", null, 2000000m, 0, 0 },
                    { 17, (byte)0, "Sebastian Vettel", null, 15000000m, 0, 0 },
                    { 18, (byte)0, "Lance Stroll", null, 10000000m, 0, 0 },
                    { 32, (byte)0, "Ferrari engines", null, 40000000m, 2, 0 },
                    { 31, (byte)0, "Red Bull Powertrains", null, 50000000m, 2, 0 },
                    { 30, (byte)0, "Mike Krack", null, 1000000m, 1, 0 },
                    { 29, (byte)0, "Jost Capito", null, 1000000m, 1, 0 },
                    { 28, (byte)0, "Christian Horner", null, 10000000m, 1, 0 },
                    { 27, (byte)0, "Toto Wolff", null, 9100000m, 1, 0 },
                    { 34, (byte)0, "Renault engines", null, 30000000m, 2, 0 },
                    { 26, (byte)0, "Andreas Seidl", null, 2000000m, 1, 0 },
                    { 24, (byte)0, "Otmar Szafnauer", null, 1000000m, 1, 0 },
                    { 23, (byte)0, "Franz Tost", null, 1000000m, 1, 0 },
                    { 22, (byte)0, "Frédéric Vasseur", null, 1000000m, 1, 0 },
                    { 21, (byte)0, "Mattias Binotto", null, 3000000m, 1, 0 },
                    { 20, (byte)0, "Mick Schumacher", null, 1000000m, 0, 0 },
                    { 19, (byte)0, "Kevin Magnussen", null, 6000000m, 0, 0 },
                    { 25, (byte)0, "Guenther Steiner", null, 1000000m, 1, 0 },
                    { 1, (byte)0, "Fernando Alonso", null, 20000000m, 0, 0 }
                });

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
