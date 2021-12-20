using Microsoft.EntityFrameworkCore.Migrations;

namespace KennelProgram.Migrations
{
    public partial class one2oneDogAndServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "servicesId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HairCut = table.Column<bool>(type: "bit", nullable: false),
                    ClawCutting = table.Column<bool>(type: "bit", nullable: false),
                    Washing = table.Column<bool>(type: "bit", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_servicesId",
                table: "Customers",
                column: "servicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_DogId",
                table: "Services",
                column: "DogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Services_servicesId",
                table: "Customers",
                column: "servicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Services_servicesId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Customers_servicesId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "servicesId",
                table: "Customers");
        }
    }
}
