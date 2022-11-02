using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("9397c269-a259-4b3b-8127-fd74aa774ada"), "40628612-46a7-4ac1-bb07-d1ce1d7bc753" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "270c3b5e-d456-4192-96e6-da0ea97865ed" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "43794bc0-d46d-44e6-9c98-d3200b8238a7" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "4b91ebbc-0569-455e-afd1-0d7e3fa68ee0" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "59a46004-228c-4299-9194-5e51bbd9a179" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d10752-1eb3-43be-868e-5d236acdb850", "270c3b5e-d456-4192-96e6-da0ea97865ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d10752-1eb3-43be-868e-5d236acdb850", "40628612-46a7-4ac1-bb07-d1ce1d7bc753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d10752-1eb3-43be-868e-5d236acdb850", "43794bc0-d46d-44e6-9c98-d3200b8238a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d10752-1eb3-43be-868e-5d236acdb850", "4b91ebbc-0569-455e-afd1-0d7e3fa68ee0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54d10752-1eb3-43be-868e-5d236acdb850", "59a46004-228c-4299-9194-5e51bbd9a179" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40a28439-815c-4784-b060-adeaf0d9fbee", "a7841924-6881-42cf-89de-b988ca40d30b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40a28439-815c-4784-b060-adeaf0d9fbee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54d10752-1eb3-43be-868e-5d236acdb850");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "270c3b5e-d456-4192-96e6-da0ea97865ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40628612-46a7-4ac1-bb07-d1ce1d7bc753");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43794bc0-d46d-44e6-9c98-d3200b8238a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b91ebbc-0569-455e-afd1-0d7e3fa68ee0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59a46004-228c-4299-9194-5e51bbd9a179");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7841924-6881-42cf-89de-b988ca40d30b");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("9397c269-a259-4b3b-8127-fd74aa774ada"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40a28439-815c-4784-b060-adeaf0d9fbee", "b2b70477-2b84-4302-a27b-8decb6e79bff", "admin", "ADMIN" },
                    { "54d10752-1eb3-43be-868e-5d236acdb850", "2e0b11ee-6da8-4629-9107-487210932e94", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a7841924-6881-42cf-89de-b988ca40d30b", 0, null, "afdc7201-0a51-4394-b78f-d714972585b8", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEBlq9/pHygfznzGcHRyLCMZNN1rB0vSe0m8HPBF8duBjzjb0+xlKU573MdCwEplY2A==", null, false, "d83b1f55-5f0c-4eb4-a77f-d2a7dbf07071", false, "admin@lemadrid.com" },
                    { "59a46004-228c-4299-9194-5e51bbd9a179", 0, "(450)-773-6800", "b47d43d4-83cb-441e-9f6d-81ec1731150f", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEKUxKzs2A+GNLnZmbROtOsdf6LZh4dwk+h6PMEw0KsNmyW5YJBBvC/0k15K0SY+N8A==", null, false, "2ef61746-2234-4968-b5a8-8cbb1109c259", false, "hugo@lemadrid.com" },
                    { "40628612-46a7-4ac1-bb07-d1ce1d7bc753", 0, "(450)-649-8594", "c5797239-a853-4464-9f6f-f07506d12fdf", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEAtUiXXHz+8mv7uw6yoxvdOX6JpgtjsmX+UlBnnjMPGuPgJI8eG5RvR/ud04yyo1Rw==", null, false, "44d2fcec-d12b-458b-9cd0-6d6b6eb3982c", false, "karl.mainville@lemadrid.com" },
                    { "43794bc0-d46d-44e6-9c98-d3200b8238a7", 0, "(450)-538-3982", "04cc852f-b3c9-461b-b9ce-23c6e8eb087e", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEF2y7QZQQBmb4MlxcGWMmBFEvKsNvzOLfrDIQcvCk6gcL20qpeR/7Fr18xTmZK5llQ==", null, false, "35daca5a-a974-4476-9cb3-d322f3fc1558", false, "maxime.lefebvre@lemadrid.com" },
                    { "4b91ebbc-0569-455e-afd1-0d7e3fa68ee0", 0, "(450)-213-5697", "cf875b06-67c8-42bb-b63c-7989fee113bb", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEFQRBaXUNPCBMBTvZ84A9Es2orbKj3Be+kUj2kXNEj3khohDjdgZ3RMuCqHblD0y+g==", null, false, "de973e55-c355-49cc-9398-30a77670c6dd", false, "louis.garceau@lemadrid.com" },
                    { "270c3b5e-d456-4192-96e6-da0ea97865ed", 0, "(450)-789-4673", "98939d1c-f87f-4f80-a455-1e4ef38299cb", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEIjCLKuEV/jarekF11w+45B8pA/2YFf7AxnxpgXl2IyFAtUsSmoRdZ0NrRKoHjhIpg==", null, false, "18699e11-af01-451d-aa47-6f2d24cf3c1b", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("9397c269-a259-4b3b-8127-fd74aa774ada"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "59a46004-228c-4299-9194-5e51bbd9a179" },
                    { new Guid("9397c269-a259-4b3b-8127-fd74aa774ada"), "40628612-46a7-4ac1-bb07-d1ce1d7bc753" },
                    { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "43794bc0-d46d-44e6-9c98-d3200b8238a7" },
                    { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "4b91ebbc-0569-455e-afd1-0d7e3fa68ee0" },
                    { new Guid("c692cde2-354c-4a5a-bebb-6790274ee888"), "270c3b5e-d456-4192-96e6-da0ea97865ed" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40a28439-815c-4784-b060-adeaf0d9fbee", "a7841924-6881-42cf-89de-b988ca40d30b" },
                    { "54d10752-1eb3-43be-868e-5d236acdb850", "59a46004-228c-4299-9194-5e51bbd9a179" },
                    { "54d10752-1eb3-43be-868e-5d236acdb850", "40628612-46a7-4ac1-bb07-d1ce1d7bc753" },
                    { "54d10752-1eb3-43be-868e-5d236acdb850", "43794bc0-d46d-44e6-9c98-d3200b8238a7" },
                    { "54d10752-1eb3-43be-868e-5d236acdb850", "4b91ebbc-0569-455e-afd1-0d7e3fa68ee0" },
                    { "54d10752-1eb3-43be-868e-5d236acdb850", "270c3b5e-d456-4192-96e6-da0ea97865ed" }
                });
        }
    }
}
