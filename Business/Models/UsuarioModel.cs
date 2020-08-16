using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class UsuarioModel:Entity
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string LembreteSenha { get; set; }
        public MembroModel Pessoa { get; set; }
    }
}
