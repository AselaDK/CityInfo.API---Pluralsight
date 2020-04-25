using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;

namespace CityInfo.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers() // mvc middleware to handle http requests
                              .AddJsonOptions(o =>
                              {  // this settings is for case sensitive json - serializable json
                                  o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                                  o.JsonSerializerOptions.PropertyNamingPolicy = null;
                              })
                .AddMvcOptions(o => // this is for use mvc
                {
                    o.EnableEndpointRouting = false;
                    o.ReturnHttpNotAcceptable = true;
                })
                .AddXmlDataContractSerializerFormatters();
                //.AddNewtonsoftJson(setupAction =>
                //    setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());  // add this to serialize the output in XML format

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //in dev environment it will show error
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //in production environment it will show nothing
                app.UseExceptionHandler();
                // to see prod env change properties of project then debug->Environment, Development to Production
            }

            app.UseStatusCodePages();   // it will return 404 text 
            app.UseMvc();

        }
    }
}
