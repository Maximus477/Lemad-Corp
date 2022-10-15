using Microsoft.EntityFrameworkCore.Migrations;

namespace LemadDb.Migrations
{
    public partial class fixpathsimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "9372738b-ddc2-42ec-973a-9e7418d5adc6", "2730f5ff-3128-48f6-bc8f-23e0401aadbc", "Administrator", "ADMINISTRATOR" },
                    { "dc01bf31-3859-40ed-afad-873fcf92b62f", "4325f2c0-b02a-49ea-8ac7-1b54aae8cb89", "Seller", "SELLER" },
                    { "817a64ed-6d50-44fc-94e3-3c5ae2ba0d35", "5269ebf3-9deb-4820-9dd3-e1d170837d93", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EntrepriseName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9674f9a6-540b-4407-b89e-3b1caa4beddc", 0, "4727afe3-7583-4b75-90a6-bc92fb69c987", "admin@lemadrid.com", false, "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEEposWFVIn/aZNDkoBFP5NPPzF5Te0pV/qoi+yY3ocj+mnbeMtHUOJUGWqNaI3EQsQ==", null, false, null, "21849cf5-8793-4685-97c4-99ea1402c569", false, null },
                    { "2c343125-0805-4990-9ef9-51e4e496d0f3", 0, "3e84f1ca-0387-40aa-abef-b7862ecc1c38", "hugolapointe@cegepsth.qc.ca", false, "Cégep Saint-Hyacinthe", false, null, null, null, "AQAAAAEAACcQAAAAEJ7PORkVT9xt5ARHZKZouhlkrbhMrO96sVQ+JtdpYFEEKpcqgqL7yZeclo8/n/LLHA==", null, false, null, "1161b6d0-acb4-4c06-9a0f-e1d94c09ac46", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "wwwroot/img/products/drivers/FernandoAlonso.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Path",
                value: "wwwroot/img/products/drivers/EstebanOcon.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Path",
                value: "wwwroot/img/products/drivers/MaxVerstappen.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Path",
                value: "wwwroot/img/products/drivers/SergioPerez.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Path",
                value: "wwwroot/img/products/drivers/CharlesLeclerc.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Path",
                value: "wwwroot/img/products/drivers/CarlosSainz.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Path",
                value: "wwwroot/img/products/drivers/LewisHamilton.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Path",
                value: "wwwroot/img/products/drivers/GeorgeRussell.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Path",
                value: "wwwroot/img/products/drivers/LandoNorris.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Path",
                value: "wwwroot/img/products/drivers/DanielRicciardo.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "wwwroot/img/products/drivers/ValtteriBottas.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "wwwroot/img/products/drivers/ZhouGuanyu.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Path",
                value: "wwwroot/img/products/drivers/PierreGasly.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Path",
                value: "wwwroot/img/products/drivers/YukiTsunoda.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Path",
                value: "wwwroot/img/products/drivers/NicholasLatifi.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Path",
                value: "wwwroot/img/products/drivers/AlexanderAlbon.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Path",
                value: "wwwroot/img/products/drivers/SebastianVettel.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Path",
                value: "wwwroot/img/products/drivers/LanceStroll.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Path",
                value: "wwwroot/img/products/drivers/KevinMagnussen.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Path",
                value: "wwwroot/img/products/drivers/MickSchumacher.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Path",
                value: "wwwroot/img/products/principals/MattiaBinotto.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Path",
                value: "wwwroot/img/products/principals/FredericVasseur.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Path",
                value: "wwwroot/img/products/principals/FranzTost.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Path",
                value: "wwwroot/img/products/principals/OtmarSzafnauer.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Path",
                value: "wwwroot/img/products/principals/GuentherSteiner.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Path",
                value: "wwwroot/img/products/principals/AndreasSeidl.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Path",
                value: "wwwroot/img/products/principals/TotoWolff.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Path",
                value: "wwwroot/img/products/principals/ChristianHorner.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Path",
                value: "wwwroot/img/products/principals/JostCapito.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Path",
                value: "wwwroot/img/products/principals/MikeKrack.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Path",
                value: "wwwroot/img/products/powerunits/RedBullPowertrains.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Path",
                value: "wwwroot/img/products/powerunits/FerrariEngines.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Path",
                value: "wwwroot/img/products/powerunits/MercedesEngines.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Path",
                value: "wwwroot/img/products/powerunits/RenaultEngines.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/JodyEgginton.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/PierreWashe.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/EnricoCardile.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/SimoneResta.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/MattHarman.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/MikeElliott.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/BenWatkins.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/FrancoisXavierDemaison.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/JanMonchaux.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "Path",
                value: "wwwroot/img/products/technicalchiefs/AndrewGreen.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/BenMichell.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/ChrisCronin.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/JornBecker.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/AlexChan.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/MattiaSpini.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/PierreHamelin.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/GaryGannon.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/EdRegan.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/GaetanJego.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/JamesUrwin.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/JoshPecket.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/KarelLoos.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/RiccardoMusconi.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/PeterBonnington.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/GianpieroLambiase.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/HughBird.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/JasonPrior.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/CristopherHayes.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/RiccardoAdami.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "Path",
                value: "wwwroot/img/products/raceengineers/XavierMarcosPardos.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817a64ed-6d50-44fc-94e3-3c5ae2ba0d35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9372738b-ddc2-42ec-973a-9e7418d5adc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc01bf31-3859-40ed-afad-873fcf92b62f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c343125-0805-4990-9ef9-51e4e496d0f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9674f9a6-540b-4407-b89e-3b1caa4beddc");

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
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\MattiaBinotto.png");

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
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\principals\\OtmarSzafnauer.png");

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
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\technicalchiefs\\PierreWashe.png");

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
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\JoshPecket.png");

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
                value: "C:\\Ecole\\Commerce\\Travaux\\Lemad-Corp\\LemadCorp\\LemadWeb\\wwwroot\\img\\products\\raceengineers\\XavierMarcosPardos.png");
        }
    }
}
