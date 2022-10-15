using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817a64ed-6d50-44fc-94e3-3c5ae2ba0d35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9372738b-ddc2-42ec-973a-9e7418d5adc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc01bf31-3859-40ed-afad-873fcf92b62f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c343125-0805-4990-9ef9-51e4e496d0f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9674f9a6-540b-4407-b89e-3b1caa4beddc");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "9372738b-ddc2-42ec-973a-9e7418d5adc6", "2730f5ff-3128-48f6-bc8f-23e0401aadbc", "Administrator", "ADMINISTRATOR" },
                    { "dc01bf31-3859-40ed-afad-873fcf92b62f", "4325f2c0-b02a-49ea-8ac7-1b54aae8cb89", "Seller", "SELLER" },
                    { "817a64ed-6d50-44fc-94e3-3c5ae2ba0d35", "5269ebf3-9deb-4820-9dd3-e1d170837d93", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9674f9a6-540b-4407-b89e-3b1caa4beddc", 0, "4727afe3-7583-4b75-90a6-bc92fb69c987", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEEposWFVIn/aZNDkoBFP5NPPzF5Te0pV/qoi+yY3ocj+mnbeMtHUOJUGWqNaI3EQsQ==", null, false, null, "21849cf5-8793-4685-97c4-99ea1402c569", false, null },
                    { "2c343125-0805-4990-9ef9-51e4e496d0f3", 0, "3e84f1ca-0387-40aa-abef-b7862ecc1c38", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEJ7PORkVT9xt5ARHZKZouhlkrbhMrO96sVQ+JtdpYFEEKpcqgqL7yZeclo8/n/LLHA==", null, false, null, "1161b6d0-acb4-4c06-9a0f-e1d94c09ac46", false, null }
                });
        }
    }
}
