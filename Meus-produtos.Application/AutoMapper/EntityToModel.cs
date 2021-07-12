using AutoMapper;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;

namespace Meus_produtos.Application.AutoMapper
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
