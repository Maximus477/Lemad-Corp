using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class seedEdit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "49b9cc8e-cf6a-4920-8f70-ff117273992e", "8e330466-3c05-425a-a8f0-45bedb0cfb42", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c34626c0-52e1-45ae-8a94-8d3a1137c68a", 0, "4c030395-ca98-488e-86cf-14a92a125f93", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEFCgbiWgAeUQ+4MVwUxo19bl0WuBc+jn+7piGwFj4vZ1CoWgihnaFtKIvsFWrcWkwg==", null, false, null, "c1fa7b01-b96b-496f-a71d-f812a5ca576d", false, "admin@lemadrid.com" },
                    { "555242c9-e199-40d4-8dd5-f493fbfc1fa2", 0, "0a58feb2-22e1-4ee1-8953-79172c83094c", "hugo@lemadrid.com", false, "Cegep de Saint-Hyacinthe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAECONBkaMhw8+5yBaoYjWzw/UqNDAqJfzzqKn8M/rA+UHSLjv2NbzqqQQS+UK35SJ2A==", null, false, null, "21b06564-ca30-486e-8577-44b23a4027a2", false, "hugo@lemadrid.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 18, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 60, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 49, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 25, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 34, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 13, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 15, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "49b9cc8e-cf6a-4920-8f70-ff117273992e", "c34626c0-52e1-45ae-8a94-8d3a1137c68a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "49b9cc8e-cf6a-4920-8f70-ff117273992e", "555242c9-e199-40d4-8dd5-f493fbfc1fa2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49b9cc8e-cf6a-4920-8f70-ff117273992e", "555242c9-e199-40d4-8dd5-f493fbfc1fa2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49b9cc8e-cf6a-4920-8f70-ff117273992e", "c34626c0-52e1-45ae-8a94-8d3a1137c68a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49b9cc8e-cf6a-4920-8f70-ff117273992e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "555242c9-e199-40d4-8dd5-f493fbfc1fa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c34626c0-52e1-45ae-8a94-8d3a1137c68a");

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
                keyValue: 8,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Discount", "Status" },
                values: new object[] { 0, 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "2b106ed6-df3d-4b70-b8b7-e5f2cc860eff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e043fdb6-7ca7-4c03-9443-903989a2b069", "e82262e3-354b-44e5-8f79-f13b0ea1f92d" });
        }
    }
}
