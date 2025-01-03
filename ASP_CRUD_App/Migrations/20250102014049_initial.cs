using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_CRUD_App.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    CarImage = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "ImageName" },
                values: new object[,]
                {
                    { "Sedan", "Sedan", "Sedan.png" },
                    { "Hatchback", "Hatchback", "Hatchback.png" },
                    { "SUV", "SUV", "SUV.png" },
                    { "Limousine", "Limousine", "Limousine.png" },
                    { "Van", "Van", "Van.png" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CarImage", "CategoryId", "Color", "Make", "Model", "Price", "Rating", "Year" },
                values: new object[,]
                {
                    { 2, "honda_civic_2006.jpg", "Sedan", "Charcoal", "Honda", "Civic", 39.99m, 5, 2006 },
                    { 4, "vw_golf_2008.jpg", "Hatchback", "Silver", "VW", "Golf", 65.99m, 2, 2008 },
                    { 3, "toyota_landcruiser100_2005.jpg", "SUV", "Green", "Toyota", "Landcruiser", 42.99m, 5, 2005 },
                    { 5, "lincoln_towncar_2006.jpg", "Limousine", "White", "Lincoln", "Towncar", 105.99m, 4, 2006 },
                    { 1, "ford_galaxy_2008.jpg", "Van", "Red", "Ford", "Galaxy", 49.99m, 3, 2008 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
