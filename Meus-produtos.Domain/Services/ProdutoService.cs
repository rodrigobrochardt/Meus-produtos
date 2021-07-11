using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces.Repositories;
using Meus_produtos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Domain.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }
    }
}
