using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models.Conta
{
    public class OperacaoModel : Entity
    {
        public string Natureza { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public Guid SolicitanteId { get; set; }
        public Guid AprovadorId { get; set; }
        public int TipoOperacao { get; set; }
        public DateTime DataOperacao { get; set; }
        public string Status { get; set; }
        public bool Aprovado { get; set; }
    }
}
