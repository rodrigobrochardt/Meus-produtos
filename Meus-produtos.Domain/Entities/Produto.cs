using System;
using System.ComponentModel.DataAnnotations;

namespace Meus_produtos.Domain.Entities
{
    public class Produto : Base
    {

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }

    }
}
