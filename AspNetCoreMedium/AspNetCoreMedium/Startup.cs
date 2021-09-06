using ComarcarServentiaServiceReference;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using SoapCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Models;
using System.ServiceModel;

namespace AspNetCoreMedium
{
 
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSoapCore();
            //services.TryAddSingleton<ComarcasServentias, ComarcasServentiasImpl>();

            //services.TryAddSingleton<ISampleService, SampleService>();
            services.TryAddSingleton<ComarcasServentias, ComarcarServentiaService>();
            services.AddMvc();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSoapEndpoint<ComarcasServentias>("/ComarcasServentiaService.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            //app.UseEndpoints(endpoints =>
            //{
            //endpoints.MapGet("/", async context =>
            // {
            //    await context.Response.WriteAsync("Hello World!");
            //});
            //  endpoints.UseSoapEndpoint<ComarcasServentias>("/ComarcasServentias.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
            // });
        }
    }
}
