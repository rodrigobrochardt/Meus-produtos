using Meus_produtos.Domain.Entities;
using Meus_produtos.Domain.Interfaces;
using Meus_produtos.Domain.Interfaces.Repositories;
using Meus_produtos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {


    }

}
