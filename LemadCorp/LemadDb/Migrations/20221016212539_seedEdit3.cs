using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class seedEdit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "346325f9-a767-4934-af2c-66c6a688e258", "2c41a3d0-f23b-4e88-9187-fcdbb0ac851f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "346325f9-a767-4934-af2c-66c6a688e258", "fc01847b-3b7f-4146-94de-9bfe27bcbbaa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "346325f9-a767-4934-af2c-66c6a688e258");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c41a3d0-f23b-4e88-9187-fcdbb0ac851f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc01847b-3b7f-4146-94de-9bfe27bcbbaa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc1b2ed1-a810-43cd-a63e-b5ce89c7b8d3", "d7233e5f-7eae-4656-9388-ef3e79e1c3d1", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ff2184b3-e750-49ff-a096-b8d1c0139772", 0, "8d616b0f-ae3c-4f28-85c4-6e62ac7e78bf", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEIe9ND1PwehUlg4eTonfSMy5iUGMz9jevuEpW6tYxeVY/uUIcJNmhQhihnS8WS80Ug==", null, false, null, "166dee84-7d21-4bd4-92d1-44fc2545339c", false, "admin@lemadrid.com" },
                    { "fd654be7-21ed-4669-9a8b-175ca8f1689c", 0, "086c3e98-4f68-4cb4-a969-802cdb64ad49", "hugo@lemadrid.com", false, "Cegep de Saint-Hyacinthe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEKwtMcr+pQmhGz3gnV6BT7lQLKYgurLdjv3qipsVEu0/Dh8FnZY9J+rw4PshuWNH6g==", null, false, null, "c4347944-40ce-45cb-9253-f18af04418f9", false, "hugo@lemadrid.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Status",
                value: 2);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fc1b2ed1-a810-43cd-a63e-b5ce89c7b8d3", "ff2184b3-e750-49ff-a096-b8d1c0139772" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fc1b2ed1-a810-43cd-a63e-b5ce89c7b8d3", "fd654be7-21ed-4669-9a8b-175ca8f1689c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc1b2ed1-a810-43cd-a63e-b5ce89c7b8d3", "fd654be7-21ed-4669-9a8b-175ca8f1689c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc1b2ed1-a810-43cd-a63e-b5ce89c7b8d3", "ff2184b3-e750-49ff-a096-b8d1c0139772" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1b2ed1-a810-43cd-a63e-b5ce89c7b8d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd654be7-21ed-4669-9a8b-175ca8f1689c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2184b3-e750-49ff-a096-b8d1c0139772");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "346325f9-a767-4934-af2c-66c6a688e258", "4c216c3b-fae3-43d9-83b9-16fb74abf708", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fc01847b-3b7f-4146-94de-9bfe27bcbbaa", 0, "226cad23-abeb-4e22-a096-4ac056bd5338", "admin@lemadrid.com", false, "Admin", false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAELOn7Twsr9DzF6/IiWO6Ly8hPDpJ8tE/XlgoUjkFkAjv1qpH+Zb94qJFneJUZA/eMg==", null, false, null, "feaf2652-fdca-4fb8-b211-04a5e5ee77e8", false, "admin@lemadrid.com" },
                    { "2c41a3d0-f23b-4e88-9187-fcdbb0ac851f", 0, "e531e970-f850-4ad5-96b9-962e656b8710", "hugo@lemadrid.com", false, "Cegep de Saint-Hyacinthe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEBJx8Rx21ojuwDYgWZFSW0Dv4eNvUJNKnebbMSQwhf/vmUgI584q+4IlN6tjhgnheQ==", null, false, null, "b646922c-5d7a-4d20-ab6b-f7ceb88757e8", false, "hugo@lemadrid.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Status",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Status",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Status",
                value: 4);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "346325f9-a767-4934-af2c-66c6a688e258", "fc01847b-3b7f-4146-94de-9bfe27bcbbaa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "346325f9-a767-4934-af2c-66c6a688e258", "2c41a3d0-f23b-4e88-9187-fcdbb0ac851f" });
        }
    }
}
