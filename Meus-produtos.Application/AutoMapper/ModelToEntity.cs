﻿using AutoMapper;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Application.AutoMapper
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<ProdutoViewModel, Produto>();

        }
    }
}
