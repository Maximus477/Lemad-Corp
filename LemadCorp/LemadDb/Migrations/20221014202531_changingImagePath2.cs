using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class changingImagePath2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64d1d90d-9820-4d6b-9110-26a0c35fdd71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b214d9-4ee1-4cdc-9066-29e4aa48e9e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4138158-38db-40c8-8c74-a037f60e13d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54f89d66-c27d-481a-871b-e625bb7004c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1df3912-e80d-4ee4-98b9-98671a8cd195");

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
                keyValue: 36,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Pierre Washe", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\PierreWashe.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "64d1d90d-9820-4d6b-9110-26a0c35fdd71", "bd61749d-4fe5-4213-ac8e-e763d332dca2", "Administrator", "ADMINISTRATOR" },
                    { "96b214d9-4ee1-4cdc-9066-29e4aa48e9e0", "b3951ed5-5cc3-4c4b-af92-8c5aac876d88", "Seller", "SELLER" },
                    { "d4138158-38db-40c8-8c74-a037f60e13d3", "c2f19018-e03e-47dd-bb9c-9efaa0c631c6", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "54f89d66-c27d-481a-871b-e625bb7004c3", 0, "48fbf87e-24b2-44cb-b1cf-e993e270d9b8", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEIrHiHE0WO2oS837IiR1S1vkmKgpzYSm24DeQy1FR3rQsPCjTQUn+Gyu2yZU8BCucQ==", null, false, null, "f60abdac-c7b8-4670-b3f6-c4a1e8e62021", false, null },
                    { "a1df3912-e80d-4ee4-98b9-98671a8cd195", 0, "9606352a-e573-4bd1-a6e9-8d8daf24db73", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEC/CZXs1KFriapz4qoukSJla7aYD74yM2jlt71dwhkupkXiG+/0W/4BBW2sMtX5YAA==", null, false, null, "ee204d8d-998d-4b85-8b53-0c59386cb7c0", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Path" },
                values: new object[] { "Pierre Wache", "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\PierreWache.png" });
        }
    }
}
