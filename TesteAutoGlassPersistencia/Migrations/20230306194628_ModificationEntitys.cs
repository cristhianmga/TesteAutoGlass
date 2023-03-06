using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteAutoGlassPersistencia.Migrations
{
    /// <inheritdoc />
    public partial class ModificationEntitys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorCodigo",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedorCodigo",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "FornecedorCodigo",
                table: "Produtos",
                newName: "CodigoFornecedor");

            migrationBuilder.AddColumn<string>(
                name: "CNPJFornecedor",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoFornecedor",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJFornecedor",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DescricaoFornecedor",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "CodigoFornecedor",
                table: "Produtos",
                newName: "FornecedorCodigo");

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorCodigo",
                table: "Produtos",
                column: "FornecedorCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedorCodigo",
                table: "Produtos",
                column: "FornecedorCodigo",
                principalTable: "Fornecedores",
                principalColumn: "Codigo");
        }
    }
}
