using System;


namespace Business.Models.Conta
{
    public class ContaModel : Entity
    {
        public float Saldo { get; set; }
        public OperacaoModel Operacao { get; set; }
    }
}
