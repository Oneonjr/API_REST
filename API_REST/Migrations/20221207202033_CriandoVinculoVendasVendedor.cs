using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIREST.Migrations
{
    /// <inheritdoc />
    public partial class CriandoVinculoVendasVendedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Vendedor_VendedorId",
                table: "Vendas");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Vendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHorario",
                table: "Vendas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Vendedor_VendedorId",
                table: "Vendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Vendedor_VendedorId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "DataHorario",
                table: "Vendas");

            migrationBuilder.AlterColumn<int>(
                name: "VendedorId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Vendedor_VendedorId",
                table: "Vendas",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
