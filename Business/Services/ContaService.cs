using Business.Interfaces;
using Business.Models.Conta;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }
        public async Task Adicionar(ContaModel conta)
        {
            if (conta != null)
                await _contaRepository.Adicionar(conta);
        }

        public Task Atualizar(ContaModel conta)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _contaRepository?.Dispose();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
