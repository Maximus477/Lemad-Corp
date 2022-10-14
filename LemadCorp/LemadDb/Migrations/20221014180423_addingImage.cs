using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class addingImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28a65325-1753-4846-bcfa-6d9a9cc87c85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cf308e5-2064-4591-969d-977f7add0f34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f94aa649-5fe4-4b90-ad6c-ec38e49a1998");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8081537e-9cdb-49c6-a2d8-6830d16d3b4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2a2d25e-ebef-4f38-9eb5-16ece6575dcd");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d52851bf-29cf-43bc-a733-40ccc5245a96", "14968af6-659b-4cf5-98ff-bfc7b00fe4cf", "Administrator", "ADMINISTRATOR" },
                    { "32f6b7e2-8fc3-4307-95c3-04e0243bd67a", "53c82cb7-b8a1-4d83-94fb-bf1f071cd7e5", "Seller", "SELLER" },
                    { "44927c9f-ffa9-44e7-9f0a-8b979fb77a53", "1de6ced0-8028-4620-a573-88154ff5c34c", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af317338-bae7-47e2-9c09-17aed6300e17", 0, "be1db757-1db3-43bd-978a-fa309384a86b", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEKa3sTH50gnz27PdsOSe8WkOR5J52oCIGytJLK3CKV4YJ65A8/TIKdyEMne5wTgSug==", null, false, null, "57a51b72-758f-465c-a261-ea24546b29e0", false, null },
                    { "824a83d1-7db2-4366-91db-2d02d5889f80", 0, "1d36c53a-86d1-4900-aa1a-ab0419ac4838", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEJ74v1cDDo2v+hLDFvZeMTCFIUizr517LY58zCN3HhXnCETofI33+16tPHKauOuUEw==", null, false, null, "66f5c95f-dd2a-4c66-bd8e-3bf93063dece", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\FernandoAlonso.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\EstebanOcon.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\MaxVerstappen.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\SergioPerez.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\CharlesLeclerc.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\CarlosSainz.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\LewisHamilton.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\GeorgeRussell.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\LandoNorris.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\DanielRicciardo.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\ValtteriBottas.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\ZhouGuanyu.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\PierreGasly.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\YukiTsunoda.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\NicholasLatifi.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\AlexanderAlbon.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\SebastianVettel.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\LanceStroll.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\KevinMagnussen.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\drivers\\MickSchumacher.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\MattiasBinotto.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\FredericVasseur.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\FranzTost.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\OtmatSzafnauer.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\GuentherSteiner.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\AndreasSeidl.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\TotoWolff.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\ChristianHorner.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\JostCapito.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\MikeKrack.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\powerunits\\RedBullPowertrains.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\powerunits\\FerrariEngines.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\powerunits\\MercedesEngines.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\powerunits\\RenaultEngines.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\JodyEgginton.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\PierreWache.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\EnricoCardile.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\SimoneResta.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\MattHarman.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\MikeElliott.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\BenWatkins.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\FrancoisXavierDemaison.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\JanMonchaux.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\AndrewGreen.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\BenMichell.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\ChrisCronin.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JornBecker.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\AlexChan.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\MattiaSpini.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\PierreHamelin.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\GaryGannon.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\EdRegan.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\GaetanJego.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JamesUrwin.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JoshPeckett.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\KarelLoos.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\RiccardoMusconi.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\PeterBonnington.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\GianpieroLambiase.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\HughBird.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JasonPrior.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\CristopherHayes.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\RiccardoAdami.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "Path",
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\XavierMarcosPadros.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32f6b7e2-8fc3-4307-95c3-04e0243bd67a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44927c9f-ffa9-44e7-9f0a-8b979fb77a53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d52851bf-29cf-43bc-a733-40ccc5245a96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "824a83d1-7db2-4366-91db-2d02d5889f80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af317338-bae7-47e2-9c09-17aed6300e17");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cf308e5-2064-4591-969d-977f7add0f34", "295f6406-dcf5-437a-9ae7-e86057ba04cf", "Administrator", "ADMINISTRATOR" },
                    { "28a65325-1753-4846-bcfa-6d9a9cc87c85", "56df0cac-7713-4b52-ad0f-21d183a5ec6f", "Seller", "SELLER" },
                    { "f94aa649-5fe4-4b90-ad6c-ec38e49a1998", "81111bed-2dfe-454d-b26a-8abc43404c6f", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8081537e-9cdb-49c6-a2d8-6830d16d3b4a", 0, "e9a039f4-94e5-4790-b04d-3e4d47bcf28e", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEJDewDVlVCQg/slCy8wUIqhrNiFO4pdeZaq11uwHLVtTlGN7fSdgYO+ZfEwS6D6Qsg==", null, false, null, "c67efd2f-04d5-4032-91c9-d731668d1c3b", false, null },
                    { "f2a2d25e-ebef-4f38-9eb5-16ece6575dcd", 0, "c686bf92-0270-4f86-94e1-f9cdf200c487", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEA4Bk5j9iSvz6e1WuxtrNH2DuffIomozOsvgvWMqs0B3jVKEsb14RDrQTfPJw1WY6A==", null, false, null, "da27d61e-e199-4a09-8935-413cc5612466", false, null }
                });
        }
    }
}
