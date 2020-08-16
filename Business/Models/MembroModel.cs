using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class MembroModel:Entity
    {
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        //public EnderecoModel Endereco { get; set; }
    }
}
