using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { new Guid("064f5e7d-663b-4e79-989f-bb746154d10d"), "fa7644a3-0d92-43c7-b0fd-5d6333b822e5" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "8374b55f-3be1-436f-b9f3-7a70d733e228" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "c04af81e-1a32-40c3-911e-1a9c0412641e" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "c432784d-08a2-4cf0-ab76-347d537670b2" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "ee975541-bee0-4dbe-af03-3777134faf43" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ef2bb42-6baf-424c-8dad-476008b71ce0", "79be7212-412b-4c31-8a1d-40dea43b5003" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9738d88a-4800-4c3f-b642-026af210a215", "8374b55f-3be1-436f-b9f3-7a70d733e228" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9738d88a-4800-4c3f-b642-026af210a215", "c04af81e-1a32-40c3-911e-1a9c0412641e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9738d88a-4800-4c3f-b642-026af210a215", "c432784d-08a2-4cf0-ab76-347d537670b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9738d88a-4800-4c3f-b642-026af210a215", "ee975541-bee0-4dbe-af03-3777134faf43" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9738d88a-4800-4c3f-b642-026af210a215", "fa7644a3-0d92-43c7-b0fd-5d6333b822e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ef2bb42-6baf-424c-8dad-476008b71ce0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9738d88a-4800-4c3f-b642-026af210a215");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79be7212-412b-4c31-8a1d-40dea43b5003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8374b55f-3be1-436f-b9f3-7a70d733e228");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c04af81e-1a32-40c3-911e-1a9c0412641e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c432784d-08a2-4cf0-ab76-347d537670b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee975541-bee0-4dbe-af03-3777134faf43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa7644a3-0d92-43c7-b0fd-5d6333b822e5");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("064f5e7d-663b-4e79-989f-bb746154d10d"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2ef2bb42-6baf-424c-8dad-476008b71ce0", "1721348d-13aa-4382-8a9b-a8294703151c", "admin", "ADMIN" },
                    { "9738d88a-4800-4c3f-b642-026af210a215", "d8d243a8-0afa-4d6f-9b8c-55ca20cc416c", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "79be7212-412b-4c31-8a1d-40dea43b5003", 0, null, "2fffec12-c218-4b92-882c-6a28fbfd27b7", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEHhUkWFZdNMZFI6M7EOSa/CeTtv9UAGWDGPnxMGqKhjSIPqQiKumj/QH+CVLYOSTqA==", null, false, "b6e2e43a-925d-46c3-a713-4f690d7f6d89", false, "admin@lemadrid.com" },
                    { "8374b55f-3be1-436f-b9f3-7a70d733e228", 0, "(450)-773-6800", "bbbc9424-57fa-42a6-a899-07cd97a7015b", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEH94hYs7V0YCzAXgeb6swT/VDuaSft0xhS9pIp4MNXmfZbPeP5IUZ1UyKs0MISlEgw==", null, false, "e29dd0b8-f9a9-4445-9b7f-1e733bdfcee2", false, "hugo@lemadrid.com" },
                    { "fa7644a3-0d92-43c7-b0fd-5d6333b822e5", 0, "(450)-649-8594", "ff7866e0-9861-45f1-90aa-eaab57087529", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEJ8sNKAzIBXv27ZdQQGQczHH6+PSo3+5EXFNZ2ykOGklwgxuEJ5NAMUpU1TiFn+WJg==", null, false, "a7a335e2-d4c6-40fc-b291-aacb8e48fd01", false, "karl.mainville@lemadrid.com" },
                    { "c04af81e-1a32-40c3-911e-1a9c0412641e", 0, "(450)-538-3982", "e7af0c40-3f6b-46b5-874c-8ae6a733723d", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEAtsZ6X4NpOdc5YKed7gFUuufhj7iQq6sWQjliUqRoVdmurHNdE8NezCn8GfA1GAhA==", null, false, "ca8674f0-92e9-4d86-a399-5daddcb07436", false, "maxime.lefebvre@lemadrid.com" },
                    { "c432784d-08a2-4cf0-ab76-347d537670b2", 0, "(450)-213-5697", "355f05fe-e835-4c7a-95ca-8ce8ce2d5a2f", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAECzIcow91rQJ9+G56EyP+/4uNhWTuw1iPqFeLBSqm5Hk78D2zzYIy1E+97kFk7w8ig==", null, false, "9f5a3657-d91c-46bd-8dad-704b4deb223e", false, "louis.garceau@lemadrid.com" },
                    { "ee975541-bee0-4dbe-af03-3777134faf43", 0, "(450)-789-4673", "39c3d72a-6e61-4010-8961-5392fd799ab8", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEOIyNT7+PJTAtDyhVXKPz9T+YlVsWOIQGXlH+LOyi5+3feIAxGZuTsC8XKn9JGPPFA==", null, false, "9a0dc78d-d30f-4bed-8cd7-42f950768ca8", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("064f5e7d-663b-4e79-989f-bb746154d10d"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "8374b55f-3be1-436f-b9f3-7a70d733e228" },
                    { new Guid("064f5e7d-663b-4e79-989f-bb746154d10d"), "fa7644a3-0d92-43c7-b0fd-5d6333b822e5" },
                    { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "c04af81e-1a32-40c3-911e-1a9c0412641e" },
                    { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "c432784d-08a2-4cf0-ab76-347d537670b2" },
                    { new Guid("7d1c0884-2a88-4e86-8976-60b54f8c9e6f"), "ee975541-bee0-4dbe-af03-3777134faf43" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2ef2bb42-6baf-424c-8dad-476008b71ce0", "79be7212-412b-4c31-8a1d-40dea43b5003" },
                    { "9738d88a-4800-4c3f-b642-026af210a215", "8374b55f-3be1-436f-b9f3-7a70d733e228" },
                    { "9738d88a-4800-4c3f-b642-026af210a215", "fa7644a3-0d92-43c7-b0fd-5d6333b822e5" },
                    { "9738d88a-4800-4c3f-b642-026af210a215", "c04af81e-1a32-40c3-911e-1a9c0412641e" },
                    { "9738d88a-4800-4c3f-b642-026af210a215", "c432784d-08a2-4cf0-ab76-347d537670b2" },
                    { "9738d88a-4800-4c3f-b642-026af210a215", "ee975541-bee0-4dbe-af03-3777134faf43" }
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
    }
}
