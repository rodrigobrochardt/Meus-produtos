using Meus_produtos.Application.Commons;
using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService, IDisposable
    {
        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public async Task<Response> Add(UsuarioViewModel obj)
        {
            var entity = new Usuario(obj);
            if (entity.IsValid())
            {
                return Ok(await usuarioRepository .Add(entity));
            }
            return BadRequest(entity.GetValidationResults());
        }

        public async Task<Response> GetAll()
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<IEnumerable<UsuarioViewModel>>(await usuarioRepository.GetAll());

            return Ok(entity);
        }

        public async Task<Response> GetById(int id)
        {

            var entity = AutoMapper.AutoMapperConfig.mapper.Map<Usuario>(await usuarioRepository.GetById(id));

            return Ok(entity);

        }

        public async Task<Response> Remove(int id)
        {
            var entity = new Usuario(await usuarioRepository.GetById(id));
            if (entity.IsValid())
            {
                return Ok(await usuarioRepository .Remove(entity));

            }
            return BadRequest(entity.GetValidationResults());

        }

        public async Task<Response> Update(UsuarioViewModel obj)
        {
            try
            {
                var entity = new Usuario(obj);
                if (entity.IsValid())
                {
                    return Ok(await usuarioRepository.Update(entity));

                }
                return BadRequest(entity.GetValidationResults());
            }
            catch (Exception except)
            {

                throw except.InnerException;
            }


        }
        public async Task<Response> Authenticate(UsuarioViewModel obj)
        {
            try
            {
                var entity = await usuarioRepository.GetById(obj.Id);
                if (entity.IsValid())
                {
                    if(obj.Senha == entity.Senha && obj.Email == entity.Email)
                    {
                        

                        var token = TokenService.GenerateToken(entity);
                        entity.Senha = "";
                        return Ok(new { entity = entity, token = token });
                    }
                    return BadRequest(obj);
                }
                return BadRequest(obj);

            }
            catch (Exception except)
            {

                throw except.InnerException;
            }
        }

        public void Dispose()
        {
            usuarioRepository.Dispose();
        }

    }
}
