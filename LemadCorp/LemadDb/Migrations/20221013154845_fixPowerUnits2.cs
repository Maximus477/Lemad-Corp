using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class fixPowerUnits2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f298e95-36f3-4d5e-a420-2c5649b09c57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b16a3ee-1455-417d-9a9d-5f071ba9d811");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fff8ee2a-d0a6-4ff7-be71-ce33ecb7e265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fb57389-069e-4d0e-a777-77569ccf10ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0366c36-ca20-44ba-8395-2bcdffcb4bce");

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dafe99cc-bbaa-4626-83bf-6cd2c457e34a", "bd8ae457-9e62-418b-b2c7-148841565bad", "Administrator", "ADMINISTRATOR" },
                    { "247b9ec3-0857-4e1c-8eb9-d47d90671a68", "ab6dc999-6ddf-44ce-a72d-227817c4ee8c", "Seller", "SELLER" },
                    { "5cef8371-bb9a-4e93-b0c5-4cd2bb322231", "9a02d26c-c189-49e4-9824-e84d1fa9c3e3", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "929072db-8545-45d8-9262-03eb600d7af6", 0, "dec295b8-c623-407c-b471-5a1532956c2c", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEMY46YKCiwhnNoEU9/eQzlgfkaa9U8D+9P+nFyvM7NcsNZYi3oST3UYOaOghhAKNGw==", null, false, null, "4efaffbf-caa8-40d3-a70a-36b83bd8e265", false, null },
                    { "a8f5d026-9c1e-4e4b-8b3c-38527ca0cb93", 0, "87400d4b-69d6-4013-adcf-73c215421fa7", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEAOeWQlA0imWE6RMY67EsbqTMw3h5ItrrhVGKGGrVlcgteM2LYf4x4xmYNSbkCVV1w==", null, false, null, "4cb48ee7-f8e8-4a40-a041-6118392f0cdf", false, null }
                });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Red Bull Powertrains", 50000000m });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ferrari engines", 40000000m });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Mercedes engines", 35000000m });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Renault engines", 30000000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "247b9ec3-0857-4e1c-8eb9-d47d90671a68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cef8371-bb9a-4e93-b0c5-4cd2bb322231");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dafe99cc-bbaa-4626-83bf-6cd2c457e34a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "929072db-8545-45d8-9262-03eb600d7af6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8f5d026-9c1e-4e4b-8b3c-38527ca0cb93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f298e95-36f3-4d5e-a420-2c5649b09c57", "469b0b6b-9780-48cd-82c7-82537e19cf3e", "Administrator", "ADMINISTRATOR" },
                    { "fff8ee2a-d0a6-4ff7-be71-ce33ecb7e265", "3e974823-7aff-4fa9-931e-e15097651fc3", "Seller", "SELLER" },
                    { "9b16a3ee-1455-417d-9a9d-5f071ba9d811", "beed2d42-4175-4e86-a230-1006b1b349b4", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b0366c36-ca20-44ba-8395-2bcdffcb4bce", 0, "d703c129-8001-4e3b-b37f-76a5f5b357ed", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEMDj9pOl+gOuT0TC1qReEDOgQvp6/Ph1KilBgr/vzaji81KJ3x8+I0whfwzPkEzn7Q==", null, false, null, "39ee7466-53f2-4244-bd0b-97250a3b7484", false, null },
                    { "5fb57389-069e-4d0e-a777-77569ccf10ca", 0, "f043a50d-86d6-4fec-b21d-a5bf0f057527", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAELWjlGrg8cNtE2uwHydoeqU+0s2S8MOfEBOBOpDZp0aPewv2tHRjDXq7Gslb4Jg0zg==", null, false, null, "275b7875-7418-4563-a8ff-c7d3cd9a249a", false, null }
                });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { null, 3000000m });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { null, 1000000m });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { null, 1000000m });

            migrationBuilder.UpdateData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { null, 1000000m });

            migrationBuilder.InsertData(
                table: "powerUnits",
                columns: new[] { "Id", "Discount", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 5, (byte)0, null, 1000000m, 0 },
                    { 6, (byte)0, null, 2000000m, 0 },
                    { 7, (byte)0, null, 9100000m, 0 },
                    { 8, (byte)0, null, 10000000m, 0 },
                    { 9, (byte)0, null, 1000000m, 0 },
                    { 10, (byte)0, null, 1000000m, 0 }
                });
        }
    }
}
