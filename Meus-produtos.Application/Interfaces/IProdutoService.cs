using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Interfaces
{
    public interface IProdutoService : IBaseService<ProdutoViewModel>
    {
        void Add(ProdutoViewModel obj);
        void Update(ProdutoViewModel obj);
        void Remove(ProdutoViewModel obj);
        IEnumerable<ProdutoViewModel> GetAll();
        ProdutoViewModel GetById(int id);
        void Dispose();
    }
}
