using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIREST.Migrations
{
    /// <inheritdoc />
    public partial class VendasEntitiess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Situacao_SituacaoId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_SituacaoId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "SituacaoId",
                table: "Vendas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SituacaoId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_SituacaoId",
                table: "Vendas",
                column: "SituacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Situacao_SituacaoId",
                table: "Vendas",
                column: "SituacaoId",
                principalTable: "Situacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
