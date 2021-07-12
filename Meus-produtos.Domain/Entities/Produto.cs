using System;
using System.ComponentModel.DataAnnotations;

namespace Meus_produtos.Domain.Entities
{
    public class Produto : Base
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        [MaxLength(80, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo de {0} caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O status é obrigatório!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O valor é obrigatória!")]
        [Range(0, int.MaxValue, ErrorMessage = "O valor não pode ser negativo!")]
        public bool Status { get; set; }




        public Produto() : base()
        {

        }
        public Produto(dynamic obj) : base()
        {
            this.Id = obj.Id;
            this.Nome = obj.Nome;
            this.Valor = obj.Valor;
            this.Status = obj.Status;
        }
    }
}
