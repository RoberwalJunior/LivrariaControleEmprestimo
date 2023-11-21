using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations;

/// <inheritdoc />
public partial class InicialDatabase : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Clientes",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                TelefoneCelular = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                TelefoneFixo = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Clientes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Livros",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Autor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Editora = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                AnoPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                Edicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Livros", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Emprestimos",
            columns: table => new
            {
                ClienteId = table.Column<int>(type: "int", nullable: false),
                LivroId = table.Column<int>(type: "int", nullable: false),
                DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                DataEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                Entregue = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Emprestimos", x => new { x.LivroId, x.ClienteId });
                table.ForeignKey(
                    name: "FK_Emprestimos_Clientes_ClienteId",
                    column: x => x.ClienteId,
                    principalTable: "Clientes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Emprestimos_Livros_LivroId",
                    column: x => x.LivroId,
                    principalTable: "Livros",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Emprestimos_ClienteId",
            table: "Emprestimos",
            column: "ClienteId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Emprestimos");

        migrationBuilder.DropTable(
            name: "Clientes");

        migrationBuilder.DropTable(
            name: "Livros");
    }
}
