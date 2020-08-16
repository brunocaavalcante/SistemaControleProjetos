using Business.Models;
using Business.Models.Conta;
using Microsoft.EntityFrameworkCore;


namespace Data.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ContaModel> Contas { get; set; }
        public DbSet<OperacaoModel> Operacoes { get; set; }
        public DbSet<ProjetoModel> Projetos { get; set; }
        public DbSet<MembroModel> Membros { get; set; }
        public DbSet<VotacaoModel> Votacoes { get; set; }
    }
}
