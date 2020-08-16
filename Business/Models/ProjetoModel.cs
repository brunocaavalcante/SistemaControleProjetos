using Business.Models.Conta;
using System;

namespace Business.Models
{
    public class ProjetoModel:Entity
    {
        public string Nome { get; set; }
        public MembroModel Membro { get; set; }
        public MembroModel Admin { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ContaModel Conta { get; set; }
        public string Descricao { get; set; }
    }
}
