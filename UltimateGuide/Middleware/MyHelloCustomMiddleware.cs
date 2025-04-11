using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace UltimateGuide.Middleware {
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyHelloCustomMiddleware {
        private readonly RequestDelegate _next;

        public MyHelloCustomMiddleware(RequestDelegate next) {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext) {
            if (httpContext.Request.Query.ContainsKey("firstname") && httpContext.Request.Query.ContainsKey("lastname")) { 
                string fullname = httpContext.Request.Query["firstname"] + " " + httpContext.Request.Query["lastname"];
                await httpContext.Response.WriteAsync($"\nHello {fullname}");
            }
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyHelloCustomMiddlewareExtensions {
        public static IApplicationBuilder UseMyHelloCustomMiddleware(this IApplicationBuilder builder) {
            return builder.UseMiddleware<MyHelloCustomMiddleware>();
        }
    }
}
