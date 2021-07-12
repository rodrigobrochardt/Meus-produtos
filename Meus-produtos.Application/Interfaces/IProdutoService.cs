using Meus_produtos.Application.Commons;
using Meus_produtos.Application.ViewModels;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Interfaces
{
    public interface IProdutoService : IBaseService<ProdutoViewModel>
    {
        Task<Response> Add(ProdutoViewModel obj);
        Task<Response> Update(ProdutoViewModel obj);
        Task<Response> Remove(int id);
        Task<Response> GetAll();
        Task<Response> GetById(int id);
        void Dispose();
    }
}
