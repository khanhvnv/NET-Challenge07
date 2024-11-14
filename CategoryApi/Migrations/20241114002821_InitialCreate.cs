using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CategoryApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bánh kem, bánh kem bắp, bánh kem nhân mứt", "Bánh kem" },
                    { 2, "Bánh mì, bánh quy, donut", "Bánh nướng" },
                    { 3, "Bánh flan, bánh su kem, pudding ", "Bánh lạnh" },
                    { 4, "Kem vani, kem đậu xanh, kem dâu, kem chuối", "Cà rem" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "/images/cakes/Banh-Kem-Dau-1.jpg", "Bánh kem nhân dâu", 335000 },
                    { 2, 1, "/images/cakes/Banh-Kem-Bap-1-2.jpg", "Bánh kem bắp", 335000 },
                    { 3, 1, "/images/cakes/Banh-Kem-Thom-10-1.jpg", "Bánh kem nhân mứt", 335000 },
                    { 4, 2, "/images/baked-cakes/sandwich-ngu-coc.jpg", "Bánh mì", 23000 },
                    { 5, 2, "/images/baked-cakes/Quy-Bo-Dau-Phong.jpg", "Bánh quy", 25000 },
                    { 6, 2, "/images/baked-cakes/Banh-Donut.jpg", "Bánh donut", 15000 },
                    { 7, 3, "/images/cold-cakes/Banh-Flan-2.jpg", "Bánh flan", 12000 },
                    { 8, 3, "/images/cold-cakes/banh_su_kem.jpg", "Bánh su kem", 33000 },
                    { 9, 3, "/images/cold-cakes/pudding-xoai.jpg", "Pudding", 35000 },
                    { 10, 4, "/images/ice-cream/Kem-Vani.jpg", "Kem vani", 13000 },
                    { 11, 4, "/images/ice-cream/Kem-Dau-Xanh.jpg", "Kem đậu xanh", 13000 },
                    { 12, 4, "/images/ice-cream/Kem-Dau.jpg", "Kem dâu", 13000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
