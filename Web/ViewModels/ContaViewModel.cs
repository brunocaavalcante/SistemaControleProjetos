using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class ContaViewModel
    {
        public float Saldo { get; set; }   
        public OperacaoViewModel OperacaoViewModel { get; set; }
    
    }
}
