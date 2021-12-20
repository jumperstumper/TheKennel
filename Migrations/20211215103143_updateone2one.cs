using Microsoft.EntityFrameworkCore.Migrations;

namespace KennelProgram.Migrations
{
    public partial class updateone2one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Services_servicesId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Dogs_DogId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_DogId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Customers_servicesId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "servicesId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "DogId",
                table: "Services",
                newName: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CustomerId",
                table: "Services",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Customers_CustomerId",
                table: "Services",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Customers_CustomerId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_CustomerId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Services",
                newName: "DogId");

            migrationBuilder.AddColumn<int>(
                name: "servicesId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_DogId",
                table: "Services",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_servicesId",
                table: "Customers",
                column: "servicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Services_servicesId",
                table: "Customers",
                column: "servicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Dogs_DogId",
                table: "Services",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
