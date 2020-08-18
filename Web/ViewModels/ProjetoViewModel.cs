using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class ProjetoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage =" O campo {0} é obrigatorio")]
        public string Nome { get; set; }

        public MembroViewModel Membro { get; set; }

        public MembroViewModel Admin { get; set; }

        [Display(Name ="Data de Início do Projeto")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data do Fim do Projeto")]
        public DateTime DataFim { get; set; }

        public ContaViewModel Conta { get; set; }

        [Required(ErrorMessage = " O campo {0} é obrigatorio")]
        public string Descricao { get; set; }
    }
}
