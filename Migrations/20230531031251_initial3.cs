using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroAlunoReciclarte.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "IdAluno",
                table: "Escolas");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos",
                column: "EscolaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "IdAluno",
                table: "Escolas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos",
                column: "EscolaId",
                unique: true);
        }
    }
}
