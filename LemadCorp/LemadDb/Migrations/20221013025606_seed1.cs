using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d8827d5-58fc-4712-aa78-1d515bf804b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c21a13-8b48-41ab-8233-0c0da77dec60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd0a8819-134f-46d3-aaa7-6ead77cadeed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68c22a90-a81e-4511-b591-caca8c18f0d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de2c418e-55c3-4c68-8c91-f5ef2b9083d7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9b16a3ee-1455-417d-9a9d-5f071ba9d811", "beed2d42-4175-4e86-a230-1006b1b349b4", "Buyer", "BUYER" },
                    { "fff8ee2a-d0a6-4ff7-be71-ce33ecb7e265", "3e974823-7aff-4fa9-931e-e15097651fc3", "Seller", "SELLER" },
                    { "5f298e95-36f3-4d5e-a420-2c5649b09c57", "469b0b6b-9780-48cd-82c7-82537e19cf3e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5fb57389-069e-4d0e-a777-77569ccf10ca", 0, "f043a50d-86d6-4fec-b21d-a5bf0f057527", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAELWjlGrg8cNtE2uwHydoeqU+0s2S8MOfEBOBOpDZp0aPewv2tHRjDXq7Gslb4Jg0zg==", null, false, null, "275b7875-7418-4563-a8ff-c7d3cd9a249a", false, null },
                    { "b0366c36-ca20-44ba-8395-2bcdffcb4bce", 0, "d703c129-8001-4e3b-b37f-76a5f5b357ed", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEMDj9pOl+gOuT0TC1qReEDOgQvp6/Ph1KilBgr/vzaji81KJ3x8+I0whfwzPkEzn7Q==", null, false, null, "39ee7466-53f2-4244-bd0b-97250a3b7484", false, null }
                });

            migrationBuilder.InsertData(
                table: "engineers",
                columns: new[] { "Id", "Discount", "FirstName", "LastName", "Price", "Status" },
                values: new object[,]
                {
                    { 1, (byte)0, "Pierre", "Wache", 2000000m, 0 },
                    { 3, (byte)0, "Simone", "Resta", 1000000m, 0 },
                    { 4, (byte)0, "Matt", "Harman", 1000000m, 0 },
                    { 5, (byte)0, "Mike", "Elliott", 1000000m, 0 },
                    { 2, (byte)0, "Enrico", "Cardile", 1500000m, 0 },
                    { 7, (byte)0, "Francois-Xavier", "Demaison", 750000m, 0 },
                    { 8, (byte)0, "Jody", "Egginton", 600000m, 0 },
                    { 9, (byte)0, "Jan", "Monchaux", 500000m, 0 },
                    { 10, (byte)0, "Andrew", "Green", 400000m, 0 },
                    { 6, (byte)0, "Ben", "Watkins", 800000m, 0 }
                });

            migrationBuilder.InsertData(
                table: "mechanics",
                columns: new[] { "Id", "Discount", "FirstName", "LastName", "Price", "Status" },
                values: new object[,]
                {
                    { 9, (byte)0, "Gaetan", "Jego", 500000m, 0 },
                    { 2, (byte)0, "Chris", "Cronin", 1500000m, 0 },
                    { 3, (byte)0, "Jorn", "Becker", 1000000m, 0 },
                    { 4, (byte)0, "Alex", "Chan", 1000000m, 0 },
                    { 5, (byte)0, "Mattia", "Spini", 1000000m, 0 },
                    { 6, (byte)0, "Pierre", "Hamelin", 800000m, 0 },
                    { 7, (byte)0, "Gary", "Gannon", 750000m, 0 },
                    { 8, (byte)0, "Ed", "Regan", 600000m, 0 },
                    { 10, (byte)0, "James", "Urwin", 400000m, 0 },
                    { 16, (byte)0, "Hugh", "Bird", 800000m, 0 },
                    { 12, (byte)0, "Karel", "Loos", 1500000m, 0 },
                    { 13, (byte)0, "Riccardo", "Musconi", 1000000m, 0 },
                    { 14, (byte)0, "Peter", "Bonnington", 1000000m, 0 },
                    { 15, (byte)0, "Gianpiero", "Lambiase", 1000000m, 0 },
                    { 1, (byte)0, "Ben", "Michell", 2000000m, 0 },
                    { 18, (byte)0, "Christopher", "Hayes", 600000m, 0 },
                    { 19, (byte)0, "Riccardo", "Adami", 500000m, 0 },
                    { 20, (byte)0, "Xavier Marcos", "Padros", 400000m, 0 },
                    { 11, (byte)0, "Josh", "Peckett", 2000000m, 0 },
                    { 17, (byte)0, "Jason", "Prior", 750000m, 0 }
                });

            migrationBuilder.InsertData(
                table: "pilots",
                columns: new[] { "Id", "Discount", "FirstName", "LastName", "Price", "Status" },
                values: new object[,]
                {
                    { 1, (byte)0, "Fernando", "Alonso", 20000000m, 0 },
                    { 19, (byte)0, "Kevin", "Magnussen", 6000000m, 0 },
                    { 12, (byte)0, "Zhou", "Guanyu", 1000000m, 0 },
                    { 13, (byte)0, "Pierre", "Gasly", 5000000m, 0 },
                    { 14, (byte)0, "Yuki", "Tsunoda", 750000m, 0 },
                    { 15, (byte)0, "Nicholas", "Latifi", 1000000m, 0 },
                    { 16, (byte)0, "Alexander", "Albon", 2000000m, 0 }
                });

            migrationBuilder.InsertData(
                table: "pilots",
                columns: new[] { "Id", "Discount", "FirstName", "LastName", "Price", "Status" },
                values: new object[,]
                {
                    { 17, (byte)0, "Sebastian", "Vettel", 15000000m, 0 },
                    { 18, (byte)0, "Lance", "Stroll", 10000000m, 0 },
                    { 9, (byte)0, "Lando", "Norris", 20000000m, 0 },
                    { 20, (byte)0, "Mick", "Schumacher", 1000000m, 0 },
                    { 11, (byte)0, "Valtteri", "Bottas", 10000000m, 0 },
                    { 10, (byte)0, "Daniel", "Ricciardo", 15000000m, 0 },
                    { 8, (byte)0, "George", "Russell", 5000000m, 0 },
                    { 2, (byte)0, "Esteban", "Ocon", 5000000m, 0 },
                    { 3, (byte)0, "Max", "Verstappen", 25000000m, 0 },
                    { 4, (byte)0, "Sergio", "Perez", 8000000m, 0 },
                    { 5, (byte)0, "Charles", "Leclerc", 12000000m, 0 },
                    { 6, (byte)0, "Carlos", "Sainz", 10000000m, 0 },
                    { 7, (byte)0, "Lewis", "Hamilton", 40000000m, 0 }
                });

            migrationBuilder.InsertData(
                table: "powerUnits",
                columns: new[] { "Id", "Discount", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 7, (byte)0, null, 9100000m, 0 },
                    { 6, (byte)0, null, 2000000m, 0 },
                    { 9, (byte)0, null, 1000000m, 0 },
                    { 1, (byte)0, null, 3000000m, 0 },
                    { 2, (byte)0, null, 1000000m, 0 },
                    { 3, (byte)0, null, 1000000m, 0 },
                    { 8, (byte)0, null, 10000000m, 0 },
                    { 5, (byte)0, null, 1000000m, 0 },
                    { 10, (byte)0, null, 1000000m, 0 },
                    { 4, (byte)0, null, 1000000m, 0 }
                });

            migrationBuilder.InsertData(
                table: "principals",
                columns: new[] { "Id", "Discount", "FirstName", "LastName", "Price", "Status" },
                values: new object[,]
                {
                    { 7, (byte)0, "Toto", "Wolff", 9100000m, 0 },
                    { 1, (byte)0, "Mattias", "Binotto", 3000000m, 0 },
                    { 2, (byte)0, "Frédéric", "Vasseur", 1000000m, 0 },
                    { 3, (byte)0, "Franz", "Tost", 1000000m, 0 },
                    { 4, (byte)0, "Otmar", "Szafnauer", 1000000m, 0 },
                    { 10, (byte)0, "Mike", "Krack", 1000000m, 0 },
                    { 9, (byte)0, "Jost", "Capito", 1000000m, 0 },
                    { 5, (byte)0, "Guenther", "Steiner", 1000000m, 0 },
                    { 6, (byte)0, "Andreas", "Seidl", 2000000m, 0 },
                    { 8, (byte)0, "Christian", "Horner", 10000000m, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f298e95-36f3-4d5e-a420-2c5649b09c57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b16a3ee-1455-417d-9a9d-5f071ba9d811");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fff8ee2a-d0a6-4ff7-be71-ce33ecb7e265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fb57389-069e-4d0e-a777-77569ccf10ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0366c36-ca20-44ba-8395-2bcdffcb4bce");

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "engineers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "mechanics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "pilots",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "powerUnits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "principals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40c21a13-8b48-41ab-8233-0c0da77dec60", "6b9180e1-e862-4425-9605-af8d8c57b3a9", "Administrator", "ADMINISTRATOR" },
                    { "2d8827d5-58fc-4712-aa78-1d515bf804b4", "807682f9-c922-450f-8cf4-ce156a050135", "Seller", "SELLER" },
                    { "fd0a8819-134f-46d3-aaa7-6ead77cadeed", "5852ffbe-249d-44cf-8016-5e728ac562e8", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "68c22a90-a81e-4511-b591-caca8c18f0d4", 0, "d649dd63-2f40-4618-9ba8-de2ffe62b05c", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEMtURw6X/9REsEFiqhcVv/n2o86iyfL4mooT5CPZJhce7KToW1FkuANBnnH4Xh8ffQ==", null, false, null, "bb904b53-168d-4968-a17b-995a02a43ace", false, null },
                    { "de2c418e-55c3-4c68-8c91-f5ef2b9083d7", 0, "d9873c62-ad72-49df-b39a-08252a3bc857", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEI90Nw0WEDjvF1naDWfjbzbXPfnlYDsz5S8+jEOAupGkr1kQ5wx2suqgAsHOIuK+MQ==", null, false, null, "776dcd21-b853-411c-b367-2369936e6814", false, null }
                });
        }
    }
}
