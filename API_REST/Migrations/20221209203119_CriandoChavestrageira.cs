using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIREST.Migrations
{
    /// <inheritdoc />
    public partial class CriandoChavestrageira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Vendedor_VendedorId",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Vendas",
                newName: "id_Vendedor");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_VendedorId",
                table: "Vendas",
                newName: "IX_Vendas_id_Vendedor");

            migrationBuilder.AlterColumn<int>(
                name: "id_Vendedor",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Vendedor_id_Vendedor",
                table: "Vendas",
                column: "id_Vendedor",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Vendedor_id_Vendedor",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "id_Vendedor",
                table: "Vendas",
                newName: "VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_id_Vendedor",
                table: "Vendas",
                newName: "IX_Vendas_VendedorId");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Vendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Vendedor_VendedorId",
                table: "Vendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id");
        }
    }
}
