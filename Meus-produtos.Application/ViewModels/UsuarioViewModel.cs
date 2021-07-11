using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Application.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {


        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MaxLength(20,ErrorMessage ="Máximo de 20 caracteres")]
        [MinLength(3,ErrorMessage ="Minimo de 3 caracteres ")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O email é obrigatório!")]
        [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres ")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
        [MinLength(8, ErrorMessage = "Minimo de 8 caracteres ")]
        public string Senha { get; set; }
    }
}
