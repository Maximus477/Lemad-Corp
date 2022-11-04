using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("d8cdff33-3bd1-42cc-b7a4-551039c68059"), "4c77fbe2-a7e9-45e6-a7f0-6796fb7db586" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "190acc73-f88e-47b7-a515-f365b39bc1bd" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "574f16f0-fb68-4379-8c50-2633d0cb8b36" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "dc5ebb49-f223-43d1-9322-339d64da0aef" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "e9b91107-126c-403c-8589-44dc7eb1fb1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0944670-849d-484f-af91-474a46dfab98", "190acc73-f88e-47b7-a515-f365b39bc1bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0944670-849d-484f-af91-474a46dfab98", "4c77fbe2-a7e9-45e6-a7f0-6796fb7db586" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0944670-849d-484f-af91-474a46dfab98", "574f16f0-fb68-4379-8c50-2633d0cb8b36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddc7ae36-28aa-4a4e-b366-b60166ac31f4", "92aa3178-9b13-4e4a-8a76-3b63fbded0d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0944670-849d-484f-af91-474a46dfab98", "dc5ebb49-f223-43d1-9322-339d64da0aef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0944670-849d-484f-af91-474a46dfab98", "e9b91107-126c-403c-8589-44dc7eb1fb1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc7ae36-28aa-4a4e-b366-b60166ac31f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0944670-849d-484f-af91-474a46dfab98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "190acc73-f88e-47b7-a515-f365b39bc1bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c77fbe2-a7e9-45e6-a7f0-6796fb7db586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574f16f0-fb68-4379-8c50-2633d0cb8b36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92aa3178-9b13-4e4a-8a76-3b63fbded0d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc5ebb49-f223-43d1-9322-339d64da0aef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b91107-126c-403c-8589-44dc7eb1fb1d");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("d8cdff33-3bd1-42cc-b7a4-551039c68059"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Command",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b3c1a3e7-a2a1-442c-b7db-e01e71e0a54c", "87869be3-febb-48df-83ef-b80ed652877a", "admin", "ADMIN" },
                    { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "6677c6d0-31ea-405a-a190-045f79cff502", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e85adc67-b50c-45cd-a63d-e6d897b0315f", 0, null, "3aadab63-5386-4449-bf9a-ab8f3d0601fb", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEOL8ntraI5Wg8XIo+1ADRW1yMomSaMva8a2bpTqWt2u3p9GOQk3Y50YEvycRVTF4YA==", null, false, "c781fd6e-3a91-46a1-a8a0-8a29ca71a6ad", false, "admin@lemadrid.com" },
                    { "53c4a6c9-4f5a-4944-a969-4e601508e2da", 0, "(450)-773-6800", "c6a98889-9d3f-4498-b31d-5700938cc051", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEJ3BJBrf1Mhkwf5tag4+9sibxGQAweHQF2Hdxi4evCoDNewAEMFUE1/mpBZqVNlaow==", null, false, "3d8c88d8-f31b-4edc-bf3b-e177c41aaf61", false, "hugo@lemadrid.com" },
                    { "8642d1dc-0329-49e9-a432-f4a2b40d6748", 0, "(450)-649-8594", "0297df0f-2c05-40c2-8bcd-904d8df2e9d2", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEC91HtJ/y7hA42+e6RILAVajLDnB6z8UQf4RY3SysVemwdmmVPCU1I57OaWOfSPmZg==", null, false, "7af5881e-b1aa-48c7-bffb-5bf3c4cf6ba2", false, "karl.mainville@lemadrid.com" },
                    { "e2ba496d-272a-4c57-9474-a8c59c9aaf48", 0, "(450)-538-3982", "f61f4211-035a-4888-a3c3-e42b6e13f80b", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEEIgMMVxGRCJVTeGFdpO1p5ZP3vd0aiPinQEPpMvNSfdfMNYYEDJac7wEjm0GlSQdA==", null, false, "c5d0fd65-698c-4ad9-9a1f-287738e319bc", false, "maxime.lefebvre@lemadrid.com" },
                    { "d6bb80b8-218d-4604-b8bf-1dc46b475a87", 0, "(450)-213-5697", "a07222a3-22a2-49a1-99e5-de66b10734ab", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEJPOmXB2OWeTIckBc4e6fyWcseU5C5M3UOn5ncsoe7+K6QLfbs9kIhAXe6bv4oCY5g==", null, false, "a9c96d53-e574-426f-b4e8-d714afca3659", false, "louis.garceau@lemadrid.com" },
                    { "644656ef-822c-45c1-bf92-24ba086ebc59", 0, "(450)-789-4673", "1e427d75-2bc7-42ea-aba3-cd942331aae7", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEDwr6475i+28Mb5Z0S/f8YYj421l8CXR2Hpjdqp8yUdQzl1qePMvTgBryH1EiWOI3Q==", null, false, "e0e8fe88-21eb-4cef-b1b6-1b74a57fa125", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("35bfa307-731a-4498-8576-b2075a454460"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "53c4a6c9-4f5a-4944-a969-4e601508e2da" },
                    { new Guid("35bfa307-731a-4498-8576-b2075a454460"), "8642d1dc-0329-49e9-a432-f4a2b40d6748" },
                    { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "e2ba496d-272a-4c57-9474-a8c59c9aaf48" },
                    { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "d6bb80b8-218d-4604-b8bf-1dc46b475a87" },
                    { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "644656ef-822c-45c1-bf92-24ba086ebc59" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b3c1a3e7-a2a1-442c-b7db-e01e71e0a54c", "e85adc67-b50c-45cd-a63d-e6d897b0315f" },
                    { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "53c4a6c9-4f5a-4944-a969-4e601508e2da" },
                    { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "8642d1dc-0329-49e9-a432-f4a2b40d6748" },
                    { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "e2ba496d-272a-4c57-9474-a8c59c9aaf48" },
                    { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "d6bb80b8-218d-4604-b8bf-1dc46b475a87" },
                    { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "644656ef-822c-45c1-bf92-24ba086ebc59" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("35bfa307-731a-4498-8576-b2075a454460"), "8642d1dc-0329-49e9-a432-f4a2b40d6748" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "53c4a6c9-4f5a-4944-a969-4e601508e2da" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "644656ef-822c-45c1-bf92-24ba086ebc59" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "d6bb80b8-218d-4604-b8bf-1dc46b475a87" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"), "e2ba496d-272a-4c57-9474-a8c59c9aaf48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "53c4a6c9-4f5a-4944-a969-4e601508e2da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "644656ef-822c-45c1-bf92-24ba086ebc59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "8642d1dc-0329-49e9-a432-f4a2b40d6748" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "d6bb80b8-218d-4604-b8bf-1dc46b475a87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c73c6ec-3349-4f89-85a0-6d1b725caecc", "e2ba496d-272a-4c57-9474-a8c59c9aaf48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3c1a3e7-a2a1-442c-b7db-e01e71e0a54c", "e85adc67-b50c-45cd-a63d-e6d897b0315f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c73c6ec-3349-4f89-85a0-6d1b725caecc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3c1a3e7-a2a1-442c-b7db-e01e71e0a54c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53c4a6c9-4f5a-4944-a969-4e601508e2da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "644656ef-822c-45c1-bf92-24ba086ebc59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8642d1dc-0329-49e9-a432-f4a2b40d6748");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6bb80b8-218d-4604-b8bf-1dc46b475a87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2ba496d-272a-4c57-9474-a8c59c9aaf48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e85adc67-b50c-45cd-a63d-e6d897b0315f");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("35bfa307-731a-4498-8576-b2075a454460"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("8fccf911-dde5-4ed3-b32c-ca9da6252622"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Command");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ddc7ae36-28aa-4a4e-b366-b60166ac31f4", "7ec82b18-912e-4851-9f39-d102d7f90d45", "admin", "ADMIN" },
                    { "e0944670-849d-484f-af91-474a46dfab98", "b455f971-9811-438e-82a8-e613dc368d37", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "92aa3178-9b13-4e4a-8a76-3b63fbded0d9", 0, null, "bdabf440-4bc9-44fe-92f3-0bc973f61110", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEN0n8uk+nYkGylId/MHJrHMXnatQF3qhKWI7lm7rbml2UJK27lkpVhsuOejSm00Diw==", null, false, "22829ccf-4b28-40ea-b5d2-53dc7b564b99", false, "admin@lemadrid.com" },
                    { "190acc73-f88e-47b7-a515-f365b39bc1bd", 0, "(450)-773-6800", "2c0465bc-3885-4ce6-a3d8-5e0492cd231b", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEDjqg2f6FxFvzmhSqhd9RahfIa3+0tnU/CknpI4t7bSSEhoKvL7hKpaE0hWVPLBUaQ==", null, false, "3774b588-4427-4e90-a513-a55cbf5e9a06", false, "hugo@lemadrid.com" },
                    { "4c77fbe2-a7e9-45e6-a7f0-6796fb7db586", 0, "(450)-649-8594", "c2be1b2e-930a-4afe-8fd5-5bde3ad8808a", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAENUOQQW1nRFQOyQn6keQ0l3ITxvKoLpj1rk46+YSH6Uxnp0uKsq40RGtk23qJPWB2A==", null, false, "fcec6256-0530-4d6b-8bdd-b4db28505639", false, "karl.mainville@lemadrid.com" },
                    { "e9b91107-126c-403c-8589-44dc7eb1fb1d", 0, "(450)-538-3982", "e9f60136-e887-4c2e-a45a-9bac28be1a62", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEFOfVW3pxqjxXXez0YYltGs6Txv4fkFKfyPwMpxeNHKPMOg6eQhKm3VG+Iq4nJq/Cw==", null, false, "a68f57d6-8977-4aee-bf20-16703364dd78", false, "maxime.lefebvre@lemadrid.com" },
                    { "dc5ebb49-f223-43d1-9322-339d64da0aef", 0, "(450)-213-5697", "a6560692-e067-4cec-83d6-57b6b35eccf1", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEL5ksg/1ypn6f1nsvtwkXd/eAs9USaMJLBpSXnTTFYFPPx8BMe4lY2lw1Qjv8WTGBA==", null, false, "036f559e-172c-4cab-9a70-c22ffcf0d5ac", false, "louis.garceau@lemadrid.com" },
                    { "574f16f0-fb68-4379-8c50-2633d0cb8b36", 0, "(450)-789-4673", "dae20f76-b500-443e-8a38-1d1c0998f3ea", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEFpiAAUGd0VRpWKugT3ACYbTLcuoKcHFBcoomtzKGOMTpntmMdbeJAxzhgJtZGjqTA==", null, false, "bf328fc8-fd5c-4249-93cf-a6aa1d2987e1", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("d8cdff33-3bd1-42cc-b7a4-551039c68059"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "190acc73-f88e-47b7-a515-f365b39bc1bd" },
                    { new Guid("d8cdff33-3bd1-42cc-b7a4-551039c68059"), "4c77fbe2-a7e9-45e6-a7f0-6796fb7db586" },
                    { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "e9b91107-126c-403c-8589-44dc7eb1fb1d" },
                    { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "dc5ebb49-f223-43d1-9322-339d64da0aef" },
                    { new Guid("ff06028f-96a2-4098-ae76-ebcfc5c7c601"), "574f16f0-fb68-4379-8c50-2633d0cb8b36" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ddc7ae36-28aa-4a4e-b366-b60166ac31f4", "92aa3178-9b13-4e4a-8a76-3b63fbded0d9" },
                    { "e0944670-849d-484f-af91-474a46dfab98", "190acc73-f88e-47b7-a515-f365b39bc1bd" },
                    { "e0944670-849d-484f-af91-474a46dfab98", "4c77fbe2-a7e9-45e6-a7f0-6796fb7db586" },
                    { "e0944670-849d-484f-af91-474a46dfab98", "e9b91107-126c-403c-8589-44dc7eb1fb1d" },
                    { "e0944670-849d-484f-af91-474a46dfab98", "dc5ebb49-f223-43d1-9322-339d64da0aef" },
                    { "e0944670-849d-484f-af91-474a46dfab98", "574f16f0-fb68-4379-8c50-2633d0cb8b36" }
                });
        }
    }
}
