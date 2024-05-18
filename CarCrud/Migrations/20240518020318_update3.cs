using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCrud.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dor",
                table: "Carro",
                newName: "cor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cor",
                table: "Carro",
                newName: "dor");
        }
    }
}
