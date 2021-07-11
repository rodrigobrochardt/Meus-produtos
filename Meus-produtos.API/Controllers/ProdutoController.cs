using Meus_produtos.Application.AutoMapper;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Application;
using Meus_produtos.Application.Interfaces;
using Meus_produtos.Domain.Entities;
using Meus_produtos.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Meus_produtos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<ProdutoViewModel> Get()
        {


            return produtoService.GetAll();
            
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public ProdutoViewModel Get(int id)
        {
            return produtoService.GetById(id);

        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] ProdutoViewModel value)
        {
            produtoService.Add(value);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("")]

        public void Put([FromBody] ProdutoViewModel value)
        {
            produtoService.Update(value);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
            produtoService.Remove(id);
        }
    }
}
