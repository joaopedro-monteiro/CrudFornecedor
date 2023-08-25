using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudFornecedor.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<long>(type: "bigint", nullable: false),
                    Especialidade = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<long>(type: "bigint", nullable: false),
                    EnderecoRua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoNumero = table.Column<int>(type: "int", nullable: false),
                    EnderecoBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
