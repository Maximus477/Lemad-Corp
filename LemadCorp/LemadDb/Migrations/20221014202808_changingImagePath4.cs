using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class changingImagePath4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "c589b6aa-8cdf-43e3-8f73-3e59b3438780", "5d977086-fc84-4926-a16c-ebfe4f3e2e09", "Administrator", "ADMINISTRATOR" },
                    { "e055c1a9-a2ab-4f10-8256-22536cae586c", "0af8711d-ce58-4538-ad74-7b804a89f5e6", "Seller", "SELLER" },
                    { "f927790d-e8b5-44a0-9111-95f4e71d47db", "d4b2630e-b4f1-49d0-a308-f1790a71c7f9", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8cd54326-e9c3-4da2-9737-686e8aad94d9", 0, "f0acbd2c-515a-4096-80d2-d47766b3be2a", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEDVPON0kUfW0wPIivLR+0ledOfBOo5nJt71iPTjADaSMXV9xZsyplEuvnp0z3Qg9zQ==", null, false, null, "cd537fe1-c12e-4e7b-8584-cf25d744240a", false, null },
                    { "30095261-8066-4da9-b79e-35444ba54600", 0, "9e74d0e4-17a5-4fde-9c3b-4e77f3fbf411", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAENpojj5ClnXXQG7q3nQwz4XBFyTPm9a8JMdAuUWWyZIfI0U7IlCk/4qMNW2xZbx15A==", null, false, null, "b287e770-792d-475b-97a6-89c56f2dba0d", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Xavier Marcos Pardos", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\XavierMarcosPardos.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c589b6aa-8cdf-43e3-8f73-3e59b3438780");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e055c1a9-a2ab-4f10-8256-22536cae586c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f927790d-e8b5-44a0-9111-95f4e71d47db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30095261-8066-4da9-b79e-35444ba54600");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cd54326-e9c3-4da2-9737-686e8aad94d9");

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
                keyValue: 64,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Xavier Marcos Padros", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\XavierMarcosPadros.png" });
        }
    }
}
