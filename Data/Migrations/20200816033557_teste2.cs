using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Peso = table.Column<string>(nullable: true),
                    Altura = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    MembroId = table.Column<Guid>(nullable: true),
                    AdminId = table.Column<Guid>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    ContaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projetos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projetos_Membros_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Membros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projetos_Contas_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projetos_Membros_MembroId",
                        column: x => x.MembroId,
                        principalTable: "Membros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Votacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProjetoId = table.Column<Guid>(nullable: true),
                    ContaId = table.Column<Guid>(nullable: true),
                    OperacaoId = table.Column<Guid>(nullable: true),
                    SolicitanteId = table.Column<Guid>(nullable: true),
                    AprovadorId = table.Column<Guid>(nullable: true),
                    VotosPositivos = table.Column<int>(nullable: false),
                    VotosNegativos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votacoes_Membros_AprovadorId",
                        column: x => x.AprovadorId,
                        principalTable: "Membros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votacoes_Contas_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votacoes_Operacoes_OperacaoId",
                        column: x => x.OperacaoId,
                        principalTable: "Operacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votacoes_Projetos_ProjetoId",
                        column: x => x.ProjetoId,
                        principalTable: "Projetos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votacoes_Membros_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Membros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_AdminId",
                table: "Projetos",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_ContaId",
                table: "Projetos",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_MembroId",
                table: "Projetos",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Votacoes_AprovadorId",
                table: "Votacoes",
                column: "AprovadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Votacoes_ContaId",
                table: "Votacoes",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Votacoes_OperacaoId",
                table: "Votacoes",
                column: "OperacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Votacoes_ProjetoId",
                table: "Votacoes",
                column: "ProjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Votacoes_SolicitanteId",
                table: "Votacoes",
                column: "SolicitanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votacoes");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Membros");
        }
    }
}
