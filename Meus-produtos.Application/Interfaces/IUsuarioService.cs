using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Interfaces
{
    public interface IUsuarioService : IBaseService<UsuarioViewModel>
    {
        void Add(UsuarioViewModel obj);
        void Update(UsuarioViewModel obj);
        void Remove(int id);
        IEnumerable<UsuarioViewModel> GetAll();
        UsuarioViewModel GetById(int id);
        void Dispose();
    }
}
