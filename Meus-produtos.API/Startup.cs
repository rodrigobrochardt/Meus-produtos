using Autofac;
using Autofac.Extensions.DependencyInjection;
using Meus_produtos.Application.AutoMapper;
using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.Services;
using Meus_produtos.Domain.Interfaces.Repositories;
using Meus_produtos.Infra.Data.Context;
using Meus_produtos.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Meus_produtos.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            AutoMapperConfig.RegisterMapping();
            using (var context = new MySqlContext())
            {
                context.Database.EnsureCreated();
            }

            services.AddControllers();
            services.AddAutofac();
            services.AddOptions();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Meus_produtos.API", Version = "v1" });
            });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //repositories
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>));
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();

            //services
            builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>));
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Meus_produtos.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
