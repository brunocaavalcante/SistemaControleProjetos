using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class OperacaoViewModel
    {
        public int TipoOperacao { get; set; }
        public DateTime DataOperacao { get; set; }
        public string Status { get; set; }
        public bool Aprovado { get; set; }
        public string Descricao { get; set; }
        public string Natureza { get; set; }
        public float Valor { get; set; }
    }
}
