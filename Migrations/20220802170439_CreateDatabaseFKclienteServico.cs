using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoCelEletronic.Migrations
{
    public partial class CreateDatabaseFKclienteServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "clienteId",
                table: "servicosdb",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "servicosid",
                table: "clientedb",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientedb_servicosid",
                table: "clientedb",
                column: "servicosid");

            migrationBuilder.AddForeignKey(
                name: "FK_clientedb_servicosdb_servicosid",
                table: "clientedb",
                column: "servicosid",
                principalTable: "servicosdb",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientedb_servicosdb_servicosid",
                table: "clientedb");

            migrationBuilder.DropIndex(
                name: "IX_clientedb_servicosid",
                table: "clientedb");

            migrationBuilder.DropColumn(
                name: "clienteId",
                table: "servicosdb");

            migrationBuilder.DropColumn(
                name: "servicosid",
                table: "clientedb");
        }
    }
}
