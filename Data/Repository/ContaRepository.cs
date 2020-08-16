using Business.Interfaces;
using Business.Models.Conta;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ContaRepository :  Repository<ContaModel>, IContaRepository
    {
        public ContaRepository(MyDbContext db) : base(db)
        {
        }

        public async Task<List<ContaModel>> ObterContaOperacoes()
        {
            return await Db.Contas.AsNoTracking()
                 .Include(o => o.Operacao).ToListAsync();
        }

        Task<ContaModel> IContaRepository.ObterContaOperacoes()
        {
            throw new NotImplementedException();
        }
    }
}
