using Autofac;
using Autofac.Extensions.DependencyInjection;
using Meus_produtos.Application;
using Meus_produtos.Application.AutoMapper;
using Meus_produtos.Application.Interfaces;
using Meus_produtos.Application.Services;
using Meus_produtos.Domain.Interfaces.Repositories;
using Meus_produtos.Infra.Data.Context;
using Meus_produtos.Infra.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

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
          
            services.AddCors();
            AutoMapperConfig.RegisterMapping();
            using (var context = new MySqlContext())
            {
                context.Database.EnsureCreated();
            }

            services.AddControllers();
            services.AddAutofac();
            services.AddOptions();
            services.AddMvc();
            var key = Encoding.ASCII.GetBytes(Settings.Key);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Meus_produtos.API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "use 'Bearer {token}' para ativar autorização",
                    Scheme = "Bearer",
                    Name = "Authorization",
                    BearerFormat = "JWT",
                    Type = SecuritySchemeType.ApiKey
                });


                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                    }
                 });
            });

            services.AddCors();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //repositories
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>));
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();


            //services
            builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>));
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            



            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Meus_produtos.API v1"));

        }
    }
}
