using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace WebApplication
{
    public partial class Startup
    {
        private void ConfigureSwaggerService(IServiceCollection services)
        {
            SwaggerInfo info = Configuration.GetSection("SwaggerInfo").Get<SwaggerInfo>();            

            services.AddSwaggerGen(options =>
            {
                string basePath = PlatformServices.Default.Application.ApplicationBasePath;
                string moduleName = GetType().GetTypeInfo().Module.Name.Replace(".dll", ".xml");
                string filePath = Path.Combine(basePath, moduleName);
                string readme = File.ReadAllText(Path.Combine(basePath, "README.md"));

                options.AddSecurityDefinition("Authentication", new ApiKeyScheme() {
                    In = "header",
                    Description = "Authentication description",
                    Name = "Authorization",
                    Type = "key" });

                options.SwaggerDoc(info.Version,
                    new Info
                    {
                        Title = info.Title,
                        Version = info.Version,
                        Description = readme,
                        TermsOfService = info.TermsOfService,
                        Contact = new Contact
                        {
                            Name = info.ContactEmail,
                            Email = info.ContactName
                        }
                    }
                 );

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
