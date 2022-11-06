using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class testing8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee051003-41e9-4d6b-bfc4-7bd7c14b8537", "43833378-7a71-4382-8f8c-5035f9226ee8", "admin", "ADMIN" },
                    { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "09e53836-f8a8-418f-9db8-8c8951752e95", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6e699009-5e12-44c4-be26-b53ffb3a8d97", 0, null, "b2cc5f3f-70b2-428c-9e39-21eba1388564", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEBihFX+WQEWTnhwq7jirD1DWHdOlrboHFsvskDUr3BTfdYKISMXHQp/X/g3jt4c3kQ==", null, false, "0583515e-6e68-4025-9605-3b8daaefeb5f", false, "admin@lemadrid.com" },
                    { "a404318f-a8c6-4546-bb63-d67c79cf40d2", 0, null, "6e77c29d-38cc-44bd-ab34-0176cb6dbb57", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEI3eL2J9PqmNKhVlJ76A2DDTni3Yc8CmRkqbVfbRvqZK0VlqIArJm0DpFBg023+bpw==", null, false, "cdac961a-72c3-4e09-89d6-7e6d166c50f9", false, "guest@user.com" },
                    { "5e02561a-0016-4d66-b955-08ae0dca4dd2", 0, "(450)-773-6800", "38e821ce-fef8-45cd-91a4-d283e87204ed", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEFAz9jjD/WmKl5ikckPthCrby1Cyj1cN+r+rfW/wP6k9sNZ91UOpRSlB2P5dUnYdrQ==", null, false, "3782c1c2-de62-4899-8f45-46183e77563f", false, "hugo@lemadrid.com" },
                    { "08d4e1e0-12cb-4801-b342-b258d7f2a916", 0, "(450)-649-8594", "26684b44-da9f-4b34-90c2-b405ee83b5e8", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEEv6BfV+pe0MR+QCJ+Z0zhRNsRDq6Dn/bDvKMZnDW7Kbv8OUUWbP9RoDjAX0f7iKQw==", null, false, "966c0bac-8b91-49fe-8f60-81a1289d5c67", false, "karl.mainville@lemadrid.com" },
                    { "a3c98ebd-c0ee-4077-8454-7b08857b5c71", 0, "(450)-538-3982", "60bb6350-3c67-461e-b7e9-a1d2f4095876", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAENkKi7UB7QwkBMnra9Im6aZkon3kgBc3tXatysMUzOXUNP9V8ThASULoAXLSVER7sQ==", null, false, "2ded2d3d-383e-4378-8170-c435334c32ff", false, "maxime.lefebvre@lemadrid.com" },
                    { "708e1ef7-f04a-4f18-ae19-56a114569010", 0, "(450)-213-5697", "9590a6b7-6cc5-4769-b8d3-c03005f35ee9", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEL69uwRWNuROsMSwtIupK47r0I23Ru5HlrpXJB/7ie8kEbTG8o1rkcINUCn0N09s0w==", null, false, "0130d7a9-a2bb-4c6d-b819-eb43ac637148", false, "louis.garceau@lemadrid.com" },
                    { "7bcde453-c7dd-40f3-b578-56ebe30784b1", 0, "(450)-789-4673", "510079c8-28a3-47a2-a6fd-698d13421542", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEGswcQtF2S5K7CRc81EeGfpoO/zUhLrPVh8c8QcCnx1x3oo0MEqwAw0NvRkZeLV3hg==", null, false, "e9ee4276-566d-4840-8bea-d2646f200bca", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("4d50d768-21b8-43b9-a2a2-2d76eb56e4fe"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "5e02561a-0016-4d66-b955-08ae0dca4dd2" },
                    { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "7bcde453-c7dd-40f3-b578-56ebe30784b1" },
                    { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "708e1ef7-f04a-4f18-ae19-56a114569010" },
                    { new Guid("4d50d768-21b8-43b9-a2a2-2d76eb56e4fe"), "08d4e1e0-12cb-4801-b342-b258d7f2a916" },
                    { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "a3c98ebd-c0ee-4077-8454-7b08857b5c71" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "708e1ef7-f04a-4f18-ae19-56a114569010" },
                    { "ee051003-41e9-4d6b-bfc4-7bd7c14b8537", "6e699009-5e12-44c4-be26-b53ffb3a8d97" },
                    { "ee051003-41e9-4d6b-bfc4-7bd7c14b8537", "a404318f-a8c6-4546-bb63-d67c79cf40d2" },
                    { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "5e02561a-0016-4d66-b955-08ae0dca4dd2" },
                    { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "08d4e1e0-12cb-4801-b342-b258d7f2a916" },
                    { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "a3c98ebd-c0ee-4077-8454-7b08857b5c71" },
                    { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "7bcde453-c7dd-40f3-b578-56ebe30784b1" }
                });

            migrationBuilder.InsertData(
                table: "Command",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Country", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "Status", "Total", "TotalDiscount", "TotalWithDiscount", "TotalWithTaxes" },
                values: new object[,]
                {
                    { new Guid("fca079e9-a566-4a99-88af-d5013f699266"), "400 Rue des maisons", "708e1ef7-f04a-4f18-ae19-56a114569010", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 50, 16, 7, DateTimeKind.Local).AddTicks(4665), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 0, 10000000m, 0m, 10000000m, 12500000m },
                    { new Guid("e904e2f6-86b9-40cb-b1f3-317bc4776fcb"), "400 Rue des maisons", "708e1ef7-f04a-4f18-ae19-56a114569010", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 50, 16, 9, DateTimeKind.Local).AddTicks(7390), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 1, 20000000m, 0m, 20000000m, 22500000m },
                    { new Guid("11c839b1-eef0-4921-9739-fcaf5ab1de6b"), "400 Rue test", "708e1ef7-f04a-4f18-ae19-56a114569010", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 50, 16, 9, DateTimeKind.Local).AddTicks(7422), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 50000000m, 0m, 50000000m, 52500000m },
                    { new Guid("b84e3705-eaee-4394-9d42-c9efa163b5af"), "400 Rue test", "708e1ef7-f04a-4f18-ae19-56a114569010", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 50, 16, 9, DateTimeKind.Local).AddTicks(7429), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 30000000m, 0m, 30000000m, 32500000m },
                    { new Guid("b8fdf8d6-afff-4e00-a79f-859181873e6d"), "400 Rue test", "708e1ef7-f04a-4f18-ae19-56a114569010", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 11, 50, 16, 9, DateTimeKind.Local).AddTicks(7433), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 1, 80000000m, 0m, 80000000m, 82500000m }
                });

            migrationBuilder.InsertData(
                table: "CommandProduct",
                columns: new[] { "Id", "CommandId", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { new Guid("d3f6b56b-e046-4c5d-aaf0-01f7fffa705c"), new Guid("fca079e9-a566-4a99-88af-d5013f699266"), 1, 4 },
                    { new Guid("9874d5c3-8485-4b5a-bc48-7f9649380c00"), new Guid("e904e2f6-86b9-40cb-b1f3-317bc4776fcb"), 10, 2 },
                    { new Guid("c109de44-3064-48b6-a09f-6c247ea6da8a"), new Guid("11c839b1-eef0-4921-9739-fcaf5ab1de6b"), 30, 1 },
                    { new Guid("1ff1c076-28cb-4291-8285-bb749c0d8acf"), new Guid("b84e3705-eaee-4394-9d42-c9efa163b5af"), 5, 2 },
                    { new Guid("5bb71d1b-fe42-4961-b710-0cc872b6f913"), new Guid("b8fdf8d6-afff-4e00-a79f-859181873e6d"), 40, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("4d50d768-21b8-43b9-a2a2-2d76eb56e4fe"), "08d4e1e0-12cb-4801-b342-b258d7f2a916" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "5e02561a-0016-4d66-b955-08ae0dca4dd2" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "708e1ef7-f04a-4f18-ae19-56a114569010" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "7bcde453-c7dd-40f3-b578-56ebe30784b1" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"), "a3c98ebd-c0ee-4077-8454-7b08857b5c71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "08d4e1e0-12cb-4801-b342-b258d7f2a916" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "5e02561a-0016-4d66-b955-08ae0dca4dd2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee051003-41e9-4d6b-bfc4-7bd7c14b8537", "6e699009-5e12-44c4-be26-b53ffb3a8d97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "708e1ef7-f04a-4f18-ae19-56a114569010" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "7bcde453-c7dd-40f3-b578-56ebe30784b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "299df8e5-6fd8-44c4-9b72-5bf7959964e9", "a3c98ebd-c0ee-4077-8454-7b08857b5c71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee051003-41e9-4d6b-bfc4-7bd7c14b8537", "a404318f-a8c6-4546-bb63-d67c79cf40d2" });

            migrationBuilder.DeleteData(
                table: "CommandProduct",
                keyColumn: "Id",
                keyValue: new Guid("1ff1c076-28cb-4291-8285-bb749c0d8acf"));

            migrationBuilder.DeleteData(
                table: "CommandProduct",
                keyColumn: "Id",
                keyValue: new Guid("5bb71d1b-fe42-4961-b710-0cc872b6f913"));

            migrationBuilder.DeleteData(
                table: "CommandProduct",
                keyColumn: "Id",
                keyValue: new Guid("9874d5c3-8485-4b5a-bc48-7f9649380c00"));

            migrationBuilder.DeleteData(
                table: "CommandProduct",
                keyColumn: "Id",
                keyValue: new Guid("c109de44-3064-48b6-a09f-6c247ea6da8a"));

            migrationBuilder.DeleteData(
                table: "CommandProduct",
                keyColumn: "Id",
                keyValue: new Guid("d3f6b56b-e046-4c5d-aaf0-01f7fffa705c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "299df8e5-6fd8-44c4-9b72-5bf7959964e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee051003-41e9-4d6b-bfc4-7bd7c14b8537");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08d4e1e0-12cb-4801-b342-b258d7f2a916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e02561a-0016-4d66-b955-08ae0dca4dd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e699009-5e12-44c4-be26-b53ffb3a8d97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bcde453-c7dd-40f3-b578-56ebe30784b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3c98ebd-c0ee-4077-8454-7b08857b5c71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a404318f-a8c6-4546-bb63-d67c79cf40d2");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("4d50d768-21b8-43b9-a2a2-2d76eb56e4fe"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("7561ea0b-2072-4066-8093-a90eda2ae8dc"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("11c839b1-eef0-4921-9739-fcaf5ab1de6b"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("b84e3705-eaee-4394-9d42-c9efa163b5af"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("b8fdf8d6-afff-4e00-a79f-859181873e6d"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("e904e2f6-86b9-40cb-b1f3-317bc4776fcb"));

            migrationBuilder.DeleteData(
                table: "Command",
                keyColumn: "Id",
                keyValue: new Guid("fca079e9-a566-4a99-88af-d5013f699266"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "708e1ef7-f04a-4f18-ae19-56a114569010");

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
        }
    }
}
