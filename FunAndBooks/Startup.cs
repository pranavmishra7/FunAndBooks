using Entities;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net.Sockets;

namespace FunAndBooks
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddDbContext<AppDbContext>(ctx => ctx.UseInMemoryDatabase("FunAndBooks"));
            services.AddApiVersioning(options=>
            { 
            options.ReportApiVersions = true;
            });
            services.AddVersionedApiExplorer(
                options => {
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl=true;
                });
            services.AddControllers();
            services.AddSwaggerGen(
                options => {
                    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "FunAndBooks", Version = "v1" });
                });

        }
        public void Configure(IApplicationBuilder app, IApiVersionDescriptionProvider provider) 
        {
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
          //app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
