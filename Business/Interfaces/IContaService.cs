using Business.Models.Conta;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IContaService: IDisposable
    {
        Task Adicionar(ContaModel conta);
        Task Atualizar(ContaModel conta);
        Task Remover(Guid id);
    }
}
