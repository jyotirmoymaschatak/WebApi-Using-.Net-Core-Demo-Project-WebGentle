using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo_From_WebGentle
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
            services.AddControllers();
            services.AddTransient<CustomMiddleWare1>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi_Demo_From_WebGentle", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region Custom Middlewares Demo
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run1");
            //});
            // after 1st run the below code wont be executed

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use1 - 1 \n");
            //    await next(); // will call the next middleware
            //    await context.Response.WriteAsync("Hello from Use1 - 2 \n");
            //});

            //app.UseMiddleware<CustomMiddleWare1>(); //calling custom middleware
            //app.Map("/jyotirmoy", CustomCode);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use2 - 1 \n");
            //    await next(); // will call the next middleware
            //    await context.Response.WriteAsync("Hello from Use2 - 2 \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run2 \n");
            //});
            #endregion

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi_Demo_From_WebGentle v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting(); //Routing is enabled

            app.UseAuthorization();

            app.UseEndpoints(endpoints => //Related to routing, adding controllers to routings
            {
                endpoints.MapControllers();
            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from CustomCode - Map \n");
            });
        }
    }
}
