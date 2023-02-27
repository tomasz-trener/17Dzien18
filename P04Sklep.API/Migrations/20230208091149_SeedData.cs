using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MaterialCategories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Granite", "Granite" },
                    { 2, "Fresh", "Fresh" },
                    { 3, "Rubber", "Rubber" },
                    { 4, "Soft", "Soft" },
                    { 5, "Frozen", "Frozen" }
                });

            migrationBuilder.InsertData(
                table: "ProductAdjectives",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Practical" },
                    { 2, "Unbranded" },
                    { 3, "Intelligent" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ImageUrl", "MaterialCategoryId", "Premium", "Title" },
                values: new object[,]
                {
                    { 1, "lime", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=1819115489", 5, false, "Incredible Granite Ball" },
                    { 2, "ivory", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://loremflickr.com/320/240?lock=304157057", 5, false, "Refined Granite Bike" },
                    { 3, "teal", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=735376770", 1, true, "Rustic Cotton Car" },
                    { 4, "maroon", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=939764289", 5, false, "Intelligent Rubber Table" },
                    { 5, "white", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://loremflickr.com/320/240?lock=736454900", 2, false, "Unbranded Wooden Soap" },
                    { 6, "magenta", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://loremflickr.com/320/240?lock=1475484605", 3, false, "Incredible Wooden Table" },
                    { 7, "cyan", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=1080277382", 4, true, "Licensed Fresh Table" },
                    { 8, "turquoise", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=513414332", 1, true, "Incredible Fresh Tuna" },
                    { 9, "azure", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=1620794650", 1, true, "Generic Frozen Soap" },
                    { 10, "teal", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=945560122", 3, false, "Unbranded Soft Ball" },
                    { 11, "azure", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=1725577467", 4, false, "Unbranded Cotton Sausages" },
                    { 12, "white", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=1683637580", 5, true, "Unbranded Rubber Soap" },
                    { 13, "yellow", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://loremflickr.com/320/240?lock=1608979742", 1, true, "Intelligent Fresh Shoes" },
                    { 14, "orchid", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=1541969988", 2, false, "Ergonomic Frozen Shoes" },
                    { 15, "olive", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=837234833", 5, true, "Unbranded Granite Fish" },
                    { 16, "cyan", "The Football Is Good For Training And Recreational Purposes", "https://loremflickr.com/320/240?lock=2067995836", 2, false, "Awesome Cotton Gloves" },
                    { 17, "cyan", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://loremflickr.com/320/240?lock=1254714705", 5, false, "Generic Cotton Ball" },
                    { 18, "orchid", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=2104809561", 4, true, "Handcrafted Metal Sausages" },
                    { 19, "turquoise", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://loremflickr.com/320/240?lock=1247655773", 2, true, "Incredible Plastic Tuna" },
                    { 20, "purple", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://loremflickr.com/320/240?lock=784092226", 1, true, "Refined Wooden Cheese" },
                    { 21, "cyan", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=318425052", 5, false, "Intelligent Rubber Salad" },
                    { 22, "purple", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://loremflickr.com/320/240?lock=858642731", 4, false, "Intelligent Steel Bike" },
                    { 23, "green", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://loremflickr.com/320/240?lock=2108990447", 2, true, "Gorgeous Metal Salad" },
                    { 24, "turquoise", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=807239797", 3, false, "Ergonomic Concrete Sausages" },
                    { 25, "olive", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://loremflickr.com/320/240?lock=1029418429", 3, false, "Handmade Plastic Table" },
                    { 26, "purple", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=2134824864", 1, true, "Refined Plastic Pizza" },
                    { 27, "green", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=356476069", 2, false, "Tasty Concrete Bike" },
                    { 28, "lime", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1016643874", 5, true, "Awesome Plastic Bacon" },
                    { 29, "teal", "The Football Is Good For Training And Recreational Purposes", "https://loremflickr.com/320/240?lock=1971998236", 1, true, "Sleek Wooden Shoes" },
                    { 30, "fuchsia", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://loremflickr.com/320/240?lock=975929757", 2, true, "Tasty Concrete Towels" }
                });

            migrationBuilder.InsertData(
                table: "Product_ProductAdjectives",
                columns: new[] { "ProductAdjectiveId", "ProductId", "Price" },
                values: new object[,]
                {
                    { 2, 1, 296m },
                    { 3, 1, 366m },
                    { 2, 2, 923m },
                    { 3, 2, 671m },
                    { 1, 3, 314m },
                    { 3, 3, 404m },
                    { 3, 4, 149m },
                    { 1, 5, 558m },
                    { 2, 5, 516m },
                    { 2, 6, 323m },
                    { 1, 7, 245m },
                    { 3, 7, 953m },
                    { 2, 8, 493m },
                    { 3, 8, 911m },
                    { 3, 9, 465m },
                    { 1, 10, 429m },
                    { 3, 10, 768m },
                    { 2, 11, 70m },
                    { 3, 11, 399m },
                    { 2, 12, 112m },
                    { 3, 12, 817m },
                    { 2, 13, 66m },
                    { 3, 13, 102m },
                    { 1, 15, 879m },
                    { 2, 15, 755m },
                    { 3, 17, 593m },
                    { 1, 19, 795m },
                    { 2, 19, 811m },
                    { 3, 19, 669m },
                    { 1, 20, 433m },
                    { 2, 21, 670m },
                    { 3, 21, 987m },
                    { 2, 22, 727m },
                    { 1, 23, 170m },
                    { 3, 24, 537m },
                    { 3, 25, 963m },
                    { 1, 26, 787m },
                    { 1, 27, 839m },
                    { 3, 28, 200m },
                    { 2, 29, 154m },
                    { 3, 29, 474m },
                    { 3, 30, 650m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 1, 27 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 28 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "Product_ProductAdjectives",
                keyColumns: new[] { "ProductAdjectiveId", "ProductId" },
                keyValues: new object[] { 3, 30 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductAdjectives",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductAdjectives",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductAdjectives",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MaterialCategories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
