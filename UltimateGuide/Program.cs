using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("Middleware 1");
    await next(context);
});

//middleware 2
app.Use(async (HttpContext context,RequestDelegate next) => {
    await context.Response.WriteAsync("\nMiddleware 2");
    await next(context);
});

//middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nTerminating Middleware");
});

app.Run();
