using Meus_produtos.Application.Commons;
using Meus_produtos.Application.ViewModels;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Interfaces
{
    public interface IUsuarioService : IBaseService<UsuarioViewModel>
    {
        Task<Response> Add(UsuarioViewModel obj);
        Task<Response> Update(UsuarioViewModel obj);
        Task<Response> Remove(int id);
        Task<Response> GetAll();
        Task<Response> GetById(int id);
        Task<Response> Authenticate(UsuarioViewModel obj);
        void Dispose();
    }
}
