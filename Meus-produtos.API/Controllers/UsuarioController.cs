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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        [Route("")]
        public IEnumerable<UsuarioViewModel> Get()
        {


            return usuarioService.GetAll();
            
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioViewModel Get(int id)
        {
            return usuarioService.GetById(id);

        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] UsuarioViewModel value)
        {
            usuarioService.Add(value);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("")]

        public void Put([FromBody] UsuarioViewModel value)
        {
            usuarioService.Update(value);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
            usuarioService.Remove(id);
        }
    }
}
