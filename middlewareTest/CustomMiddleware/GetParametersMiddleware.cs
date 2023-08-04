using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace middlewareTest.CustomMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GetParametersMiddleware
    {
        private readonly RequestDelegate _next;

        public GetParametersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine(httpContext.Items["fullName"]);
            Console.WriteLine("end");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GetParametersMiddlewareExtensions
    {
        public static IApplicationBuilder UseGetParametersMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GetParametersMiddleware>();
        }
    }
}
