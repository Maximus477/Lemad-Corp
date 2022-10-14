using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class changingImagePath3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ff38e4e-868f-4651-9844-85d62912af86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3237ed22-4e4d-4183-8954-f960f1517abd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "746d2afc-db95-46b0-bd06-a36cbfcbcea1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5873d68f-3ca6-424c-8af6-4c6707cf5d79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa3fae60-c996-41bf-8200-c3fcfc836fab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7fe934c5-b013-4c28-8de3-181b6b7e82d0", "da5887c7-8021-4f3e-b957-1321c59a96d4", "Administrator", "ADMINISTRATOR" },
                    { "5c584110-1bb3-4be4-bec9-0ea7558e8129", "f9932a03-d843-4492-85ba-7c6de91bafd1", "Seller", "SELLER" },
                    { "0d30a975-eae6-4a5f-a95a-ebcb95111c0f", "996a1b94-7f10-47b0-82a7-d3f202744efb", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e4109a7d-888f-47fa-a912-f0d261ef4b75", 0, "dfe2c87e-f620-4085-ae22-150f7ad76fa0", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEDWp22ra1YN1xkbIN1yvoCCLoDxv797VAQPfgrk34vZTLTqIzuU/09rKJMc9/fHLsg==", null, false, null, "f3349a64-4779-4b35-ba5c-360344dd1df6", false, null },
                    { "26026d71-ea8e-4c72-8cd4-fa8242aa0471", 0, "77025b34-0850-4f72-9c03-851c39adde72", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEGPcsZuEBw+v8dj/rH1iJqXQDP0n+fqzk91f7BWBxXH8qbzibZNdQwI45HMuO3HZnw==", null, false, null, "53027229-e9c4-4acd-a995-c044af5e97e5", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Josh Pecket", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JoshPecket.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d30a975-eae6-4a5f-a95a-ebcb95111c0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c584110-1bb3-4be4-bec9-0ea7558e8129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fe934c5-b013-4c28-8de3-181b6b7e82d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26026d71-ea8e-4c72-8cd4-fa8242aa0471");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4109a7d-888f-47fa-a912-f0d261ef4b75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ff38e4e-868f-4651-9844-85d62912af86", "acd6cbd5-c5be-4106-9f4d-1de4027eca69", "Administrator", "ADMINISTRATOR" },
                    { "746d2afc-db95-46b0-bd06-a36cbfcbcea1", "91c3a0c0-5e8e-4cd8-878f-ec94b7070715", "Seller", "SELLER" },
                    { "3237ed22-4e4d-4183-8954-f960f1517abd", "ac9da030-bf1a-4041-b733-f3f085dd33ba", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fa3fae60-c996-41bf-8200-c3fcfc836fab", 0, "84f5045e-6363-4cf3-9bc2-624b4fe4f2d4", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEOqEKeaBd8NS2N/hYVQTv0OQsmyBwuVOz0Vm1JEQThx/YcCJzJOpHI1CTv1QSaXklA==", null, false, null, "b80a0d57-91ff-475a-ae86-5e57953d725f", false, null },
                    { "5873d68f-3ca6-424c-8af6-4c6707cf5d79", 0, "9da37471-dbf9-4c20-8413-d33a60873947", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEK1P4W/Vp2w91at599RUPrulsNbb9/6gqP4jVZXdNdNzDlaKnfyd8XDWUgsf4n80nw==", null, false, null, "c69113a6-03ce-422b-a724-a6bc10b9ac35", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Josh Peckett", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JoshPeckett.png" });
        }
    }
}
