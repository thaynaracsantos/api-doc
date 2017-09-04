using System;

namespace WebApplication.Swagger
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class HideInDocsAttribute : Attribute
    {
    }
}
