using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace Meus_produtos.Application.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService, IDisposable
    {
        private readonly IProdutoRepository produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository) :base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public void Add(ProdutoViewModel obj)
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<ProdutoViewModel, Produto>(obj);

            produtoRepository.Add(entity);
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(produtoRepository.GetAll());

            return entity;
        }

        public ProdutoViewModel GetById(int id)
        {

            var entity = AutoMapper.AutoMapperConfig.mapper.Map<Produto, ProdutoViewModel>(produtoRepository.GetById(id));

            return entity;

        }

        public void Remove(ProdutoViewModel obj)
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<ProdutoViewModel,Produto >(obj);

            produtoRepository.Remove(entity);
        }

        public void Update(ProdutoViewModel obj)
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<ProdutoViewModel, Produto>(obj);

            produtoRepository.Update(entity);
        }

        public void Dispose()
        {
            produtoRepository.Dispose();
        }


    }
}
