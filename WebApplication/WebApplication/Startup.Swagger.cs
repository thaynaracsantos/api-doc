using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Reflection;

namespace WebApplication
{
    public partial class Startup
    {
        private void ConfigureSwaggerService(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Web API",
                        Version = "v1",
                        Description = "Web API Description",
                        TermsOfService = "Terms of service"
                    }
                 );

                string basePath = PlatformServices.Default.Application.ApplicationBasePath;
                string moduleName = GetType().GetTypeInfo().Module.Name.Replace(".dll", ".xml");
                string filePath = Path.Combine(basePath, moduleName);

                options.IncludeXmlComments(filePath);
                options.DescribeAllEnumsAsStrings();
            });
        }

        private void ConfigureSwagger(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger(c => c.PreSerializeFilters.Add((swagger, httpReq) => swagger.Host = httpReq.Host.Value));
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs"));
            }
        }
    }
}
