using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_AspNetUsers_ApplicationUserId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Commands_CivicAddresses_AdresseCiviqueId",
                table: "Commands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Commands_CommandId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commands",
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

            migrationBuilder.RenameTable(
                name: "Commands",
                newName: "Command");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_ApplicationUserId",
                table: "Command",
                newName: "IX_Command_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Commands_AdresseCiviqueId",
                table: "Command",
                newName: "IX_Command_AdresseCiviqueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Command",
                table: "Command",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CommandProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CommandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommandProduct_Command_CommandId",
                        column: x => x.CommandId,
                        principalTable: "Command",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_CommandProduct_CommandId",
                table: "CommandProduct",
                column: "CommandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_AspNetUsers_ApplicationUserId",
                table: "Command",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Command_CivicAddresses_AdresseCiviqueId",
                table: "Command",
                column: "AdresseCiviqueId",
                principalTable: "CivicAddresses",
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
                name: "FK_Command_AspNetUsers_ApplicationUserId",
                table: "Command");

            migrationBuilder.DropForeignKey(
                name: "FK_Command_CivicAddresses_AdresseCiviqueId",
                table: "Command");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Command_CommandId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CommandProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Command",
                table: "Command");

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

            migrationBuilder.RenameTable(
                name: "Command",
                newName: "Commands");

            migrationBuilder.RenameIndex(
                name: "IX_Command_ApplicationUserId",
                table: "Commands",
                newName: "IX_Commands_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Command_AdresseCiviqueId",
                table: "Commands",
                newName: "IX_Commands_AdresseCiviqueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commands",
                table: "Commands",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_AspNetUsers_ApplicationUserId",
                table: "Commands",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_CivicAddresses_AdresseCiviqueId",
                table: "Commands",
                column: "AdresseCiviqueId",
                principalTable: "CivicAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Commands_CommandId",
                table: "Products",
                column: "CommandId",
                principalTable: "Commands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
