using Meus_produtos.Application.Commons;
using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        [Authorize]
        public async Task<Response> Get()
        {


            return await usuarioService.GetAll();
            
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<Response> Get(int id)
        {
            return await usuarioService.GetById(id);

        }

        // POST api/<UsuarioController>
        [HttpPost]
        [AllowAnonymous]
        public async Task<Response> Post([FromBody] UsuarioViewModel value)
        {
            return await usuarioService.Add(value);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("")]
        [Authorize]
        public async Task<Response> Put([FromBody] UsuarioViewModel value)
        {
            return await usuarioService.Update(value);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<Response> Delete(int id)
        {
            
            return await usuarioService.Remove(id);
        }

        // POST api/<HomeController>
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UsuarioViewModel usuario)
        {
            return await usuarioService.Authenticate(usuario);
        }
    }
}
