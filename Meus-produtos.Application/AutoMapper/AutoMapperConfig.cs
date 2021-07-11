using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meus_produtos.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper mapper { get; set; }

        public static void RegisterMapping()
        {
            var mapperConfig = new MapperConfiguration(config => { config.AddProfile<EntityToModel>(); config.AddProfile<ModelToEntity>(); });
            mapper = mapperConfig.CreateMapper();
        }
        
    }
}
