using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class testing6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandProduct_Command_CommandId",
                table: "CommandProduct");

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "3ca20e43-1302-408b-9775-788262e33573" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "5bba8c0c-af5d-4118-bd24-34202df99eac" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "efb092d4-f926-4603-9c7a-f2515103d89f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"), "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "3ca20e43-1302-408b-9775-788262e33573" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "5bba8c0c-af5d-4118-bd24-34202df99eac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca3807d-29b9-4410-886f-18709a191b15", "6d588f88-8891-4881-9e92-1dcf1ada336b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca3807d-29b9-4410-886f-18709a191b15", "be4e02e8-e93d-4ce0-927e-eb05804c2fab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "efb092d4-f926-4603-9c7a-f2515103d89f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca3807d-29b9-4410-886f-18709a191b15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0a7ea54-f407-4869-a52d-93894811cf4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ca20e43-1302-408b-9775-788262e33573");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "480cc716-b2b5-47a2-a439-a7e6df1ecd5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bba8c0c-af5d-4118-bd24-34202df99eac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d588f88-8891-4881-9e92-1dcf1ada336b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be4e02e8-e93d-4ce0-927e-eb05804c2fab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efb092d4-f926-4603-9c7a-f2515103d89f");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CommandId",
                table: "CommandProduct",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "290dd2cf-1cd7-4db7-a959-496c8153fd0c", "ffe3d751-59b3-4de4-85d0-9a64b4998d79", "admin", "ADMIN" },
                    { "09675e3f-86e4-4401-80b9-95f71f167ff7", "30b19d8e-b69e-467c-94ff-fe5bf2297718", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8ba46c3a-3b6b-401c-bb11-f36f69dc42f4", 0, null, "a49f8e5e-1921-4849-abbd-db69e12b3b88", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEM6hawuyJ+TiVFVbeAS2t6ucEQwr2dUwMj+fIJq9HaligzafesTPv6iOSgeZ1Akoiw==", null, false, "666a6344-51bb-427b-8312-7c4d71b80f9f", false, "admin@lemadrid.com" },
                    { "ea1f3c45-5ad5-44a6-bdde-5dd557b27861", 0, null, "56a07f8b-b0d3-43c0-8114-7460adcee5df", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEKuMjgP6PMBySvAcAG2tn4J3/t7MDwJbYDdC0U8QfFVaPoMdzGgCjdms1VA3TzkjEQ==", null, false, "a70917b4-3992-4f1e-ae8a-ea9f28821cd8", false, "guest@user.com" },
                    { "51b0f748-f0a0-463f-987d-76b097bdb1a9", 0, "(450)-773-6800", "9125f955-dc7c-420a-9a85-3e4a0c9e036a", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEIUFfqs6BbtQSFGf+XsTIlSYYGRBFoiGUue8/lBbW5s5aulccVJZPj/L6yyZ55Q77Q==", null, false, "98b0634b-30c6-4518-8a72-a578f93c9b36", false, "hugo@lemadrid.com" },
                    { "640eb153-2d44-4ae1-a81a-d9139c077137", 0, "(450)-649-8594", "49a688ae-a185-4b35-aa20-03fcbec9288d", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEBawup79iEaYM32SFfgIBWfkZrK6LG3oRWhRZNGJE5UCzPnRyMVqRxwiWm3FMueR7g==", null, false, "873f8ff2-4ee3-4b1c-9b9f-78722aebcb85", false, "karl.mainville@lemadrid.com" },
                    { "518fb97d-4763-4442-bf3b-4ebd3a224f16", 0, "(450)-538-3982", "7945413c-01c2-4f98-b0c6-194319293d69", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAED9ZezF8qtIvW55K0sR9CIc+TfeHCWDXZMzL7EL/v5YgMstM5U+5Fi0Z9TsTiGtVDw==", null, false, "63f0fcbd-2cee-4992-b153-b7079da74711", false, "maxime.lefebvre@lemadrid.com" },
                    { "3433e156-4025-4fed-84f7-e5fb32f66654", 0, "(450)-213-5697", "bb11e9eb-c9d5-45e0-b1ee-6c3ccfd811a0", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEEu1W4pIERmT+tt6fN1YqIVDVURH/h0g101b8+3EJ8WuZ8g/PI8pgDFluWLIbNw76g==", null, false, "27474a07-27c3-4e3a-805f-7b90bea2ab8e", false, "louis.garceau@lemadrid.com" },
                    { "270d25e6-3f87-40ca-84ac-70971f71cebf", 0, "(450)-789-4673", "52b62097-ed8f-4cf7-a280-527468f43214", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEEAHdMphsYsZuPKXKpOb15xZPpy0YO+Qj6Tey/Su8WP6XW+OOplN9kcIyxjbYC92CQ==", null, false, "81096939-f0b7-4569-a185-5b4869a929a4", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("1d1d3838-bd6f-4322-b50a-4b8b484ba0a5"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "51b0f748-f0a0-463f-987d-76b097bdb1a9" },
                    { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "270d25e6-3f87-40ca-84ac-70971f71cebf" },
                    { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "3433e156-4025-4fed-84f7-e5fb32f66654" },
                    { new Guid("1d1d3838-bd6f-4322-b50a-4b8b484ba0a5"), "640eb153-2d44-4ae1-a81a-d9139c077137" },
                    { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "518fb97d-4763-4442-bf3b-4ebd3a224f16" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "09675e3f-86e4-4401-80b9-95f71f167ff7", "3433e156-4025-4fed-84f7-e5fb32f66654" },
                    { "290dd2cf-1cd7-4db7-a959-496c8153fd0c", "8ba46c3a-3b6b-401c-bb11-f36f69dc42f4" },
                    { "290dd2cf-1cd7-4db7-a959-496c8153fd0c", "ea1f3c45-5ad5-44a6-bdde-5dd557b27861" },
                    { "09675e3f-86e4-4401-80b9-95f71f167ff7", "51b0f748-f0a0-463f-987d-76b097bdb1a9" },
                    { "09675e3f-86e4-4401-80b9-95f71f167ff7", "640eb153-2d44-4ae1-a81a-d9139c077137" },
                    { "09675e3f-86e4-4401-80b9-95f71f167ff7", "518fb97d-4763-4442-bf3b-4ebd3a224f16" },
                    { "09675e3f-86e4-4401-80b9-95f71f167ff7", "270d25e6-3f87-40ca-84ac-70971f71cebf" }
                });

            migrationBuilder.InsertData(
                table: "Command",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Country", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "Status", "Total", "TotalDiscount", "TotalWithDiscount", "TotalWithTaxes" },
                values: new object[,]
                {
                    { new Guid("c9ae0cca-0b4f-4f50-bd72-c36a5b0dac45"), "400 Rue des maisons", "3433e156-4025-4fed-84f7-e5fb32f66654", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 48, 33, 207, DateTimeKind.Local).AddTicks(6831), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 0, 10000000m, 0m, 10000000m, 12500000m },
                    { new Guid("4aa62e92-9bab-4387-8707-780cc822481a"), "400 Rue des maisons", "3433e156-4025-4fed-84f7-e5fb32f66654", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 48, 33, 210, DateTimeKind.Local).AddTicks(709), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 1, 20000000m, 0m, 20000000m, 22500000m },
                    { new Guid("0bd19132-c791-443f-b182-09a75be8b619"), "400 Rue test", "3433e156-4025-4fed-84f7-e5fb32f66654", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 48, 33, 210, DateTimeKind.Local).AddTicks(734), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 50000000m, 0m, 50000000m, 52500000m },
                    { new Guid("6e507934-2d8b-4cf8-a76f-0825357be07e"), "400 Rue test", "3433e156-4025-4fed-84f7-e5fb32f66654", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 48, 33, 210, DateTimeKind.Local).AddTicks(740), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 30000000m, 0m, 30000000m, 32500000m },
                    { new Guid("3636db55-a948-4631-b155-5c13f16d9213"), "400 Rue test", "3433e156-4025-4fed-84f7-e5fb32f66654", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 48, 33, 210, DateTimeKind.Local).AddTicks(744), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 1, 80000000m, 0m, 80000000m, 82500000m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CommandProduct_Command_CommandId",
                table: "CommandProduct",
                column: "CommandId",
                principalTable: "Command",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandProduct_Command_CommandId",
                table: "CommandProduct");

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("1d1d3838-bd6f-4322-b50a-4b8b484ba0a5"), "640eb153-2d44-4ae1-a81a-d9139c077137" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "270d25e6-3f87-40ca-84ac-70971f71cebf" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "3433e156-4025-4fed-84f7-e5fb32f66654" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "518fb97d-4763-4442-bf3b-4ebd3a224f16" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"), "51b0f748-f0a0-463f-987d-76b097bdb1a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09675e3f-86e4-4401-80b9-95f71f167ff7", "270d25e6-3f87-40ca-84ac-70971f71cebf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09675e3f-86e4-4401-80b9-95f71f167ff7", "3433e156-4025-4fed-84f7-e5fb32f66654" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09675e3f-86e4-4401-80b9-95f71f167ff7", "518fb97d-4763-4442-bf3b-4ebd3a224f16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09675e3f-86e4-4401-80b9-95f71f167ff7", "51b0f748-f0a0-463f-987d-76b097bdb1a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09675e3f-86e4-4401-80b9-95f71f167ff7", "640eb153-2d44-4ae1-a81a-d9139c077137" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "290dd2cf-1cd7-4db7-a959-496c8153fd0c", "8ba46c3a-3b6b-401c-bb11-f36f69dc42f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "290dd2cf-1cd7-4db7-a959-496c8153fd0c", "ea1f3c45-5ad5-44a6-bdde-5dd557b27861" });

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("0bd19132-c791-443f-b182-09a75be8b619"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("3636db55-a948-4631-b155-5c13f16d9213"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("4aa62e92-9bab-4387-8707-780cc822481a"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("6e507934-2d8b-4cf8-a76f-0825357be07e"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("c9ae0cca-0b4f-4f50-bd72-c36a5b0dac45"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09675e3f-86e4-4401-80b9-95f71f167ff7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "290dd2cf-1cd7-4db7-a959-496c8153fd0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "270d25e6-3f87-40ca-84ac-70971f71cebf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3433e156-4025-4fed-84f7-e5fb32f66654");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "518fb97d-4763-4442-bf3b-4ebd3a224f16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51b0f748-f0a0-463f-987d-76b097bdb1a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "640eb153-2d44-4ae1-a81a-d9139c077137");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ba46c3a-3b6b-401c-bb11-f36f69dc42f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea1f3c45-5ad5-44a6-bdde-5dd557b27861");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("1d1d3838-bd6f-4322-b50a-4b8b484ba0a5"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("ce4337c6-3936-44ff-83a2-d048bd89511b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CommandId",
                table: "CommandProduct",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ca3807d-29b9-4410-886f-18709a191b15", "f6cb5bfa-4074-4bcb-ba7f-cd712e088952", "admin", "ADMIN" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "775d859d-e510-4b88-9558-3feaaf49efad", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d588f88-8891-4881-9e92-1dcf1ada336b", 0, null, "416f1491-e504-4dbe-9dad-0ebd5a281cde", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEGfhL5MEU/Bi7WlxmI5ySy7TGUf5QxUIu0mRKDYDl+onNx74kkuG8wIp7SjtcZs9ag==", null, false, "2df2a2f8-c288-40f8-bcab-fc45f1d3ef96", false, "admin@lemadrid.com" },
                    { "be4e02e8-e93d-4ce0-927e-eb05804c2fab", 0, null, "eb27d116-da26-49ad-a9e7-d3458b9060e1", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEF4doCN4tqFuXyJQKlPWRusC6sw1t61K2eA0yhtGRGacCvY/0ocBaJowrJ9xaKxhDQ==", null, false, "30fccd7b-6772-4ea3-953a-e491b70eb2ad", false, "guest@user.com" },
                    { "3ca20e43-1302-408b-9775-788262e33573", 0, "(450)-773-6800", "46cae0de-e74b-4e61-8eec-08837d82f839", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAELldiWAY4d/5RJj3p3LOPmTcAD8w7/ZowGmdLB4KELlU/9J+uRg3txji6faJxb/y6w==", null, false, "bfb484ca-a314-4451-92ab-77a2170da544", false, "hugo@lemadrid.com" },
                    { "480cc716-b2b5-47a2-a439-a7e6df1ecd5c", 0, "(450)-649-8594", "6205e6b3-89a6-4dbc-82b9-65ca407c3617", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEEHJjxD7vCDzYdIHuXxDydK+ys6ypKOfqFQ//ZBihAbz7+DTg658A0JNyyUlyuDnrQ==", null, false, "d0f1646c-bd14-4303-b798-02de7a0bbcbd", false, "karl.mainville@lemadrid.com" },
                    { "5bba8c0c-af5d-4118-bd24-34202df99eac", 0, "(450)-538-3982", "dbc7b983-2f76-4131-8783-4a24e4941e17", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEMOE/wuLfn5fT2/fLUWx/sX4GXj3HvwkoM/lbuJ6XAMHLYkCgb5TCZ7ak8OGwTJBVA==", null, false, "a9052e52-d44b-46bb-97f3-b8af3c01a9d4", false, "maxime.lefebvre@lemadrid.com" },
                    { "efb092d4-f926-4603-9c7a-f2515103d89f", 0, "(450)-213-5697", "dccbe3f4-29f3-4eb8-b4d5-4f9d52de03cc", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEEZo2fO1DW5kyyyH9AC22XRRZ7zbYRjeY+svbk6UCrUL6CDm8dx1UDVfKMTMjB854w==", null, false, "9534916b-b7b7-481b-ab63-3461c27ec4d0", false, "louis.garceau@lemadrid.com" },
                    { "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82", 0, "(450)-789-4673", "f6bdc709-58a7-4f23-a9b5-36c7c38cb720", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEPmTz2PZueJOJTIznm8frtyDDPzoDXy8vBlel123/EvkKhIziEbkvF7GPxIrz7I4ig==", null, false, "32fa72e0-962a-4a21-98f6-698d8939fcf3", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "3ca20e43-1302-408b-9775-788262e33573" },
                    { new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"), "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" },
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "5bba8c0c-af5d-4118-bd24-34202df99eac" },
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "efb092d4-f926-4603-9c7a-f2515103d89f" },
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0ca3807d-29b9-4410-886f-18709a191b15", "6d588f88-8891-4881-9e92-1dcf1ada336b" },
                    { "0ca3807d-29b9-4410-886f-18709a191b15", "be4e02e8-e93d-4ce0-927e-eb05804c2fab" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "3ca20e43-1302-408b-9775-788262e33573" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "5bba8c0c-af5d-4118-bd24-34202df99eac" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "efb092d4-f926-4603-9c7a-f2515103d89f" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CommandProduct_Command_CommandId",
                table: "CommandProduct",
                column: "CommandId",
                principalTable: "Command",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
