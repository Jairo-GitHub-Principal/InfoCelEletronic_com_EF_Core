using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoCelEletronic.Migrations
{
    public partial class CreateDatabasePrencheNomeEmServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "clienteNome",
                table: "servicosdb",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clienteNome",
                table: "servicosdb");
        }
    }
}
