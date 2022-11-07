using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test20000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "500d63ef-34ca-44e8-907a-563e150df9cd" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "780b1d3a-2393-420d-a8da-47b7e79874f6" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "a51f88a8-8ea5-41ad-b690-a88775d78d94" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "c7d5a1c3-7717-40db-9682-07bcd2e862de" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("eae3ea43-fc52-498b-946e-5f2de169fbc3"), "0b2c15de-d6cf-4653-88d0-7fe1fef6075e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "0b2c15de-d6cf-4653-88d0-7fe1fef6075e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "500d63ef-34ca-44e8-907a-563e150df9cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "780b1d3a-2393-420d-a8da-47b7e79874f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "a51f88a8-8ea5-41ad-b690-a88775d78d94" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "c7d5a1c3-7717-40db-9682-07bcd2e862de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b19c9f56-ae3c-4f3c-baff-ac16e3f51947", "e1fb517d-f356-4671-ac1b-5bb41999300d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b19c9f56-ae3c-4f3c-baff-ac16e3f51947", "e44c0e2d-cd74-47a6-a746-696f46518572" });

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("295482cf-f7fa-45bb-aa3b-bb0f8bdad1e2"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("51320e52-e219-4480-9aa4-75c163f54a8d"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("9691693e-818c-43ca-a344-942b90e3f56f"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("969ec8a2-ce09-44d5-b09c-c835d24446be"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("e1dd7ebf-6cc6-45e9-831d-b6be88d4eeaf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b19c9f56-ae3c-4f3c-baff-ac16e3f51947");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b2c15de-d6cf-4653-88d0-7fe1fef6075e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "500d63ef-34ca-44e8-907a-563e150df9cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a51f88a8-8ea5-41ad-b690-a88775d78d94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7d5a1c3-7717-40db-9682-07bcd2e862de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1fb517d-f356-4671-ac1b-5bb41999300d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e44c0e2d-cd74-47a6-a746-696f46518572");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("eae3ea43-fc52-498b-946e-5f2de169fbc3"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("2727744d-d1e7-4096-b5ea-115f5ecd1964"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("3a4ccbb4-a27f-4002-b332-2faf0326bc2f"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("4140254f-e712-4d62-9255-86f5579f7c38"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("58096430-eafe-4daa-8a14-b403923a486c"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("e67059cc-89b7-4188-9745-5f523cf0e7e2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "780b1d3a-2393-420d-a8da-47b7e79874f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dab2b3ea-4e0e-4440-9592-e97727120a36", "92815d6d-868f-41cd-af25-42ae3feee5f7", "admin", "ADMIN" },
                    { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "d3dd8f9e-f6e6-4fcb-a32f-dff337136fd4", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d64ec9f-c316-45b3-87e6-945d157c7d1d", 0, null, "6309fbf0-b437-4791-b299-7720cbe835c1", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAELE/qgyxgNo/9l8Jgc9rtopLJRw7P8AyP6EJZuboDasE7bPyDFznrNh/7Jv+l/NAQg==", null, false, "32bb0e12-272f-4e31-8806-01db79b8f2e5", false, "admin@lemadrid.com" },
                    { "d68faec3-ea94-4803-ac77-c37baabb6909", 0, null, "f4e6044b-665b-4832-805e-4aae467372be", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEI5Jjjc/ijId5EGt+rto4v4PhVlgeYyJwvebJNUHg0KP/TPig8whFbYNj6+0Vrghqw==", null, false, "aee4e9fe-1f3c-4287-a1f2-bef503bcbe1b", false, "guest@user.com" },
                    { "639b9647-84e2-490e-b31b-ab9d5512cbed", 0, "(450)-773-6800", "b66bb28f-c6c6-4c40-906f-2c0650fbba38", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEOjo1+NqWq1ZZCZ6ocnYQTyPASx/FTFUFj/0gDfCwAPCxWv8OczibADTSE0PyhucRg==", null, false, "7835f13b-f358-427f-8b4f-0f37ec09d9f8", false, "hugo@lemadrid.com" },
                    { "b5053a34-f24b-4111-8b2c-6a549e3878c5", 0, "(450)-649-8594", "cfd37989-04e6-46e3-a16c-afa8c40bb715", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAECCu8jf0RvnorzPBKMTxEvJAIjgLZVVc9gbL6NjGRh2ECECZKTvPuIpG8F+iXxCCug==", null, false, "9cd585c0-6aa4-4c68-b46c-3f84da4878d5", false, "karl.mainville@lemadrid.com" },
                    { "02ceaec3-276c-44dd-ae2d-40137eb6e505", 0, "(450)-538-3982", "59240729-9864-495d-89fd-b76d278c7c80", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEMGF3jTgygsXPmbZ9yBRQUfWvWMNfkzKHiABf5g2Hk5B95/Bwm6xU2mNaiTlNR04KQ==", null, false, "efff98a0-2ab9-40a5-9a3d-7b102eb1a6f5", false, "maxime.lefebvre@lemadrid.com" },
                    { "5486cbbe-fe66-4829-aad1-c016d9cfbc3f", 0, "(450)-213-5697", "990a8213-76c4-499c-9693-0af3c57ed54d", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEJuFbXI4GRJdqNcjL1HgwXwLQWnueAQ+hbpXQUYMLfF4TpuH5ReKy3QJEREDwaoplg==", null, false, "67b07fc9-edcf-4858-a4ff-ae0655b71cf2", false, "louis.garceau@lemadrid.com" },
                    { "884f2f91-f7d9-4e3d-8f2e-b8b582a98579", 0, "(450)-789-4673", "753e1733-3907-44d4-9f43-74eb08023796", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEOo9cXGxvkYG0PiHwi4DCwMpTs/hVSUYNS7shvkC16BheWeX++PjPbeU4YNjJqq/oQ==", null, false, "d6720833-716c-4477-b92c-ce5b3c269e20", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("85307633-f1ec-404c-a71f-735e71b5e5c2"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "639b9647-84e2-490e-b31b-ab9d5512cbed" },
                    { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "884f2f91-f7d9-4e3d-8f2e-b8b582a98579" },
                    { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "5486cbbe-fe66-4829-aad1-c016d9cfbc3f" },
                    { new Guid("85307633-f1ec-404c-a71f-735e71b5e5c2"), "b5053a34-f24b-4111-8b2c-6a549e3878c5" },
                    { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "02ceaec3-276c-44dd-ae2d-40137eb6e505" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f" },
                    { "dab2b3ea-4e0e-4440-9592-e97727120a36", "1d64ec9f-c316-45b3-87e6-945d157c7d1d" },
                    { "dab2b3ea-4e0e-4440-9592-e97727120a36", "d68faec3-ea94-4803-ac77-c37baabb6909" },
                    { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "639b9647-84e2-490e-b31b-ab9d5512cbed" },
                    { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "b5053a34-f24b-4111-8b2c-6a549e3878c5" },
                    { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "02ceaec3-276c-44dd-ae2d-40137eb6e505" },
                    { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "884f2f91-f7d9-4e3d-8f2e-b8b582a98579" }
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Country", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "Status", "Total", "TotalDiscount", "TotalWithDiscount", "TotalWithTaxes" },
                values: new object[,]
                {
                    { new Guid("8e3e84e0-6597-4068-ae4f-98f9f633bb86"), "400 Rue des maisons", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 7, 10, 54, 22, 470, DateTimeKind.Local).AddTicks(2426), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 0, 10000000m, 0m, 10000000m, 12500000m },
                    { new Guid("0b976030-af64-4903-8059-9cd962e4ca6a"), "400 Rue des maisons", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 7, 10, 54, 22, 472, DateTimeKind.Local).AddTicks(9761), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 1, 20000000m, 0m, 20000000m, 22500000m },
                    { new Guid("1d2d6bdb-594c-42eb-906c-fbdb2b6b0ee7"), "400 Rue test", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 7, 10, 54, 22, 472, DateTimeKind.Local).AddTicks(9798), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 50000000m, 0m, 50000000m, 52500000m },
                    { new Guid("902723ed-ef6b-4a77-bbac-f0093bdbdc2f"), "400 Rue test", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 7, 10, 54, 22, 472, DateTimeKind.Local).AddTicks(9805), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 30000000m, 0m, 30000000m, 32500000m },
                    { new Guid("f534d311-f6a0-43c8-8896-fdfb6528119b"), "400 Rue test", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 7, 10, 54, 22, 472, DateTimeKind.Local).AddTicks(9810), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 1, 80000000m, 0m, 80000000m, 82500000m }
                });

            migrationBuilder.InsertData(
                table: "CommandProducts",
                columns: new[] { "Id", "CommandId", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { new Guid("377de87d-1b0c-441a-b646-77394e431475"), new Guid("8e3e84e0-6597-4068-ae4f-98f9f633bb86"), 1, 4 },
                    { new Guid("5f3beff1-af89-4f8c-b051-ca9bce93f4ef"), new Guid("0b976030-af64-4903-8059-9cd962e4ca6a"), 10, 2 },
                    { new Guid("29f309c8-11f4-40dc-81d2-f205393956f1"), new Guid("1d2d6bdb-594c-42eb-906c-fbdb2b6b0ee7"), 30, 1 },
                    { new Guid("857ef119-b714-466a-a9f3-bbc21e67e933"), new Guid("902723ed-ef6b-4a77-bbac-f0093bdbdc2f"), 5, 2 },
                    { new Guid("7197fa3a-2729-45cc-a8c2-4194a075fd86"), new Guid("f534d311-f6a0-43c8-8896-fdfb6528119b"), 40, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("85307633-f1ec-404c-a71f-735e71b5e5c2"), "b5053a34-f24b-4111-8b2c-6a549e3878c5" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "02ceaec3-276c-44dd-ae2d-40137eb6e505" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "5486cbbe-fe66-4829-aad1-c016d9cfbc3f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "639b9647-84e2-490e-b31b-ab9d5512cbed" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("da478d5c-4532-41cf-a623-994414ad143c"), "884f2f91-f7d9-4e3d-8f2e-b8b582a98579" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "02ceaec3-276c-44dd-ae2d-40137eb6e505" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dab2b3ea-4e0e-4440-9592-e97727120a36", "1d64ec9f-c316-45b3-87e6-945d157c7d1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "5486cbbe-fe66-4829-aad1-c016d9cfbc3f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "639b9647-84e2-490e-b31b-ab9d5512cbed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "884f2f91-f7d9-4e3d-8f2e-b8b582a98579" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0fc9da6-b98c-42d9-86ce-4094cc03b996", "b5053a34-f24b-4111-8b2c-6a549e3878c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dab2b3ea-4e0e-4440-9592-e97727120a36", "d68faec3-ea94-4803-ac77-c37baabb6909" });

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("29f309c8-11f4-40dc-81d2-f205393956f1"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("377de87d-1b0c-441a-b646-77394e431475"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("5f3beff1-af89-4f8c-b051-ca9bce93f4ef"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("7197fa3a-2729-45cc-a8c2-4194a075fd86"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("857ef119-b714-466a-a9f3-bbc21e67e933"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0fc9da6-b98c-42d9-86ce-4094cc03b996");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dab2b3ea-4e0e-4440-9592-e97727120a36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ceaec3-276c-44dd-ae2d-40137eb6e505");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d64ec9f-c316-45b3-87e6-945d157c7d1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "639b9647-84e2-490e-b31b-ab9d5512cbed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "884f2f91-f7d9-4e3d-8f2e-b8b582a98579");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5053a34-f24b-4111-8b2c-6a549e3878c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d68faec3-ea94-4803-ac77-c37baabb6909");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("85307633-f1ec-404c-a71f-735e71b5e5c2"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("da478d5c-4532-41cf-a623-994414ad143c"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("0b976030-af64-4903-8059-9cd962e4ca6a"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("1d2d6bdb-594c-42eb-906c-fbdb2b6b0ee7"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("8e3e84e0-6597-4068-ae4f-98f9f633bb86"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("902723ed-ef6b-4a77-bbac-f0093bdbdc2f"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("f534d311-f6a0-43c8-8896-fdfb6528119b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5486cbbe-fe66-4829-aad1-c016d9cfbc3f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b19c9f56-ae3c-4f3c-baff-ac16e3f51947", "8edfe310-c20d-4abc-bb67-a74194141884", "admin", "ADMIN" },
                    { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "abda965f-216a-41a8-a3ac-c86f62c62b87", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e1fb517d-f356-4671-ac1b-5bb41999300d", 0, null, "dcf24c2f-c892-4ca3-af33-1f040ae80d1f", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAELJi0d0slCAd/4cWJrZiOXZHiE2Xq4jWwmDG1jnkFyT34GCMwO4sYMKbO+CnT/eq4Q==", null, false, "a75e987a-45a8-4a3c-8907-53e7893b7ed0", false, "admin@lemadrid.com" },
                    { "e44c0e2d-cd74-47a6-a746-696f46518572", 0, null, "00cfeb39-ff9f-448f-bbc1-9dedae88ef8f", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAENuWGE7WA5pSqTLerEDQvMFJ/X9iag9a5z4nx3LSmO7iQtfKlaBfGe21ZZhQNGh1Ew==", null, false, "aaa8ac17-963a-40a4-b016-ffa99d5e7a00", false, "guest@user.com" },
                    { "500d63ef-34ca-44e8-907a-563e150df9cd", 0, "(450)-773-6800", "a766b828-3fab-4604-945a-4a849f84fd03", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEFfjBhB/YseLaiQou/WB+DksuBvjZ9dwgc22CQjLKSN/Sho38Rgris3NxRPi+DWuoA==", null, false, "dda17b27-5142-4895-9afe-c4230b2a9566", false, "hugo@lemadrid.com" },
                    { "0b2c15de-d6cf-4653-88d0-7fe1fef6075e", 0, "(450)-649-8594", "25186218-13f0-4658-9667-a0e672aee14d", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEGVelJEBIfVoGzRaudyeazPZOXgphwuAawo4yizbN7KumqkZCHj3YoEUiEhMhHA1Qg==", null, false, "d277efc3-ead8-4f5e-a2bb-0b85b0a72c72", false, "karl.mainville@lemadrid.com" },
                    { "a51f88a8-8ea5-41ad-b690-a88775d78d94", 0, "(450)-538-3982", "825cad3a-0324-4e47-956f-cd07c2dd942d", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEFALP5R/Lul2euUDPRGyblvAOQwmJO3mn3MZwG088err2L/dCPHvir2oPC/y5lUhRg==", null, false, "0e3b88a2-96e1-4c97-8eee-ae4979c76791", false, "maxime.lefebvre@lemadrid.com" },
                    { "780b1d3a-2393-420d-a8da-47b7e79874f6", 0, "(450)-213-5697", "d20aed48-488f-4bca-bfda-810dc345a2a9", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEPTH8zNMf05gx/y2btqNVRsTdoiw8QwObKpfA0NfKDB+KP8ki5+w6Z50HCJdcOQYnQ==", null, false, "3b7ad808-e626-4114-ad4b-d2aaa263a388", false, "louis.garceau@lemadrid.com" },
                    { "c7d5a1c3-7717-40db-9682-07bcd2e862de", 0, "(450)-789-4673", "a2263ca5-8568-4775-a86b-38ff1d1bba01", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEKy93q62zOhg//7vhAOblz6UK/WP0py2KeA5Z1PHbBbzsOeCvPTIorH4qgiWYx842g==", null, false, "d999caae-fb16-4afd-9f1b-0b040df21a2a", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("eae3ea43-fc52-498b-946e-5f2de169fbc3"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "500d63ef-34ca-44e8-907a-563e150df9cd" },
                    { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "c7d5a1c3-7717-40db-9682-07bcd2e862de" },
                    { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "780b1d3a-2393-420d-a8da-47b7e79874f6" },
                    { new Guid("eae3ea43-fc52-498b-946e-5f2de169fbc3"), "0b2c15de-d6cf-4653-88d0-7fe1fef6075e" },
                    { new Guid("8126c70f-74c8-4987-b93f-8af77f6fab01"), "a51f88a8-8ea5-41ad-b690-a88775d78d94" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "780b1d3a-2393-420d-a8da-47b7e79874f6" },
                    { "b19c9f56-ae3c-4f3c-baff-ac16e3f51947", "e1fb517d-f356-4671-ac1b-5bb41999300d" },
                    { "b19c9f56-ae3c-4f3c-baff-ac16e3f51947", "e44c0e2d-cd74-47a6-a746-696f46518572" },
                    { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "500d63ef-34ca-44e8-907a-563e150df9cd" },
                    { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "0b2c15de-d6cf-4653-88d0-7fe1fef6075e" },
                    { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "a51f88a8-8ea5-41ad-b690-a88775d78d94" },
                    { "dc16dd8e-d3a1-46dd-8759-fb39244b1eb5", "c7d5a1c3-7717-40db-9682-07bcd2e862de" }
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Country", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "Status", "Total", "TotalDiscount", "TotalWithDiscount", "TotalWithTaxes" },
                values: new object[,]
                {
                    { new Guid("58096430-eafe-4daa-8a14-b403923a486c"), "400 Rue des maisons", "780b1d3a-2393-420d-a8da-47b7e79874f6", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 13, 32, 29, 683, DateTimeKind.Local).AddTicks(339), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 0, 10000000m, 0m, 10000000m, 12500000m },
                    { new Guid("3a4ccbb4-a27f-4002-b332-2faf0326bc2f"), "400 Rue des maisons", "780b1d3a-2393-420d-a8da-47b7e79874f6", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 13, 32, 29, 685, DateTimeKind.Local).AddTicks(3543), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", 1, 20000000m, 0m, 20000000m, 22500000m },
                    { new Guid("2727744d-d1e7-4096-b5ea-115f5ecd1964"), "400 Rue test", "780b1d3a-2393-420d-a8da-47b7e79874f6", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 13, 32, 29, 685, DateTimeKind.Local).AddTicks(3582), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 50000000m, 0m, 50000000m, 52500000m },
                    { new Guid("4140254f-e712-4d62-9255-86f5579f7c38"), "400 Rue test", "780b1d3a-2393-420d-a8da-47b7e79874f6", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 13, 32, 29, 685, DateTimeKind.Local).AddTicks(3590), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 0, 30000000m, 0m, 30000000m, 32500000m },
                    { new Guid("e67059cc-89b7-4188-9745-5f523cf0e7e2"), "400 Rue test", "780b1d3a-2393-420d-a8da-47b7e79874f6", "Saint-Hyacinthe", "Canada", new DateTime(2022, 11, 6, 13, 32, 29, 685, DateTimeKind.Local).AddTicks(3595), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", 1, 80000000m, 0m, 80000000m, 82500000m }
                });

            migrationBuilder.InsertData(
                table: "CommandProducts",
                columns: new[] { "Id", "CommandId", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { new Guid("969ec8a2-ce09-44d5-b09c-c835d24446be"), new Guid("58096430-eafe-4daa-8a14-b403923a486c"), 1, 4 },
                    { new Guid("e1dd7ebf-6cc6-45e9-831d-b6be88d4eeaf"), new Guid("3a4ccbb4-a27f-4002-b332-2faf0326bc2f"), 10, 2 },
                    { new Guid("9691693e-818c-43ca-a344-942b90e3f56f"), new Guid("2727744d-d1e7-4096-b5ea-115f5ecd1964"), 30, 1 },
                    { new Guid("51320e52-e219-4480-9aa4-75c163f54a8d"), new Guid("4140254f-e712-4d62-9255-86f5579f7c38"), 5, 2 },
                    { new Guid("295482cf-f7fa-45bb-aa3b-bb0f8bdad1e2"), new Guid("e67059cc-89b7-4188-9745-5f523cf0e7e2"), 40, 1 }
                });
        }
    }
}
