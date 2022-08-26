using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoCelEletronic.Migrations
{
    public partial class CreateDatabaseFKclienteServico2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientedb_servicosdb_servicosid",
                table: "clientedb");

            migrationBuilder.DropIndex(
                name: "IX_clientedb_servicosid",
                table: "clientedb");

            migrationBuilder.DropColumn(
                name: "servicosid",
                table: "clientedb");

            migrationBuilder.CreateIndex(
                name: "IX_servicosdb_clienteId",
                table: "servicosdb",
                column: "clienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_servicosdb_clientedb_clienteId",
                table: "servicosdb",
                column: "clienteId",
                principalTable: "clientedb",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_servicosdb_clientedb_clienteId",
                table: "servicosdb");

            migrationBuilder.DropIndex(
                name: "IX_servicosdb_clienteId",
                table: "servicosdb");

            migrationBuilder.AddColumn<int>(
                name: "servicosid",
                table: "clientedb",
                type: "int",
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
    }
}
