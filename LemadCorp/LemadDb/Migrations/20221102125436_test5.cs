using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandProduct_Command_CommandsId",
                table: "CommandProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandProduct_Products_ProductsId",
                table: "CommandProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommandProduct",
                table: "CommandProduct");

            migrationBuilder.DropIndex(
                name: "IX_CommandProduct_ProductsId",
                table: "CommandProduct");

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "33d0f158-9e06-44f8-b186-6e51393c834f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "53ddc1ea-7f21-4c92-a137-b762c3f99e00" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "92afd4a6-9c8a-4474-b648-45ca5b866f3b" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "c3bc50e9-5926-4ac9-99b1-96688a1366d5" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("e67e272a-d6ce-4f4b-8e1c-269abfd2478a"), "3a31e2a9-d805-496b-a44d-ffce675e3a8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11b37af5-02c9-49d1-b80a-df8f2cfabb3c", "0045fc08-228a-4e22-991e-88e5dbd7a49d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "33d0f158-9e06-44f8-b186-6e51393c834f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "3a31e2a9-d805-496b-a44d-ffce675e3a8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "53ddc1ea-7f21-4c92-a137-b762c3f99e00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "92afd4a6-9c8a-4474-b648-45ca5b866f3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "c3bc50e9-5926-4ac9-99b1-96688a1366d5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11b37af5-02c9-49d1-b80a-df8f2cfabb3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9231e880-6743-45d1-afd6-02a2bb1ac4c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0045fc08-228a-4e22-991e-88e5dbd7a49d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33d0f158-9e06-44f8-b186-6e51393c834f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a31e2a9-d805-496b-a44d-ffce675e3a8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53ddc1ea-7f21-4c92-a137-b762c3f99e00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92afd4a6-9c8a-4474-b648-45ca5b866f3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bc50e9-5926-4ac9-99b1-96688a1366d5");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("e67e272a-d6ce-4f4b-8e1c-269abfd2478a"));

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "CommandProduct",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "CommandsId",
                table: "CommandProduct",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "CommandId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CommandId",
                table: "CommandProduct",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommandProduct",
                table: "CommandProduct",
                column: "Id");

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
                name: "IX_Products_CommandId",
                table: "Products",
                column: "CommandId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandProduct_CommandId",
                table: "CommandProduct",
                column: "CommandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandProduct_Command_CommandId",
                table: "CommandProduct",
                column: "CommandId",
                principalTable: "Command",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Command_CommandId",
                table: "Products",
                column: "CommandId",
                principalTable: "Command",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandProduct_Command_CommandId",
                table: "CommandProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Command_CommandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CommandId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommandProduct",
                table: "CommandProduct");

            migrationBuilder.DropIndex(
                name: "IX_CommandProduct_CommandId",
                table: "CommandProduct");

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
                name: "CommandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CommandId",
                table: "CommandProduct");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "CommandProduct",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CommandProduct",
                newName: "CommandsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommandProduct",
                table: "CommandProduct",
                columns: new[] { "CommandsId", "ProductsId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11b37af5-02c9-49d1-b80a-df8f2cfabb3c", "a7771257-0642-4083-87ed-eeb8564ce05e", "admin", "ADMIN" },
                    { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "e5efbf05-4910-4e48-a780-dbcc978e7f55", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0045fc08-228a-4e22-991e-88e5dbd7a49d", 0, null, "c9242570-6b3d-485d-9003-21fb111ec633", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEJWSvYbcWAqCIzn49tiorPq6xU2TvRMXN/IsRwij0snCkoF5BoMrW3DyKsb4ZpCuwQ==", null, false, "3c0b13b3-407d-4038-a0fe-32e9daa6429d", false, "admin@lemadrid.com" },
                    { "53ddc1ea-7f21-4c92-a137-b762c3f99e00", 0, "(450)-773-6800", "fa7848c7-8737-48a0-b571-baa990f988d4", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEGNMpW4q1MgtjgU94p+UDXLR3vgDxdB1k2vQuusFYJq4ubSTNzCCJeVerl0mIdNvYg==", null, false, "31b93d5e-cbed-470f-b9df-cb7dcaabb10d", false, "hugo@lemadrid.com" },
                    { "3a31e2a9-d805-496b-a44d-ffce675e3a8f", 0, "(450)-649-8594", "c38ab235-5689-40fd-99d1-8f1164e51dc0", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEDqg6c+lL0cjNDKL3z59PO9RrwVKgAaq1Ubl1dt2ZB/AFQ8jVbUnGFAWU+VsWaQYPA==", null, false, "f49fa9f6-f7f1-440d-b935-501870425c2a", false, "karl.mainville@lemadrid.com" },
                    { "33d0f158-9e06-44f8-b186-6e51393c834f", 0, "(450)-538-3982", "bf1ca6b4-8545-4d32-ae51-acb5d91fccfb", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEDaz/yKkQ4RhRMBYmPyxiRtrPzD13/lkvd/HeLGuBIAYctrpWx48I6mOsPoBFKSojA==", null, false, "7a40ee42-dfa5-4d2c-9f4b-e48a8e495cfc", false, "maxime.lefebvre@lemadrid.com" },
                    { "92afd4a6-9c8a-4474-b648-45ca5b866f3b", 0, "(450)-213-5697", "a917a13e-31d6-49d5-87f0-dd2f467bcf30", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEG7vNPd+eUiuaSNS8Bz1umBcUtPE/52LFiO3N9lTXp9ypXO7h/57fEUCVk8BGXTzMA==", null, false, "33df1a9f-d842-4180-89be-40a30257cdfd", false, "louis.garceau@lemadrid.com" },
                    { "c3bc50e9-5926-4ac9-99b1-96688a1366d5", 0, "(450)-789-4673", "17b74fcf-f68a-4418-9324-25e529779fe2", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEBqJa7oUvfFWark7Z3rmhgVq8OfIARmkW9kqHIAnJmCbzPpGYtja2ktcuuvGDjURxQ==", null, false, "01dd97cc-d11f-41fd-9028-57bea9fc362c", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("e67e272a-d6ce-4f4b-8e1c-269abfd2478a"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "53ddc1ea-7f21-4c92-a137-b762c3f99e00" },
                    { new Guid("e67e272a-d6ce-4f4b-8e1c-269abfd2478a"), "3a31e2a9-d805-496b-a44d-ffce675e3a8f" },
                    { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "33d0f158-9e06-44f8-b186-6e51393c834f" },
                    { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "92afd4a6-9c8a-4474-b648-45ca5b866f3b" },
                    { new Guid("a813b8c9-1ff0-4ee0-bc30-70a0bf6d8ddf"), "c3bc50e9-5926-4ac9-99b1-96688a1366d5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "11b37af5-02c9-49d1-b80a-df8f2cfabb3c", "0045fc08-228a-4e22-991e-88e5dbd7a49d" },
                    { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "53ddc1ea-7f21-4c92-a137-b762c3f99e00" },
                    { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "3a31e2a9-d805-496b-a44d-ffce675e3a8f" },
                    { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "33d0f158-9e06-44f8-b186-6e51393c834f" },
                    { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "92afd4a6-9c8a-4474-b648-45ca5b866f3b" },
                    { "9231e880-6743-45d1-afd6-02a2bb1ac4c6", "c3bc50e9-5926-4ac9-99b1-96688a1366d5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandProduct_ProductsId",
                table: "CommandProduct",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandProduct_Command_CommandsId",
                table: "CommandProduct",
                column: "CommandsId",
                principalTable: "Command",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandProduct_Products_ProductsId",
                table: "CommandProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
