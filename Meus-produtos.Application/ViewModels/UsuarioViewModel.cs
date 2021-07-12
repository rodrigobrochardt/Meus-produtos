using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Application.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
