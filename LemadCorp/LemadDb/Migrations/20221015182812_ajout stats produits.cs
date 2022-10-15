using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class ajoutstatsproduits : Migration
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DateNaissance",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxContractTime",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Quote",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9c9ee8d2-97f1-4ada-87e9-0c2c70b889e1", "29dc411d-9725-45f3-9e45-944b9c844619", "Administrator", "ADMINISTRATOR" },
                    { "71001d14-b72a-427c-9d8c-e3fe4197b009", "346b7076-91a3-4aca-b292-e617726f7bb5", "Seller", "SELLER" },
                    { "7187197c-9589-45f5-b580-0501dc4ebfdd", "6e524d52-0871-4854-98e9-d27e5a91fe51", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "74d07f54-5959-4a13-ad02-64ad3f88ab7c", 0, "2482bd98-33cd-42c2-b131-b6cb542d4354", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAELdKba1EVbJWBXmqtPhs9KXu2QxmRBW5TSkW3i2x962MmkmiU8Wkp9NNbHYFEbGmag==", null, false, null, "6c8679cb-4ef1-46db-9b9a-21f73a773cc7", false, null },
                    { "0c4bd994-8f87-4b43-840d-dabf2ddf6e0b", 0, "5ae5bf10-5f8f-48aa-a831-9ae4f4acf528", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEN2Nv7D9LEquRPXYSbyExleqZcAaj1bUwu/E2msyaJU264jIAxkuAhN5UjaUXKXuDw==", null, false, null, "df320024-9234-4ba3-b5aa-658d435816e6", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teflonso, the spanish GOAT", 5, "I am one of the best to have raced in F1. I am probably not fastest in qualifying, or the wet, but I am 9.5 in all areas. I try to benefit from that." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max", 5, "Mistakes happen, and they happen to the best of us." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Checo", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1994, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1989, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1989, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1999, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1996, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1995, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1996, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1987, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1998, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1999, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateNaissance", "Description", "MaxContractTime", "Quote" },
                values: new object[] { new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71001d14-b72a-427c-9d8c-e3fe4197b009");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7187197c-9589-45f5-b580-0501dc4ebfdd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c9ee8d2-97f1-4ada-87e9-0c2c70b889e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c4bd994-8f87-4b43-840d-dabf2ddf6e0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74d07f54-5959-4a13-ad02-64ad3f88ab7c");

            migrationBuilder.DropColumn(
                name: "DateNaissance",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MaxContractTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quote",
                table: "Products");

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
