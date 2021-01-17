using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Conta.Migration.Migrations
{
    public partial class MyFirstMigration : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContaBancarias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BancoId = table.Column<long>(type: "bigint", nullable: true),
                    NumeroConta = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NumeroAgencia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaBancarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaBancarias_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaBancarias_BancoId",
                table: "ContaBancarias",
                column: "BancoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaBancarias");

            migrationBuilder.DropTable(
                name: "Bancos");
        }
    }
}
