using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class deletingImageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32f6b7e2-8fc3-4307-95c3-04e0243bd67a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44927c9f-ffa9-44e7-9f0a-8b979fb77a53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d52851bf-29cf-43bc-a733-40ccc5245a96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "824a83d1-7db2-4366-91db-2d02d5889f80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af317338-bae7-47e2-9c09-17aed6300e17");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Products");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d52851bf-29cf-43bc-a733-40ccc5245a96", "14968af6-659b-4cf5-98ff-bfc7b00fe4cf", "Administrator", "ADMINISTRATOR" },
                    { "32f6b7e2-8fc3-4307-95c3-04e0243bd67a", "53c82cb7-b8a1-4d83-94fb-bf1f071cd7e5", "Seller", "SELLER" },
                    { "44927c9f-ffa9-44e7-9f0a-8b979fb77a53", "1de6ced0-8028-4620-a573-88154ff5c34c", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af317338-bae7-47e2-9c09-17aed6300e17", 0, "be1db757-1db3-43bd-978a-fa309384a86b", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEKa3sTH50gnz27PdsOSe8WkOR5J52oCIGytJLK3CKV4YJ65A8/TIKdyEMne5wTgSug==", null, false, null, "57a51b72-758f-465c-a261-ea24546b29e0", false, null },
                    { "824a83d1-7db2-4366-91db-2d02d5889f80", 0, "1d36c53a-86d1-4900-aa1a-ab0419ac4838", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEJ74v1cDDo2v+hLDFvZeMTCFIUizr517LY58zCN3HhXnCETofI33+16tPHKauOuUEw==", null, false, null, "66f5c95f-dd2a-4c66-bd8e-3bf93063dece", false, null }
                });
        }
    }
}
