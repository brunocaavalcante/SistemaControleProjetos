using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class atualizaprojeto170820 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Projetos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Projetos");
        }
    }
}
