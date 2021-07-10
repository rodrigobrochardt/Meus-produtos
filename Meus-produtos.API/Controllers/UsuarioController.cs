using AutoMapper;
using Meus_produtos.API.ViewModels;
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
        private readonly UsuarioRepository usuarioRepository = new UsuarioRepository();



        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<UsuarioViewModel> Get()
        {

            var usuarioViewModel = AutoMapper.AutoMapperConfig.mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(usuarioRepository.GetAll());

            return usuarioViewModel;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
