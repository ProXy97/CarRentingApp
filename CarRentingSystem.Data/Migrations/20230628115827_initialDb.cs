using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentingSystem.Web.Data.Migrations
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MaxWeightCapacity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MinAgeRequired = table.Column<int>(type: "int", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PeopleCapacity = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Emissions = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CategoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProtectionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    ProtectionPlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Extras_ProtectionPlans_ProtectionPlanId",
                        column: x => x.ProtectionPlanId,
                        principalTable: "ProtectionPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "Id", "Category", "Description", "ImagePath", "IsAvailable", "Make", "MaxWeightCapacity", "Model" },
                values: new object[] { 1, "Van", "The award-winning van that continues to lead the way for large vans - the Sprinter Panel Van boasts the highest standard specification of any large van. Take your business to the next level.", "/img/Cargos/Mercedes Cargo.png", true, "Mercedes", 3750, "Sprinter" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryType", "Description", "Emissions", "ImageUrl", "IsAvailable", "Location", "Make", "MinAgeRequired", "Model", "PeopleCapacity", "Power", "PricePerDay", "Transmission", "Year" },
                values: new object[,]
                {
                    { 1, "Luxury", "Performance. Efficiency. Design. This is Audi Innovation. Sophistication in every detail.", 120, "https://imgd.aeplcdn.com/370x208/n/cw/ec/39472/a6-exterior-right-front-three-quarter.jpeg?q=75", true, "Sofia", "Audi", 28, "A6", 5, 333, 199.99m, "Automatic", 2022 },
                    { 2, "Luxury", "Performance. Efficiency. Design. This is Audi Innovation. Sophistication in every detail.", 80, "https://www.motortrend.com/uploads/sites/10/2020/12/2021-audi-a4-premium-sedan-angular-front.png", true, "Sofia", "Audi", 28, "A4", 5, 170, 179.99m, "Automatic", 2021 },
                    { 3, "Luxury", "The BMW 520d 2021 is a luxury sedan that combines elegance and performance. It features a powerful yet efficient diesel engine, delivering a smooth and dynamic driving experience. With its sleek design, advanced technology, and comfortable interior, it offers a perfect blend of style, comfort, and sophistication.", 80, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTy8W7qHiL69C8N-v0y_3xIM1jwkrBpKrVuVw&usqp=CAU", true, "Plovdiv", "BMW", 28, "520d", 5, 170, 199.99m, "Automatic", 2021 },
                    { 4, "Small", "Stylish and compact hatchback that offers a perfect balance of performance, efficiency, and modern features, making it a practical and enjoyable urban companion.", 30, "https://media.autoexpress.co.uk/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1649084579/autoexpress/2022/04/Renault%20Clio%202022.jpg", true, "Plovdiv", "Renault", 22, "Clio", 4, 70, 49.99m, "Manual", 2022 },
                    { 5, "Medium", "Reliable and spacious mid-size sedan, known for its comfortable ride, premium interior, advanced safety features, and fuel-efficient engine options, making it a versatile family car.", 65, "https://media.autoexpress.co.uk/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1563183024/autoexpress/2019/02/01_7.jpg", true, "Bourgas", "Volkswagen", 22, "Passat", 5, 140, 89.99m, "Automatic", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Discount", "Name", "PricePerDay", "ProtectionPlanId" },
                values: new object[,]
                {
                    { 1, "For a specific request to go abroad, you may be asked for additional information and certain restrictions may be imposed.", 0.0, "Driving abroad", 60m, null },
                    { 2, "Enjoy your stay in Bulgaria with high quality internet everywhere in the country.", 0.0, "Mobile WiFi HOTSPOT", 6m, null },
                    { 3, null, 0.0, "Tension belt", 1m, null },
                    { 4, "One time fee for purchase of Anti-skid show chains. They remain for the client after rental.", 0.0, "Anti-skid snow chains", 30m, null },
                    { 5, "Limits your financial liability in the event of collision-related damage to the vehicle", 0.0, "Collision Damage Waiver (CDW)", 0m, null },
                    { 6, "Limits your financial liability in the event of theft or attempted theft of the vehicle", 0.0, "Theft Waiver (THW)", 0m, null },
                    { 7, "Reduces your financial liability for damage to windscreen, glass, lights and tyres up to your excess.", 0.0, "Value Cover. Glass, Lights and Tyres Protection", 4.54m, null },
                    { 8, "Provides indemnity for driver and passengers in case of death or injury and covers medical expenses.", 0.0, "Personal Accident Protection", 4.54m, null },
                    { 9, "Provides indemnity for your personal belongings in case of destruction or theft.", 0.0, "Personal belongings protection", 4.54m, null }
                });

            migrationBuilder.InsertData(
                table: "ProtectionPlans",
                columns: new[] { "Id", "Description", "Discount", "PricePerDay", "ProtectionType" },
                values: new object[,]
                {
                    { 1, "Basic Plan", null, 0.00m, "Basic" },
                    { 2, "Medium Plan", null, 8.58m, "Medium" },
                    { 3, "Premium Plan", null, 12.88m, "Premium" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Extras_ProtectionPlanId",
                table: "Extras",
                column: "ProtectionPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "ProtectionPlans");
        }
    }
}
