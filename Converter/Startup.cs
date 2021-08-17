using Converter.BusinnesLogic.Mappers;
using Converter.Infostructure.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Converter.Infostructure.Repository;
using Converter.BusinnesLogic.Interfaces;
using Converter.BusinnesLogic.Services;

namespace Converter
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
            
            services.AddMvc(options => options.EnableEndpointRouting = false)
                .AddJsonOptions(o =>
                {
                    o.JsonSerializerOptions.PropertyNamingPolicy = null;
                    o.JsonSerializerOptions.DictionaryKeyPolicy = null;
                });
          


            ConfigureDatabases(services, Configuration);
            // Infrastructure Layer
            
            services.AddControllers();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
           

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

        }
        public static void ConfigureDatabases(IServiceCollection services, IConfiguration Configuration)
        {

            services.AddDbContext<AppDataContext>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICurrencyConverterService, CurrencyConverterService>();
            services.AddAutoMapper(typeof(IEMapper));



        }
    }
}
