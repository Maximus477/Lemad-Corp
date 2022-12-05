using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class tester : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FinalCardNumbers",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptName",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2bb1fa6-b55c-4d05-8b7c-4df1cffdf5ba", "d9d47c1d-86da-4b7e-ae1e-566e5376a972", "admin", "ADMIN" },
                    { "b216b726-1a5c-490a-bda0-14f34a052bdb", "e04f7d99-e0ad-47b0-b0dc-10745e508be4", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b4eb4fb-921d-4080-a9ec-b15c360a6654", 0, null, "bf92e407-8750-4a18-9aae-dce80f93c0b9", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEFc9kvq7bF4oJo3XizCfjorPUWJd00xgl1iKto4sEwryi4IzqVjUy1K94Id+gnV4MA==", null, false, "8d13df2d-590c-42b6-9e7a-bbc4046db791", false, "admin@lemadrid.com" },
                    { "711b1af2-1d2c-4b1c-bfff-571f0078b7aa", 0, null, "0d56f0f9-6adb-4238-8fe0-fd0f1e67d2fb", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEOGgW1NU1nFmY8GIpTETGddV9Ggw51osG47gnsUQTfCC4DrpB3NSQX013wMKVIcfTw==", null, false, "38d6f8fc-eaca-42f6-9189-d8b823da505f", false, "guest@user.com" },
                    { "4edfe2dd-596d-4046-beb9-bc840a667079", 0, "(450)-773-6800", "41a46432-4e36-4336-81a7-20da20c1d02f", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEL//bZnvSNJKCkat+HRLvwOMys3sYulD8oPFlfTE3K+BaMiSiSxs4jc4PX7YXM0vCA==", null, false, "81519c57-c8bb-460e-a149-c56041c01b10", false, "hugo@lemadrid.com" },
                    { "9ece2b39-e699-4b16-8f97-d51d5c2b7a59", 0, "(450)-649-8594", "b9bb8081-3ef4-421f-9015-87500d1160bc", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEFUgkor9SyaUaXBr92LpwC/dsk26E2Nlh3YvRI9xp6tbYSV0rF7TlPDPB12oEKmi5Q==", null, false, "909fff90-35c7-4db1-8116-109e18c4617d", false, "karl.mainville@lemadrid.com" },
                    { "b4081dc4-7381-4592-b7b0-66596a51e3d4", 0, "(450)-538-3982", "759a778c-0052-4c47-acc8-2e4b8afe18e9", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEKYNaGWdpFJR+kJ5yMtnx4NKr2fRYQR2pTwf73zGrm5saZnvhqxOE2mu4tyyj3iSfw==", null, false, "643c278d-903b-4e9c-a3db-f7e408e7779a", false, "maxime.lefebvre@lemadrid.com" },
                    { "9191ed31-60cb-40a7-b7fb-79e2057cf831", 0, "(450)-213-5697", "633bb270-7e33-4c6c-82ee-9e1f9198e349", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAECNedUmUPJvTkUeC/n0i8daYYoo3kRENe38IouWNm3OhWM91ppXLrynBOvKslFg0wA==", null, false, "aa6539a3-7f29-4f8c-b1c0-5644f115efa2", false, "louis.garceau@lemadrid.com" },
                    { "b2c07821-5a4c-4f1f-a6c6-bcdcc43e43c3", 0, "(450)-789-4673", "3c5e8c2b-f0b2-4de5-aead-6f8f01223d8c", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAELpd7eb0mNZVAxPwNyhqsUR+EHH7f0Fv9OP2ORhK8WN6TxFydYz/IhkDL68XPD6oow==", null, false, "6b13ce2d-95cd-4127-91c0-38efb58b13e7", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("7fddd593-b53e-45e4-bb28-2aee3541639a"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "4edfe2dd-596d-4046-beb9-bc840a667079" },
                    { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "b2c07821-5a4c-4f1f-a6c6-bcdcc43e43c3" },
                    { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "9191ed31-60cb-40a7-b7fb-79e2057cf831" },
                    { new Guid("7fddd593-b53e-45e4-bb28-2aee3541639a"), "9ece2b39-e699-4b16-8f97-d51d5c2b7a59" },
                    { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "b4081dc4-7381-4592-b7b0-66596a51e3d4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b216b726-1a5c-490a-bda0-14f34a052bdb", "9191ed31-60cb-40a7-b7fb-79e2057cf831" },
                    { "a2bb1fa6-b55c-4d05-8b7c-4df1cffdf5ba", "8b4eb4fb-921d-4080-a9ec-b15c360a6654" },
                    { "a2bb1fa6-b55c-4d05-8b7c-4df1cffdf5ba", "711b1af2-1d2c-4b1c-bfff-571f0078b7aa" },
                    { "b216b726-1a5c-490a-bda0-14f34a052bdb", "4edfe2dd-596d-4046-beb9-bc840a667079" },
                    { "b216b726-1a5c-490a-bda0-14f34a052bdb", "9ece2b39-e699-4b16-8f97-d51d5c2b7a59" },
                    { "b216b726-1a5c-490a-bda0-14f34a052bdb", "b4081dc4-7381-4592-b7b0-66596a51e3d4" },
                    { "b216b726-1a5c-490a-bda0-14f34a052bdb", "b2c07821-5a4c-4f1f-a6c6-bcdcc43e43c3" }
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Country", "CreatedAt", "Email", "FinalCardNumbers", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "ReceiptName", "Status", "Total", "TotalDiscount", "TotalWithDiscount", "TotalWithTaxes" },
                values: new object[,]
                {
                    { new Guid("97cdd972-13e4-45f9-b09d-f0d6b5ccecb0"), "400 Rue des maisons", "9191ed31-60cb-40a7-b7fb-79e2057cf831", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 17, 8, 26, 980, DateTimeKind.Local).AddTicks(4583), "louis.garceau@lemadrid.com", null, "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", null, 0, 10000000m, 0m, 10000000m, 12500000m },
                    { new Guid("53c25441-7bb9-4e75-8594-9092b7039052"), "400 Rue des maisons", "9191ed31-60cb-40a7-b7fb-79e2057cf831", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 17, 8, 26, 982, DateTimeKind.Local).AddTicks(8502), "louis.garceau@lemadrid.com", null, "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", null, 1, 20000000m, 0m, 20000000m, 22500000m },
                    { new Guid("312af4ad-8217-4fbf-84cb-9981c3c393cd"), "400 Rue test", "9191ed31-60cb-40a7-b7fb-79e2057cf831", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 17, 8, 26, 982, DateTimeKind.Local).AddTicks(8539), "louis.garceau@lemadrid.com", null, "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", null, 0, 50000000m, 0m, 50000000m, 52500000m },
                    { new Guid("515af8d7-fadf-49b0-bf39-f6351bbd1ab7"), "400 Rue test", "9191ed31-60cb-40a7-b7fb-79e2057cf831", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 17, 8, 26, 982, DateTimeKind.Local).AddTicks(8545), "louis.garceau@lemadrid.com", null, "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", null, 0, 30000000m, 0m, 30000000m, 32500000m },
                    { new Guid("d41aac10-6f77-44a1-8830-7ceb5171368d"), "400 Rue test", "9191ed31-60cb-40a7-b7fb-79e2057cf831", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 17, 8, 26, 982, DateTimeKind.Local).AddTicks(8549), "louis.garceau@lemadrid.com", null, "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", null, 1, 80000000m, 0m, 80000000m, 82500000m }
                });

            migrationBuilder.InsertData(
                table: "CommandProducts",
                columns: new[] { "Id", "CommandId", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { new Guid("60a0afc4-6e85-414c-9ca7-65d51004a8d3"), new Guid("97cdd972-13e4-45f9-b09d-f0d6b5ccecb0"), 1, 4 },
                    { new Guid("03e0a2b8-5dd9-4d72-a910-d65c6836cb67"), new Guid("53c25441-7bb9-4e75-8594-9092b7039052"), 10, 2 },
                    { new Guid("e8b89913-829d-4c66-9603-5fbb33ac53cd"), new Guid("312af4ad-8217-4fbf-84cb-9981c3c393cd"), 30, 1 },
                    { new Guid("c059784a-4a23-4397-9c13-1c6e504c6bde"), new Guid("515af8d7-fadf-49b0-bf39-f6351bbd1ab7"), 5, 2 },
                    { new Guid("745f4738-977d-4dbb-8074-1edb6ca78b77"), new Guid("d41aac10-6f77-44a1-8830-7ceb5171368d"), 40, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("7fddd593-b53e-45e4-bb28-2aee3541639a"), "9ece2b39-e699-4b16-8f97-d51d5c2b7a59" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "4edfe2dd-596d-4046-beb9-bc840a667079" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "9191ed31-60cb-40a7-b7fb-79e2057cf831" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "b2c07821-5a4c-4f1f-a6c6-bcdcc43e43c3" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"), "b4081dc4-7381-4592-b7b0-66596a51e3d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b216b726-1a5c-490a-bda0-14f34a052bdb", "4edfe2dd-596d-4046-beb9-bc840a667079" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2bb1fa6-b55c-4d05-8b7c-4df1cffdf5ba", "711b1af2-1d2c-4b1c-bfff-571f0078b7aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2bb1fa6-b55c-4d05-8b7c-4df1cffdf5ba", "8b4eb4fb-921d-4080-a9ec-b15c360a6654" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b216b726-1a5c-490a-bda0-14f34a052bdb", "9191ed31-60cb-40a7-b7fb-79e2057cf831" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b216b726-1a5c-490a-bda0-14f34a052bdb", "9ece2b39-e699-4b16-8f97-d51d5c2b7a59" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b216b726-1a5c-490a-bda0-14f34a052bdb", "b2c07821-5a4c-4f1f-a6c6-bcdcc43e43c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b216b726-1a5c-490a-bda0-14f34a052bdb", "b4081dc4-7381-4592-b7b0-66596a51e3d4" });

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("03e0a2b8-5dd9-4d72-a910-d65c6836cb67"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("60a0afc4-6e85-414c-9ca7-65d51004a8d3"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("745f4738-977d-4dbb-8074-1edb6ca78b77"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("c059784a-4a23-4397-9c13-1c6e504c6bde"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("e8b89913-829d-4c66-9603-5fbb33ac53cd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2bb1fa6-b55c-4d05-8b7c-4df1cffdf5ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b216b726-1a5c-490a-bda0-14f34a052bdb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4edfe2dd-596d-4046-beb9-bc840a667079");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "711b1af2-1d2c-4b1c-bfff-571f0078b7aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b4eb4fb-921d-4080-a9ec-b15c360a6654");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ece2b39-e699-4b16-8f97-d51d5c2b7a59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c07821-5a4c-4f1f-a6c6-bcdcc43e43c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4081dc4-7381-4592-b7b0-66596a51e3d4");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("7fddd593-b53e-45e4-bb28-2aee3541639a"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("b06e4cf6-8e94-448d-92a3-0004802da3bd"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("312af4ad-8217-4fbf-84cb-9981c3c393cd"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("515af8d7-fadf-49b0-bf39-f6351bbd1ab7"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("53c25441-7bb9-4e75-8594-9092b7039052"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("97cdd972-13e4-45f9-b09d-f0d6b5ccecb0"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("d41aac10-6f77-44a1-8830-7ceb5171368d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9191ed31-60cb-40a7-b7fb-79e2057cf831");

            migrationBuilder.DropColumn(
                name: "FinalCardNumbers",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptName",
                table: "Commands");

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
    }
}
