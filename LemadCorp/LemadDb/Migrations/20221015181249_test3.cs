using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "526ebc52-2ce9-449a-ad13-3f5f559da1a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8ffcb24-0f14-4048-ad28-1e926e7bec07");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eff57c6-b1ca-43fa-9edc-a260d20738d1", "061cab27-dc78-444c-9fac-69d4c7905a58" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0eff57c6-b1ca-43fa-9edc-a260d20738d1", "f1fc8679-b84b-4325-ac18-7923f9cadb9f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eff57c6-b1ca-43fa-9edc-a260d20738d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "061cab27-dc78-444c-9fac-69d4c7905a58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1fc8679-b84b-4325-ac18-7923f9cadb9f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8824314a-7887-40b8-a0ef-70dda236b81a", "447d5f03-d2a5-47fd-aee3-8c8f492a8035", "Administrator", "ADMINISTRATOR" },
                    { "87711ec0-be0c-4ac8-88a5-aa0fd217ba2e", "934e5038-397d-4155-a7ea-646cc6c5e83c", "Seller", "SELLER" },
                    { "0ab1f408-4bc4-4ebe-bf26-6269413b3c71", "3c8e71da-44b5-47a1-aa07-465104a10a41", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e9990b08-1418-4a5e-a951-a7d4e86d1035", 0, "5d28fb5a-2fe3-4274-9e12-4f0f41df7442", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEPo+ubn9A3VbnMmu4UshqHJ5WRU7bXArcKVxuc9Q2NYy6s4AeNH+AfhxjOOmcG5Hmg==", null, false, null, "957a7dc8-67a8-4000-b89f-22fc2a167d20", false, "Admin" },
                    { "4e9ad9d8-cf74-4eaf-a2cd-159abdb0269f", 0, "c5efce19-980c-4ae3-b0f8-e4173106f7f1", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAENAzlJvKHYVnKIBpGwqyoG0rUt1yIkp0bzowu2RpiyyDjfj9bCrjSnsh6R8vxs0u3A==", null, false, null, "2a082b71-2b70-4092-9027-ed9b144fa46c", false, "Hugo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8824314a-7887-40b8-a0ef-70dda236b81a", "e9990b08-1418-4a5e-a951-a7d4e86d1035" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8824314a-7887-40b8-a0ef-70dda236b81a", "4e9ad9d8-cf74-4eaf-a2cd-159abdb0269f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ab1f408-4bc4-4ebe-bf26-6269413b3c71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87711ec0-be0c-4ac8-88a5-aa0fd217ba2e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8824314a-7887-40b8-a0ef-70dda236b81a", "4e9ad9d8-cf74-4eaf-a2cd-159abdb0269f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8824314a-7887-40b8-a0ef-70dda236b81a", "e9990b08-1418-4a5e-a951-a7d4e86d1035" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8824314a-7887-40b8-a0ef-70dda236b81a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e9ad9d8-cf74-4eaf-a2cd-159abdb0269f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9990b08-1418-4a5e-a951-a7d4e86d1035");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eff57c6-b1ca-43fa-9edc-a260d20738d1", "4c8cbc4e-a375-48bb-81ba-2b486de6d392", "Administrator", "ADMINISTRATOR" },
                    { "526ebc52-2ce9-449a-ad13-3f5f559da1a4", "f55c57a5-65ed-4dae-8a7d-6a0cd134490a", "Seller", "SELLER" },
                    { "d8ffcb24-0f14-4048-ad28-1e926e7bec07", "7b4148c8-2f6a-4c62-b794-613fcc5b46fb", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "061cab27-dc78-444c-9fac-69d4c7905a58", 0, "2523b38a-f2f6-403b-a13b-06a17dfd170f", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEIpIbtdBILq6e924SoXDX+i3745sbL9isGcRUB9UqMz/sffZzvIRpP24dNVhpmt7Jg==", null, false, null, "dbab7e01-cb17-41f8-864f-5108b1b35511", false, "admin@lemadrid.com" },
                    { "f1fc8679-b84b-4325-ac18-7923f9cadb9f", 0, "ece9ec71-d43a-4719-88a6-37c0ad2ebb04", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEA+gE4cXl1Q+zi93ePs6vTQW9qgLPqw7oMMHbGREJ2fJFt/ekDSj1EY5Y5r/ri3lfg==", null, false, null, "f3480039-a1b1-47f8-b08f-cd05970d1286", false, "hugolapointe@cegepsth.qc.ca" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0eff57c6-b1ca-43fa-9edc-a260d20738d1", "061cab27-dc78-444c-9fac-69d4c7905a58" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0eff57c6-b1ca-43fa-9edc-a260d20738d1", "f1fc8679-b84b-4325-ac18-7923f9cadb9f" });
        }
    }
}
