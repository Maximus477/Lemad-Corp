using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class test1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0ca3807d-29b9-4410-886f-18709a191b15", "f6cb5bfa-4074-4bcb-ba7f-cd712e088952", "admin", "ADMIN" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "775d859d-e510-4b88-9558-3feaaf49efad", "buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cellphone", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d588f88-8891-4881-9e92-1dcf1ada336b", 0, null, "416f1491-e504-4dbe-9dad-0ebd5a281cde", "admin@lemadrid.com", false, null, null, false, null, "ADMIN@LEMADRID.COM", "ADMIN@LEMADRID.COM", "AQAAAAEAACcQAAAAEGfhL5MEU/Bi7WlxmI5ySy7TGUf5QxUIu0mRKDYDl+onNx74kkuG8wIp7SjtcZs9ag==", null, false, "2df2a2f8-c288-40f8-bcab-fc45f1d3ef96", false, "admin@lemadrid.com" },
                    { "be4e02e8-e93d-4ce0-927e-eb05804c2fab", 0, null, "eb27d116-da26-49ad-a9e7-d3458b9060e1", "guest@user.com", false, null, null, false, null, "GUEST@USER.COM", "GUEST@USER.COM", "AQAAAAEAACcQAAAAEF4doCN4tqFuXyJQKlPWRusC6sw1t61K2eA0yhtGRGacCvY/0ocBaJowrJ9xaKxhDQ==", null, false, "30fccd7b-6772-4ea3-953a-e491b70eb2ad", false, "guest@user.com" },
                    { "3ca20e43-1302-408b-9775-788262e33573", 0, "(450)-773-6800", "46cae0de-e74b-4e61-8eec-08837d82f839", "hugo@lemadrid.com", false, "Hugo", "Lapointe", false, null, "HUGO@LEMADRID.COM", "HUGO@LEMADRID.COM", "AQAAAAEAACcQAAAAELldiWAY4d/5RJj3p3LOPmTcAD8w7/ZowGmdLB4KELlU/9J+uRg3txji6faJxb/y6w==", null, false, "bfb484ca-a314-4451-92ab-77a2170da544", false, "hugo@lemadrid.com" },
                    { "480cc716-b2b5-47a2-a439-a7e6df1ecd5c", 0, "(450)-649-8594", "6205e6b3-89a6-4dbc-82b9-65ca407c3617", "karl.mainville@lemadrid.com", false, "Karl", "Mainville", false, null, "KARL.MAINVILLE@LEMADRID.COM", "KARL.MAINVILLE@LEMADRID.COM", "AQAAAAEAACcQAAAAEEHJjxD7vCDzYdIHuXxDydK+ys6ypKOfqFQ//ZBihAbz7+DTg658A0JNyyUlyuDnrQ==", null, false, "d0f1646c-bd14-4303-b798-02de7a0bbcbd", false, "karl.mainville@lemadrid.com" },
                    { "5bba8c0c-af5d-4118-bd24-34202df99eac", 0, "(450)-538-3982", "dbc7b983-2f76-4131-8783-4a24e4941e17", "maxime.lefebvre@lemadrid.com", false, "Maxime", "Lefebvre", false, null, "MAXIME.LEFEBVRE@LEMADRID.COM", "MAXIME.LEFEBVRE@LEMADRID.COM", "AQAAAAEAACcQAAAAEMOE/wuLfn5fT2/fLUWx/sX4GXj3HvwkoM/lbuJ6XAMHLYkCgb5TCZ7ak8OGwTJBVA==", null, false, "a9052e52-d44b-46bb-97f3-b8af3c01a9d4", false, "maxime.lefebvre@lemadrid.com" },
                    { "efb092d4-f926-4603-9c7a-f2515103d89f", 0, "(450)-213-5697", "dccbe3f4-29f3-4eb8-b4d5-4f9d52de03cc", "louis.garceau@lemadrid.com", false, "Louis", "Garceau", false, null, "LOUIS.GARCEAU@LEMADRID.COM", "LOUIS.GARCEAU@LEMADRID.COM", "AQAAAAEAACcQAAAAEEZo2fO1DW5kyyyH9AC22XRRZ7zbYRjeY+svbk6UCrUL6CDm8dx1UDVfKMTMjB854w==", null, false, "9534916b-b7b7-481b-ab63-3461c27ec4d0", false, "louis.garceau@lemadrid.com" },
                    { "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82", 0, "(450)-789-4673", "f6bdc709-58a7-4f23-a9b5-36c7c38cb720", "laurent.brochu@lemadrid.com", false, "Laurent", "Brochu", false, null, "LAURENT.BROCHU@LEMADRID.COM", "LAURENT.BROCHU@LEMADRID.COM", "AQAAAAEAACcQAAAAEPmTz2PZueJOJTIznm8frtyDDPzoDXy8vBlel123/EvkKhIziEbkvF7GPxIrz7I4ig==", null, false, "32fa72e0-962a-4a21-98f6-698d8939fcf3", false, "laurent.brochu@lemadrid.com" }
                });

            migrationBuilder.InsertData(
                table: "CivicAddresses",
                columns: new[] { "Id", "Address", "City", "Country", "PostalCode", "Province" },
                values: new object[,]
                {
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "3000 Av. Boullé", "Saint-Hyacinthe", "Canada", "J2S 1H9", "Québec" },
                    { new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"), "1899 Henri-Becquerel", "Sainte-Julie", "Canada", "J3E 1V6", "Québec" }
                });

            migrationBuilder.InsertData(
                table: "AddressUser",
                columns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "3ca20e43-1302-408b-9775-788262e33573" },
                    { new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"), "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" },
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "5bba8c0c-af5d-4118-bd24-34202df99eac" },
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "efb092d4-f926-4603-9c7a-f2515103d89f" },
                    { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0ca3807d-29b9-4410-886f-18709a191b15", "6d588f88-8891-4881-9e92-1dcf1ada336b" },
                    { "0ca3807d-29b9-4410-886f-18709a191b15", "be4e02e8-e93d-4ce0-927e-eb05804c2fab" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "3ca20e43-1302-408b-9775-788262e33573" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "5bba8c0c-af5d-4118-bd24-34202df99eac" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "efb092d4-f926-4603-9c7a-f2515103d89f" },
                    { "b0a7ea54-f407-4869-a52d-93894811cf4a", "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "3ca20e43-1302-408b-9775-788262e33573" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "5bba8c0c-af5d-4118-bd24-34202df99eac" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"), "efb092d4-f926-4603-9c7a-f2515103d89f" });

            migrationBuilder.DeleteData(
                table: "AddressUser",
                keyColumns: new[] { "AdresseCiviqueId", "ApplicationUserId" },
                keyValues: new object[] { new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"), "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "3ca20e43-1302-408b-9775-788262e33573" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "480cc716-b2b5-47a2-a439-a7e6df1ecd5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "5bba8c0c-af5d-4118-bd24-34202df99eac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca3807d-29b9-4410-886f-18709a191b15", "6d588f88-8891-4881-9e92-1dcf1ada336b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ca3807d-29b9-4410-886f-18709a191b15", "be4e02e8-e93d-4ce0-927e-eb05804c2fab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0a7ea54-f407-4869-a52d-93894811cf4a", "efb092d4-f926-4603-9c7a-f2515103d89f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca3807d-29b9-4410-886f-18709a191b15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0a7ea54-f407-4869-a52d-93894811cf4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ca20e43-1302-408b-9775-788262e33573");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "480cc716-b2b5-47a2-a439-a7e6df1ecd5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bba8c0c-af5d-4118-bd24-34202df99eac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d588f88-8891-4881-9e92-1dcf1ada336b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be4e02e8-e93d-4ce0-927e-eb05804c2fab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb7e1e7d-5fb0-4411-8dfc-d61be410dc82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efb092d4-f926-4603-9c7a-f2515103d89f");

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("53389df9-f7cd-436b-869d-d03a7df2c34a"));

            migrationBuilder.DeleteData(
                table: "CivicAddresses",
                keyColumn: "Id",
                keyValue: new Guid("dfd5fc27-ee4c-4aad-a569-81d52c746fcb"));

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
    }
}
