using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test1003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "c22e6bf7-bb57-4062-b97e-d06c4597452d", "411967d6-c1ce-4fe8-ae53-96c3d20b03ae", "admin", "ADMIN" },
                    { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "f4084a7b-8758-4699-b21b-dbdb7be4f8ad", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32a591a7-496f-43a4-ac9e-2d6f2d70887f", 0, null, "62453d02-329e-4cb4-8454-995496183733", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEL7iz8tDEBQDy3orZHxOZWql5jPPtitjnARhTuIGn1wO1RkVqXjWvLNzBB+ea0xG6A==", null, false, "d466a1ff-452c-4d10-abcd-f52af4877199", false, "admin@lemadrid.com" },
                    { "ef66c42e-41c0-4507-abd5-f23fbd6d5f33", 0, null, "be20d92c-b9f4-444e-b125-ed95c20b8e8c", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAENS22VGzyZhMXXY+1RcCWDGhaYZ5onY88lEMiQktOSGGbF6kjDi7OOoEuGbHcw73Vw==", null, false, "26540fb3-6131-454f-ab30-6508b658254a", false, "guest@user.com" },
                    { "95723e74-5022-42ad-8353-421da33f8719", 0, "(450)-773-6800", "b866f46e-b09d-47e7-a3cc-61a5e1c14428", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEMnfkfrV+KLLPHqQJj8iBaQiYEgs/nlWhItjIBBecPW/jv6ZJAdBfCIVCDwFMUTuKA==", null, false, "62e7093f-91c9-45de-af1c-04adef0e20bb", false, "hugo@lemadrid.com" },
                    { "2adb537a-a23a-45f9-a9fd-22370fa51969", 0, "(450)-649-8594", "daa1ac16-6171-4208-bbf3-2469149eac05", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEBZymCvlg9FM95o9aq2n+LgEDh2CBlJgaJIiyylsPAoVVaenwCfAhdGTY0Y2ZtNiMA==", null, false, "491b2a70-8e8a-4600-a9ef-5f05e9244bb7", false, "karl.mainville@lemadrid.com" },
                    { "4118bbda-baa1-4c76-b53c-e896da57db1c", 0, "(450)-538-3982", "26ab7701-5943-471b-bcf3-fac6707a1386", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEFciLuyejXtoRqM6uNNUr2Rqf6XMbTIqd3GcEzPBGQjrBDD0ndDnXEIqut8FXu/nYA==", null, false, "b1b46c65-9e37-4643-bded-da01fda14a78", false, "maxime.lefebvre@lemadrid.com" },
                    { "60b3e808-279e-4223-ad12-d031b35c7830", 0, "(450)-213-5697", "788602bb-e015-4146-bdc9-52cdaddf790c", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEOkl6xRbibEjviwWmMFw2XzymrBGo57QgkTulBGhqDrKFc5USAy49GVjCYMrSiiUmw==", null, false, "b6f65622-df10-4a86-9e73-ed83eacec155", false, "louis.garceau@lemadrid.com" },
                    { "563c5d8c-35d4-4e5f-bb1a-a35cb138dc83", 0, "(450)-789-4673", "b2c82b90-228d-4018-b990-01f839ed7ba1", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEKCa2/P9lLWjTnk8bMQMRlrGhub8SmdHI+kPpxeNs8GQZziR++gv7emoOmS+FWQNwA==", null, false, "6befa7c2-667a-4751-ae41-44503d73fecb", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("a495bb77-fa52-4afb-b19e-fdbbdf91da77"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "95723e74-5022-42ad-8353-421da33f8719" },
                    { new Guid("a495bb77-fa52-4afb-b19e-fdbbdf91da77"), "2adb537a-a23a-45f9-a9fd-22370fa51969" },
                    { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "4118bbda-baa1-4c76-b53c-e896da57db1c" },
                    { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "60b3e808-279e-4223-ad12-d031b35c7830" },
                    { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "563c5d8c-35d4-4e5f-bb1a-a35cb138dc83" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c22e6bf7-bb57-4062-b97e-d06c4597452d", "32a591a7-496f-43a4-ac9e-2d6f2d70887f" },
                    { "c22e6bf7-bb57-4062-b97e-d06c4597452d", "ef66c42e-41c0-4507-abd5-f23fbd6d5f33" },
                    { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "95723e74-5022-42ad-8353-421da33f8719" },
                    { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "2adb537a-a23a-45f9-a9fd-22370fa51969" },
                    { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "4118bbda-baa1-4c76-b53c-e896da57db1c" },
                    { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "60b3e808-279e-4223-ad12-d031b35c7830" },
                    { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "563c5d8c-35d4-4e5f-bb1a-a35cb138dc83" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("a495bb77-fa52-4afb-b19e-fdbbdf91da77"), "2adb537a-a23a-45f9-a9fd-22370fa51969" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "4118bbda-baa1-4c76-b53c-e896da57db1c" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "563c5d8c-35d4-4e5f-bb1a-a35cb138dc83" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "60b3e808-279e-4223-ad12-d031b35c7830" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"), "95723e74-5022-42ad-8353-421da33f8719" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "2adb537a-a23a-45f9-a9fd-22370fa51969" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c22e6bf7-bb57-4062-b97e-d06c4597452d", "32a591a7-496f-43a4-ac9e-2d6f2d70887f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "4118bbda-baa1-4c76-b53c-e896da57db1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "563c5d8c-35d4-4e5f-bb1a-a35cb138dc83" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "60b3e808-279e-4223-ad12-d031b35c7830" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fffe048b-2f52-4345-9dba-7cdeefa493cf", "95723e74-5022-42ad-8353-421da33f8719" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c22e6bf7-bb57-4062-b97e-d06c4597452d", "ef66c42e-41c0-4507-abd5-f23fbd6d5f33" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c22e6bf7-bb57-4062-b97e-d06c4597452d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fffe048b-2f52-4345-9dba-7cdeefa493cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2adb537a-a23a-45f9-a9fd-22370fa51969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32a591a7-496f-43a4-ac9e-2d6f2d70887f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4118bbda-baa1-4c76-b53c-e896da57db1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "563c5d8c-35d4-4e5f-bb1a-a35cb138dc83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60b3e808-279e-4223-ad12-d031b35c7830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95723e74-5022-42ad-8353-421da33f8719");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef66c42e-41c0-4507-abd5-f23fbd6d5f33");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("a495bb77-fa52-4afb-b19e-fdbbdf91da77"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("e9d94210-8831-4f52-945f-cf2c6044bdf7"));

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
    }
}
