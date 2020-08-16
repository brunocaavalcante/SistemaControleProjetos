using Business.Models.Conta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class VotacaoModel:Entity
    {
        public ProjetoModel Projeto { get; set; }
        public ContaModel Conta { get; set; }
        public OperacaoModel Operacao { get; set; }
        public MembroModel Solicitante { get; set; }
        public MembroModel Aprovador { get; set; }
        public int VotosPositivos { get; set; }
        public int VotosNegativos { get; set; }
    }
}
