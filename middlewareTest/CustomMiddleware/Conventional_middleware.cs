using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace middlewareTest.CustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Conventional_middleware
    {
        private readonly RequestDelegate _next;

        public Conventional_middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            // before logic
            if (httpContext.Request.Query.ContainsKey("firstname") &&
                httpContext.Request.Query.ContainsKey("lastname"))
            {
                string fullName = httpContext.Request.Query["firstname"] + " " +
                httpContext.Request.Query["lastname"];
                //await httpContext.Response.WriteAsync(fullName);
                httpContext.Items["fullName"] = fullName;
                //Console.WriteLine(fullName);
            }
            await _next(httpContext);
            // after logic
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Conventional_middlewareExtensions
    {
        public static IApplicationBuilder UseConventional_middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Conventional_middleware>();
        }
    }
}
