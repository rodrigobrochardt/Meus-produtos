using Meus_produtos.Application.Interfaces;
using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Application
{
    public class UsuarioApplicationService : BaseApplicationService<Usuario>, IUsuarioApplicationService
    {
        private readonly IUsuarioService usuarioApplicationService;
        public UsuarioApplicationService(IUsuarioService usuarioApplicationService) :base(usuarioApplicationService)
        {
            this.usuarioApplicationService = usuarioApplicationService;
        }


    }
}
