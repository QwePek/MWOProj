using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class migracja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Pages", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 830, new DateTime(2023, 5, 12, 11, 30, 23, 549, DateTimeKind.Local).AddTicks(5577), "Gorgeous Wooden Chair" },
                    { 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 96, new DateTime(2023, 7, 1, 8, 32, 28, 513, DateTimeKind.Local).AddTicks(3824), "Intelligent Cotton Towels" },
                    { 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 712, new DateTime(2023, 3, 20, 6, 38, 15, 459, DateTimeKind.Local).AddTicks(690), "Generic Wooden Fish" },
                    { 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 675, new DateTime(2022, 12, 20, 18, 22, 31, 505, DateTimeKind.Local).AddTicks(2933), "Handcrafted Steel Shoes" },
                    { 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 699, new DateTime(2023, 4, 17, 13, 46, 42, 575, DateTimeKind.Local).AddTicks(985), "Ergonomic Plastic Car" },
                    { 6, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839, new DateTime(2023, 9, 30, 3, 16, 49, 95, DateTimeKind.Local).AddTicks(2399), "Fantastic Rubber Salad" },
                    { 7, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 176, new DateTime(2023, 2, 10, 12, 51, 19, 918, DateTimeKind.Local).AddTicks(5102), "Handmade Granite Table" },
                    { 8, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 703, new DateTime(2023, 5, 5, 9, 25, 6, 512, DateTimeKind.Local).AddTicks(7611), "Ergonomic Steel Pants" },
                    { 9, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 198, new DateTime(2023, 1, 18, 22, 10, 32, 368, DateTimeKind.Local).AddTicks(4513), "Small Plastic Table" },
                    { 10, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 276, new DateTime(2023, 5, 7, 0, 11, 6, 321, DateTimeKind.Local).AddTicks(7392), "Handmade Wooden Table" },
                    { 11, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 415, new DateTime(2023, 5, 11, 4, 51, 18, 267, DateTimeKind.Local).AddTicks(6591), "Fantastic Concrete Chicken" },
                    { 12, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 160, new DateTime(2023, 8, 20, 10, 24, 2, 727, DateTimeKind.Local).AddTicks(6012), "Practical Granite Ball" },
                    { 13, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 74, new DateTime(2023, 3, 22, 12, 21, 46, 683, DateTimeKind.Local).AddTicks(9438), "Intelligent Steel Salad" },
                    { 14, "The Football Is Good For Training And Recreational Purposes", 987, new DateTime(2023, 6, 22, 2, 1, 19, 714, DateTimeKind.Local).AddTicks(4991), "Sleek Steel Tuna" },
                    { 15, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 360, new DateTime(2023, 2, 20, 11, 42, 14, 457, DateTimeKind.Local).AddTicks(2309), "Ergonomic Steel Shirt" },
                    { 16, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 246, new DateTime(2022, 11, 9, 16, 57, 1, 641, DateTimeKind.Local).AddTicks(9121), "Handcrafted Rubber Bike" },
                    { 17, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 643, new DateTime(2023, 8, 18, 2, 10, 6, 205, DateTimeKind.Local).AddTicks(3704), "Small Steel Tuna" },
                    { 18, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 181, new DateTime(2023, 9, 3, 23, 29, 47, 566, DateTimeKind.Local).AddTicks(9783), "Gorgeous Cotton Keyboard" },
                    { 19, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 627, new DateTime(2023, 8, 2, 21, 20, 47, 125, DateTimeKind.Local).AddTicks(9228), "Unbranded Steel Car" },
                    { 20, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 887, new DateTime(2023, 6, 7, 18, 59, 58, 807, DateTimeKind.Local).AddTicks(3152), "Refined Fresh Mouse" },
                    { 21, "The Football Is Good For Training And Recreational Purposes", 939, new DateTime(2023, 4, 4, 22, 41, 59, 976, DateTimeKind.Local).AddTicks(9952), "Ergonomic Plastic Computer" },
                    { 22, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 705, new DateTime(2023, 11, 4, 17, 50, 20, 455, DateTimeKind.Local).AddTicks(128), "Tasty Plastic Cheese" },
                    { 23, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 331, new DateTime(2023, 4, 10, 23, 50, 46, 399, DateTimeKind.Local).AddTicks(7274), "Tasty Metal Pants" },
                    { 24, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 224, new DateTime(2023, 6, 28, 13, 56, 27, 665, DateTimeKind.Local).AddTicks(2291), "Intelligent Fresh Bacon" },
                    { 25, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 42, new DateTime(2023, 6, 10, 7, 7, 36, 554, DateTimeKind.Local).AddTicks(9093), "Handcrafted Fresh Sausages" },
                    { 26, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 781, new DateTime(2023, 7, 11, 11, 32, 20, 686, DateTimeKind.Local).AddTicks(1536), "Licensed Metal Mouse" },
                    { 27, "The Football Is Good For Training And Recreational Purposes", 249, new DateTime(2022, 12, 18, 5, 55, 43, 121, DateTimeKind.Local).AddTicks(9950), "Ergonomic Metal Shoes" },
                    { 28, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 813, new DateTime(2022, 11, 19, 16, 0, 58, 514, DateTimeKind.Local).AddTicks(3790), "Fantastic Frozen Gloves" },
                    { 29, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 107, new DateTime(2023, 10, 29, 22, 17, 30, 455, DateTimeKind.Local).AddTicks(1018), "Unbranded Granite Hat" },
                    { 30, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 906, new DateTime(2023, 10, 9, 21, 37, 52, 583, DateTimeKind.Local).AddTicks(2721), "Generic Fresh Computer" },
                    { 31, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 125, new DateTime(2022, 11, 13, 9, 24, 9, 321, DateTimeKind.Local).AddTicks(9406), "Generic Steel Ball" },
                    { 32, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 312, new DateTime(2023, 3, 14, 23, 35, 31, 587, DateTimeKind.Local).AddTicks(5641), "Licensed Soft Salad" },
                    { 33, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 843, new DateTime(2023, 8, 8, 14, 51, 56, 724, DateTimeKind.Local).AddTicks(9996), "Ergonomic Metal Soap" },
                    { 34, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 75, new DateTime(2023, 4, 11, 0, 52, 59, 688, DateTimeKind.Local).AddTicks(5369), "Ergonomic Rubber Car" },
                    { 35, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 625, new DateTime(2022, 11, 29, 17, 21, 22, 517, DateTimeKind.Local).AddTicks(8232), "Unbranded Wooden Soap" },
                    { 36, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 929, new DateTime(2023, 8, 16, 19, 23, 53, 498, DateTimeKind.Local).AddTicks(8882), "Intelligent Plastic Cheese" },
                    { 37, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 233, new DateTime(2023, 10, 22, 16, 1, 30, 301, DateTimeKind.Local).AddTicks(646), "Generic Steel Pizza" },
                    { 38, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 530, new DateTime(2023, 5, 19, 2, 7, 13, 781, DateTimeKind.Local).AddTicks(451), "Ergonomic Fresh Keyboard" },
                    { 39, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 707, new DateTime(2023, 7, 17, 0, 37, 22, 418, DateTimeKind.Local).AddTicks(4984), "Fantastic Metal Chair" },
                    { 40, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 472, new DateTime(2022, 11, 20, 16, 40, 27, 751, DateTimeKind.Local).AddTicks(1670), "Small Metal Sausages" },
                    { 41, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 826, new DateTime(2022, 11, 12, 8, 5, 36, 270, DateTimeKind.Local).AddTicks(7967), "Fantastic Metal Keyboard" },
                    { 42, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 306, new DateTime(2023, 1, 10, 13, 50, 0, 906, DateTimeKind.Local).AddTicks(1404), "Refined Metal Fish" },
                    { 43, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 902, new DateTime(2023, 8, 11, 23, 20, 57, 763, DateTimeKind.Local).AddTicks(3602), "Fantastic Soft Pants" },
                    { 44, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 764, new DateTime(2022, 11, 18, 16, 10, 22, 830, DateTimeKind.Local).AddTicks(9427), "Practical Steel Tuna" },
                    { 45, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 378, new DateTime(2023, 8, 1, 6, 55, 53, 935, DateTimeKind.Local).AddTicks(8668), "Unbranded Cotton Soap" },
                    { 46, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 956, new DateTime(2023, 4, 9, 23, 12, 43, 394, DateTimeKind.Local).AddTicks(204), "Gorgeous Frozen Towels" },
                    { 47, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 993, new DateTime(2023, 1, 5, 23, 31, 47, 261, DateTimeKind.Local).AddTicks(202), "Unbranded Wooden Chair" },
                    { 48, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 462, new DateTime(2022, 11, 18, 22, 50, 42, 402, DateTimeKind.Local).AddTicks(7805), "Handmade Steel Pants" },
                    { 49, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 267, new DateTime(2023, 6, 1, 21, 9, 46, 592, DateTimeKind.Local).AddTicks(7410), "Tasty Steel Cheese" },
                    { 50, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 16, new DateTime(2023, 5, 24, 22, 11, 33, 135, DateTimeKind.Local).AddTicks(9500), "Incredible Concrete Salad" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 20, 6, 38, 15, 452, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 30, 3, 16, 49, 88, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 18, 22, 10, 32, 362, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 20, 10, 24, 2, 721, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 20, 11, 42, 14, 450, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 3, 23, 29, 47, 560, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 4, 22, 41, 59, 970, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 28, 13, 56, 27, 658, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 18, 5, 55, 43, 115, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 9, 21, 37, 52, 576, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 8, 14, 51, 56, 718, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 16, 19, 23, 53, 492, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 17, 0, 37, 22, 412, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 10, 13, 50, 0, 899, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 1, 6, 55, 53, 929, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 18, 22, 50, 42, 396, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 28, 13, 12, 13, 974, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 25, 14, 54, 55, 333, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 19, 2, 12, 54, 912, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 3, 43, 39, 395, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 20, 15, 6, 33, 583, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 31, 10, 33, 55, 853, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 2, 4, 24, 3, 171, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 3, 21, 0, 22, 400, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 19, 22, 29, 13, 964, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 14, 16, 5, 34, 88, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 3, 4, 9, 10, 84, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 28, 6, 35, 5, 195, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 21, 17, 5, 59, 188, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 15, 18, 1, 22, 405, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 11, 16, 27, 11, 601, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 22, 12, 14, 37, 540, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 29, 12, 43, 38, 791, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 26, 5, 59, 26, 630, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 14, 10, 51, 44, 625, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 3, 5, 25, 42, 158, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 31, 20, 58, 55, 554, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 10, 19, 0, 35, 873, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 7, 2, 38, 50, 432, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 24, 23, 25, 7, 56, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 7, 6, 30, 29, 204, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 29, 17, 41, 28, 634, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 21, 9, 27, 42, 190, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 25, 7, 8, 7, 349, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 3, 3, 14, 30, 419, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 8, 7, 56, 41, 978, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 11, 2, 56, 16, 280, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 22, 23, 48, 33, 706, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 8, 4, 30, 37, 308, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 25, 17, 39, 36, 488, DateTimeKind.Local).AddTicks(6825));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 18, 15, 16, 56, 509, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 30, 11, 55, 30, 145, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 19, 6, 49, 13, 418, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 20, 19, 2, 43, 777, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 20, 20, 20, 55, 507, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 4, 8, 8, 28, 617, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 3, 7, 20, 41, 27, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 22, 35, 8, 715, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 18, 14, 34, 24, 172, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 10, 6, 16, 33, 633, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 8, 23, 30, 37, 775, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 17, 4, 2, 34, 549, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 14, 9, 16, 3, 468, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 10, 22, 28, 41, 956, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 1, 15, 34, 34, 985, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 7, 29, 23, 452, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 21, 50, 55, 30, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 23, 33, 36, 390, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 10, 51, 35, 969, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 10, 12, 22, 20, 451, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 18, 23, 45, 14, 640, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 31, 19, 12, 36, 909, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 31, 13, 2, 44, 228, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 1, 5, 39, 3, 457, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 17, 7, 7, 55, 21, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 13, 0, 44, 15, 144, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 3, 12, 47, 51, 140, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 26, 15, 13, 46, 252, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 1, 44, 40, 245, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 16, 2, 40, 3, 461, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 12, 1, 5, 52, 658, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 20, 53, 18, 597, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 27, 21, 22, 19, 848, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 26, 14, 38, 7, 686, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 14, 19, 30, 25, 681, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 14, 4, 23, 214, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 30, 5, 37, 36, 610, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 3, 39, 16, 929, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 5, 11, 17, 31, 489, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 8, 3, 48, 113, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 7, 15, 9, 10, 261, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 27, 2, 20, 9, 690, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 21, 18, 6, 23, 246, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 25, 15, 46, 48, 405, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 11, 53, 11, 475, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 6, 16, 35, 23, 35, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 11, 34, 57, 337, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 23, 8, 27, 14, 763, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 6, 13, 9, 18, 365, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 26, 2, 18, 17, 545, DateTimeKind.Local).AddTicks(1817));
        }
    }
}
