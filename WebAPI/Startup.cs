using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Interfaces.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Services.Destino;
using Services.Lugares;
using Services.Categoria;
using Services.Tipo_Transporte;
using Services.Transporte;
using Services.Usuario;
using Microsoft.OpenApi.Models;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Server=localhost;Initial Catalog=ProyectoPrograX;Trusted_Connection=true"
            };
            conn.Open();
                       
            services.AddSingleton<ICategoria, categoriaService>();
            services.AddSingleton<IDestino, DestinoService>();
            services.AddSingleton<ILugaresVisitados, LugaresService>();
            services.AddSingleton<ITipoTrans, TipoTransporteService>();
            services.AddSingleton<ITransporte, TransporteSerivce>();
            services.AddSingleton<IUsuario, UsuarioService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleDI());
            #region Modulo Autofac
            builder.RegisterModule(new ModuleDI());
            #endregion
            #region AutoFac Direct Registration
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
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
