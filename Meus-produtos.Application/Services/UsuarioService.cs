using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.ViewModels;
using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace Meus_produtos.Application.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService, IDisposable
    {
        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) :base(usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public void Add(UsuarioViewModel obj)
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<UsuarioViewModel, Usuario>(obj);

            usuarioRepository.Add(entity);
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(usuarioRepository.GetAll());

            return entity;
        }

        public UsuarioViewModel GetById(int id)
        {

            var entity = AutoMapper.AutoMapperConfig.mapper.Map<Usuario, UsuarioViewModel>(usuarioRepository.GetById(id));

            return entity;

        }

        public void Remove(int id)
        {
            var entity = usuarioRepository.GetById(id);
            usuarioRepository.Remove(entity);

        }

        public void Update(UsuarioViewModel obj)
        {
            var entity = AutoMapper.AutoMapperConfig.mapper.Map<UsuarioViewModel, Usuario>(obj);

            usuarioRepository.Update(entity);
        }

        public void Dispose()
        {
            usuarioRepository.Dispose();
        }

    }
}
