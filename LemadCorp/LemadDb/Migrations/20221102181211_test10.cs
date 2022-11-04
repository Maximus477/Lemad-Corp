using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("18bc42c7-c292-4220-85c1-e3044aae516b"), "29e070e4-12dc-41fc-97ca-7aa38e813b2c" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "223b2bdb-2c4f-4ef7-924e-84d324d7f392" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "543b4a2d-ffd4-43fb-95e0-98f06c530c54" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "c485331d-9426-43ae-9611-b227fb966ecc" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "ff2fc1bd-b013-45e8-a185-db294b02874a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "223b2bdb-2c4f-4ef7-924e-84d324d7f392" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "29e070e4-12dc-41fc-97ca-7aa38e813b2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "543b4a2d-ffd4-43fb-95e0-98f06c530c54" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8fd79bb2-8e41-4e7a-8224-d683a395f10c", "65cfb49a-da72-4c6d-9ed5-0382fb1e03ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "c485331d-9426-43ae-9611-b227fb966ecc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "ff2fc1bd-b013-45e8-a185-db294b02874a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61f3abd6-809f-441c-8ee2-e15b0eb36270");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd79bb2-8e41-4e7a-8224-d683a395f10c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "223b2bdb-2c4f-4ef7-924e-84d324d7f392");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29e070e4-12dc-41fc-97ca-7aa38e813b2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "543b4a2d-ffd4-43fb-95e0-98f06c530c54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65cfb49a-da72-4c6d-9ed5-0382fb1e03ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c485331d-9426-43ae-9611-b227fb966ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2fc1bd-b013-45e8-a185-db294b02874a");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("18bc42c7-c292-4220-85c1-e3044aae516b"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("d2222528-4e92-4e22-a054-12378554bf57"));

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Command",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalDiscount",
                table: "Command",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWithDiscount",
                table: "Command",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWithTaxes",
                table: "Command",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c268261-3e08-45bb-8837-febaa8e8588b", "fd813c03-4b5c-4e19-a10f-a61db8b7e5de", "admin", "ADMIN" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "e3f9fa8f-fce8-4d81-ac81-bcdd014a984b", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b352816-b6b3-4ca9-b776-c340f26f2822", 0, null, "622bfe96-b311-4bf8-8c78-4dd1dc91cc90", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEOV/v4+i8WiD8r7zjy8FZM/BctrZwq2GQWp0HiMVD9Ul3TNIYQhxlutnd2zbuBXIXA==", null, false, "ab39aab7-3a0e-4b93-8487-bebf53dba680", false, "admin@lemadrid.com" },
                    { "509b57a1-3237-43df-9991-d249f5bc55ab", 0, "(450)-773-6800", "91655652-6610-40e4-8e5d-ded0ea1af120", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEM2XM43xb5waieiKEBVdb/KHyAr18rrL1nxVxVKsR5qiL9rbHVXzBANL/rD4T42kdw==", null, false, "57fa00e9-143e-48ca-a6c7-db681c8723ed", false, "hugo@lemadrid.com" },
                    { "919f85fd-1570-4094-97a9-c46b26a8936d", 0, "(450)-649-8594", "76965fce-62bf-4714-add4-d53ddb69f553", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEJCxrXKLxWgr0i5Z2i7uKYl8W7w9goO0EaL1UT0ZJCZXaW83TWGYScpST102iyZpSw==", null, false, "49ffba74-b56d-4555-ad15-09c69cb141b2", false, "karl.mainville@lemadrid.com" },
                    { "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84", 0, "(450)-538-3982", "7cfc741d-746c-4a44-b04f-759bc967552d", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAED8AxBmy4g8o4KpCXMx3Unr8sWfTkDt+i1FwJtnXJdDTQCPzzEMUOla6++nVwX12JQ==", null, false, "80a97b0c-6dc1-4ab2-9ccc-2ead41bd4cf7", false, "maxime.lefebvre@lemadrid.com" },
                    { "bde03042-809f-4d36-92df-3e1326b1efc9", 0, "(450)-213-5697", "8c351df9-dd69-4c1c-bf37-a15b4780467c", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAENJluxqgXO8bPqLBf3bAvvx1YA46EWIF+K7sxvnAnX9AnjLepEnSZnQ6t/ipwM5gXQ==", null, false, "8e78ed78-92ca-4d73-8604-13c0f4044927", false, "louis.garceau@lemadrid.com" },
                    { "67aa9680-d861-4bd3-bf7c-307ed12d6cf3", 0, "(450)-789-4673", "21276e26-1c93-4b1b-b86e-00ecc815b770", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEB7LOaNL4f7iU0qCyo7rP5modiWzaNi0PW5RalUNoRMGdtVmsZF5qdCfxE4qtfwKLg==", null, false, "4c5a7a07-676c-435a-ba08-67a79c848a2b", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "509b57a1-3237-43df-9991-d249f5bc55ab" },
                    { new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"), "919f85fd-1570-4094-97a9-c46b26a8936d" },
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" },
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "bde03042-809f-4d36-92df-3e1326b1efc9" },
                    { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c268261-3e08-45bb-8837-febaa8e8588b", "8b352816-b6b3-4ca9-b776-c340f26f2822" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "509b57a1-3237-43df-9991-d249f5bc55ab" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "919f85fd-1570-4094-97a9-c46b26a8936d" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "bde03042-809f-4d36-92df-3e1326b1efc9" },
                    { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "509b57a1-3237-43df-9991-d249f5bc55ab" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"), "bde03042-809f-4d36-92df-3e1326b1efc9" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"), "919f85fd-1570-4094-97a9-c46b26a8936d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "509b57a1-3237-43df-9991-d249f5bc55ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "67aa9680-d861-4bd3-bf7c-307ed12d6cf3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c268261-3e08-45bb-8837-febaa8e8588b", "8b352816-b6b3-4ca9-b776-c340f26f2822" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "919f85fd-1570-4094-97a9-c46b26a8936d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318", "bde03042-809f-4d36-92df-3e1326b1efc9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c268261-3e08-45bb-8837-febaa8e8588b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88fd8308-6f3a-4d7d-a5fc-b3aad5c0b318");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509b57a1-3237-43df-9991-d249f5bc55ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5251a5c4-a28a-4cfd-90ec-c7a9e8180e84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67aa9680-d861-4bd3-bf7c-307ed12d6cf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b352816-b6b3-4ca9-b776-c340f26f2822");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "919f85fd-1570-4094-97a9-c46b26a8936d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bde03042-809f-4d36-92df-3e1326b1efc9");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("2f8b635c-6d91-4c37-8cc7-e1dfaa68d3e1"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("570781fd-6375-4a2f-bda1-afd52bd3eea7"));

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "TotalDiscount",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "TotalWithDiscount",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "TotalWithTaxes",
                table: "Command");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8fd79bb2-8e41-4e7a-8224-d683a395f10c", "0e5a8701-d4ed-4688-b546-a06a48a1cf2b", "admin", "ADMIN" },
                    { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "df6a76de-3c26-4f8c-9669-f00c4af99dd2", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65cfb49a-da72-4c6d-9ed5-0382fb1e03ea", 0, null, "855f49e1-7ada-4280-ac5d-e820b0514557", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAELf0D589MapcRqT6xc82Mh80d+P2nJU8gJlVvNte+GwegFyba8miVSNGh0f03ks4Ug==", null, false, "b1453484-f0ce-4633-9788-295a43dd2190", false, "admin@lemadrid.com" },
                    { "543b4a2d-ffd4-43fb-95e0-98f06c530c54", 0, "(450)-773-6800", "d572fe07-5d91-49b4-9968-52d910899e38", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEKhjp45+591vHQrrE3vlqHH93y8rAPFFGtQrF/DcFyhY6fcnEJ8ZluXtFwf4D0+BGQ==", null, false, "41e126ee-2e65-46dd-82b5-5a92a1be3718", false, "hugo@lemadrid.com" },
                    { "29e070e4-12dc-41fc-97ca-7aa38e813b2c", 0, "(450)-649-8594", "d3e16eb6-ba8e-4752-84fc-18107d73f421", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEBs6DCcSZm9ha/0nYWeyax7YUeySCOlC7xvyx7+KdrNRI70pO/1qnZ8iq2gGDmsrTw==", null, false, "a18349fe-e99b-4db3-8d9c-3a3c471e1cef", false, "karl.mainville@lemadrid.com" },
                    { "c485331d-9426-43ae-9611-b227fb966ecc", 0, "(450)-538-3982", "158fd3ff-a7b9-4135-abac-ea5d0eb12fec", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEJgwXTvKLHTNPhwteiKvoJWugH1PrCKaJlrGSUCgRXstXmDewAo+PmaAmy6DAeCgQg==", null, false, "ad2124e7-05b4-4555-bd2d-34fe53cbabed", false, "maxime.lefebvre@lemadrid.com" },
                    { "ff2fc1bd-b013-45e8-a185-db294b02874a", 0, "(450)-213-5697", "4cf0c91d-8202-43ad-95a1-be4cd85915fa", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEBSBg1L+x4wWlhP8zPOlOmiFQjqfrp4nL36sbnVcEW+pDPEMbB6sh2EA5Xt0QRN0gg==", null, false, "8dfd4a90-6768-441f-b486-2f8382e85d88", false, "louis.garceau@lemadrid.com" },
                    { "223b2bdb-2c4f-4ef7-924e-84d324d7f392", 0, "(450)-789-4673", "bf134744-8248-48fc-81aa-a3fd65ec7790", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEFr4ip0QsXVsnUWvdO1NPQ8J5Krq9BRQ2hC93V4Yujp5E2phyQf8S1Asw2YvVNBSjw==", null, false, "51faeac1-9eeb-45cd-b76e-9dd56603b963", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("18bc42c7-c292-4220-85c1-e3044aae516b"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "543b4a2d-ffd4-43fb-95e0-98f06c530c54" },
                    { new Guid("18bc42c7-c292-4220-85c1-e3044aae516b"), "29e070e4-12dc-41fc-97ca-7aa38e813b2c" },
                    { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "c485331d-9426-43ae-9611-b227fb966ecc" },
                    { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "ff2fc1bd-b013-45e8-a185-db294b02874a" },
                    { new Guid("d2222528-4e92-4e22-a054-12378554bf57"), "223b2bdb-2c4f-4ef7-924e-84d324d7f392" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8fd79bb2-8e41-4e7a-8224-d683a395f10c", "65cfb49a-da72-4c6d-9ed5-0382fb1e03ea" },
                    { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "543b4a2d-ffd4-43fb-95e0-98f06c530c54" },
                    { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "29e070e4-12dc-41fc-97ca-7aa38e813b2c" },
                    { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "c485331d-9426-43ae-9611-b227fb966ecc" },
                    { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "ff2fc1bd-b013-45e8-a185-db294b02874a" },
                    { "61f3abd6-809f-441c-8ee2-e15b0eb36270", "223b2bdb-2c4f-4ef7-924e-84d324d7f392" }
                });
        }
    }
}
