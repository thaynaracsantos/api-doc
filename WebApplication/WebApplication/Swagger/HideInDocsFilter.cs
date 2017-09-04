using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using System.Reflection;

namespace WebApplication.Swagger
{
    public class HideInDocsFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            foreach (var apiDescriptionsGroup in context.ApiDescriptionsGroups.Items)
            {
                foreach (ApiDescription apiDescription in apiDescriptionsGroup.Items)
                {
                    var descriptor = apiDescription.ActionDescriptor as ControllerActionDescriptor;
                    if (descriptor == null) continue;
                    if (!descriptor.MethodInfo.GetCustomAttributes<HideInDocsAttribute>().Any()) continue;

                    string route = "/" + descriptor.AttributeRouteInfo.Template.TrimEnd('/');
                    string actionName = descriptor.ActionName;
                    PathItem value = swaggerDoc.Paths[route];                   

                    value.Delete = actionName.Equals("Delete") ? null : value.Delete;
                    value.Get = actionName.Equals("Get") ? null : value.Get;
                    value.Patch = actionName.Equals("Patch") ? null : value.Patch;
                    value.Post = actionName.Equals("Post") ? null : value.Post;
                    value.Options = actionName.Equals("Options") ? null : value.Options;
                    value.Head = actionName.Equals("Head") ? null : value.Head;
                    value.Ref = actionName.Equals("Ref") ? null : value.Ref;
                    value.Parameters = actionName.Equals("Parameters") ? null : value.Parameters;

                    swaggerDoc.Paths[route] = value;
                }
            }
        }
    }
}
