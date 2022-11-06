using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test1004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "da316f96-6ff8-4cec-8685-deef33b1b425", "545b05ca-354d-4fa4-bca9-261b37af900b", "admin", "ADMIN" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "3b3c94d6-ef6c-44a6-adbc-36e900d35472", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a894c2d-56c3-4ae9-9648-33b85f3775a3", 0, null, "b10a337b-62a8-4c14-9749-3be98da08016", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAENWt2m0KqNbC0kkWk2raWWE3mXWC/qMmbWagYgRaxdlcDHNtKAYcYndye1UJz4F0Gw==", null, false, "e804dbc0-1574-4a84-b4b2-80739c68295a", false, "admin@lemadrid.com" },
                    { "e8b6e176-8aed-4cfa-a630-71a17b534a60", 0, null, "dfeda26d-a89b-49f2-bce4-42bf57abf464", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEHMHCYEw4FYiqxu/frLneo3Da3alKqhxv+T/DS2gxy31n8paqLDbKcfT8H8CgJLaxQ==", null, false, "a0e7d20b-4318-4201-8130-daf1d8004ba4", false, "guest@user.com" },
                    { "1e635c42-5d17-4004-acd5-41e936526d85", 0, "(450)-773-6800", "aed56769-f5f1-406c-9b87-f3f859b3b8d6", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEAb0MCHdEGxmVMAAm+EeWp+31YjXBQS4shuJkTYL3gxhrUtwZ0BqWgr/7MiFWsI8nA==", null, false, "5659bda6-9a27-40a3-ad6d-de5212192ca9", false, "hugo@lemadrid.com" },
                    { "548daea5-0e2f-4a34-8422-6727651cb048", 0, "(450)-649-8594", "d3b670e8-41a6-420c-b5db-e881fa2cd521", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEIv2rHnSXfn7CLv3d3+rNnOGCFp1tgR49q7eyKW+eOvybe2BpNbZdnKq4bpICGayFg==", null, false, "089a0ef5-b1d9-411e-a51a-99ea2f66ba65", false, "karl.mainville@lemadrid.com" },
                    { "4724e75f-0470-4199-8d05-ca753c2dacbb", 0, "(450)-538-3982", "8f28cd06-f79b-42ae-b189-cca63cab9867", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEOSh1AKh5TNyUVcwt83EK8Abz+c+OfNCyn3KKnAXgrYwpPWNL6+yLaLb1r3TAtoC1Q==", null, false, "1c17a65d-8306-4ac4-847d-7ef4987adc01", false, "maxime.lefebvre@lemadrid.com" },
                    { "f530eb17-908f-4790-b1ac-2dd8099f30c3", 0, "(450)-213-5697", "10d130d9-b08e-4673-bc20-961183f52b22", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAELnier1wnn2FyMUMVEzh9zQSLFFogSHzhtQR1HkgwjEY77Z6FT8mZ4hCgoTNnGGIHQ==", null, false, "4de7831e-aa06-4aff-aea6-1184ddecec99", false, "louis.garceau@lemadrid.com" },
                    { "471d3972-4c54-4328-91d7-64e02f68b885", 0, "(450)-789-4673", "915ddc4a-b661-41c5-87ae-98aa52ccd5da", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEE4dnLeHyidesyMGKc50LYLAAtTBDvvSsyc2d8Kx/ZLhQYGis7aGp1FV+KwF27qZyg==", null, false, "d481a512-ea14-4180-bc48-f8a1175204ba", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "1e635c42-5d17-4004-acd5-41e936526d85" },
                    { new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"), "548daea5-0e2f-4a34-8422-6727651cb048" },
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "4724e75f-0470-4199-8d05-ca753c2dacbb" },
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "f530eb17-908f-4790-b1ac-2dd8099f30c3" },
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "471d3972-4c54-4328-91d7-64e02f68b885" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "da316f96-6ff8-4cec-8685-deef33b1b425", "4a894c2d-56c3-4ae9-9648-33b85f3775a3" },
                    { "da316f96-6ff8-4cec-8685-deef33b1b425", "e8b6e176-8aed-4cfa-a630-71a17b534a60" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "1e635c42-5d17-4004-acd5-41e936526d85" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "548daea5-0e2f-4a34-8422-6727651cb048" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "4724e75f-0470-4199-8d05-ca753c2dacbb" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "f530eb17-908f-4790-b1ac-2dd8099f30c3" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "471d3972-4c54-4328-91d7-64e02f68b885" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"), "548daea5-0e2f-4a34-8422-6727651cb048" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "1e635c42-5d17-4004-acd5-41e936526d85" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "471d3972-4c54-4328-91d7-64e02f68b885" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "4724e75f-0470-4199-8d05-ca753c2dacbb" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "f530eb17-908f-4790-b1ac-2dd8099f30c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "1e635c42-5d17-4004-acd5-41e936526d85" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "471d3972-4c54-4328-91d7-64e02f68b885" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "4724e75f-0470-4199-8d05-ca753c2dacbb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da316f96-6ff8-4cec-8685-deef33b1b425", "4a894c2d-56c3-4ae9-9648-33b85f3775a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "548daea5-0e2f-4a34-8422-6727651cb048" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da316f96-6ff8-4cec-8685-deef33b1b425", "e8b6e176-8aed-4cfa-a630-71a17b534a60" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "f530eb17-908f-4790-b1ac-2dd8099f30c3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f6cf373-c708-4048-bdcf-f81e2c75be01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da316f96-6ff8-4cec-8685-deef33b1b425");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e635c42-5d17-4004-acd5-41e936526d85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "471d3972-4c54-4328-91d7-64e02f68b885");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4724e75f-0470-4199-8d05-ca753c2dacbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a894c2d-56c3-4ae9-9648-33b85f3775a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548daea5-0e2f-4a34-8422-6727651cb048");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8b6e176-8aed-4cfa-a630-71a17b534a60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f530eb17-908f-4790-b1ac-2dd8099f30c3");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("bc466f63-6674-415b-8417-7108332bdfaa"));

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
    }
}
