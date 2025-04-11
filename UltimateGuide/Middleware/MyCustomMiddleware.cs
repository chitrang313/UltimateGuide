
namespace UltimateGuide.Middleware {
    public class MyCustomMiddleware:IMiddleware {
        public async Task InvokeAsync(HttpContext context,RequestDelegate next) {
            await context.Response.WriteAsync("\nCustom Middleware Start");
            await next(context);
            await context.Response.WriteAsync("\nCustom Middleware End");
        }
    }
}
