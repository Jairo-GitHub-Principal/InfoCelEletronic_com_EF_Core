using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoCelEletronic.Migrations
{
    public partial class CreateDatabaseTipoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "clientedb",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "clientedb");
        }
    }
}
