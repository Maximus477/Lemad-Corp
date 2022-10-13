using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class fixPowerUnits : Migration
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
                    { "be5fcc54-3b48-4940-a8e3-bcc1c92db559", "fd92b680-4ba9-4f0b-ac10-dab50fa5d994", "Administrator", "ADMINISTRATOR" },
                    { "5352daf2-bdcd-4dee-acdb-38072239ff10", "c775d7e2-a1c9-4f1c-a07f-30bdb77b6878", "Seller", "SELLER" },
                    { "782b9ded-9e21-4950-90dd-ce2851e77f59", "cebd35ed-b865-4aac-b470-17e74edd9e85", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b8aa33b7-9965-436e-8de1-21160760f8b1", 0, "3b9b1e40-7acc-4ebc-a37c-ba1715d20d6e", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEKAgbZqVpSuY/48Jfr2MiMEv708uWUBqrgQXppwf+i8rrkEvJ8miX4qHv/U4S60mUA==", null, false, null, "7425c2ec-c2a0-4763-a762-ff23097097ac", false, null },
                    { "d706a1b1-c040-4af7-aeef-fff420bd6334", 0, "72441a7d-430a-4696-9434-cfdf723f0c0a", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEAzsxTamfufEkUdrl3HF95TY7mYAEyuFTqog3QSW2tt0whSf+DGJWTrUpDZLxTuyEQ==", null, false, null, "67b40faa-191d-46a5-9bd9-153ef4e90912", false, null }
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
                keyValue: "5352daf2-bdcd-4dee-acdb-38072239ff10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "782b9ded-9e21-4950-90dd-ce2851e77f59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be5fcc54-3b48-4940-a8e3-bcc1c92db559");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8aa33b7-9965-436e-8de1-21160760f8b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d706a1b1-c040-4af7-aeef-fff420bd6334");

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
