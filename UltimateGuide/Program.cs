using Microsoft.Extensions.Primitives;
using UltimateGuide.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();

var app = builder.Build();

//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("\nMiddleware 1");
    await next(context);
});

//middleware 2
//app.UseMiddleware<MyCustomMiddleware>();
app.UseMyCustomMiddleware();
app.UseMyHelloCustomMiddleware();


//middleware 3
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nTerminating Middleware");
});

app.Run();
