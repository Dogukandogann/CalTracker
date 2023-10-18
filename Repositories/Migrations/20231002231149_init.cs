using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Coefficient = table.Column<double>(type: "float", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Height = table.Column<double>(type: "float", maxLength: 5, nullable: false),
                    Weight = table.Column<double>(type: "float", maxLength: 5, nullable: false),
                    UserStatus = table.Column<int>(type: "int", nullable: false),
                    UserAccess = table.Column<int>(type: "int", nullable: false),
                    AimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Aims_AimId",
                        column: x => x.AimId,
                        principalTable: "Aims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Calorie = table.Column<double>(type: "float", maxLength: 8, nullable: false),
                    Fat = table.Column<double>(type: "float", maxLength: 8, nullable: false),
                    Carbonhidrate = table.Column<double>(type: "float", maxLength: 8, nullable: false),
                    Protein = table.Column<double>(type: "float", maxLength: 8, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    FoodCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_FoodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealTime = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMeals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVerifications",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Verification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVerifications", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserVerifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodAmounts",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    UserMealId = table.Column<int>(type: "int", nullable: false),
                    Gram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAmounts", x => new { x.FoodId, x.UserMealId });
                    table.ForeignKey(
                        name: "FK_FoodAmounts_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAmounts_UserMeals_UserMealId",
                        column: x => x.UserMealId,
                        principalTable: "UserMeals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aims",
                columns: new[] { "Id", "Coefficient", "Name" },
                values: new object[,]
                {
                    { 1, 1.0, "Kilo Verme" },
                    { 2, 1.0, "Kilo Alma" },
                    { 3, 1.0, "Kilo Koruma" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Deniz Ürünü", null },
                    { 2, "Tavuk", null },
                    { 3, "Meyve", null },
                    { 4, "Tatlı", null },
                    { 5, "Süt ve Süt Ürünü", null },
                    { 6, "Kırmızı Et", null },
                    { 7, "Kahvaltılık", null },
                    { 8, "Tahıl", null },
                    { 9, "Soslar", null },
                    { 10, "FastFood", null },
                    { 11, "Sebze", null },
                    { 12, "Salatalar", null },
                    { 13, "Çerez", null },
                    { 14, "Çorba", null },
                    { 15, "Yağ", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "Carbonhidrate", "Description", "Fat", "FoodCategoryId", "Gram", "ImagePath", "Name", "Protein" },
                values: new object[,]
                {
                    { 1, 26.0, 3.0799999237060547, null, 0.70999997854232788, 1, 30, "https://picsum.photos/500/500", "Midye Dolma", 1.6200000047683716 },
                    { 2, 125.0, 12.420000076293945, null, 7.1500000953674316, 1, 155, "https://picsum.photos/500/500", "Suşi", 3.0399999618530273 },
                    { 3, 69.0, 0.5, null, 4.9200000762939453, 2, 30, "https://picsum.photos/500/500", "Kızarmış Tavuk Kanadı", 5.8499999046325684 },
                    { 4, 117.0, 4.380000114440918, null, 7.1700000762939453, 2, 80, "https://picsum.photos/500/500", "Haşlanmış Tavuk But", 7.9600000381469727 },
                    { 5, 46.0, 2.25, null, 2.25, 2, 30, "https://picsum.photos/500/500", "Tavuk Köftesi", 4.130000114440918 },
                    { 6, 336.0, 46.770000457763672, null, 9.0299997329711914, 2, 220, "https://picsum.photos/500/500", "Tavuklu Pilav", 15.899999618530273 },
                    { 7, 121.0, 2.7000000476837158, null, 9.0, 2, 45, "https://picsum.photos/500/500", "Tavuk Nugget", 7.1999998092651367 },
                    { 8, 243.0, 8.9200000762939453, null, 7.9000000953674316, 2, 170, "https://picsum.photos/500/500", "Ekmek Arası Tavuk Döner", 31.950000762939453 },
                    { 9, 309.0, 15.130000114440918, null, 36.369998931884766, 2, 250, "https://picsum.photos/500/500", "Tavuk Sote", 43.099998474121094 },
                    { 10, 95.0, 25.129999160766602, null, 0.31000000238418579, 3, 180, "https://picsum.photos/500/500", "Elma", 0.4699999988079071 },
                    { 11, 101.0, 27.110000610351562, null, 0.25, 3, 178, "https://picsum.photos/500/500", "Armut", 0.63999998569488525 },
                    { 12, 62.0, 15.399999618530273, null, 0.15999999642372131, 3, 130, "https://picsum.photos/500/500", "Portakal", 1.25 },
                    { 13, 74.0, 18.450000762939453, null, 0.25, 3, 245, "https://picsum.photos/500/500", "Greyfurt", 1.3500000238418579 },
                    { 14, 57.0, 15.300000190734863, null, 0.10000000149011612, 3, 250, "https://picsum.photos/500/500", "Ayva", 0.40000000596046448 },
                    { 15, 40.0, 10.149999618530273, null, 0.25, 3, 75, "https://picsum.photos/500/500", "Mandalina", 0.60000002384185791 },
                    { 16, 42.0, 10.100000381469727, null, 0.25, 3, 69, "https://picsum.photos/500/500", "Kivi", 0.62000000476837158 },
                    { 17, 105.0, 27.0, null, 0.40000000596046448, 3, 118, "https://picsum.photos/500/500", "Muz", 1.2999999523162842 },
                    { 18, 17.0, 3.9000000953674316, null, 0.15000000596046448, 3, 35, "https://picsum.photos/500/500", "Kayısı", 0.5 },
                    { 19, 46.0, 11.0, null, 0.44999998807907104, 3, 144, "https://picsum.photos/500/500", "Çilek", 0.94999998807907104 },
                    { 20, 60.0, 16.0, null, 0.17000000178813934, 3, 80, "https://picsum.photos/500/500", "Trabzon Hurması", 0.5 },
                    { 21, 87.0, 22.100000381469727, null, 0.30000001192092896, 3, 138, "https://picsum.photos/500/500", "Kiraz", 1.4500000476837158 },
                    { 22, 52.0, 13.0, null, 0.30000001192092896, 3, 250, "https://picsum.photos/500/500", "Vişne", 1.0299999713897705 },
                    { 23, 54.0, 13.050000190734863, null, 0.30000001192092896, 3, 150, "https://picsum.photos/500/500", "Kavun", 1.3500000238418579 },
                    { 24, 46.0, 15.130000114440918, null, 36.369998931884766, 3, 150, "https://picsum.photos/500/500", "Karpuz", 43.099998474121094 },
                    { 25, 28.0, 7.3499999046325684, null, 0.070000000298023224, 3, 56, "https://picsum.photos/500/500", "Ananas", 0.30000001192092896 },
                    { 26, 160.0, 8.5, null, 14.699999809265137, 3, 100, "https://picsum.photos/500/500", "Avakado", 2.0 },
                    { 27, 100.0, 24.700000762939453, null, 0.62999999523162842, 3, 165, "https://picsum.photos/500/500", "Mango", 1.3500000238418579 },
                    { 28, 64.0, 14.699999809265137, null, 0.80000001192092896, 3, 125, "https://picsum.photos/500/500", "Ahududu", 1.5 },
                    { 29, 62.0, 13.800000190734863, null, 0.80000001192092896, 3, 100, "https://picsum.photos/500/500", "Böğürtlen", 1.5 },
                    { 30, 76.0, 18.850000381469727, null, 0.5, 3, 165, "https://picsum.photos/500/500", "Yeşil Erik", 1.1499999761581421 },
                    { 31, 37.0, 9.3500003814697266, null, 0.15000000596046448, 3, 50, "https://picsum.photos/500/500", "İncir", 0.40000000596046448 },
                    { 32, 60.0, 13.699999809265137, null, 0.55000001192092896, 3, 140, "https://picsum.photos/500/500", "Dut", 2.0 },
                    { 33, 104.0, 27.299999237060547, null, 0.25, 3, 150, "https://picsum.photos/500/500", "Üzüm", 1.1000000238418579 },
                    { 34, 145.0, 33.0, null, 2.0, 3, 170, "https://picsum.photos/500/500", "Nar", 3.0 },
                    { 35, 60.0, 14.300000190734863, null, 0.37999999523162842, 3, 150, "https://picsum.photos/500/500", "Şeftali", 1.3600000143051147 },
                    { 36, 17.0, 5.4000000953674316, null, 0.17000000178813934, 3, 58, "https://picsum.photos/500/500", "Limon", 0.64999997615814209 },
                    { 37, 80.0, 21.0, null, 0.15000000596046448, 3, 135, "https://picsum.photos/500/500", "Kırmızı Erik", 1.0 },
                    { 38, 133.0, 21.899999618530273, null, 3.0, 4, 115, "https://picsum.photos/500/500", "Sütlaç", 4.0 },
                    { 39, 294.0, 47.900001525878906, null, 8.0, 4, 180, "https://picsum.photos/500/500", "Kazandibi", 5.6999998092651367 },
                    { 40, 300.0, 50.0, null, 7.1999998092651367, 4, 125, "https://picsum.photos/500/500", "Magnolia", 3.5 },
                    { 41, 380.0, 56.799999237060547, null, 11.199999809265137, 4, 170, "https://picsum.photos/500/500", "Tiramisu", 9.25 },
                    { 42, 510.0, 62.0, null, 23.469999313354492, 4, 150, "https://picsum.photos/500/500", "Cheesecake", 9.75 },
                    { 43, 143.0, 21.700000762939453, null, 4.8299999237060547, 4, 110, "https://picsum.photos/500/500", "Güllaç", 2.5499999523162842 },
                    { 44, 165.0, 31.100000381469727, null, 0.20000000298023224, 4, 210, "https://picsum.photos/500/500", "Tavuk Göğsü Tatlısı", 6.25 },
                    { 45, 233.0, 38.180000305175781, null, 4.5999999046325684, 4, 150, "https://picsum.photos/500/500", "Muhallebi", 4.6999998092651367 },
                    { 46, 132.0, 16.629999160766602, null, 3.7999999523162842, 4, 200, "https://picsum.photos/500/500", "Puding", 7.4499998092651367 },
                    { 47, 160.0, 19.0, null, 6.630000114440918, 4, 130, "https://picsum.photos/500/500", "Supangle", 4.5199999809265137 },
                    { 48, 301.0, 39.0, null, 9.25, 4, 185, "https://picsum.photos/500/500", "Trileçe", 12.850000381469727 },
                    { 49, 343.0, 111.0, null, 10.800000190734863, 4, 120, "https://picsum.photos/500/500", "Höşmerim", 17.0 },
                    { 50, 273.0, 42.549999237060547, null, 7.6999998092651367, 4, 250, "https://picsum.photos/500/500", "Keşkül", 7.3000001907348633 },
                    { 51, 344.0, 61.209999084472656, null, 5.5, 4, 110, "https://picsum.photos/500/500", "Aşure", 7.8400001525878906 },
                    { 52, 429.0, 55.799999237060547, null, 19.299999237060547, 4, 180, "https://picsum.photos/500/500", "Profiterol", 5.8000001907348633 },
                    { 53, 99.0, 21.049999237060547, null, 1.0199999809265137, 4, 75, "https://picsum.photos/500/500", "Meyveli Dondurma", 0.97000002861022949 },
                    { 54, 240.0, 30.75, null, 9.0, 4, 150, "https://picsum.photos/500/500", "Sütlü Dondurma", 9.0 },
                    { 55, 216.0, 28.200000762939453, null, 11.0, 4, 100, "https://picsum.photos/500/500", "Çikolatalı Dondurma", 3.7999999523162842 },
                    { 56, 262.0, 43.150001525878906, null, 5.0, 4, 170, "https://picsum.photos/500/500", "Sütlü İrmik Tatlısı", 7.0 },
                    { 57, 532.0, 64.900001525878906, null, 25.200000762939453, 4, 100, "https://picsum.photos/500/500", "İrmik Helvası", 7.7699999809265137 },
                    { 58, 294.0, 43.5, null, 12.180000305175781, 4, 90, "https://picsum.photos/500/500", "Kağıt Helva", 0.11999999731779099 },
                    { 59, 660.0, 79.0, null, 34.349998474121094, 4, 160, "https://picsum.photos/500/500", "Baklava", 12.359999656677246 },
                    { 60, 422.0, 51.75, null, 22.549999237060547, 4, 145, "https://picsum.photos/500/500", "Kadayıf", 6.8499999046325684 },
                    { 61, 242.0, 34.450000762939453, null, 14.75, 4, 82, "https://picsum.photos/500/500", "Soğuk Baklava", 3.2999999523162842 },
                    { 62, 256.0, 40.700000762939453, null, 7.25, 4, 90, "https://picsum.photos/500/500", "Tulumba", 2.5099999904632568 },
                    { 63, 476.0, 84.400001525878906, null, 13.550000190734863, 4, 285, "https://picsum.photos/500/500", "Kemalpaşa", 16.600000381469727 },
                    { 64, 673.0, 66.75, null, 40.599998474121094, 4, 215, "https://picsum.photos/500/500", "Halka Tatlısı", 5.0 },
                    { 65, 330.0, 150.75, null, 0.93999999761581421, 4, 90, "https://picsum.photos/500/500", "Şam Tatlısı", 18.879999160766602 },
                    { 66, 522.0, 59.759998321533203, null, 29.149999618530273, 4, 160, "https://picsum.photos/500/500", "Şöbiyet", 5.9499998092651367 },
                    { 67, 426.0, 55.0, null, 20.520000457763672, 4, 120, "https://picsum.photos/500/500", "Künefe", 7.3600001335144043 },
                    { 68, 272.0, 45.950000762939453, null, 8.9499998092651367, 4, 100, "https://picsum.photos/500/500", "Şekerpare", 2.6500000953674316 },
                    { 69, 348.0, 55.0, null, 9.3999996185302734, 4, 100, "https://picsum.photos/500/500", "Revani", 5.820000171661377 },
                    { 70, 78.0, 7.5199999809265137, null, 4.820000171661377, 4, 15, "https://picsum.photos/500/500", "Lokma Tatlısı", 0.34999999403953552 },
                    { 71, 251.0, 34.380001068115234, null, 11.329999923706055, 4, 85, "https://picsum.photos/500/500", "Kalburabastı", 4.0 },
                    { 72, 210.0, 20.950000762939453, null, 12.079999923706055, 4, 50, "https://picsum.photos/500/500", "Fıstıklı Sarma Tatlısı", 3.7100000381469727 },
                    { 73, 99.0, 12.630000114440918, null, 4.809999942779541, 4, 30, "https://picsum.photos/500/500", "Un Helvası", 0.47999998927116394 },
                    { 74, 480.0, 37.049999237060547, null, 33.299999237060547, 4, 150, "https://picsum.photos/500/500", "San Sebastian", 7.8000001907348633 },
                    { 75, 93.0, 0.75999999046325684, null, 7.3000001907348633, 5, 30, "https://picsum.photos/500/500", "Beyaz Peynir", 6.1100001335144043 },
                    { 76, 72.0, 1.1399999856948853, null, 6.0, 5, 30, "https://picsum.photos/500/500", "Süzme Peynir", 3.4000000953674316 },
                    { 77, 30.0, 0.14000000059604645, null, 2.3399999141693115, 5, 15, "https://picsum.photos/500/500", "Lor Peyniri", 2.1700000762939453 },
                    { 78, 71.0, 0.50999999046325684, null, 5.320000171661377, 5, 20, "https://picsum.photos/500/500", "Kaşar Peyniri", 5.4000000953674316 },
                    { 79, 10.0, 0.2800000011920929, null, 0.89999997615814209, 5, 5, "https://picsum.photos/500/500", "Labne", 0.25 },
                    { 80, 72.0, 0.37999999523162842, null, 5.0, 5, 25, "https://picsum.photos/500/500", "Örgü Peynir", 6.25 },
                    { 81, 68.0, 1.5800000429153442, null, 4.929999828338623, 5, 25, "https://picsum.photos/500/500", "Dil Peyniri", 4.3000001907348633 },
                    { 82, 90.0, 0.25999999046325684, null, 7.380000114440918, 5, 25, "https://picsum.photos/500/500", "Hellim Peyniri", 6.9800000190734863 },
                    { 83, 90.0, 0.6600000262260437, null, 6.7100000381469727, 5, 30, "https://picsum.photos/500/500", "Permesan Peynir", 6.6100001335144043 },
                    { 84, 61.0, 0.0, null, 5.0999999046325684, 5, 15, "https://picsum.photos/500/500", "Cheddar Peynir", 3.7100000381469727 },
                    { 85, 122.0, 9.3199996948242188, null, 6.5, 5, 200, "https://picsum.photos/500/500", "Yoğurt", 6.940000057220459 },
                    { 86, 115.0, 11.0, null, 4.8499999046325684, 5, 200, "https://picsum.photos/500/500", "Cacık", 6.6599998474121094 },
                    { 87, 78.0, 0.56000000238418579, null, 5.309999942779541, 2, 50, "https://picsum.photos/500/500", "Haşlanmış Yumurta", 6.3000001907348633 },
                    { 88, 101.0, 1.2699999809265137, null, 7.940000057220459, 2, 55, "https://picsum.photos/500/500", "Omlet", 6.6999998092651367 },
                    { 89, 254.0, 2.0499999523162842, null, 15.0, 2, 130, "https://picsum.photos/500/500", "Peynirli Omlet", 15.300000190734863 },
                    { 90, 205.0, 3.7000000476837158, null, 10.0, 2, 150, "https://picsum.photos/500/500", "Mantarlı Omlet", 12.449999809265137 },
                    { 91, 205.0, 3.7000000476837158, null, 10.0, 2, 150, "https://picsum.photos/500/500", "Menemen", 12.449999809265137 },
                    { 92, 242.0, 3.4000000953674316, null, 19.5, 2, 100, "https://picsum.photos/500/500", "Sucuklu Yumurta", 13.5 },
                    { 93, 489.0, 3.9500000476837158, null, 44.400001525878906, 5, 120, "https://picsum.photos/500/500", "Kuymak - Mıhlama", 19.100000381469727 },
                    { 94, 166.0, 2.5699999332427979, null, 14.199999809265137, 6, 50, "https://picsum.photos/500/500", "Sucuk", 7.0999999046325684 },
                    { 95, 60.0, 0.11999999731779099, null, 5.5999999046325684, 6, 40, "https://picsum.photos/500/500", "Sosis", 2.2400000095367432 },
                    { 96, 45.0, 0.63999998569488525, null, 3.9200000762939453, 6, 15, "https://picsum.photos/500/500", "Dana Salam", 1.6499999761581421 },
                    { 97, 17.0, 0.23999999463558197, null, 1.1299999952316284, 6, 8, "https://picsum.photos/500/500", "Hindi Salam", 1.309999942779541 },
                    { 98, 32.0, 0.69999998807907104, null, 0.0, 6, 30, "https://picsum.photos/500/500", "Dana Jambon", 4.9200000762939453 },
                    { 99, 15.0, 0.34999999403953552, null, 0.46000000834465027, 2, 12, "https://picsum.photos/500/500", "Hindi Jambon", 2.3499999046325684 },
                    { 100, 11.0, 0.11999999731779099, null, 0.43999999761581421, 2, 12, "https://picsum.photos/500/500", "Piliç Jambon", 1.559999942779541 },
                    { 101, 51.0, 0.0, null, 1.5, 2, 30, "https://picsum.photos/500/500", "Hindi Füme", 8.8000001907348633 },
                    { 102, 26.0, 0.30000001192092896, null, 0.89999997615814209, 2, 30, "https://picsum.photos/500/500", "Pilic Füme", 3.9000000953674316 },
                    { 103, 75.0, 0.0, null, 4.1700000762939453, 6, 30, "https://picsum.photos/500/500", "Pastırma", 8.8500003814697266 },
                    { 104, 5.0, 0.23999999463558197, null, 0.43999999761581421, 3, 4, "https://picsum.photos/500/500", "Siyah Zeytin", 0.029999999329447746 },
                    { 105, 6.0, 0.15000000596046448, null, 0.61000001430511475, 3, 4, "https://picsum.photos/500/500", "Yeşil Zeytin", 0.05000000074505806 },
                    { 106, 30.0, 8.25, null, 0.0, 4, 10, "https://picsum.photos/500/500", "Bal", 0.039999999105930328 },
                    { 107, 29.0, 0.17000000178813934, null, 3.1600000858306885, 5, 5, "https://picsum.photos/500/500", "Kaymak", 0.05000000074505806 },
                    { 108, 197.0, 15.800000190734863, null, 12.529999732971191, 4, 35, "https://picsum.photos/500/500", "Keçi Sütü", 5.1100001335144043 },
                    { 109, 169.0, 13.550000190734863, null, 10.0, 4, 30, "https://picsum.photos/500/500", "Cevizli Yaz Helvası", 4.4099998474121094 },
                    { 110, 87.0, 3.1800000667572021, null, 7.1999998092651367, 4, 15, "https://picsum.photos/500/500", "Tahin", 2.6700000762939453 },
                    { 111, 29.0, 0.0, null, 0.0099999997764825821, 4, 10, "https://picsum.photos/500/500", "Pekmez", 0.0 },
                    { 112, 27.0, 2.880000114440918, null, 1.5499999523162842, 4, 5, "https://picsum.photos/500/500", "Nutella", 0.31999999284744263 },
                    { 113, 25.0, 2.7100000381469727, null, 1.3799999952316284, 4, 5, "https://picsum.photos/500/500", "Kakaolu Fındık Kreması", 0.43999999761581421 },
                    { 114, 34.0, 3.0799999237060547, null, 2.2300000190734863, 4, 6, "https://picsum.photos/500/500", "Fındık Ezmesi", 0.55000001192092896 },
                    { 115, 35.0, 1.2999999523162842, null, 3.0, 1, 6, "https://picsum.photos/500/500", "Fıstık Ezmesi ", 1.440000057220459 },
                    { 116, 36.0, 1.1000000238418579, null, 2.7599999904632568, 4, 6, "https://picsum.photos/500/500", "Şekersiz Fıstık Ezmesi", 1.3200000524520874 },
                    { 117, 157.0, 30.590000152587891, null, 0.93000000715255737, 1, 100, "https://picsum.photos/500/500", "Haşlanmış Makarna", 5.8000001907348633 },
                    { 118, 178.0, 27.430000305175781, null, 4.4800000190734863, 8, 200, "https://picsum.photos/500/500", "Domatesli Makarna", 6.5500001907348633 },
                    { 119, 303.0, 20.899999618530273, null, 17.0, 8, 200, "https://picsum.photos/500/500", "Spagetti Bolonez", 15.829999923706055 },
                    { 120, 164.0, 31.180000305175781, null, 4.429999828338623, 8, 100, "https://picsum.photos/500/500", "Penne Arabiata", 26.5 },
                    { 121, 289.0, 50.099998474121094, null, 3.7999999523162842, 8, 100, "https://picsum.photos/500/500", "Fettucini Alfredo", 10.399999618530273 },
                    { 122, 272.0, 25.0, null, 13.560000419616699, 8, 150, "https://picsum.photos/500/500", "Lazanya", 12.649999618530273 },
                    { 123, 382.0, 52.259998321533203, null, 11.199999809265137, 8, 230, "https://picsum.photos/500/500", "Fırında Makarna", 17.139999389648438 },
                    { 124, 283.0, 53.75, null, 4.0399999618530273, 8, 300, "https://picsum.photos/500/500", "Makarna Salatası", 8.5200004577636719 },
                    { 125, 22.0, 4.8000001907348633, null, 0.0, 9, 20, "https://picsum.photos/500/500", "Ketçap", 0.25 },
                    { 126, 50.0, 3.1099998950958252, null, 4.3400001525878906, 9, 13, "https://picsum.photos/500/500", "Mayonez", 0.11999999731779099 },
                    { 127, 6.0, 0.57999998331069946, null, 0.33000001311302185, 9, 8, "https://picsum.photos/500/500", "Hardal", 0.37000000476837158 },
                    { 128, 26.0, 6.380000114440918, null, 0.059999998658895493, 9, 20, "https://picsum.photos/500/500", "Barbekü Sos", 0.11999999731779099 },
                    { 129, 24.0, 1.7899999618530273, null, 1.7000000476837158, 9, 20, "https://picsum.photos/500/500", "Ranch Sos", 0.46000000834465027 },
                    { 130, 56.0, 1.3999999761581421, null, 5.4000000953674316, 9, 20, "https://picsum.photos/500/500", "Buffalo Sos", 0.40000000596046448 },
                    { 131, 9.0, 0.54000002145767212, null, 4.8600001335144043, 9, 10, "https://picsum.photos/500/500", "Pesto Sos", 3.4700000286102295 },
                    { 132, 15.0, 3.7000000476837158, null, 0.0, 9, 8, "https://picsum.photos/500/500", "Nar Ekşisi", 0.05000000074505806 },
                    { 133, 22.0, 1.6000000238418579, null, 1.7000000476837158, 9, 10, "https://picsum.photos/500/500", "Köri Sos", 0.05000000074505806 },
                    { 134, 6.0, 0.56000000238418579, null, 0.0, 9, 10, "https://picsum.photos/500/500", "Soya Sos", 1.0499999523162842 },
                    { 135, 529.0, 38.049999237060547, null, 26.649999618530273, 2, 200, "https://picsum.photos/500/500", "Çıtır Tavuk", 34.0 },
                    { 136, 270.0, 33.0, null, 10.0, 10, 100, "https://picsum.photos/500/500", "Tavuk Burger ", 13.0 },
                    { 137, 290.0, 30.959999084472656, null, 12.0, 10, 115, "https://picsum.photos/500/500", "Cheeseburger", 16.950000762939453 },
                    { 138, 277.0, 31.069999694824219, null, 9.5600004196166992, 10, 130, "https://picsum.photos/500/500", "Etli Ekmek", 15.279999732971191 },
                    { 139, 221.0, 32.270000457763672, null, 5.5500001907348633, 10, 150, "https://picsum.photos/500/500", "Lahmacun", 9.75 },
                    { 140, 380.0, 19.049999237060547, null, 50.340000152587891, 10, 220, "https://picsum.photos/500/500", "Tantuni", 43.599998474121094 },
                    { 141, 241.0, 40.0, null, 5.630000114440918, 10, 130, "https://picsum.photos/500/500", "Karışık Pizza", 7.8000001907348633 },
                    { 142, 266.0, 41.229999542236328, null, 6.5999999046325684, 10, 220, "https://picsum.photos/500/500", "Sebzeli Pizza", 13.100000381469727 },
                    { 143, 433.0, 68.769996643066406, null, 3.9300000667572021, 10, 245, "https://picsum.photos/500/500", "Kokoreç Yarım Ekmek", 28.100000381469727 },
                    { 144, 361.0, 64.75, null, 30.639999389648438, 10, 150, "https://picsum.photos/500/500", "Çiğköfte Dürüm", 15.060000419616699 },
                    { 145, 309.0, 15.130000114440918, null, 36.369998931884766, 10, 250, "https://picsum.photos/500/500", "Tavuk Döner Dürüm", 43.099998474121094 },
                    { 146, 301.0, 19.700000762939453, null, 45.599998474121094, 10, 235, "https://picsum.photos/500/500", "Et Döner Dürüm", 29.649999618530273 },
                    { 147, 1296.0, 65.739997863769531, null, 92.349998474121094, 10, 640, "https://picsum.photos/500/500", "Kumpir", 50.0 },
                    { 148, 325.0, 15.020000457763672, null, 45.5, 10, 200, "https://picsum.photos/500/500", "Adana Dürüm", 27.799999237060547 },
                    { 149, 325.0, 15.020000457763672, null, 45.5, 10, 200, "https://picsum.photos/500/500", "Urfa Dürüm", 27.799999237060547 },
                    { 150, 250.0, 33.150001525878906, null, 11.800000190734863, 10, 80, "https://picsum.photos/500/500", "Patates Kızartması", 2.75 },
                    { 151, 97.0, 18.909999847412109, null, 0.62999999523162842, 10, 100, "https://picsum.photos/500/500", "Soğan Halkası", 3.4000000953674316 },
                    { 152, 628.0, 73.44000244140625, null, 25.569999694824219, 10, 300, "https://picsum.photos/500/500", "Kıymalı Pide", 24.600000381469727 },
                    { 153, 600.0, 69.0, null, 26.829999923706055, 10, 250, "https://picsum.photos/500/500", "Kaşarlı Pide", 19.75 },
                    { 154, 515.0, 73.199996948242188, null, 11.5, 10, 350, "https://picsum.photos/500/500", "Kuşbaşılı pide", 28.299999237060547 },
                    { 155, 22.0, 4.7800002098083496, null, 0.25, 11, 123, "https://picsum.photos/500/500", "Domates", 1.0800000429153442 },
                    { 156, 27.0, 5.8000001907348633, null, 0.30000001192092896, 11, 149, "https://picsum.photos/500/500", "Çeri Domates", 1.309999942779541 },
                    { 157, 15.0, 3.630000114440918, null, 0.10999999940395355, 3, 100, "https://picsum.photos/500/500", "Salatalık", 0.64999997615814209 },
                    { 158, 5.0, 1.0299999713897705, null, 0.05000000074505806, 11, 36, "https://picsum.photos/500/500", "Marul", 0.5 },
                    { 159, 12.0, 2.4600000381469727, null, 0.20999999344348907, 11, 46, "https://picsum.photos/500/500", "Çarliston Biber", 0.75999999046325684 },
                    { 160, 37.0, 7.179999828338623, null, 0.36000001430511475, 11, 119, "https://picsum.photos/500/500", " Kırmızı Biber", 1.1799999475479126 },
                    { 161, 1.0, 0.23999999463558197, null, 0.0010000000474974513, 11, 5, "https://picsum.photos/500/500", "Nane", 0.059999998658895493 },
                    { 162, 1.0, 0.23000000417232513, null, 0.029999999329447746, 11, 10, "https://picsum.photos/500/500", "Feslegen", 0.12999999523162842 },
                    { 163, 1.0, 0.23000000417232513, null, 0.0099999997764825821, 11, 10, "https://picsum.photos/500/500", "Dereotu", 0.12999999523162842 },
                    { 164, 5.0, 0.99000000953674316, null, 0.31999999284744263, 11, 5, "https://picsum.photos/500/500", "Kişniş", 0.2199999988079071 },
                    { 165, 4.0, 0.76999998092651367, null, 0.18000000715255737, 11, 5, "https://picsum.photos/500/500", "Biberiye", 0.059999998658895493 },
                    { 166, 1.0, 0.23999999463558197, null, 0.029999999329447746, 11, 5, "https://picsum.photos/500/500", "Maydanoz", 0.10999999940395355 },
                    { 167, 19.0, 3.940000057220459, null, 0.11999999731779099, 11, 116, "https://picsum.photos/500/500", "Turp", 0.79000002145767212 },
                    { 168, 27.0, 5.320000171661377, null, 0.30000001192092896, 11, 107, "https://picsum.photos/500/500", "Karnabahar", 2.0499999523162842 },
                    { 169, 31.0, 6.0399999618530273, null, 0.34000000357627869, 11, 91, "https://picsum.photos/500/500", "Brokoli", 2.5699999332427979 },
                    { 170, 38.0, 7.880000114440918, null, 0.25999999046325684, 11, 88, "https://picsum.photos/500/500", "Brüksel Lahana", 2.9700000286102295 },
                    { 171, 22.0, 5.1599998474121094, null, 0.090000003576278687, 11, 90, "https://picsum.photos/500/500", "Beyaz Lahana", 1.1399999856948853 },
                    { 172, 28.0, 6.559999942779541, null, 0.14000000059604645, 11, 90, "https://picsum.photos/500/500", "Kırmızı Lahana", 1.2699999809265137 },
                    { 173, 25.0, 5.8400001525878906, null, 0.15000000596046448, 11, 61, "https://picsum.photos/500/500", "Havuc", 0.56999999284744263 },
                    { 174, 4.0, 0.99000000953674316, null, 0.019999999552965164, 11, 5, "https://picsum.photos/500/500", "Sarımsak", 0.18999999761581421 },
                    { 175, 44.0, 10.270000457763672, null, 0.10999999940395355, 11, 110, "https://picsum.photos/500/500", "Soğan", 1.2100000381469727 },
                    { 176, 2.0, 0.43999999761581421, null, 0.0099999997764825821, 11, 5, "https://picsum.photos/500/500", "Yeşil Soğan", 0.10999999940395355 },
                    { 177, 9.0, 1.4600000381469727, null, 0.15000000596046448, 11, 43, "https://picsum.photos/500/500", "Semizotu", 0.87000000476837158 },
                    { 178, 7.0, 1.3500000238418579, null, 0.070000000298023224, 11, 36, "https://picsum.photos/500/500", "Pazı", 0.64999997615814209 },
                    { 179, 33.0, 6.0999999046325684, null, 0.62999999523162842, 11, 196, "https://picsum.photos/500/500", "Kabak", 2.369999885559082 },
                    { 180, 5.0, 0.73000001907348633, null, 0.12999999523162842, 11, 20, "https://picsum.photos/500/500", "Roka", 0.51999998092651367 },
                    { 181, 115.0, 5.0900001525878906, null, 10.300000190734863, 11, 100, "https://picsum.photos/500/500", "Ispanak Yemeği (Etsiz)", 2.1099998950958252 },
                    { 182, 112.0, 4.9800000190734863, null, 10.260000228881836, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Semizotu", 1.2899999618530273 },
                    { 183, 131.0, 11.890000343322754, null, 7.179999828338623, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Pazı", 3.7400000095367432 },
                    { 184, 151.0, 21.389999389648438, null, 5.5100002288818359, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Taze Fasülye", 5.5399999618530273 },
                    { 185, 120.0, 7.25, null, 10.270000457763672, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Pırasa", 0.9100000262260437 },
                    { 186, 147.0, 11.069999694824219, null, 10.380000114440918, 11, 100, "https://picsum.photos/500/500", "Bezelye Yemeği (Etsiz)", 3.4800000190734863 },
                    { 187, 80.0, 7.1399998664855957, null, 5.4099998474121094, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Brokoli", 2.369999885559082 },
                    { 188, 115.0, 5.2899999618530273, null, 10.409999847412109, 11, 100, "https://picsum.photos/500/500", "Karnabahar Yemeği(Etsiz)", 1.4800000190734863 },
                    { 189, 113.0, 4.679999828338623, null, 10.569999694824219, 11, 100, "https://picsum.photos/500/500", "Bamya Yemeği (Etsiz)", 1.059999942779541 },
                    { 190, 112.0, 8.6800003051757812, null, 8.869999885559082, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Türlü", 1.3300000429153442 },
                    { 191, 145.0, 9.7600002288818359, null, 10.689999580383301, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Bakla", 3.3199999332427979 },
                    { 192, 90.0, 7.1399998664855957, null, 6.369999885559082, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Kereviz", 1.9199999570846558 },
                    { 193, 146.0, 12.090000152587891, null, 10.710000038146973, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Enginar", 2.9300000667572021 },
                    { 194, 90.0, 4.5500001907348633, null, 10.189999580383301, 11, 200, "https://picsum.photos/500/500", "Sebze Sote", 0.93999999761581421 },
                    { 195, 258.0, 13.590000152587891, null, 13.600000381469727, 11, 200, "https://picsum.photos/500/500", "Zeytinyağlı Sebze Dolması", 5.5999999046325684 },
                    { 196, 108.0, 8.3199996948242188, null, 8.1499996185302734, 11, 60, "https://picsum.photos/500/500", "Zeytinyağlı Yaprak Sarma", 1.3300000429153442 },
                    { 197, 111.0, 5.190000057220459, null, 10.180000305175781, 11, 100, "https://picsum.photos/500/500", "Zeytinyağlı Kabak", 0.81000000238418579 },
                    { 198, 9.0, 1.7599999904632568, null, 0.12999999523162842, 12, 55, "https://picsum.photos/500/500", "Sade Salata (Karışık Yeşillik)", 0.8399999737739563 },
                    { 199, 180.0, 28.0, null, 5.0999999046325684, 12, 255, "https://picsum.photos/500/500", "Mercimekli Lor Peynirli Salata", 2.7000000476837158 },
                    { 200, 225.0, 5.2800002098083496, null, 8.2899999618530273, 12, 255, "https://picsum.photos/500/500", "Tavuklu Salata", 31.379999160766602 },
                    { 201, 267.0, 5.2800002098083496, null, 16.489999771118164, 12, 260, "https://picsum.photos/500/500", "Etli Salata (bonfileli/köfteli/fümeli)", 24.840000152587891 },
                    { 202, 215.0, 5.2800002098083496, null, 6.3499999046325684, 12, 270, "https://picsum.photos/500/500", "Ton Balıklı Salata", 21.959999084472656 },
                    { 203, 108.0, 15.840000152587891, null, 4.6399998664855957, 11, 60, "https://picsum.photos/500/500", "Kısır", 2.7100000381469727 },
                    { 204, 70.0, 9.9499998092651367, null, 2.4100000858306885, 12, 30, "https://picsum.photos/500/500", "Mercimet Köftesi", 2.75 },
                    { 205, 588.0, 51.0, null, 33.299999237060547, 12, 370, "https://picsum.photos/500/500", "Tabule Salatası", 14.399999618530273 },
                    { 206, 225.0, 6.6999998092651367, null, 9.8100004196166992, 12, 260, "https://picsum.photos/500/500", "Peynirli Yumurtalı Salata", 16.780000686645508 },
                    { 207, 115.0, 16.620000839233398, null, 3.7599999904632568, 12, 220, "https://picsum.photos/500/500", "Çoban Salata", 3.190000057220459 },
                    { 208, 114.0, 7.7100000381469727, null, 7.7199997901916504, 12, 155, "https://picsum.photos/500/500", "Gavurdağı Salata", 2.9500000476837158 },
                    { 209, 132.0, 21.770000457763672, null, 3.3299999237060547, 12, 187, "https://picsum.photos/500/500", "Patates Salatası", 2.4600000381469727 },
                    { 210, 172.0, 38.400001525878906, null, 0.95999997854232788, 12, 315, "https://picsum.photos/500/500", "Meyve Salatası", 1.6499999761581421 },
                    { 211, 98.0, 22.090000152587891, null, 0.62000000476837158, 10, 50, "https://picsum.photos/500/500", "Kestane", 0.81000000238418579 },
                    { 212, 76.0, 15.579999923706055, null, 0.8399999737739563, 10, 20, "https://picsum.photos/500/500", "Patlamış Mısır", 2.4000000953674316 },
                    { 213, 71.0, 11.699999809265137, null, 1.25, 13, 20, "https://picsum.photos/500/500", "Sarı Leblebi", 3.7300000190734863 },
                    { 214, 72.0, 11.899999618530273, null, 1.2000000476837158, 13, 20, "https://picsum.photos/500/500", "Beyaz Leblebi", 3.7899999618530273 },
                    { 215, 97.0, 2.5699999332427979, null, 9.3599996566772461, 13, 15, "https://picsum.photos/500/500", "Fındık", 2.2999999523162842 },
                    { 216, 97.0, 3.619999885559082, null, 8.3900003433227539, 13, 17, "https://picsum.photos/500/500", "Pembe Leblebi", 3.5499999523162842 },
                    { 217, 170.0, 4.8400001525878906, null, 14.770000457763672, 13, 30, "https://picsum.photos/500/500", "Yer Fıstığı", 7.7399997711181641 },
                    { 218, 103.0, 5.0900001525878906, null, 8.25, 13, 18, "https://picsum.photos/500/500", "Antep Fıstığı", 3.7899999618530273 },
                    { 219, 52.0, 1.1000000238418579, null, 5.2199997901916504, 13, 10, "https://picsum.photos/500/500", "Ceviz", 1.2200000286102295 },
                    { 220, 104.40000152587891, 2.6800000667572021, null, 8.4200000762939453, 13, 20, "https://picsum.photos/500/500", "Kabak Çekirdeği", 6.5999999046325684 },
                    { 221, 111.0, 6.0399999618530273, null, 8.7700004577636719, 13, 20, "https://picsum.photos/500/500", "Çiğ Kaju", 3.6400001049041748 },
                    { 222, 230.0, 13.079999923706055, null, 18.540000915527344, 13, 40, "https://picsum.photos/500/500", "Kaju Fıstığı Kavrulmuş", 6.119999885559082 },
                    { 223, 32.0, 5.1999998092651367, null, 0.75999999046325684, 13, 7, "https://picsum.photos/500/500", "Siyah Leblebi", 0.6600000262260437 },
                    { 224, 267.0, 68.900001525878906, null, 1.2000000476837158, 13, 100, "https://picsum.photos/500/500", "Erik Kurusu", 3.5 },
                    { 225, 277.0, 71.199996948242188, null, 0.5, 13, 100, "https://picsum.photos/500/500", "Üzüm Kurusu", 2.2999999523162842 },
                    { 226, 284.0, 72.199996948242188, null, 1.2000000476837158, 13, 100, "https://picsum.photos/500/500", "Kayısı Kurusu", 5.4000000953674316 },
                    { 227, 238.0, 62.299999237060547, null, 2.0999999046325684, 13, 100, "https://picsum.photos/500/500", "Elma Kurusu", 2.0999999046325684 },
                    { 228, 390.0, 80.5, null, 1.7999999523162842, 13, 100, "https://picsum.photos/500/500", "Muz Kurusu", 3.9000000953674316 },
                    { 229, 290.0, 78.0, null, 1.2000000476837158, 13, 100, "https://picsum.photos/500/500", "Kuru İncir", 3.5999999046325684 },
                    { 230, 277.0, 74.0, null, 0.40000000596046448, 13, 100, "https://picsum.photos/500/500", "Hurma", 2.0 },
                    { 231, 48.0, 12.0, null, 0.37999999523162842, 3, 100, "https://picsum.photos/500/500", "Yaban Mersini Kurusu", 0.37999999523162842 },
                    { 232, 270.0, 62.599998474121094, null, 0.60000002384185791, 13, 100, "https://picsum.photos/500/500", "Armut Kurusu", 2.2999999523162842 },
                    { 233, 719.0, 10.460000038146973, null, 74.779998779296875, 10, 100, "https://picsum.photos/500/500", "Patates Cipsi", 1.2300000190734863 },
                    { 234, 404.0, 42.680000305175781, null, 25.049999237060547, 10, 100, "https://picsum.photos/500/500", "Mısır Cipsi", 4.9499998092651367 },
                    { 235, 861.0, 84.150001525878906, null, 56.099998474121094, 10, 165, "https://picsum.photos/500/500", "Pringles Original", 6.2699999809265137 },
                    { 236, 198.0, 20.719999313354492, null, 11.829999923706055, 10, 100, "https://picsum.photos/500/500", "Ülker Çikolatalı Gofret", 2.130000114440918 },
                    { 237, 302.0, 68.30999755859375, null, 0.090000003576278687, 10, 100, "https://picsum.photos/500/500", "Jelibon", 5.8499999046325684 },
                    { 238, 765.0, 139.77000427246094, null, 16.799999237060547, 10, 175, "https://picsum.photos/500/500", "Petibör Bisküvi", 13.529999732971191 },
                    { 239, 184.0, 26.690000534057617, null, 4.8600001335144043, 10, 45, "https://picsum.photos/500/500", "Form Kepekli Bisküvi", 5.9000000953674316 },
                    { 240, 18.0, 2.9600000381469727, null, 0.60000002384185791, 10, 4, "https://picsum.photos/500/500", "Cicibebe Bisküvi", 0.18000000715255737 },
                    { 241, 26.0, 2.9000000953674316, null, 1.7599999904632568, 10, 5, "https://picsum.photos/500/500", "Çikolata", 0.2199999988079071 },
                    { 242, 76.0, 6.5999999046325684, null, 4.5399999618530273, 10, 50, "https://picsum.photos/500/500", "Protein Bar", 2.2100000381469727 },
                    { 243, 270.0, 41.040000915527344, null, 10.829999923706055, 10, 57, "https://picsum.photos/500/500", "Oreo", 2.0 },
                    { 244, 286.0, 72.199996948242188, null, 0.0, 10, 76, "https://picsum.photos/500/500", "Olips Şeker", 0.0 },
                    { 245, 167.0, 14.310000419616699, null, 10.979999542236328, 10, 30, "https://picsum.photos/500/500", "Tadelle Çikolata", 2.7000000476837158 },
                    { 246, 190.0, 21.879999160766602, null, 9.9799995422363281, 10, 35, "https://picsum.photos/500/500", "Dido Çikolata", 2.7000000476837158 },
                    { 247, 259.0, 29.0, null, 14.0, 10, 50, "https://picsum.photos/500/500", "Karam Gurme", 2.75 },
                    { 248, 154.0, 22.0, null, 7.9200000762939453, 10, 40, "https://picsum.photos/500/500", "Eti Brownie Gold", 2.0399999618530273 },
                    { 249, 118.0, 10.75, null, 7.2800002098083496, 10, 28, "https://picsum.photos/500/500", "Kinder Süt Dilimi", 2.1600000858306885 },
                    { 250, 110.0, 10.399999618530273, null, 6.8000001907348633, 10, 20, "https://picsum.photos/500/500", "Kinder Sürpriz Yumurta", 1.6000000238418579 },
                    { 251, 50.0, 7.8400001525878906, null, 1.7799999713897705, 10, 11, "https://picsum.photos/500/500", "Eti Gong", 0.63999998569488525 },
                    { 252, 50.0, 6.5100002288818359, null, 2.4100000858306885, 10, 10, "https://picsum.photos/500/500", "Biskrem", 0.44999998807907104 },
                    { 253, 39.0, 4.369999885559082, null, 1.8999999761581421, 10, 8, "https://picsum.photos/500/500", "Ülker Probis", 0.93000000715255737 },
                    { 254, 113.0, 17.049999237060547, null, 3.7799999713897705, 10, 35, "https://picsum.photos/500/500", "Süt Burger", 1.75 },
                    { 255, 90.0, 12.649999618530273, null, 4.0100002288818359, 10, 55, "https://picsum.photos/500/500", "Dankek 8kek", 0.87999999523162842 },
                    { 256, 232.0, 26.5, null, 12.850000381469727, 10, 50, "https://picsum.photos/500/500", "Brownie Intense", 2.2999999523162842 },
                    { 257, 167.0, 22.959999084472656, null, 7.2399997711181641, 10, 40, "https://picsum.photos/500/500", "Eti Topkek Kakolu", 2.119999885559082 },
                    { 258, 264.0, 34.619998931884766, null, 12.600000381469727, 10, 60, "https://picsum.photos/500/500", "Eti Popkek Meyveli", 2.8199999332427979 },
                    { 259, 167.0, 22.959999084472656, null, 7.2399997711181641, 10, 40, "https://picsum.photos/500/500", "Eti Topkek Portakallı", 2.119999885559082 },
                    { 260, 132.0, 20.309999465942383, null, 5.0999999046325684, 1, 30, "https://picsum.photos/500/500", "Halley", 1.2000000476837158 },
                    { 261, 33.0, 5.1599998474121094, null, 1.2699999809265137, 10, 7, "https://picsum.photos/500/500", "Ülker Kremalı Bisküvi", 0.36000001430511475 },
                    { 262, 152.0, 18.600000381469727, null, 7.8000001907348633, 10, 30, "https://picsum.photos/500/500", "Ülker Çokoprens", 1.6799999475479126 },
                    { 263, 44.0, 7.429999828338623, null, 1.3799999952316284, 10, 10, "https://picsum.photos/500/500", "Eti Cin", 0.4699999988079071 },
                    { 264, 584.0, 69.720001220703125, null, 29.280000686645508, 10, 120, "https://picsum.photos/500/500", "Eti Nero", 8.2799997329711914 },
                    { 265, 51.0, 6.0999999046325684, null, 2.5999999046325684, 10, 10, "https://picsum.photos/500/500", "Eti Tutku", 0.5 },
                    { 266, 46.0, 6.130000114440918, null, 2.1600000858306885, 10, 10, "https://picsum.photos/500/500", "Eti Benim'O", 0.4699999988079071 },
                    { 267, 68.0, 9.869999885559082, null, 2.5399999618530273, 10, 15, "https://picsum.photos/500/500", "Eti Burçak", 0.93000000715255737 },
                    { 268, 405.0, 52.919998168945312, null, 17.639999389648438, 10, 84, "https://picsum.photos/500/500", "Ülker İkram", 6.4699997901916504 },
                    { 269, 605.0, 90.75, null, 23.75, 10, 125, "https://picsum.photos/500/500", "Lotus Bisküvi", 6.130000114440918 },
                    { 270, 133.0, 18.100000381469727, null, 5.4000000953674316, 10, 30, "https://picsum.photos/500/500", "Şölen Greta Zeytinli", 2.7999999523162842 },
                    { 271, 181.0, 19.110000610351562, null, 11.319999694824219, 10, 33, "https://picsum.photos/500/500", "Ülker Çokonat", 2.0499999523162842 },
                    { 272, 120.0, 10.399999618530273, null, 7.8299999237060547, 10, 21, "https://picsum.photos/500/500", "Kinder Bueno", 1.809999942779541 },
                    { 273, 197.0, 25.559999465942383, null, 9.8000001907348633, 10, 40, "https://picsum.photos/500/500", "Eti Hoşbeş", 3.0399999618530273 },
                    { 274, 250.0, 34.0, null, 12.0, 10, 50, "https://picsum.photos/500/500", "Twix", 4.0 },
                    { 275, 237.0, 31.309999465942383, null, 11.350000381469727, 10, 50, "https://picsum.photos/500/500", "Snickers", 3.7999999523162842 },
                    { 276, 225.0, 35.0, null, 8.5, 10, 50, "https://picsum.photos/500/500", "Mars", 2.0 },
                    { 277, 206.0, 25.200000762939453, null, 10.640000343322754, 10, 40, "https://picsum.photos/500/500", "Ülker Albeni", 2.2400000095367432 },
                    { 278, 169.0, 20.159999847412109, null, 8.7399997711181641, 10, 33, "https://picsum.photos/500/500", "Crunch Çikolata", 2.0499999523162842 },
                    { 279, 184.0, 27.360000610351562, null, 7.4000000953674316, 10, 40, "https://picsum.photos/500/500", "Ülker Metro", 1.9600000381469727 },
                    { 280, 193.0, 22.979999542236328, null, 9.7799997329711914, 10, 60, "https://picsum.photos/500/500", "Alaska Frigo", 2.4000000953674316 },
                    { 281, 148.0, 15.479999542236328, null, 0.0, 10, 28, "https://picsum.photos/500/500", "Coco Star", 1.2000000476837158 },
                    { 282, 200.0, 40.819999694824219, null, 2.9100000858306885, 10, 52, "https://picsum.photos/500/500", "Sade Çubuk Kraker", 5.5100002288818359 },
                    { 283, 172.0, 22.389999389648438, null, 7.0999999046325684, 10, 37, "https://picsum.photos/500/500", "Susamlı Çubuk Kraker", 3.8900001049041748 },
                    { 284, 113.0, 5.4699997901916504, null, 8.8599996566772461, 10, 20, "https://picsum.photos/500/500", "Çizi Bisküvi", 3.1500000953674316 },
                    { 285, 125.0, 15.0, null, 6.25, 10, 75, "https://picsum.photos/500/500", "Cornetto", 1.559999942779541 },
                    { 286, 239.0, 24.639999389648438, null, 14.630000114440918, 10, 77, "https://picsum.photos/500/500", "Magnum", 2.7000000476837158 },
                    { 287, 179.0, 42.049999237060547, null, 0.20000000298023224, 10, 50, "https://picsum.photos/500/500", "Mısır Gevreği / Cornflakes", 3.75 },
                    { 288, 195.0, 33.139999389648438, null, 3.4500000476837158, 10, 100, "https://picsum.photos/500/500", "Yulaf Ezmesi", 8.4499998092651367 },
                    { 289, 336.0, 57.520000457763672, null, 4.440000057220459, 8, 230, "https://picsum.photos/500/500", "Pilav Üstü Kuru", 15.279999732971191 },
                    { 290, 334.0, 30.299999237060547, null, 12.289999961853027, 8, 230, "https://picsum.photos/500/500", "Hamsili Pilav", 26.520000457763672 },
                    { 291, 462.0, 82.849998474121094, null, 10.010000228881836, 8, 270, "https://picsum.photos/500/500", "Şehriyeli Pilav", 8.5299997329711914 },
                    { 292, 169.0, 31.290000915527344, null, 2.940000057220459, 8, 100, "https://picsum.photos/500/500", "Nohutlu Pilav ", 4.1500000953674316 },
                    { 293, 139.0, 25.989999771118164, null, 2.5299999713897705, 8, 100, "https://picsum.photos/500/500", "İç Pilav", 2.5899999141693115 },
                    { 294, 118.0, 22.620000839233398, null, 1.9900000095367432, 8, 80, "https://picsum.photos/500/500", "Sade Pilav", 1.9900000095367432 },
                    { 295, 169.0, 31.129999160766602, null, 2.6099998950958252, 8, 230, "https://picsum.photos/500/500", "Domatesli Bulgur Pilavı", 4.559999942779541 },
                    { 296, 480.0, 43.689998626708984, null, 23.760000228881836, 8, 245, "https://picsum.photos/500/500", "Acem Pilavı", 22.319999694824219 },
                    { 297, 570.0, 58.200000762939453, null, 27.559999465942383, 8, 340, "https://picsum.photos/500/500", "Özbek Pilavı", 22.350000381469727 },
                    { 298, 118.0, 14.050000190734863, null, 3.0999999046325684, 8, 50, "https://picsum.photos/500/500", "Basmati Pilavı", 1.6499999761581421 },
                    { 299, 380.0, 72.760002136230469, null, 3.75, 8, 180, "https://picsum.photos/500/500", "Kuskus Pilavı", 11.789999961853027 },
                    { 300, 283.0, 46.470001220703125, null, 8.6499996185302734, 8, 170, "https://picsum.photos/500/500", "Tereyağlı Pirinç Pilavı", 4.1399998664855957 },
                    { 301, 31.0, 3.059999942779541, null, 1.6000000238418579, 14, 150, "https://picsum.photos/500/500", "Bezelye Çorbası", 1.0499999523162842 },
                    { 302, 47.0, 6.5300002098083496, null, 1.6599999666213989, 14, 150, "https://picsum.photos/500/500", "Domates Çorbası", 1.3600000143051147 },
                    { 303, 31.0, 2.0699999332427979, null, 1.7300000190734863, 14, 100, "https://picsum.photos/500/500", "Kaşarlı Domates Çorbası", 1.6799999475479126 },
                    { 304, 68.0, 8.9200000762939453, null, 1.7599999904632568, 14, 150, "https://picsum.photos/500/500", "Ezogelin Çorbası", 2.8299999237060547 },
                    { 305, 139.0, 4.929999828338623, null, 6.3499999046325684, 14, 100, "https://picsum.photos/500/500", "İşkembe Çorbası", 15.140000343322754 },
                    { 306, 68.0, 12.420000076293945, null, 0.28999999165534973, 14, 150, "https://picsum.photos/500/500", "Kırmızı Mercimek Çorbası", 3.690000057220459 },
                    { 307, 121.0, 12.039999961853027, null, 6.0300002098083496, 14, 150, "https://picsum.photos/500/500", "Yeşil Mercimek Çorbası", 4.5 },
                    { 308, 44.0, 6.059999942779541, null, 1.6799999475479126, 14, 100, "https://picsum.photos/500/500", "Sebze Çorbası", 1.0 },
                    { 309, 91.0, 7.4800000190734863, null, 4.929999828338623, 14, 150, "https://picsum.photos/500/500", "Tarhana Çorbası", 3.4500000476837158 },
                    { 310, 70.0, 9.7100000381469727, null, 2.4100000858306885, 14, 150, "https://picsum.photos/500/500", "Yayla Çorbası", 12.189999580383301 },
                    { 311, 83.0, 5.1700000762939453, null, 2.9500000476837158, 14, 150, "https://picsum.photos/500/500", "Tavuk Çorbası", 5.9600000381469727 },
                    { 312, 29.0, 2.4100000858306885, null, 1.190000057220459, 14, 100, "https://picsum.photos/500/500", "Balkabaği Çorbası", 1.8700000047683716 },
                    { 313, 99.0, 7.3600001335144043, null, 6.369999885559082, 14, 150, "https://picsum.photos/500/500", "Mantar Çorbası", 3.059999942779541 },
                    { 314, 120.0, 5.2100000381469727, null, 11.270000457763672, 14, 150, "https://picsum.photos/500/500", "Kremalı Mantar Çorbası", 1.9199999570846558 },
                    { 315, 39.0, 5.059999942779541, null, 1.4700000286102295, 14, 150, "https://picsum.photos/500/500", "Brokoli Çorbası", 1.3700000047683716 },
                    { 316, 117.0, 0.86000001430511475, null, 4.2899999618530273, 14, 150, "https://picsum.photos/500/500", "Paça Çorbası", 18.809999465942383 },
                    { 317, 49.0, 4.429999828338623, null, 1.2699999809265137, 14, 100, "https://picsum.photos/500/500", "Balik Çorbası", 4.5100002288818359 },
                    { 318, 72.0, 7.1999998092651367, null, 3.0699999332427979, 14, 100, "https://picsum.photos/500/500", "Tutmac Çorbası", 3.0099999904632568 },
                    { 319, 67.0, 6.5100002288818359, null, 4.1599998474121094, 14, 150, "https://picsum.photos/500/500", "Kereviz Çorbası", 0.87000000476837158 },
                    { 320, 71.0, 13.170000076293945, null, 0.64999997615814209, 1, 30, "https://picsum.photos/500/500", "Beyaz Ekmek", 3.2000000476837158 },
                    { 321, 63.0, 10.680000305175781, null, 0.87999999523162842, 8, 25, "https://picsum.photos/500/500", "Tam Buğday Ekmeği", 3.1099998950958252 },
                    { 322, 63.0, 13.149999618530273, null, 0.27000001072883606, 8, 30, "https://picsum.photos/500/500", "Cavdar Ekmeği", 1.809999942779541 },
                    { 323, 54.0, 11.140000343322754, null, 0.37999999523162842, 8, 25, "https://picsum.photos/500/500", "Kepekli Ekmek", 1.5099999904632568 },
                    { 324, 20.0, 3.5299999713897705, null, 0.36000001430511475, 8, 5, "https://picsum.photos/500/500", "Grissini", 0.50999999046325684 },
                    { 325, 76.0, 14.310000419616699, null, 1.0, 8, 30, "https://picsum.photos/500/500", "Beyaz Tost Ekmeği", 2.2100000381469727 },
                    { 326, 67.0, 11.649999618530273, null, 0.79000002145767212, 8, 28, "https://picsum.photos/500/500", "Çok Tahıllı Tost Ekmeği", 3.3299999237060547 },
                    { 327, 178.0, 37.209999084472656, null, 1.6100000143051147, 8, 65, "https://picsum.photos/500/500", "Sandviç Ekmeği", 5.070000171661377 },
                    { 328, 171.0, 31.079999923706055, null, 1.5, 8, 70, "https://picsum.photos/500/500", "Kepekli Sandviç Ekmeği", 6.7199997901916504 },
                    { 329, 142.0, 29.639999389648438, null, 1.0399999618530273, 8, 52, "https://picsum.photos/500/500", "Hamburger Ekmeği", 3.6400001049041748 },
                    { 330, 387.0, 80.180000305175781, null, 1.4099999666213989, 8, 160, "https://picsum.photos/500/500", "Yufka", 10.939999580383301 },
                    { 331, 36.0, 7.2800002098083496, null, 0.10999999940395355, 8, 10, "https://picsum.photos/500/500", "İrmik", 1.2699999809265137 },
                    { 332, 37.0, 9.0600004196166992, null, 0.079999998211860657, 8, 10, "https://picsum.photos/500/500", "Mısır Nişastası", 0.019999999552965164 },
                    { 333, 40.0, 7.1999998092651367, null, 0.52999997138977051, 8, 10, "https://picsum.photos/500/500", "Galeta Unu", 1.3400000333786011 },
                    { 334, 40.0, 8.5399999618530273, null, 0.0099999997764825821, 8, 10, "https://picsum.photos/500/500", "Beyaz Un", 0.039999999105930328 },
                    { 335, 194.0, 25.110000610351562, null, 6.8499999046325684, 8, 75, "https://picsum.photos/500/500", "Peynirli Börek", 7.5799999237060547 },
                    { 336, 204.0, 26.870000839233398, null, 8.6700000762939453, 8, 75, "https://picsum.photos/500/500", "Patatesli Börek", 4.2699999809265137 },
                    { 337, 116.0, 21.389999389648438, null, 2.3499999046325684, 8, 75, "https://picsum.photos/500/500", "Ispanaklı Börek", 4.2899999618530273 },
                    { 338, 172.0, 18.770000457763672, null, 8.2399997711181641, 8, 75, "https://picsum.photos/500/500", "Su Böreği", 5.3899998664855957 },
                    { 339, 264.0, 32.759998321533203, null, 13.279999732971191, 8, 70, "https://picsum.photos/500/500", "Çiğ Börek", 3.1800000667572021 },
                    { 340, 107.0, 18.430000305175781, null, 1.0800000429153442, 8, 75, "https://picsum.photos/500/500", "Patlıcanlı Börek", 4.0500001907348633 },
                    { 341, 361.0, 57.099998474121094, null, 7.9699997901916504, 4, 220, "https://picsum.photos/500/500", "Bisküvili Pasta", 11.220000267028809 },
                    { 342, 577.0, 39.560001373291016, null, 42.849998474121094, 4, 150, "https://picsum.photos/500/500", "Çikolatalı Pasta", 7.440000057220459 },
                    { 343, 257.0, 41.5, null, 6.0900001525878906, 4, 150, "https://picsum.photos/500/500", "Meyveli Pasta", 6.380000114440918 },
                    { 344, 286.0, 43.490001678466797, null, 6.8000001907348633, 4, 160, "https://picsum.photos/500/500", "Muzlu Rulo Pasta", 10.270000457763672 },
                    { 345, 241.0, 32.950000762939453, null, 9.1499996185302734, 4, 70, "https://picsum.photos/500/500", "Sade Kek", 4.4499998092651367 },
                    { 346, 268.0, 31.200000762939453, null, 13.109999656677246, 4, 70, "https://picsum.photos/500/500", "Kakaolu Kek", 3.940000057220459 },
                    { 347, 249.0, 26.909999847412109, null, 13.359999656677246, 4, 70, "https://picsum.photos/500/500", "Havuclu Kek", 3.8399999141693115 },
                    { 348, 188.0, 28.920000076293945, null, 5.6999998092651367, 4, 70, "https://picsum.photos/500/500", "Portakallı Kek", 3.5499999523162842 },
                    { 349, 153.0, 18.079999923706055, null, 7.6599998474121094, 4, 45, "https://picsum.photos/500/500", "Elmalı Kurabiye", 2.4900000095367432 },
                    { 350, 238.0, 22.219999313354492, null, 14.840000152587891, 4, 45, "https://picsum.photos/500/500", "Fındıklı Kurabiye", 3.8599998950958252 },
                    { 351, 203.0, 21.610000610351562, null, 11.380000114440918, 4, 45, "https://picsum.photos/500/500", "Cevizli Kurabiye", 3.690000057220459 },
                    { 352, 210.0, 21.950000762939453, null, 12.199999809265137, 4, 45, "https://picsum.photos/500/500", "Çikolatalı Kurabiye", 2.9700000286102295 },
                    { 353, 161.0, 17.649999618530273, null, 8.6800003051757812, 4, 45, "https://picsum.photos/500/500", "Yulafli Fit Kurabiye", 5.4800000190734863 },
                    { 354, 102.0, 19.389999389648438, null, 1.5399999618530273, 4, 45, "https://picsum.photos/500/500", "Kuru Uzumlu Diyet Kurabiye", 3.4600000381469727 },
                    { 355, 184.0, 19.309999465942383, null, 10.220000267028809, 4, 30, "https://picsum.photos/500/500", "Tuzlu Pastane Kurabiyesi", 3.8199999332427979 },
                    { 356, 128.0, 21.059999465942383, null, 4.6700000762939453, 4, 30, "https://picsum.photos/500/500", "Tuzsuz Pastane Kurabiyesi", 0.18000000715255737 },
                    { 357, 167.0, 14.970000267028809, null, 60.669998168945312, 4, 35, "https://picsum.photos/500/500", "Kandil Simidi", 2.9300000667572021 },
                    { 358, 275.0, 57.139999389648438, null, 3.5699999332427979, 1, 100, "https://picsum.photos/500/500", "Simit", 10.710000038146973 },
                    { 359, 243.0, 22.329999923706055, null, 14.739999771118164, 1, 70, "https://picsum.photos/500/500", "Poğaça", 4.9099998474121094 },
                    { 360, 274.0, 21.399999618530273, null, 18.290000915527344, 8, 70, "https://picsum.photos/500/500", "Peynirli Poğaça", 6.0999999046325684 },
                    { 361, 234.0, 25.200000762939453, null, 20.440000534057617, 8, 70, "https://picsum.photos/500/500", "Dereotlu Poğaça", 5.0900001525878906 },
                    { 362, 267.0, 23.969999313354492, null, 17.270000457763672, 8, 70, "https://picsum.photos/500/500", "Zeytinli Poğaça", 5.059999942779541 },
                    { 363, 230.0, 20.010000228881836, null, 14.960000038146973, 8, 70, "https://picsum.photos/500/500", "Patatesli Poğaça", 3.4800000190734863 },
                    { 364, 341.0, 35.220001220703125, null, 23.889999389648438, 1, 90, "https://picsum.photos/500/500", "Acma", 5.9099998474121094 },
                    { 365, 268.0, 36.709999084472656, null, 10.829999923706055, 8, 75, "https://picsum.photos/500/500", "Cikolatalı Acma", 5.320000171661377 },
                    { 366, 354.0, 31.25, null, 22.950000762939453, 8, 90, "https://picsum.photos/500/500", "Zeytinli Acma", 5.2699999809265137 },
                    { 367, 250.0, 45.159999847412109, null, 0.62999999523162842, 8, 180, "https://picsum.photos/500/500", "Etsiz Kuru Fasulye", 17.510000228881836 },
                    { 368, 322.0, 41.159999847412109, null, 0.62999999523162842, 8, 200, "https://picsum.photos/500/500", "Etli Kuru Fasulye", 11.800000190734863 },
                    { 369, 132.0, 22.420000076293945, null, 2.3900001049041748, 8, 200, "https://picsum.photos/500/500", "Bezelye Yemegi    ", 6.1500000953674316 },
                    { 370, 164.0, 17.040000915527344, null, 4.5199999809265137, 8, 230, "https://picsum.photos/500/500", "Mercimnek Yemegi ", 8.9700002670288086 },
                    { 371, 140.0, 42.830001831054688, null, 14.140000343322754, 8, 140, "https://picsum.photos/500/500", "ZeytinFatlı Barbunya ", 15.989999771118164 },
                    { 372, 140.0, 42.830001831054688, null, 14.140000343322754, 8, 140, "https://picsum.photos/500/500", "zeytinFatlıBarbunya ", 15.989999771118164 },
                    { 373, 607.0, 110.31999969482422, null, 1.9099999666213989, 8, 180, "https://picsum.photos/500/500", "Meksika Fasulyesi ", 40.549999237060547 },
                    { 374, 274.0, 0.31000000238418579, null, 17.790000915527344, 8, 180, "https://picsum.photos/500/500", "Soya Fasulyesi ", 28.309999465942383 },
                    { 375, 44.0, 0.0, null, 4.9899997711181641, 5, 5, "https://picsum.photos/500/500", "Balik Fati ", 0.0 },
                    { 376, 135.0, 0.0, null, 15.0, 15, 15, "https://picsum.photos/500/500", "İç Fati ", 0.0 },
                    { 377, 79.0, 0.0099999997764825821, null, 8.6099996566772461, 15, 14, "https://picsum.photos/500/500", "Kuyruk Fati ", 0.28999999165534973 },
                    { 378, 44.0, 0.0, null, 5.0, 15, 5, "https://picsum.photos/500/500", "Aycicek Fati ", 0.0 },
                    { 379, 35.0, 0.0, null, 4.0, 15, 4, "https://picsum.photos/500/500", "Fındık Fati ", 0.0 },
                    { 380, 40.0, 0.0099999997764825821, null, 4.5, 15, 4, "https://picsum.photos/500/500", "Zeytin Fati ", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AimId", "Email", "FirstName", "Height", "LastName", "PasswordHash", "PasswordSalt", "UserAccess", "UserStatus", "Weight" },
                values: new object[] { 3, 1, "admin", "Admin", 1.8, "Admin", new byte[] { 108, 201, 165, 162, 112, 59, 180, 38, 187, 6, 81, 121, 8, 251, 225, 102, 89, 166, 151, 220, 72, 221, 161, 222, 194, 58, 78, 214, 35, 54, 234, 34, 98, 89, 162, 119, 0, 116, 87, 132, 75, 27, 15, 7, 137, 46, 249, 85, 121, 122, 15, 201, 153, 108, 253, 134, 202, 214, 171, 3, 100, 171, 142, 51 }, new byte[] { 218, 189, 128, 231, 168, 98, 232, 98, 139, 76, 236, 125, 11, 48, 125, 153, 166, 3, 24, 232, 92, 172, 60, 249, 240, 145, 203, 137, 156, 151, 225, 241, 181, 73, 180, 119, 86, 175, 146, 71, 27, 159, 156, 177, 31, 106, 30, 172, 1, 131, 212, 1, 222, 200, 24, 155, 128, 130, 141, 187, 154, 166, 193, 212, 166, 251, 231, 198, 99, 113, 142, 93, 168, 187, 54, 113, 122, 216, 169, 54, 179, 67, 58, 64, 138, 58, 87, 249, 194, 9, 159, 250, 227, 177, 172, 49, 93, 8, 170, 199, 201, 111, 240, 22, 144, 154, 154, 219, 81, 255, 69, 3, 78, 67, 210, 204, 181, 236, 119, 170, 44, 71, 39, 101, 142, 174, 201, 28 }, 1, 1, 80.0 });

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmounts_UserMealId",
                table: "FoodAmounts",
                column: "UserMealId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Name",
                table: "Foods",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserMeals_UserId",
                table: "UserMeals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AimId",
                table: "Users",
                column: "AimId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodAmounts");

            migrationBuilder.DropTable(
                name: "UserVerifications");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "UserMeals");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Aims");
        }
    }
}
