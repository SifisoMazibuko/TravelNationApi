using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using TravelNationApi.Models.iVeri;

namespace TravelNationApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.Configure<IVeriConfiguration>(Configuration);
            services.Configure<SabreConfiguration>(Configuration.GetSection("SabreConfiguration"));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("TravelNationApi", new Info { Title = "The Rest API of TravelNation\'s back-end", Contact = new Contact { Name = "Tumelo Motsikelane", Email = "tumelomotsikelane@gmail.com" } });
            });

            var basePath = AppContext.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "TravelNationApi.xml");
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/TravelNationApi/swagger.json", "Travel Nation Rest API");
            });

            app.UseMvc();
        }
    }
}
