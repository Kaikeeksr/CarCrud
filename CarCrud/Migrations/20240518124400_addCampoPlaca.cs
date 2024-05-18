using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCrud.Migrations
{
    /// <inheritdoc />
    public partial class addCampoPlaca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "placa",
                table: "Carro",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "placa",
                table: "Carro");
        }
    }
}
