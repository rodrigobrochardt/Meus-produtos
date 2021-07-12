using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Application.ViewModels
{
    public class ProdutoViewModel : BaseViewModel
    {

        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
    }
}
