using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test1000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "546594d0-2ad3-4e23-9db3-b97272553e01" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "770bfba9-df82-49a5-a1e6-0f89ec1c3589" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "7a7060a4-abab-410d-8b2e-0c2357703600" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "82ad0b65-3ccb-45e0-8816-0a1a7324860d" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("f1be8e7f-37f7-4e50-8524-714f09b12c33"), "e8c898f7-c67b-4667-9ed2-d4546e655da6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb241a30-14c3-4533-81ea-af17b5020664", "06cc62fd-8dbd-4353-ab57-8948a0002ddf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675c0900-f261-4a8a-95c8-667bbfdb008d", "546594d0-2ad3-4e23-9db3-b97272553e01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb241a30-14c3-4533-81ea-af17b5020664", "64a8d043-c099-4d23-a747-bcb63095d6dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675c0900-f261-4a8a-95c8-667bbfdb008d", "770bfba9-df82-49a5-a1e6-0f89ec1c3589" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675c0900-f261-4a8a-95c8-667bbfdb008d", "7a7060a4-abab-410d-8b2e-0c2357703600" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675c0900-f261-4a8a-95c8-667bbfdb008d", "82ad0b65-3ccb-45e0-8816-0a1a7324860d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675c0900-f261-4a8a-95c8-667bbfdb008d", "e8c898f7-c67b-4667-9ed2-d4546e655da6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "675c0900-f261-4a8a-95c8-667bbfdb008d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb241a30-14c3-4533-81ea-af17b5020664");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06cc62fd-8dbd-4353-ab57-8948a0002ddf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "546594d0-2ad3-4e23-9db3-b97272553e01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a8d043-c099-4d23-a747-bcb63095d6dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770bfba9-df82-49a5-a1e6-0f89ec1c3589");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a7060a4-abab-410d-8b2e-0c2357703600");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82ad0b65-3ccb-45e0-8816-0a1a7324860d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8c898f7-c67b-4667-9ed2-d4546e655da6");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("f1be8e7f-37f7-4e50-8524-714f09b12c33"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "049920ee-9d0e-41ad-9d31-69261b4ab75c", "b167ff67-0726-4ef1-9ddc-9c0747f0c930", "admin", "ADMIN" },
                    { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "49ab078a-6f1f-498b-a9a4-b58fea192c85", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "058ec686-0751-425e-9c6c-83d5e5437eea", 0, null, "8cb41a80-6541-4812-8e4b-af3307de4dac", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEDsKg7oEvU32zUvoT0YP6/7vZAWTDxQEXrpYS0KhOqvvmhfLyo9funjLIp+oBg18MA==", null, false, "2fd6e927-6544-40ce-b9a7-3624f7362cf6", false, "admin@lemadrid.com" },
                    { "5e10aa3b-3678-420a-8fe2-48c998f7467f", 0, null, "11469ab8-77e8-48d3-adc6-7de56af4157f", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEJP2VAtgSx81Keou+D9JC5Mz3Nu26mDADCFsr7x3Yt2FoBFhs1XEp/9jAwIwkO9w7Q==", null, false, "857c8179-8269-49ca-abec-c8e5c03f53e0", false, "guest@user.com" },
                    { "18612ff4-86d9-49d4-9ceb-31e602a06884", 0, "(450)-773-6800", "0a8d677f-97ca-4c3f-8239-a46b6a0bdbc1", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEE6Z+Zs9qkp5GLmAjlFfG+aN0KRaaGbH2KzOl/MBTpyEkuFAW9NRD16PDHMEWBDB8w==", null, false, "534f5bdd-59d2-4fe1-975d-24648a278515", false, "hugo@lemadrid.com" },
                    { "a8bbdf32-8f5a-405a-8c81-03a465665f13", 0, "(450)-649-8594", "b5731f52-f3d2-4f3c-91b8-80871d50c4f9", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEIDe6UnNLSvHSKFmJ51bgw1MVvMzT7n8ESYx9huyCLfZjPW3RKMUM4o/qWn9cdPD/A==", null, false, "f6fd81f3-9999-447b-bc22-4712d1233523", false, "karl.mainville@lemadrid.com" },
                    { "40b01ca6-c9f3-41e1-87e7-e0cc9cab181b", 0, "(450)-538-3982", "eeaf14a0-8500-46a2-bd29-cca5de63be31", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEPWtbjtd5YwGxwqwDMFXujyTsm0MKLbWnU8Br2Uep8W0uDzI3vhcYClN74DfIjDgwg==", null, false, "207b2869-98fe-4481-9e34-f8d4b5a668bd", false, "maxime.lefebvre@lemadrid.com" },
                    { "3f685cf1-fac3-4d5e-8d86-99dae4cba8bc", 0, "(450)-213-5697", "94792187-2f96-44cb-9c88-41313177df43", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAECTpPWkuodlmgY+XXceeFruBuigVdZNwTy1AJ+DeqOx4k3Ihy01U3H23c+ST58CnzA==", null, false, "b244ddba-f2c1-4750-876b-0ef6a73df8bf", false, "louis.garceau@lemadrid.com" },
                    { "e8774c2f-d3c9-47db-9091-a80d0852e4ca", 0, "(450)-789-4673", "73a5a17b-0e0b-46e9-8bca-bc075f6084b6", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEMgK0s/0xPapC8RraDmsMeS8EVIu6YIuvoCJOWngiyBDzIi+M4h+MDSEO9WeCHjfww==", null, false, "bbef3b93-4735-46ae-b408-c12f3f22c54b", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("581a06c3-b519-4f5f-8f38-fcd578d01131"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "18612ff4-86d9-49d4-9ceb-31e602a06884" },
                    { new Guid("581a06c3-b519-4f5f-8f38-fcd578d01131"), "a8bbdf32-8f5a-405a-8c81-03a465665f13" },
                    { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "40b01ca6-c9f3-41e1-87e7-e0cc9cab181b" },
                    { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "3f685cf1-fac3-4d5e-8d86-99dae4cba8bc" },
                    { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "e8774c2f-d3c9-47db-9091-a80d0852e4ca" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "049920ee-9d0e-41ad-9d31-69261b4ab75c", "058ec686-0751-425e-9c6c-83d5e5437eea" },
                    { "049920ee-9d0e-41ad-9d31-69261b4ab75c", "5e10aa3b-3678-420a-8fe2-48c998f7467f" },
                    { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "18612ff4-86d9-49d4-9ceb-31e602a06884" },
                    { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "a8bbdf32-8f5a-405a-8c81-03a465665f13" },
                    { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "40b01ca6-c9f3-41e1-87e7-e0cc9cab181b" },
                    { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "3f685cf1-fac3-4d5e-8d86-99dae4cba8bc" },
                    { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "e8774c2f-d3c9-47db-9091-a80d0852e4ca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("581a06c3-b519-4f5f-8f38-fcd578d01131"), "a8bbdf32-8f5a-405a-8c81-03a465665f13" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "18612ff4-86d9-49d4-9ceb-31e602a06884" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "3f685cf1-fac3-4d5e-8d86-99dae4cba8bc" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "40b01ca6-c9f3-41e1-87e7-e0cc9cab181b" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"), "e8774c2f-d3c9-47db-9091-a80d0852e4ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "049920ee-9d0e-41ad-9d31-69261b4ab75c", "058ec686-0751-425e-9c6c-83d5e5437eea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "18612ff4-86d9-49d4-9ceb-31e602a06884" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "3f685cf1-fac3-4d5e-8d86-99dae4cba8bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "40b01ca6-c9f3-41e1-87e7-e0cc9cab181b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "049920ee-9d0e-41ad-9d31-69261b4ab75c", "5e10aa3b-3678-420a-8fe2-48c998f7467f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "a8bbdf32-8f5a-405a-8c81-03a465665f13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93543e57-6d20-4a2d-a2bd-bdf621d43a67", "e8774c2f-d3c9-47db-9091-a80d0852e4ca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "049920ee-9d0e-41ad-9d31-69261b4ab75c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93543e57-6d20-4a2d-a2bd-bdf621d43a67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "058ec686-0751-425e-9c6c-83d5e5437eea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18612ff4-86d9-49d4-9ceb-31e602a06884");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f685cf1-fac3-4d5e-8d86-99dae4cba8bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40b01ca6-c9f3-41e1-87e7-e0cc9cab181b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e10aa3b-3678-420a-8fe2-48c998f7467f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8bbdf32-8f5a-405a-8c81-03a465665f13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8774c2f-d3c9-47db-9091-a80d0852e4ca");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("581a06c3-b519-4f5f-8f38-fcd578d01131"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("dfad5cc1-a3da-4d55-9598-e0dca0889096"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fb241a30-14c3-4533-81ea-af17b5020664", "ba19b4c5-4baa-456d-9972-4e5a4efbb12b", "admin", "ADMIN" },
                    { "675c0900-f261-4a8a-95c8-667bbfdb008d", "e4422a51-e9ff-4adb-834e-07ea4c4c8e4b", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06cc62fd-8dbd-4353-ab57-8948a0002ddf", 0, null, "7d035c04-4aca-48b0-8b50-7c8a70f6eefa", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAECuTS0ge4H4ey7w+GCav4Wn0Z2Zx0fHYGYH/cdBrT7kuHrLg1VYmyT1eYomScBRQRg==", null, false, "d3d752e8-5317-4c15-a8a3-4648a9b3beff", false, "admin@lemadrid.com" },
                    { "64a8d043-c099-4d23-a747-bcb63095d6dd", 0, null, "e5f35148-c189-4d17-aa27-d1fce02e6525", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAECISPQcWYxsfhp1CAnKa9CTWx9hltCw5m+r47iea23KcvymYRVoKpMHWiCRyKGt04w==", null, false, "6cb44d93-ef6d-43f9-91dc-a9ebebeaf327", false, "guest@user.com" },
                    { "770bfba9-df82-49a5-a1e6-0f89ec1c3589", 0, "(450)-773-6800", "942b1cba-8479-4333-aec6-c6e397239658", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEGXm/9F9QWUO7t8lIqc9yceIcDV0CcciAykRYbxBqj/lK4RV94cDAoBZ2U8INBii5A==", null, false, "bd9efe08-dc4d-4cf5-8ba8-694e5cd7a0c8", false, "hugo@lemadrid.com" },
                    { "e8c898f7-c67b-4667-9ed2-d4546e655da6", 0, "(450)-649-8594", "33fcb95f-179c-4ff2-94d1-365903347b0f", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEEtRVrRPwgpH+S+r3r/bsPR4G1GYGZ2YKDqXbs2ItBLCkvbGxgQ4w2bXhYOE6qmfCQ==", null, false, "aed95146-a5d9-461a-962d-915780a15424", false, "karl.mainville@lemadrid.com" },
                    { "546594d0-2ad3-4e23-9db3-b97272553e01", 0, "(450)-538-3982", "382c694f-bc97-4db1-891c-8bb6f6d45eb7", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEIFUadC8yLE4NSJPYL5AleNV93ZUg7ru3y4AJAI57d/uLRL4RQv0nk3kGY/Eas3L1Q==", null, false, "290358d1-7a0a-45b3-ad4c-4cce6cd61c23", false, "maxime.lefebvre@lemadrid.com" },
                    { "82ad0b65-3ccb-45e0-8816-0a1a7324860d", 0, "(450)-213-5697", "9885c131-1d12-42a8-8c87-507807364e4b", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAELgKNWjNIrnWex0Ya2hNGimG6McoC/OIaOsk3fVa0MMaAX7I/W7oP6yfM7Iuuh1Biw==", null, false, "29482467-a07c-47c3-b3ba-e317a39ffad8", false, "louis.garceau@lemadrid.com" },
                    { "7a7060a4-abab-410d-8b2e-0c2357703600", 0, "(450)-789-4673", "0ba04478-2945-496b-be1b-1d1b41fb7131", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEGdSMmvYmB/ya6tynzSJKQYUIJgiC3rl+t1W+DD1bldjmJA904kLIKz8kjqBPjLYcA==", null, false, "5eaa15e9-1f56-4b6b-86c8-1ea59b8bd14f", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("f1be8e7f-37f7-4e50-8524-714f09b12c33"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "770bfba9-df82-49a5-a1e6-0f89ec1c3589" },
                    { new Guid("f1be8e7f-37f7-4e50-8524-714f09b12c33"), "e8c898f7-c67b-4667-9ed2-d4546e655da6" },
                    { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "546594d0-2ad3-4e23-9db3-b97272553e01" },
                    { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "82ad0b65-3ccb-45e0-8816-0a1a7324860d" },
                    { new Guid("2dfb7675-eb8d-4e31-a0cc-06233f65e1d7"), "7a7060a4-abab-410d-8b2e-0c2357703600" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fb241a30-14c3-4533-81ea-af17b5020664", "06cc62fd-8dbd-4353-ab57-8948a0002ddf" },
                    { "fb241a30-14c3-4533-81ea-af17b5020664", "64a8d043-c099-4d23-a747-bcb63095d6dd" },
                    { "675c0900-f261-4a8a-95c8-667bbfdb008d", "770bfba9-df82-49a5-a1e6-0f89ec1c3589" },
                    { "675c0900-f261-4a8a-95c8-667bbfdb008d", "e8c898f7-c67b-4667-9ed2-d4546e655da6" },
                    { "675c0900-f261-4a8a-95c8-667bbfdb008d", "546594d0-2ad3-4e23-9db3-b97272553e01" },
                    { "675c0900-f261-4a8a-95c8-667bbfdb008d", "82ad0b65-3ccb-45e0-8816-0a1a7324860d" },
                    { "675c0900-f261-4a8a-95c8-667bbfdb008d", "7a7060a4-abab-410d-8b2e-0c2357703600" }
                });
        }
    }
}
