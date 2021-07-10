using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.API.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MaxLength(20,ErrorMessage ="Máximo de {0} caracteres")]
        [MinLength(3,ErrorMessage ="Minimo de {0} caracteres ")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O email é obrigatório!")]
        [MaxLength(20, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(3, ErrorMessage = "Minimo de {0} caracteres ")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        [MaxLength(8, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(20, ErrorMessage = "Minimo de {0} caracteres ")]
        public string Senha { get; set; }
    }
}
