using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class changingImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a56be8e-a4fb-4115-9ad8-e17330b0dda9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c44280a-93f6-448c-ba1d-e685ba27aba8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdd27f4a-faf0-44aa-ba25-f2454b710067");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a75b70c-211d-43b9-a92f-3c139281063f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1ff2d05-6cd5-4579-8c08-1fb9109e64d5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64d1d90d-9820-4d6b-9110-26a0c35fdd71", "bd61749d-4fe5-4213-ac8e-e763d332dca2", "Administrator", "ADMINISTRATOR" },
                    { "96b214d9-4ee1-4cdc-9066-29e4aa48e9e0", "b3951ed5-5cc3-4c4b-af92-8c5aac876d88", "Seller", "SELLER" },
                    { "d4138158-38db-40c8-8c74-a037f60e13d3", "c2f19018-e03e-47dd-bb9c-9efaa0c631c6", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "54f89d66-c27d-481a-871b-e625bb7004c3", 0, "48fbf87e-24b2-44cb-b1cf-e993e270d9b8", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEIrHiHE0WO2oS837IiR1S1vkmKgpzYSm24DeQy1FR3rQsPCjTQUn+Gyu2yZU8BCucQ==", null, false, null, "f60abdac-c7b8-4670-b3f6-c4a1e8e62021", false, null },
                    { "a1df3912-e80d-4ee4-98b9-98671a8cd195", 0, "9606352a-e573-4bd1-a6e9-8d8daf24db73", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEC/CZXs1KFriapz4qoukSJla7aYD74yM2jlt71dwhkupkXiG+/0W/4BBW2sMtX5YAA==", null, false, null, "ee204d8d-998d-4b85-8b53-0c59386cb7c0", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Mattia Binotto", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\MattiaBinotto.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\OtmarSzafnauer.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64d1d90d-9820-4d6b-9110-26a0c35fdd71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b214d9-4ee1-4cdc-9066-29e4aa48e9e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4138158-38db-40c8-8c74-a037f60e13d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54f89d66-c27d-481a-871b-e625bb7004c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1df3912-e80d-4ee4-98b9-98671a8cd195");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c44280a-93f6-448c-ba1d-e685ba27aba8", "e1dbce6c-84bf-4d8b-bb72-35f3079f7261", "Administrator", "ADMINISTRATOR" },
                    { "bdd27f4a-faf0-44aa-ba25-f2454b710067", "f1846015-bcc5-4234-a951-d6e773a9542f", "Seller", "SELLER" },
                    { "5a56be8e-a4fb-4115-9ad8-e17330b0dda9", "3df6237d-b853-4c67-947e-fdd885772eee", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f1ff2d05-6cd5-4579-8c08-1fb9109e64d5", 0, "36174e56-97ff-4867-8266-c329b70d1bfc", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEHyljnpOHEex1LJ3PpFjJaeQyFzoKwz9JDbQJnXNyWhhHWSdD5hemnOhKk34ekgu9A==", null, false, null, "14abbce2-c89e-42fe-8f65-0de310e94857", false, null },
                    { "6a75b70c-211d-43b9-a92f-3c139281063f", 0, "8ff8b2c3-9d38-4285-b5f3-a3289c2b4c81", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEMIGuKvMQkV9HlOsVYOtXRrHmBdXLp0LyzKHTJnCOD0cDCJQotCpvM/bFwpK7zrk7w==", null, false, null, "958b0e6e-5eef-448e-ad38-cf83ae38d14c", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Mattias Binotto", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\MattiasBinotto.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\OtmatSzafnauer.png");
        }
    }
}
