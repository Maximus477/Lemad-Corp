using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test1007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"), "548daea5-0e2f-4a34-8422-6727651cb048" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "1e635c42-5d17-4004-acd5-41e936526d85" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "471d3972-4c54-4328-91d7-64e02f68b885" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "4724e75f-0470-4199-8d05-ca753c2dacbb" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "f530eb17-908f-4790-b1ac-2dd8099f30c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "1e635c42-5d17-4004-acd5-41e936526d85" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "471d3972-4c54-4328-91d7-64e02f68b885" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "4724e75f-0470-4199-8d05-ca753c2dacbb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da316f96-6ff8-4cec-8685-deef33b1b425", "4a894c2d-56c3-4ae9-9648-33b85f3775a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "548daea5-0e2f-4a34-8422-6727651cb048" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da316f96-6ff8-4cec-8685-deef33b1b425", "e8b6e176-8aed-4cfa-a630-71a17b534a60" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "f530eb17-908f-4790-b1ac-2dd8099f30c3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f6cf373-c708-4048-bdcf-f81e2c75be01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da316f96-6ff8-4cec-8685-deef33b1b425");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e635c42-5d17-4004-acd5-41e936526d85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "471d3972-4c54-4328-91d7-64e02f68b885");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4724e75f-0470-4199-8d05-ca753c2dacbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a894c2d-56c3-4ae9-9648-33b85f3775a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548daea5-0e2f-4a34-8422-6727651cb048");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8b6e176-8aed-4cfa-a630-71a17b534a60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f530eb17-908f-4790-b1ac-2dd8099f30c3");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("bc466f63-6674-415b-8417-7108332bdfaa"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d3c5446-4bc1-41e2-a7df-d7204482f03a", "14fb05ef-7f38-48b8-9a66-faea009ebff2", "admin", "ADMIN" },
                    { "e2264e06-818a-4845-a202-05878e291878", "25c58997-1d2a-43e2-9ac1-2c51ec1c9b31", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "98c10574-9c53-4ec3-8676-d616b20ad9ae", 0, null, "84820fb6-8370-4135-8eca-e3fe537a2e75", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEPiQnC8YicyfHCP7oSplGqqotECA1vsAOTOlod9aumex8UIMqTN9X8hoBsAPP41jXg==", null, false, "71e0ce42-71e7-429b-8323-d23d27587ab5", false, "admin@lemadrid.com" },
                    { "73e3acea-ce85-4193-9ffc-259c2f4e6abe", 0, null, "3a76da68-1d8f-4b0b-8b21-8e6544cb0b4a", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEE2MJDa508Q4MdGogycu0DTTraiIeT7FYVRUJ+6mFXLBV3E7Y2KtCD9/3y7YC1uuTQ==", null, false, "0a2625ba-db52-48a3-8e86-05e65bf6d5b1", false, "guest@user.com" },
                    { "6910cc3a-67b1-47e7-a818-9d8c64f02521", 0, "(450)-773-6800", "d4659092-eb1a-4567-85c0-af9f6e229b6e", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEO5EgHMwQapSqycP+l+FR1VU1PS8tILMJZVV4ZMDMNh1ELBEG/YN+MC6mQPUR4cb4A==", null, false, "8e969231-e03a-4b72-8f5c-0f7dae7c529c", false, "hugo@lemadrid.com" },
                    { "a8729f94-58fc-4cd6-b91d-4cb7ec883c24", 0, "(450)-649-8594", "07cbbd0e-08d0-43e3-9ff6-f41457b1629b", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEP/oWjs5EDFGAkW6Y+hg0B1/mVfPYSIsqU33WmQQfbYMA2qsjh7lpwR2nS1DeRdJRg==", null, false, "d9b79bc0-a659-4bf1-a328-c34f82013bae", false, "karl.mainville@lemadrid.com" },
                    { "d9a9eed2-357e-4978-bb0d-5faba7ce1e36", 0, "(450)-538-3982", "c77785e9-02a6-4383-821c-f05c9e4dddef", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAECehuQLbCQFTxIIxRBinqXMsuSsvKgAMntiV9edmQWgvzs3DMLCReKxWvOiWvS+d6Q==", null, false, "15954c27-b930-4646-a2d1-8d2c33f513cb", false, "maxime.lefebvre@lemadrid.com" },
                    { "e6fa3f69-6bc5-412a-9db4-a531cfe44d2d", 0, "(450)-213-5697", "6e48804f-8e3d-4120-b0c7-6b9a0e29bee1", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEIl2PjjWoerNR4w9ER5iiHcPTuzudmf/elan0HdQqUeOlNrBHNu5eQg4QuWD8nUJ2g==", null, false, "c8273dee-f0a0-4854-ac50-352ef501975a", false, "louis.garceau@lemadrid.com" },
                    { "0b1699c7-cd0e-48e2-8aba-fddb3c574b2d", 0, "(450)-789-4673", "e804d837-656f-453f-89ff-ff58f737a3df", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAENRxVFxAC/9ES6zBNnPRAmXfd63PoLWyiIdFV77IS2xyWsNwyn3LYR8KSYmmUsxc2w==", null, false, "7064d4c1-002f-4b1f-9c72-74793349f5e5", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("46b0be44-31e3-4d66-8d85-0fd7a0c622ad"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "6910cc3a-67b1-47e7-a818-9d8c64f02521" },
                    { new Guid("46b0be44-31e3-4d66-8d85-0fd7a0c622ad"), "a8729f94-58fc-4cd6-b91d-4cb7ec883c24" },
                    { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "d9a9eed2-357e-4978-bb0d-5faba7ce1e36" },
                    { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "e6fa3f69-6bc5-412a-9db4-a531cfe44d2d" },
                    { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "0b1699c7-cd0e-48e2-8aba-fddb3c574b2d" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0d3c5446-4bc1-41e2-a7df-d7204482f03a", "98c10574-9c53-4ec3-8676-d616b20ad9ae" },
                    { "0d3c5446-4bc1-41e2-a7df-d7204482f03a", "73e3acea-ce85-4193-9ffc-259c2f4e6abe" },
                    { "e2264e06-818a-4845-a202-05878e291878", "6910cc3a-67b1-47e7-a818-9d8c64f02521" },
                    { "e2264e06-818a-4845-a202-05878e291878", "a8729f94-58fc-4cd6-b91d-4cb7ec883c24" },
                    { "e2264e06-818a-4845-a202-05878e291878", "d9a9eed2-357e-4978-bb0d-5faba7ce1e36" },
                    { "e2264e06-818a-4845-a202-05878e291878", "e6fa3f69-6bc5-412a-9db4-a531cfe44d2d" },
                    { "e2264e06-818a-4845-a202-05878e291878", "0b1699c7-cd0e-48e2-8aba-fddb3c574b2d" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("46b0be44-31e3-4d66-8d85-0fd7a0c622ad"), "a8729f94-58fc-4cd6-b91d-4cb7ec883c24" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "0b1699c7-cd0e-48e2-8aba-fddb3c574b2d" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "6910cc3a-67b1-47e7-a818-9d8c64f02521" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "d9a9eed2-357e-4978-bb0d-5faba7ce1e36" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"), "e6fa3f69-6bc5-412a-9db4-a531cfe44d2d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2264e06-818a-4845-a202-05878e291878", "0b1699c7-cd0e-48e2-8aba-fddb3c574b2d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2264e06-818a-4845-a202-05878e291878", "6910cc3a-67b1-47e7-a818-9d8c64f02521" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d3c5446-4bc1-41e2-a7df-d7204482f03a", "73e3acea-ce85-4193-9ffc-259c2f4e6abe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d3c5446-4bc1-41e2-a7df-d7204482f03a", "98c10574-9c53-4ec3-8676-d616b20ad9ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2264e06-818a-4845-a202-05878e291878", "a8729f94-58fc-4cd6-b91d-4cb7ec883c24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2264e06-818a-4845-a202-05878e291878", "d9a9eed2-357e-4978-bb0d-5faba7ce1e36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2264e06-818a-4845-a202-05878e291878", "e6fa3f69-6bc5-412a-9db4-a531cfe44d2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d3c5446-4bc1-41e2-a7df-d7204482f03a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2264e06-818a-4845-a202-05878e291878");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b1699c7-cd0e-48e2-8aba-fddb3c574b2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6910cc3a-67b1-47e7-a818-9d8c64f02521");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73e3acea-ce85-4193-9ffc-259c2f4e6abe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98c10574-9c53-4ec3-8676-d616b20ad9ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8729f94-58fc-4cd6-b91d-4cb7ec883c24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9a9eed2-357e-4978-bb0d-5faba7ce1e36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fa3f69-6bc5-412a-9db4-a531cfe44d2d");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("46b0be44-31e3-4d66-8d85-0fd7a0c622ad"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("6f67389f-2710-4531-8873-0fda699a6d2d"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da316f96-6ff8-4cec-8685-deef33b1b425", "545b05ca-354d-4fa4-bca9-261b37af900b", "admin", "ADMIN" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "3b3c94d6-ef6c-44a6-adbc-36e900d35472", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a894c2d-56c3-4ae9-9648-33b85f3775a3", 0, null, "b10a337b-62a8-4c14-9749-3be98da08016", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAENWt2m0KqNbC0kkWk2raWWE3mXWC/qMmbWagYgRaxdlcDHNtKAYcYndye1UJz4F0Gw==", null, false, "e804dbc0-1574-4a84-b4b2-80739c68295a", false, "admin@lemadrid.com" },
                    { "e8b6e176-8aed-4cfa-a630-71a17b534a60", 0, null, "dfeda26d-a89b-49f2-bce4-42bf57abf464", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEHMHCYEw4FYiqxu/frLneo3Da3alKqhxv+T/DS2gxy31n8paqLDbKcfT8H8CgJLaxQ==", null, false, "a0e7d20b-4318-4201-8130-daf1d8004ba4", false, "guest@user.com" },
                    { "1e635c42-5d17-4004-acd5-41e936526d85", 0, "(450)-773-6800", "aed56769-f5f1-406c-9b87-f3f859b3b8d6", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAEAb0MCHdEGxmVMAAm+EeWp+31YjXBQS4shuJkTYL3gxhrUtwZ0BqWgr/7MiFWsI8nA==", null, false, "5659bda6-9a27-40a3-ad6d-de5212192ca9", false, "hugo@lemadrid.com" },
                    { "548daea5-0e2f-4a34-8422-6727651cb048", 0, "(450)-649-8594", "d3b670e8-41a6-420c-b5db-e881fa2cd521", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEIv2rHnSXfn7CLv3d3+rNnOGCFp1tgR49q7eyKW+eOvybe2BpNbZdnKq4bpICGayFg==", null, false, "089a0ef5-b1d9-411e-a51a-99ea2f66ba65", false, "karl.mainville@lemadrid.com" },
                    { "4724e75f-0470-4199-8d05-ca753c2dacbb", 0, "(450)-538-3982", "8f28cd06-f79b-42ae-b189-cca63cab9867", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEOSh1AKh5TNyUVcwt83EK8Abz+c+OfNCyn3KKnAXgrYwpPWNL6+yLaLb1r3TAtoC1Q==", null, false, "1c17a65d-8306-4ac4-847d-7ef4987adc01", false, "maxime.lefebvre@lemadrid.com" },
                    { "f530eb17-908f-4790-b1ac-2dd8099f30c3", 0, "(450)-213-5697", "10d130d9-b08e-4673-bc20-961183f52b22", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAELnier1wnn2FyMUMVEzh9zQSLFFogSHzhtQR1HkgwjEY77Z6FT8mZ4hCgoTNnGGIHQ==", null, false, "4de7831e-aa06-4aff-aea6-1184ddecec99", false, "louis.garceau@lemadrid.com" },
                    { "471d3972-4c54-4328-91d7-64e02f68b885", 0, "(450)-789-4673", "915ddc4a-b661-41c5-87ae-98aa52ccd5da", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEE4dnLeHyidesyMGKc50LYLAAtTBDvvSsyc2d8Kx/ZLhQYGis7aGp1FV+KwF27qZyg==", null, false, "d481a512-ea14-4180-bc48-f8a1175204ba", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "1e635c42-5d17-4004-acd5-41e936526d85" },
                    { new Guid("67adfd80-ab64-409e-89ca-e1f2525c913d"), "548daea5-0e2f-4a34-8422-6727651cb048" },
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "4724e75f-0470-4199-8d05-ca753c2dacbb" },
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "f530eb17-908f-4790-b1ac-2dd8099f30c3" },
                    { new Guid("bc466f63-6674-415b-8417-7108332bdfaa"), "471d3972-4c54-4328-91d7-64e02f68b885" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "da316f96-6ff8-4cec-8685-deef33b1b425", "4a894c2d-56c3-4ae9-9648-33b85f3775a3" },
                    { "da316f96-6ff8-4cec-8685-deef33b1b425", "e8b6e176-8aed-4cfa-a630-71a17b534a60" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "1e635c42-5d17-4004-acd5-41e936526d85" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "548daea5-0e2f-4a34-8422-6727651cb048" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "4724e75f-0470-4199-8d05-ca753c2dacbb" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "f530eb17-908f-4790-b1ac-2dd8099f30c3" },
                    { "6f6cf373-c708-4048-bdcf-f81e2c75be01", "471d3972-4c54-4328-91d7-64e02f68b885" }
                });
        }
    }
}
