using Business.Models.Conta;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IContaRepository:IRepository<ContaModel>
    {
        Task<ContaModel> ObterContaOperacoes();
    }
}
