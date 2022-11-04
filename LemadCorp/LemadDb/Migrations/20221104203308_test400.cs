using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test400 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2e7ad6e7-0bbd-4838-984f-dc6b678afa5b"), "7ddf313c-cb97-45bf-9863-f7902fab7980" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "8b3ccedf-a3bb-4e15-8180-0de8d0de7446" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "cc921d09-e071-4c32-b751-7ea8442d31d9" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "d1bfb2dc-27f2-4c93-a535-068a54bd6b4e" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "e31143a7-bbcc-44f1-9251-f6e5424636b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "7ddf313c-cb97-45bf-9863-f7902fab7980" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "863c918a-f890-48a2-b0ed-987d00869107", "81a33229-834f-4dec-89a1-e58a3ec58ed6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "8b3ccedf-a3bb-4e15-8180-0de8d0de7446" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "cc921d09-e071-4c32-b751-7ea8442d31d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "d1bfb2dc-27f2-4c93-a535-068a54bd6b4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "e31143a7-bbcc-44f1-9251-f6e5424636b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b04e44c-57f5-4751-88c4-a9c4596d4c02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "863c918a-f890-48a2-b0ed-987d00869107");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ddf313c-cb97-45bf-9863-f7902fab7980");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81a33229-834f-4dec-89a1-e58a3ec58ed6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b3ccedf-a3bb-4e15-8180-0de8d0de7446");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc921d09-e071-4c32-b751-7ea8442d31d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1bfb2dc-27f2-4c93-a535-068a54bd6b4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e31143a7-bbcc-44f1-9251-f6e5424636b9");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("2e7ad6e7-0bbd-4838-984f-dc6b678afa5b"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "863c918a-f890-48a2-b0ed-987d00869107", "16ec6a9a-df05-4a3e-b847-337a56cf2bda", "admin", "ADMIN" },
                    { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "9c42530b-606f-4d35-ba43-992ed9310286", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "81a33229-834f-4dec-89a1-e58a3ec58ed6", 0, null, "9c2d8422-dfd1-47bc-af95-60a8b908061a", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEBTuHSjYnFR25LMBGbfNv6XJ33AtFteXIx9NltHbNzLnri57LBRyTbpE8a73iG1fVQ==", null, false, "ab104ee3-bc70-48e7-8da3-65038827a18a", false, "admin@lemadrid.com" },
                    { "d1bfb2dc-27f2-4c93-a535-068a54bd6b4e", 0, "(450)-773-6800", "e745e971-0c6c-4619-aed9-a09682f756fb", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAENvRjfOkLj2q6F9eUrkq9G3yVig7RYhEu87KRbhyoUlTHJDgSy6shrVkblRkcDh7Gg==", null, false, "75963645-cf04-4c05-a3b7-ae85960e4afd", false, "hugo@lemadrid.com" },
                    { "7ddf313c-cb97-45bf-9863-f7902fab7980", 0, "(450)-649-8594", "757e036a-cff6-4b97-81a1-17f8f48bbc67", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEP/D98UnOzJ3MlcKbY/PFxO+QrD/JMOEzWZ5tYuZ1Px2GGRoXXk/8IyLCEM7zoNSLQ==", null, false, "8adac4d5-f112-4a81-b1cd-02d8791f9c0e", false, "karl.mainville@lemadrid.com" },
                    { "cc921d09-e071-4c32-b751-7ea8442d31d9", 0, "(450)-538-3982", "45567378-556f-41d7-88d5-d78e11f35cf0", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEP0IKNEF72JnJWzu/t3VWo7U9ei507Q+K2O56stHKSD7fgQbLai0A0GpPW/4nT0YqQ==", null, false, "19a950b8-7674-4e4e-952a-ae86681592e9", false, "maxime.lefebvre@lemadrid.com" },
                    { "8b3ccedf-a3bb-4e15-8180-0de8d0de7446", 0, "(450)-213-5697", "2c45cf2e-8549-4efb-85de-62e1e9fd1eb0", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAENtOne4BLGNygw5ASsvYS4pvO6yU9v6e4Wku/OInYVk2nHLKLCKwjxcdYy5qK5XeeA==", null, false, "dec1571c-bd99-42d4-b9e0-e882e8f3ad6e", false, "louis.garceau@lemadrid.com" },
                    { "e31143a7-bbcc-44f1-9251-f6e5424636b9", 0, "(450)-789-4673", "8b3ca23e-1322-4adc-826a-e155349ff746", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEH8t9Jqfzb50d/BpnW+DjnB9UZb701xG4NeSjnwPdQmoHEtzcwwKrKhNUJGry/gSzg==", null, false, "dacf4ff5-1bf7-4f9e-bd74-c05b82e39a02", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("2e7ad6e7-0bbd-4838-984f-dc6b678afa5b"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "d1bfb2dc-27f2-4c93-a535-068a54bd6b4e" },
                    { new Guid("2e7ad6e7-0bbd-4838-984f-dc6b678afa5b"), "7ddf313c-cb97-45bf-9863-f7902fab7980" },
                    { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "cc921d09-e071-4c32-b751-7ea8442d31d9" },
                    { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "8b3ccedf-a3bb-4e15-8180-0de8d0de7446" },
                    { new Guid("4326aa75-3b1a-41cd-a9bb-4ff34374151f"), "e31143a7-bbcc-44f1-9251-f6e5424636b9" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "863c918a-f890-48a2-b0ed-987d00869107", "81a33229-834f-4dec-89a1-e58a3ec58ed6" },
                    { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "d1bfb2dc-27f2-4c93-a535-068a54bd6b4e" },
                    { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "7ddf313c-cb97-45bf-9863-f7902fab7980" },
                    { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "cc921d09-e071-4c32-b751-7ea8442d31d9" },
                    { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "8b3ccedf-a3bb-4e15-8180-0de8d0de7446" },
                    { "0b04e44c-57f5-4751-88c4-a9c4596d4c02", "e31143a7-bbcc-44f1-9251-f6e5424636b9" }
                });
        }
    }
}
