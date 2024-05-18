using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCrud.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Carro");

            migrationBuilder.RenameColumn(
                name: "Renavam",
                table: "Carro",
                newName: "renavam");

            migrationBuilder.RenameColumn(
                name: "Potencia",
                table: "Carro",
                newName: "potencia");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Carro",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Carro",
                newName: "categoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carro",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Cor",
                table: "Carro",
                newName: "dor");

            migrationBuilder.RenameColumn(
                name: "AnoFabricacao",
                table: "Carro",
                newName: "ano_fabricacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "renavam",
                table: "Carro",
                newName: "Renavam");

            migrationBuilder.RenameColumn(
                name: "potencia",
                table: "Carro",
                newName: "Potencia");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Carro",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "categoria",
                table: "Carro",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Carro",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "dor",
                table: "Carro",
                newName: "Cor");

            migrationBuilder.RenameColumn(
                name: "ano_fabricacao",
                table: "Carro",
                newName: "AnoFabricacao");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Carro",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
