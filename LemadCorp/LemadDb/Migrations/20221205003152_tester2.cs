using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class tester2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "FinalCardNumbers",
                table: "Commands",
                newName: "ReceiptProvince");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseTime",
                table: "Commands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ReceiptAddress",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptCity",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptCountry",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptEmail",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptLast4",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptPhone",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptPostalCode",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "94554c70-1eba-41de-8da2-9e9be50ea16b", "aff83baa-b298-4df4-83a7-c6b4a72d32ea", "admin", "ADMIN" },
                    { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "8743c7a8-de87-4a45-a0b6-04f31b369981", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b678e2b-ed47-4d66-ba9d-e38e6b16aade", 0, null, "75c40b63-0f15-43a5-a38f-bc7eed853573", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEMMLHD6a8f3req28COC/Bo/XEl8/8lUPfKclYvYAeS8ItZLsK3ipjTlUUiad83XmBg==", null, false, "23cfa4cf-c0b2-497d-a818-0ccd1327c136", false, "admin@lemadrid.com" },
                    { "2fc58e2f-c0b8-49b9-bf88-702a4f3a8ae9", 0, null, "6bff579a-b1e5-45df-917c-126ee8f81d6d", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEGVNfcWtb55SBHJNj2yb98uWDZDqxJ5gd07pS6akXaPQ7x/EMo3aR6DXDmYezRguZA==", null, false, "952edf70-d163-4e19-9d8a-eab09478b36a", false, "guest@user.com" },
                    { "58b83e10-74f8-4475-a348-4157091fb28a", 0, "(450)-773-6800", "a0a8d4fa-3298-4009-b3ea-64ee27f7ac31", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEPnvt9JCShTxYZIvWrjcR6DwC7Lyes+fMNc0u0LSSY230S7HbaazaTDgdiPB5Fy1wQ==", null, false, "ec7b6c5d-78f1-4f33-b873-7101907d0207", false, "hugo@lemadrid.com" },
                    { "d8f07f1f-7130-49ad-b53a-ceff73fe8102", 0, "(450)-649-8594", "81e2d84b-f6a8-45a5-9fb7-8512d1362a93", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAELyJNNACYk5FjIVpGF/Ksum8DJ/ruxnMkt1nXGDiYMtt/pb1BDp9ZxbNfGyrhw7Edg==", null, false, "83fbd38c-dafe-4e7a-b46a-1ec3f0e3f78a", false, "karl.mainville@lemadrid.com" },
                    { "f9d9a41b-72de-446c-9161-0e88bac8d076", 0, "(450)-538-3982", "7c6c83ee-3f4f-454c-ae4d-afd2a465a0c2", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEJa9UAEL8hwFeYeyXRbz14qV4wulSGcTzuEWDLyCMFEH7GtqmuSaIRbKyXkG6cC0Nw==", null, false, "67f7fab3-b949-429b-b80e-a203c5a190f0", false, "maxime.lefebvre@lemadrid.com" },
                    { "d0b0aa90-7730-424e-8a18-7849baffc970", 0, "(450)-213-5697", "b703797c-0196-4278-87d3-6eec5e1b7ba5", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEPIINnW46c2nRc1KgjOwfUTboDaVjjUW6XNc3zLX+PttTuvtoB7+Gp1FwYolcv0y6g==", null, false, "c5d50440-f694-43ed-94d5-1894761b2152", false, "louis.garceau@lemadrid.com" },
                    { "2b69667b-beaf-43ad-a0dc-148f849f3079", 0, "(450)-789-4673", "a9725370-76b6-4d25-a44d-0d0413daafae", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEOOQ1Ydzgmdqsr2o1Ttf6krtGVVdipOxbjom7f7s+Bk751x7xZjcI02C8iYO8CXovg==", null, false, "f6889284-a0ee-4805-bc34-d64a8f8d4891", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("461a6cb5-ac46-492b-ba04-2de4af1f04f2"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "58b83e10-74f8-4475-a348-4157091fb28a" },
                    { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "2b69667b-beaf-43ad-a0dc-148f849f3079" },
                    { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "d0b0aa90-7730-424e-8a18-7849baffc970" },
                    { new Guid("461a6cb5-ac46-492b-ba04-2de4af1f04f2"), "d8f07f1f-7130-49ad-b53a-ceff73fe8102" },
                    { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "f9d9a41b-72de-446c-9161-0e88bac8d076" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "d0b0aa90-7730-424e-8a18-7849baffc970" },
                    { "94554c70-1eba-41de-8da2-9e9be50ea16b", "1b678e2b-ed47-4d66-ba9d-e38e6b16aade" },
                    { "94554c70-1eba-41de-8da2-9e9be50ea16b", "2fc58e2f-c0b8-49b9-bf88-702a4f3a8ae9" },
                    { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "58b83e10-74f8-4475-a348-4157091fb28a" },
                    { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "d8f07f1f-7130-49ad-b53a-ceff73fe8102" },
                    { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "f9d9a41b-72de-446c-9161-0e88bac8d076" },
                    { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "2b69667b-beaf-43ad-a0dc-148f849f3079" }
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Country", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Province", "PurchaseTime", "ReceiptAddress", "ReceiptCity", "ReceiptCountry", "ReceiptEmail", "ReceiptLast4", "ReceiptName", "ReceiptPhone", "ReceiptPostalCode", "ReceiptProvince", "Status", "Total", "TotalDiscount", "TotalWithDiscount", "TotalWithTaxes" },
                values: new object[,]
                {
                    { new Guid("d97c3e80-fa6a-422d-8e55-323fbf205493"), "400 Rue des maisons", "d0b0aa90-7730-424e-8a18-7849baffc970", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 19, 31, 51, 826, DateTimeKind.Local).AddTicks(8586), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, 0, 10000000m, 0m, 10000000m, 12500000m },
                    { new Guid("b5252606-8517-4957-8a66-9ebb428d51c8"), "400 Rue des maisons", "d0b0aa90-7730-424e-8a18-7849baffc970", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 19, 31, 51, 830, DateTimeKind.Local).AddTicks(3786), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J28 B25", "Quebec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, 1, 20000000m, 0m, 20000000m, 22500000m },
                    { new Guid("8618910e-dd98-4727-8bae-edaf0182263d"), "400 Rue test", "d0b0aa90-7730-424e-8a18-7849baffc970", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 19, 31, 51, 830, DateTimeKind.Local).AddTicks(3838), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, 0, 50000000m, 0m, 50000000m, 52500000m },
                    { new Guid("9a637023-b7dd-4dd4-ae14-3a355acc6561"), "400 Rue test", "d0b0aa90-7730-424e-8a18-7849baffc970", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 19, 31, 51, 830, DateTimeKind.Local).AddTicks(3844), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, 0, 30000000m, 0m, 30000000m, 32500000m },
                    { new Guid("3ca516b2-6bda-41f7-8fcd-c48e6e81c4fc"), "400 Rue test", "d0b0aa90-7730-424e-8a18-7849baffc970", "Saint-Hyacinthe", "Canada", new DateTime(2022, 12, 4, 19, 31, 51, 830, DateTimeKind.Local).AddTicks(3857), "louis.garceau@lemadrid.com", "Louis", "Garceau", "(450)-213-5697", "J2F 2F5", "Quebec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, 1, 80000000m, 0m, 80000000m, 82500000m }
                });

            migrationBuilder.InsertData(
                table: "CommandProducts",
                columns: new[] { "Id", "CommandId", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { new Guid("bdcfca99-2299-4029-9bfa-deb78a2f540f"), new Guid("d97c3e80-fa6a-422d-8e55-323fbf205493"), 1, 4 },
                    { new Guid("dfbc5b69-51cb-4d8a-b1b7-0cbaddff12fc"), new Guid("b5252606-8517-4957-8a66-9ebb428d51c8"), 10, 2 },
                    { new Guid("2fa84e03-16a8-40dd-9372-446b416b1ffc"), new Guid("8618910e-dd98-4727-8bae-edaf0182263d"), 30, 1 },
                    { new Guid("ae3f63ff-7b4b-48c4-9711-14d3d769575b"), new Guid("9a637023-b7dd-4dd4-ae14-3a355acc6561"), 5, 2 },
                    { new Guid("73cf0e73-74d2-4dee-9641-0457ef92a8b9"), new Guid("3ca516b2-6bda-41f7-8fcd-c48e6e81c4fc"), 40, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("461a6cb5-ac46-492b-ba04-2de4af1f04f2"), "d8f07f1f-7130-49ad-b53a-ceff73fe8102" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "2b69667b-beaf-43ad-a0dc-148f849f3079" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "58b83e10-74f8-4475-a348-4157091fb28a" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "d0b0aa90-7730-424e-8a18-7849baffc970" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("728cce15-a923-47e7-a390-8022353218e0"), "f9d9a41b-72de-446c-9161-0e88bac8d076" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94554c70-1eba-41de-8da2-9e9be50ea16b", "1b678e2b-ed47-4d66-ba9d-e38e6b16aade" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "2b69667b-beaf-43ad-a0dc-148f849f3079" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94554c70-1eba-41de-8da2-9e9be50ea16b", "2fc58e2f-c0b8-49b9-bf88-702a4f3a8ae9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "58b83e10-74f8-4475-a348-4157091fb28a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "d0b0aa90-7730-424e-8a18-7849baffc970" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "d8f07f1f-7130-49ad-b53a-ceff73fe8102" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63697c9f-3ac8-4ad2-9a87-73fce003ee6c", "f9d9a41b-72de-446c-9161-0e88bac8d076" });

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("2fa84e03-16a8-40dd-9372-446b416b1ffc"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("73cf0e73-74d2-4dee-9641-0457ef92a8b9"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("ae3f63ff-7b4b-48c4-9711-14d3d769575b"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("bdcfca99-2299-4029-9bfa-deb78a2f540f"));

            migrationBuilder.DeleteData(
                table: "CommandProducts",
                keyColumn: "Id",
                keyValue: new Guid("dfbc5b69-51cb-4d8a-b1b7-0cbaddff12fc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63697c9f-3ac8-4ad2-9a87-73fce003ee6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94554c70-1eba-41de-8da2-9e9be50ea16b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b678e2b-ed47-4d66-ba9d-e38e6b16aade");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b69667b-beaf-43ad-a0dc-148f849f3079");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fc58e2f-c0b8-49b9-bf88-702a4f3a8ae9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58b83e10-74f8-4475-a348-4157091fb28a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8f07f1f-7130-49ad-b53a-ceff73fe8102");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9d9a41b-72de-446c-9161-0e88bac8d076");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("461a6cb5-ac46-492b-ba04-2de4af1f04f2"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("728cce15-a923-47e7-a390-8022353218e0"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("3ca516b2-6bda-41f7-8fcd-c48e6e81c4fc"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("8618910e-dd98-4727-8bae-edaf0182263d"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("9a637023-b7dd-4dd4-ae14-3a355acc6561"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("b5252606-8517-4957-8a66-9ebb428d51c8"));

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: new Guid("d97c3e80-fa6a-422d-8e55-323fbf205493"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0b0aa90-7730-424e-8a18-7849baffc970");

            migrationBuilder.DropColumn(
                name: "PurchaseTime",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptAddress",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptCity",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptCountry",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptEmail",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptLast4",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptPhone",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "ReceiptPostalCode",
                table: "Commands");

            migrationBuilder.RenameColumn(
                name: "ReceiptProvince",
                table: "Commands",
                newName: "FinalCardNumbers");

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
    }
}
