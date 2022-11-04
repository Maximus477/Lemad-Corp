using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "509b57a1-3237-43df-9991-d249f5bc55ab" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "bde03042-809f-4d36-92df-3e1326b1efc9" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"), "919f85fd-1570-4094-97a9-c46b26a8936d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "509b57a1-3237-43df-9991-d249f5bc55ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c268261-3e08-45bb-8837-febaa8e8588b", "8b352816-b6b3-4ca9-b776-c340f26f2822" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "919f85fd-1570-4094-97a9-c46b26a8936d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "bde03042-809f-4d36-92df-3e1326b1efc9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c268261-3e08-45bb-8837-febaa8e8588b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509b57a1-3237-43df-9991-d249f5bc55ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67aa9680-d861-4bd3-bf7c-307ed12d6cf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b352816-b6b3-4ca9-b776-c340f26f2822");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "919f85fd-1570-4094-97a9-c46b26a8936d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bde03042-809f-4d36-92df-3e1326b1efc9");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CommandProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CommandProduct");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c268261-3e08-45bb-8837-febaa8e8588b", "fd813c03-4b5c-4e19-a10f-a61db8b7e5de", "admin", "ADMIN" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "e3f9fa8f-fce8-4d81-ac81-bcdd014a984b", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b352816-b6b3-4ca9-b776-c340f26f2822", 0, null, "622bfe96-b311-4bf8-8c78-4dd1dc91cc90", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEOV/v4+i8WiD8r7zjy8FZM/BctrZwq2GQWp0HiMVD9Ul3TNIYQhxlutnd2zbuBXIXA==", null, false, "ab39aab7-3a0e-4b93-8487-bebf53dba680", false, "admin@lemadrid.com" },
                    { "509b57a1-3237-43df-9991-d249f5bc55ab", 0, "(450)-773-6800", "91655652-6610-40e4-8e5d-ded0ea1af120", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEM2XM43xb5waieiKEBVdb/KHyAr18rrL1nxVxVKsR5qiL9rbHVXzBANL/rD4T42kdw==", null, false, "57fa00e9-143e-48ca-a6c7-db681c8723ed", false, "hugo@lemadrid.com" },
                    { "919f85fd-1570-4094-97a9-c46b26a8936d", 0, "(450)-649-8594", "76965fce-62bf-4714-add4-d53ddb69f553", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEJCxrXKLxWgr0i5Z2i7uKYl8W7w9goO0EaL1UT0ZJCZXaW83TWGYScpST102iyZpSw==", null, false, "49ffba74-b56d-4555-ad15-09c69cb141b2", false, "karl.mainville@lemadrid.com" },
                    { "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84", 0, "(450)-538-3982", "7cfc741d-746c-4a44-b04f-759bc967552d", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAED8AxBmy4g8o4KpCXMx3Unr8sWfTkDt+i1FwJtnXJdDTQCPzzEMUOla6++nVwX12JQ==", null, false, "80a97b0c-6dc1-4ab2-9ccc-2ead41bd4cf7", false, "maxime.lefebvre@lemadrid.com" },
                    { "bde03042-809f-4d36-92df-3e1326b1efc9", 0, "(450)-213-5697", "8c351df9-dd69-4c1c-bf37-a15b4780467c", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAENJluxqgXO8bPqLBf3bAvvx1YA46EWIF+K7sxvnAnX9AnjLepEnSZnQ6t/ipwM5gXQ==", null, false, "8e78ed78-92ca-4d73-8604-13c0f4044927", false, "louis.garceau@lemadrid.com" },
                    { "67aa9680-d861-4bd3-bf7c-307ed12d6cf3", 0, "(450)-789-4673", "21276e26-1c93-4b1b-b86e-00ecc815b770", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEB7LOaNL4f7iU0qCyo7rP5modiWzaNi0PW5RalUNoRMGdtVmsZF5qdCfxE4qtfwKLg==", null, false, "4c5a7a07-676c-435a-ba08-67a79c848a2b", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "509b57a1-3237-43df-9991-d249f5bc55ab" },
                    { new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"), "919f85fd-1570-4094-97a9-c46b26a8936d" },
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" },
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "bde03042-809f-4d36-92df-3e1326b1efc9" },
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c268261-3e08-45bb-8837-febaa8e8588b", "8b352816-b6b3-4ca9-b776-c340f26f2822" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "509b57a1-3237-43df-9991-d249f5bc55ab" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "919f85fd-1570-4094-97a9-c46b26a8936d" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "bde03042-809f-4d36-92df-3e1326b1efc9" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" }
                });
        }
    }
}
