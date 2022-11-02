using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Command_CivicAddresses_AdresseCiviqueId",
                table: "Command");

            migrationBuilder.DropIndex(
                name: "IX_Command_AdresseCiviqueId",
                table: "Command");

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "472de711-f00c-43a5-8128-2c33e7545ff9" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "bd116812-f31a-42e0-876e-2a1ee931e84f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "c220dbfa-6055-479a-8305-ebc6a18ac4c5" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "fc4028e1-b72f-47fa-b106-1ac7f0eb374c" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("3e767205-01ce-4c26-9251-004b54ff0990"), "61e6857f-f476-4223-a8d7-671dafb47b7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31b04287-1909-4130-9b09-afe1b64978c5", "472de711-f00c-43a5-8128-2c33e7545ff9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0799fc7b-88e5-4d99-8b8c-f16d75d9943f", "49d73853-c7e5-43bd-82a2-013b592105d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31b04287-1909-4130-9b09-afe1b64978c5", "61e6857f-f476-4223-a8d7-671dafb47b7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31b04287-1909-4130-9b09-afe1b64978c5", "bd116812-f31a-42e0-876e-2a1ee931e84f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31b04287-1909-4130-9b09-afe1b64978c5", "c220dbfa-6055-479a-8305-ebc6a18ac4c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31b04287-1909-4130-9b09-afe1b64978c5", "fc4028e1-b72f-47fa-b106-1ac7f0eb374c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0799fc7b-88e5-4d99-8b8c-f16d75d9943f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31b04287-1909-4130-9b09-afe1b64978c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472de711-f00c-43a5-8128-2c33e7545ff9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49d73853-c7e5-43bd-82a2-013b592105d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61e6857f-f476-4223-a8d7-671dafb47b7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd116812-f31a-42e0-876e-2a1ee931e84f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c220dbfa-6055-479a-8305-ebc6a18ac4c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc4028e1-b72f-47fa-b106-1ac7f0eb374c");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("3e767205-01ce-4c26-9251-004b54ff0990"));

            migrationBuilder.DropColumn(
                name: "AdresseCiviqueId",
                table: "Command");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Command",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Command",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Command",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Command",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Command",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Command");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Command");

            migrationBuilder.AddColumn<Guid>(
                name: "AdresseCiviqueId",
                table: "Command",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0799fc7b-88e5-4d99-8b8c-f16d75d9943f", "c6fdfb5c-0669-4548-8d8c-a25662e77cc9", "admin", "ADMIN" },
                    { "31b04287-1909-4130-9b09-afe1b64978c5", "36e773a2-00ac-4b7a-9fcf-1927dd65a9e2", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "49d73853-c7e5-43bd-82a2-013b592105d1", 0, null, "3e1a3126-c0d5-4e31-b87d-1ecb2c5b3f77", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEEcwvPw+p6ivgHZe/4izg4Ae2c2MUPHlbTUmfk+duUr4Sc2pXU5vNgWbLKqL+loCDA==", null, false, "2a4f3339-f95b-4d41-b5d7-3a6809d7ba91", false, "admin@lemadrid.com" },
                    { "bd116812-f31a-42e0-876e-2a1ee931e84f", 0, "(450)-773-6800", "4653d393-6f4e-4d11-870f-30f2e5578bfb", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAECA6hKs5DEqla2ysVrEXD23w4HL5TkvrT3FUCHB0p/0SDrbtUTjCK66qpKJFkmK2bA==", null, false, "ef051ed1-9cd7-4e75-9ce1-743af9fdea9b", false, "hugo@lemadrid.com" },
                    { "61e6857f-f476-4223-a8d7-671dafb47b7e", 0, "(450)-649-8594", "ccd1ec5e-7393-4d41-a29a-0c9c9cc8c621", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEHA2rMs0CHrU/HfqNcEsiX87TBx4M3d2KCTmXFIIxrbH8EzTUBmiNmthxpaiB2CpNw==", null, false, "c6585cfc-3513-4e69-a279-1ab467b4ddff", false, "karl.mainville@lemadrid.com" },
                    { "c220dbfa-6055-479a-8305-ebc6a18ac4c5", 0, "(450)-538-3982", "d99ba045-d5ec-4ac8-a588-267e06a1bcc4", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEPAPguL5O0uHkB1y1KPJtwCwYq3I6WCVMfC/eeRZnfBGwLHufdxSRn1LbNLUh0aRlg==", null, false, "06bda441-ca61-4ed0-ac6c-9072ebddc81e", false, "maxime.lefebvre@lemadrid.com" },
                    { "fc4028e1-b72f-47fa-b106-1ac7f0eb374c", 0, "(450)-213-5697", "9a3b38ca-29f6-4091-9eb1-943d513f53de", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEAy0Lg/O7AkRKJZ6hBY9wdsr4f+zjSsjt7GMJltzWrb3LtZNaJU99FuXnEBxIvIWvw==", null, false, "dab1041b-8abf-41de-94bf-af38024821e7", false, "louis.garceau@lemadrid.com" },
                    { "472de711-f00c-43a5-8128-2c33e7545ff9", 0, "(450)-789-4673", "fe1193c8-2e3f-4bc3-936a-22216c34bfa7", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAECyC5kA1RUCv4e8sedTNZdhKzKFN7cLt6Wv9mZFOLMVg0/KHEekGmM4QbQavHLYxzg==", null, false, "cfba6889-8f38-4ba2-8ddf-0e41ee0c054e", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("3e767205-01ce-4c26-9251-004b54ff0990"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "bd116812-f31a-42e0-876e-2a1ee931e84f" },
                    { new Guid("3e767205-01ce-4c26-9251-004b54ff0990"), "61e6857f-f476-4223-a8d7-671dafb47b7e" },
                    { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "c220dbfa-6055-479a-8305-ebc6a18ac4c5" },
                    { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "fc4028e1-b72f-47fa-b106-1ac7f0eb374c" },
                    { new Guid("22ac75d5-df2f-4ea9-9b15-d515738c7dca"), "472de711-f00c-43a5-8128-2c33e7545ff9" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0799fc7b-88e5-4d99-8b8c-f16d75d9943f", "49d73853-c7e5-43bd-82a2-013b592105d1" },
                    { "31b04287-1909-4130-9b09-afe1b64978c5", "bd116812-f31a-42e0-876e-2a1ee931e84f" },
                    { "31b04287-1909-4130-9b09-afe1b64978c5", "61e6857f-f476-4223-a8d7-671dafb47b7e" },
                    { "31b04287-1909-4130-9b09-afe1b64978c5", "c220dbfa-6055-479a-8305-ebc6a18ac4c5" },
                    { "31b04287-1909-4130-9b09-afe1b64978c5", "fc4028e1-b72f-47fa-b106-1ac7f0eb374c" },
                    { "31b04287-1909-4130-9b09-afe1b64978c5", "472de711-f00c-43a5-8128-2c33e7545ff9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Command_AdresseCiviqueId",
                table: "Command",
                column: "AdresseCiviqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_CivicAddresses_AdresseCiviqueId",
                table: "Command",
                column: "AdresseCiviqueId",
                principalTable: "CivicAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
