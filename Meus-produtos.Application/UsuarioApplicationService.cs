﻿using Meus_produtos.Application.Interfaces;
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
        private readonly IUsuarioService usuarioService;
        public UsuarioApplicationService(IUsuarioService usuarioService) :base(usuarioService)
        {
            this.usuarioService = usuarioService;
        }


    }
}
