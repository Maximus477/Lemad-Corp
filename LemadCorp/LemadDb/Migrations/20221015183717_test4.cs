using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d409de83-e50b-4b9c-bff9-e58b8776c9e8", "59261265-dc42-4cb8-b1a0-784aa1bc8f64", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "578f6a4b-72dc-49db-9411-9970b61542be", 0, "fc70cf0b-2233-4a7b-b24f-97ebd84b792f", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAELddTVprP1TS4WPzjlQXzvibTAA8dOYS7tQVyk4mi6/3hjbsqrm4hqzK75N6xiafWA==", null, false, null, "65bd21cd-eccf-4237-b8a6-3601bbf273e5", false, "admin@lemadrid.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d409de83-e50b-4b9c-bff9-e58b8776c9e8", "578f6a4b-72dc-49db-9411-9970b61542be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d409de83-e50b-4b9c-bff9-e58b8776c9e8", "578f6a4b-72dc-49db-9411-9970b61542be" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d409de83-e50b-4b9c-bff9-e58b8776c9e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "578f6a4b-72dc-49db-9411-9970b61542be");

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
    }
}
