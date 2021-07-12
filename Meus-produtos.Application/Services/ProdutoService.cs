using Meus_produtos.Application.Commons;
using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService, IDisposable
    {
        private readonly IProdutoRepository produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public async Task<Response> Add(ProdutoViewModel obj)
        {
            var entity = new Produto(obj);
            if (entity.IsValid())
            {
                return Ok(await produtoRepository.Add(entity));
            }
            return BadRequest(entity.GetValidationResults());
        }

        public async Task<Response> GetAll()
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<IEnumerable<ProdutoViewModel>>(await produtoRepository.GetAll());

            return Ok(entity);
        }

        public async Task<Response> GetById(int id)
        {

            var entity = AutoMapper.AutoMapperConfig.mapper.Map<Produto>(await produtoRepository.GetById(id));

            return Ok(entity);

        }

        public async Task<Response> Remove(int id)
        {
            var entity = new Produto(await produtoRepository.GetById(id));
            if (entity.IsValid())
            {
                return Ok(await produtoRepository.Remove(entity));

            }
            return BadRequest(entity.GetValidationResults());
        }

        public async Task<Response> Update(ProdutoViewModel obj)
        {
            try
            {
                var entity = new Produto(obj);
                if (entity.IsValid())
                {
                    return Ok(await produtoRepository.Update(entity));

                }
                return BadRequest(entity.GetValidationResults());
            }
            catch (Exception except)
            {

                throw except.InnerException;
            }
        }

        public void Dispose()
        {
            produtoRepository.Dispose();
        }


    }
}
