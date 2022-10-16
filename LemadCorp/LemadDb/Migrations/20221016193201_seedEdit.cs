using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class seedEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "436d8f73-e129-4d07-ba19-c5cc19750c28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "4f024328-1cd0-4d35-b95b-477189461eb3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2285b12c-0f2c-4921-8b08-d9e7be3014c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "436d8f73-e129-4d07-ba19-c5cc19750c28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f024328-1cd0-4d35-b95b-477189461eb3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "0c131837-032d-4d7b-8c6f-498c8b5a1872", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b106ed6-df3d-4b70-b8b7-e5f2cc860eff", 0, "3847bd63-8247-4932-bb72-d673b4deb367", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAENuh0NlcImiBxUKrZ5fNWJk1Y4oA11rgkfoXUKU/vEGwuYgA0AcKjLyHZ3mGkhchGg==", null, false, null, "d95680fe-47e7-4532-b3db-b10813ac020f", false, "admin@lemadrid.com" },
                    { "e82262e3-354b-44e5-8f79-f13b0ea1f92d", 0, "413fd30e-eec5-418b-bcbd-23135cf8fbf2", "hugo@lemadrid.com", false, "Cegep de Saint-Hyacinthe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEKRY57U3N8Y3Bq6GC1WRGCJghs7CezEyXRFB0nq8GsO9zEW1WoxGkmkMGbr31xcTnA==", null, false, null, "7b65c32e-ea64-4bb8-b241-d5259f216f88", false, "hugo@lemadrid.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Status",
                value: 4);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "2b106ed6-df3d-4b70-b8b7-e5f2cc860eff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "e82262e3-354b-44e5-8f79-f13b0ea1f92d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "2b106ed6-df3d-4b70-b8b7-e5f2cc860eff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "e82262e3-354b-44e5-8f79-f13b0ea1f92d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e043fdb6-7ca7-4c03-9443-903989a2b069");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b106ed6-df3d-4b70-b8b7-e5f2cc860eff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e82262e3-354b-44e5-8f79-f13b0ea1f92d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "105c01fb-267f-4437-a095-4e88170ba754", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f024328-1cd0-4d35-b95b-477189461eb3", 0, "45713f8b-0cf2-4dc3-b181-6a6d16a2e5d2", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEIKr5zTr7nOcHDChULgftNlPMwxpeRCCiDnesZEWJ8Cc5HLFLj2P1RtWuUV0XjjPgA==", null, false, null, "001c2192-3c47-4f07-b984-9d7b071fe7b3", false, "admin@lemadrid.com" },
                    { "436d8f73-e129-4d07-ba19-c5cc19750c28", 0, "a1e86012-aab5-4de6-8d15-57c3a92b31a8", "hugo@lemadrid.com", false, "Cegep de Saint-Hyacinthe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEFporoJ0IoTMgzx5aIkLzhbTGS1phY3JlLJxJRU5tCGZ8unm3VpfOPrMZxAEbTpUsg==", null, false, null, "8d303eb3-00f2-4496-851c-2e1ab1dca588", false, "hugo@lemadrid.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Status",
                value: 0);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "4f024328-1cd0-4d35-b95b-477189461eb3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2285b12c-0f2c-4921-8b08-d9e7be3014c7", "436d8f73-e129-4d07-ba19-c5cc19750c28" });
        }
    }
}
