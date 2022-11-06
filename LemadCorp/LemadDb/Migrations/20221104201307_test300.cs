using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test300 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "5df6a11e-af74-4989-9fde-62eda9b607f6" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "602b87da-ea3a-48e4-8893-6400b8f0723e" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "977dbd7d-12eb-407d-aba5-f47e0cc89ff9" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "f131d3f8-c8e1-4498-96a7-c261db8d46fd" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("fbcf9910-d9e7-4d1f-8000-270bc3419f15"), "8e93885a-79af-47da-8bc5-3124472a5945" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63675fdb-2c62-420e-9c6c-c7315e66564f", "5df6a11e-af74-4989-9fde-62eda9b607f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63675fdb-2c62-420e-9c6c-c7315e66564f", "602b87da-ea3a-48e4-8893-6400b8f0723e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63675fdb-2c62-420e-9c6c-c7315e66564f", "8e93885a-79af-47da-8bc5-3124472a5945" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "985700de-11fe-4b2d-96bc-70a91fd2d766", "933ee85a-66a6-4acf-b8c1-5416d85863c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63675fdb-2c62-420e-9c6c-c7315e66564f", "977dbd7d-12eb-407d-aba5-f47e0cc89ff9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63675fdb-2c62-420e-9c6c-c7315e66564f", "f131d3f8-c8e1-4498-96a7-c261db8d46fd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63675fdb-2c62-420e-9c6c-c7315e66564f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985700de-11fe-4b2d-96bc-70a91fd2d766");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5df6a11e-af74-4989-9fde-62eda9b607f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "602b87da-ea3a-48e4-8893-6400b8f0723e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e93885a-79af-47da-8bc5-3124472a5945");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "933ee85a-66a6-4acf-b8c1-5416d85863c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977dbd7d-12eb-407d-aba5-f47e0cc89ff9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f131d3f8-c8e1-4498-96a7-c261db8d46fd");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("fbcf9910-d9e7-4d1f-8000-270bc3419f15"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "985700de-11fe-4b2d-96bc-70a91fd2d766", "5544e809-3388-4c2f-acab-ba884fa7dab1", "admin", "ADMIN" },
                    { "63675fdb-2c62-420e-9c6c-c7315e66564f", "94be910f-7494-4f2a-9c0d-c9209bbd21b1", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "933ee85a-66a6-4acf-b8c1-5416d85863c8", 0, null, "ecd1aa9d-5bb8-4c37-880b-27ba58c217e3", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAENwRVImH856Pf63CoP+xoLrwGyDtIfW4smu/zHIQ/uJ7GPz3/0lcVkMxufPgJGr95A==", null, false, "c18a6a9f-1815-4b50-9944-a077cf5b972c", false, "admin@lemadrid.com" },
                    { "602b87da-ea3a-48e4-8893-6400b8f0723e", 0, "(450)-773-6800", "a7d999ff-5244-4ec8-84b7-46248ed0ad0d", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAENGP+431h031EqLwhm3JNmKnRTGaubzR7hHBrQl8aHYE9ZQNXvx6IxQoN9DpmwmwbA==", null, false, "36ce58a8-cecd-47e8-99bb-4696c376dd54", false, "hugo@lemadrid.com" },
                    { "8e93885a-79af-47da-8bc5-3124472a5945", 0, "(450)-649-8594", "5a6b70dc-1434-481e-8bb1-51c1749c28db", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAECdVd+JMitrbLa9dJHqcIgMhXkdCX/SPSmh98o3dSjX5qSSCMB3ejWIzdRn3SqSymw==", null, false, "f3900710-0479-4f1e-8174-09c8674ece64", false, "karl.mainville@lemadrid.com" },
                    { "5df6a11e-af74-4989-9fde-62eda9b607f6", 0, "(450)-538-3982", "01eb3475-ba4c-4062-9742-2bd01262be67", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEIFrz4/JZHCyqxln4iA7aum9qn8ubaOLr5N3LQnPj7ysenf1h9OHeiMGio5ZA4z94A==", null, false, "87225d08-e844-4dfa-97e2-e083f183c6fa", false, "maxime.lefebvre@lemadrid.com" },
                    { "977dbd7d-12eb-407d-aba5-f47e0cc89ff9", 0, "(450)-213-5697", "ce86924b-7ab4-4cb4-b559-2baed0e73e8c", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEETCeWlLheMON8b/v6M2ZsZLAv9L/sGtaJHh8deUsWe0tqpBAKuR6CYfmhqmYmcXsA==", null, false, "6a0b23ab-a1a1-4c6f-ad01-15321b21d8de", false, "louis.garceau@lemadrid.com" },
                    { "f131d3f8-c8e1-4498-96a7-c261db8d46fd", 0, "(450)-789-4673", "ba3f24d5-5bc8-4759-a682-a85f6cb60a28", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEBIKPSmOPPLHfgb/PThV6s6KFNd8+QUowhaWDOR2vgcNR8q89jxTZjyAoGayI1kaOg==", null, false, "482699be-ef7a-48a0-b2b1-ccbb2738c20a", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("fbcf9910-d9e7-4d1f-8000-270bc3419f15"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "602b87da-ea3a-48e4-8893-6400b8f0723e" },
                    { new Guid("fbcf9910-d9e7-4d1f-8000-270bc3419f15"), "8e93885a-79af-47da-8bc5-3124472a5945" },
                    { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "5df6a11e-af74-4989-9fde-62eda9b607f6" },
                    { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "977dbd7d-12eb-407d-aba5-f47e0cc89ff9" },
                    { new Guid("1cf9dde6-0ba4-4828-90bb-100780ed7b7a"), "f131d3f8-c8e1-4498-96a7-c261db8d46fd" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "985700de-11fe-4b2d-96bc-70a91fd2d766", "933ee85a-66a6-4acf-b8c1-5416d85863c8" },
                    { "63675fdb-2c62-420e-9c6c-c7315e66564f", "602b87da-ea3a-48e4-8893-6400b8f0723e" },
                    { "63675fdb-2c62-420e-9c6c-c7315e66564f", "8e93885a-79af-47da-8bc5-3124472a5945" },
                    { "63675fdb-2c62-420e-9c6c-c7315e66564f", "5df6a11e-af74-4989-9fde-62eda9b607f6" },
                    { "63675fdb-2c62-420e-9c6c-c7315e66564f", "977dbd7d-12eb-407d-aba5-f47e0cc89ff9" },
                    { "63675fdb-2c62-420e-9c6c-c7315e66564f", "f131d3f8-c8e1-4498-96a7-c261db8d46fd" }
                });
        }
    }
}
