using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Application.ViewModels
{
    public class ProdutoViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        [MaxLength(80, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo de {0} caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O status é obrigatório!")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "O valor é obrigatória!")]
        [Range(0, int.MaxValue, ErrorMessage = "O valor não pode ser negativo!")]
        public decimal Valor { get; set; }
    }
}
