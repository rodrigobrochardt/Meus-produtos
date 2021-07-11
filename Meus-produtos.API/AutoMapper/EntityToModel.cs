using AutoMapper;
using Meus_produtos.API.ViewModels;
using Meus_produtos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.API.AutoMapper
{
    public class EntityToModel : Profile
    {
        public EntityToModel()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Produto, ProdutoViewModel>();

        }
    }
}
