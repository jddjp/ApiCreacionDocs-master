using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ApiCreacionDocs.Interfaces;
using ApiCreacionDocs.Services;
using ApiCreacionDocs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


namespace ApiCreacionDocs
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("AppAdministration", new OpenApiInfo()
                { Title = "Api Creacion Docs",
                   Version="V1"});

       
            });

       
            //ServiciosControllers
            services.AddControllers();
           
            // Nuget dependencies  vistas pdfs
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddMvc().AddControllersAsServices();

            // Services dependencies Vistas pdf
            services.AddTransient<IDocumentService, DocumentService>();
            services.AddTransient<IRazorRendererHelper, RazorRendererHelper>();

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //SWAGGER
            app.UseStaticFiles();
            app.UseSwagger();
           

            app.UseSwaggerUI(c =>
            {
                // c.SwaggerEndpoint("AppAdministration/swagger.json", "Api Creacion Docs");
                c.SwaggerEndpoint("AppAdministration/swagger.json", "Api Creacion  Docs");
            });

            //SWAGGER


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
