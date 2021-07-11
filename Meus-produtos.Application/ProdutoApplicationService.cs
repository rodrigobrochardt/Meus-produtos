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
    public class ProdutoApplicationService : BaseApplicationService<Produto>, IProdutoApplicationService
    {
        private readonly IProdutoService produtoService;
        public ProdutoApplicationService(IProdutoService produtoService) :base(produtoService)
        {
            this.produtoService = produtoService;
        }


    }
}
