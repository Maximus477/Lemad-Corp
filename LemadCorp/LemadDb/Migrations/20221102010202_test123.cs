using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "14cb37a7-12b0-4ead-bf34-b0b642629606" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "5bcac41e-7c91-47a1-95d5-db49b00f568f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "9c42e86b-f867-4625-8b15-9b537f888b88" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "e8e6b9c2-0bda-4c4a-912f-219386b6c40c" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("67790e07-da65-416c-8ccd-d7e8f8f40fbd"), "87209de5-9088-40f7-8f45-93a0aea864ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "14cb37a7-12b0-4ead-bf34-b0b642629606" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "5bcac41e-7c91-47a1-95d5-db49b00f568f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed3685cd-a84e-43f7-862d-4ae5d96513f8", "710203d9-5242-44c1-a7ea-31e44ce8e29e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "87209de5-9088-40f7-8f45-93a0aea864ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "9c42e86b-f867-4625-8b15-9b537f888b88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "e8e6b9c2-0bda-4c4a-912f-219386b6c40c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27a0aaad-88f2-40c6-ac81-31c8bbfa085b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3685cd-a84e-43f7-862d-4ae5d96513f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14cb37a7-12b0-4ead-bf34-b0b642629606");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bcac41e-7c91-47a1-95d5-db49b00f568f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "710203d9-5242-44c1-a7ea-31e44ce8e29e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87209de5-9088-40f7-8f45-93a0aea864ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c42e86b-f867-4625-8b15-9b537f888b88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8e6b9c2-0bda-4c4a-912f-219386b6c40c");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("67790e07-da65-416c-8ccd-d7e8f8f40fbd"));

            migrationBuilder.AddColumn<Guid>(
                name: "AdresseCiviqueId",
                table: "Commands",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cfa8dae9-7642-4e10-bc0f-b0cb66c1b918", "d4ee6ffa-ca6f-4407-ba47-d55766d61759", "admin", "ADMIN" },
                    { "36ca4b87-6ca7-427f-b077-c11fbc992880", "33f19bc1-05cf-4641-9711-22d6f7174c95", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "56ac5385-5ace-4a7b-b640-b91328c59f71", 0, null, "eb47d785-61b0-4137-9ac3-d0cd69ee8e6c", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEKRnWv6dRCJR18Mw8ACtEvbojLhGCxR3iu2DdZhk9/wbw/jdU0C2r0AoI3frIOjjeg==", null, false, "bd25cc46-d08d-49f1-bdc9-ffd328fd0b49", false, "admin@lemadrid.com" },
                    { "db426634-279c-41be-adcc-56d9990bf9ef", 0, "(450)-773-6800", "77ffd858-5cd4-40cc-b6b8-32b3db8d3173", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEISJ4B8TMSSykbWRfQGg8C8bvlgJQ6MsK40LZEJ8Mp/8FW6AVJvQc+lRQxjwLs71Aw==", null, false, "2f5e9b06-6ef4-4686-9005-eb9634722835", false, "hugo@lemadrid.com" },
                    { "001e81af-c503-47b0-976c-1fd6b633d332", 0, "(450)-649-8594", "b9d18e3c-56e3-4a8b-9117-671655f769f2", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEHT7FAhJQBtQ+H5RSQepob6UZaYBYoqQ6iPWZmEJHBRRCWSS7PTCnoMQvjdMxKsodg==", null, false, "96959b31-ef8a-40d0-8dd4-d80ecba82b38", false, "karl.mainville@lemadrid.com" },
                    { "0f1f7df2-85e3-4e98-be3b-a29131336af6", 0, "(450)-538-3982", "3ed267b6-ec5b-4ccb-bc02-2702ce85edc8", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEGV3aIbihZM2SzecAwmoF+RltLE1+15zuB7Dm6D/B3prSSEwIrgg02xSu9UOx8CAvg==", null, false, "9ca46a55-d65f-4be2-82a3-7669f384d539", false, "maxime.lefebvre@lemadrid.com" },
                    { "c9b73f06-3887-4049-980b-375d5574f71f", 0, "(450)-213-5697", "973ef864-fceb-4af6-98db-52e0a5ae093b", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAENW8tPShKvPGsNJFIfeQSGL+2ZxKUJHwQ428fRsbzqTGcJZLbR0SorhbPOPoVqyYtA==", null, false, "84e67b0b-51ff-44af-ac47-ddd57237fd4d", false, "louis.garceau@lemadrid.com" },
                    { "451bd6a4-0394-4ebd-8815-bcc57eab6195", 0, "(450)-789-4673", "e944777f-eacd-40de-ad67-455e1f2561b6", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEKKZbTfsmUNhj6VYUZbNcU98OsDorIVjyfMHNaNuBP8XAm1pYIsv/JeCPQ9vLbUNhA==", null, false, "4f9a3560-114f-4635-970b-d620c1aaf7cb", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("0af5514e-96a2-4fd0-a90f-ea6da9cd125f"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "db426634-279c-41be-adcc-56d9990bf9ef" },
                    { new Guid("0af5514e-96a2-4fd0-a90f-ea6da9cd125f"), "001e81af-c503-47b0-976c-1fd6b633d332" },
                    { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "0f1f7df2-85e3-4e98-be3b-a29131336af6" },
                    { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "c9b73f06-3887-4049-980b-375d5574f71f" },
                    { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "451bd6a4-0394-4ebd-8815-bcc57eab6195" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cfa8dae9-7642-4e10-bc0f-b0cb66c1b918", "56ac5385-5ace-4a7b-b640-b91328c59f71" },
                    { "36ca4b87-6ca7-427f-b077-c11fbc992880", "db426634-279c-41be-adcc-56d9990bf9ef" },
                    { "36ca4b87-6ca7-427f-b077-c11fbc992880", "001e81af-c503-47b0-976c-1fd6b633d332" },
                    { "36ca4b87-6ca7-427f-b077-c11fbc992880", "0f1f7df2-85e3-4e98-be3b-a29131336af6" },
                    { "36ca4b87-6ca7-427f-b077-c11fbc992880", "c9b73f06-3887-4049-980b-375d5574f71f" },
                    { "36ca4b87-6ca7-427f-b077-c11fbc992880", "451bd6a4-0394-4ebd-8815-bcc57eab6195" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commands_AdresseCiviqueId",
                table: "Commands",
                column: "AdresseCiviqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CivicAddresses_AdresseCiviqueId",
                table: "Commands",
                column: "AdresseCiviqueId",
                principalTable: "CivicAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CivicAddresses_AdresseCiviqueId",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_AdresseCiviqueId",
                table: "Commands");

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("0af5514e-96a2-4fd0-a90f-ea6da9cd125f"), "001e81af-c503-47b0-976c-1fd6b633d332" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "0f1f7df2-85e3-4e98-be3b-a29131336af6" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "451bd6a4-0394-4ebd-8815-bcc57eab6195" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "c9b73f06-3887-4049-980b-375d5574f71f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"), "db426634-279c-41be-adcc-56d9990bf9ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36ca4b87-6ca7-427f-b077-c11fbc992880", "001e81af-c503-47b0-976c-1fd6b633d332" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36ca4b87-6ca7-427f-b077-c11fbc992880", "0f1f7df2-85e3-4e98-be3b-a29131336af6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36ca4b87-6ca7-427f-b077-c11fbc992880", "451bd6a4-0394-4ebd-8815-bcc57eab6195" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cfa8dae9-7642-4e10-bc0f-b0cb66c1b918", "56ac5385-5ace-4a7b-b640-b91328c59f71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36ca4b87-6ca7-427f-b077-c11fbc992880", "c9b73f06-3887-4049-980b-375d5574f71f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36ca4b87-6ca7-427f-b077-c11fbc992880", "db426634-279c-41be-adcc-56d9990bf9ef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36ca4b87-6ca7-427f-b077-c11fbc992880");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfa8dae9-7642-4e10-bc0f-b0cb66c1b918");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "001e81af-c503-47b0-976c-1fd6b633d332");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1f7df2-85e3-4e98-be3b-a29131336af6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451bd6a4-0394-4ebd-8815-bcc57eab6195");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56ac5385-5ace-4a7b-b640-b91328c59f71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9b73f06-3887-4049-980b-375d5574f71f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db426634-279c-41be-adcc-56d9990bf9ef");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("0af5514e-96a2-4fd0-a90f-ea6da9cd125f"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("92c86fd5-0169-4d99-9606-042ec795b4f1"));

            migrationBuilder.DropColumn(
                name: "AdresseCiviqueId",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Commands");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Commands");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ed3685cd-a84e-43f7-862d-4ae5d96513f8", "fd626be4-451f-4039-9fbd-f47268fc0cd6", "admin", "ADMIN" },
                    { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "7df83f0d-911f-4ffa-8ad8-d4a61206aeea", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "710203d9-5242-44c1-a7ea-31e44ce8e29e", 0, null, "20e0f6b7-3b61-43b4-8533-a633c8755d12", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAELDDMR9fBWTe4vVviyYUjPJIWewvOq1WkZbT2Wj3NkRjEHMOgrCw6krmNV6WQcoE6w==", null, false, "e5a804d0-21cb-4312-ba03-c4bd84d0c484", false, "admin@lemadrid.com" },
                    { "9c42e86b-f867-4625-8b15-9b537f888b88", 0, "(450)-773-6800", "c6abfb91-3357-4563-ba0c-273c3e4621e8", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEL6lMO33+nwCOn3K7dEFsn4jqf4VGRC+q5xvwV5PaRqixT4zrrCHzbL84gkMWfblMg==", null, false, "6fd6179a-1113-4c69-b3c1-4ac99d3605e7", false, "hugo@lemadrid.com" },
                    { "87209de5-9088-40f7-8f45-93a0aea864ef", 0, "(450)-649-8594", "11f346e6-f125-427a-9cd9-b47c7c891377", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEF8/DXs2wHe8L+3tTdKgf4x14fSCQW5den7poFtYXCQFWj03rwU2uHhNtICroIijLw==", null, false, "5870f94d-5f36-4f33-a6e6-635d02617a8b", false, "karl.mainville@lemadrid.com" },
                    { "e8e6b9c2-0bda-4c4a-912f-219386b6c40c", 0, "(450)-538-3982", "a1d89b61-508a-4d68-b4d4-6cd47ba50cb0", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEP75w9VDLlqkSOxF938eZAKuwhwerqZYEq/yVIm/GoheEROD225ZRvuJ0A+/pvlg2A==", null, false, "2c108cf6-3280-48e5-a9b4-bb8d4c05125d", false, "maxime.lefebvre@lemadrid.com" },
                    { "5bcac41e-7c91-47a1-95d5-db49b00f568f", 0, "(450)-213-5697", "48bf6333-184c-46ef-8248-42ac403b6f4c", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEKoT2xKAtyMlStC/AakAd8WyjAlDuQho1w+HH9ut8QMHgzFH3EZwAhM4EmeZyGrxaw==", null, false, "bf1a3eef-d7fa-458c-8179-e3801b890ebb", false, "louis.garceau@lemadrid.com" },
                    { "14cb37a7-12b0-4ead-bf34-b0b642629606", 0, "(450)-789-4673", "2c328386-3292-47b0-92a9-79ad15547be1", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAELx8EyVs+0Q+wKn56okYg5mHvBfWiRovfuozy/GsWZiRNo38pVRt8/9DLRj5P89bZA==", null, false, "ab64039f-9985-44ef-92ed-77d727626007", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("67790e07-da65-416c-8ccd-d7e8f8f40fbd"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "9c42e86b-f867-4625-8b15-9b537f888b88" },
                    { new Guid("67790e07-da65-416c-8ccd-d7e8f8f40fbd"), "87209de5-9088-40f7-8f45-93a0aea864ef" },
                    { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "e8e6b9c2-0bda-4c4a-912f-219386b6c40c" },
                    { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "5bcac41e-7c91-47a1-95d5-db49b00f568f" },
                    { new Guid("5dfcb1e1-3fd6-4b8a-a730-e56a9163b7c4"), "14cb37a7-12b0-4ead-bf34-b0b642629606" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ed3685cd-a84e-43f7-862d-4ae5d96513f8", "710203d9-5242-44c1-a7ea-31e44ce8e29e" },
                    { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "9c42e86b-f867-4625-8b15-9b537f888b88" },
                    { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "87209de5-9088-40f7-8f45-93a0aea864ef" },
                    { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "e8e6b9c2-0bda-4c4a-912f-219386b6c40c" },
                    { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "5bcac41e-7c91-47a1-95d5-db49b00f568f" },
                    { "27a0aaad-88f2-40c6-ac81-31c8bbfa085b", "14cb37a7-12b0-4ead-bf34-b0b642629606" }
                });
        }
    }
}
