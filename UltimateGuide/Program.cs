using Microsoft.Extensions.Primitives;
using UltimateGuide.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();

var app = builder.Build();

app.UseWhen(context => context.Request.Query.ContainsKey("username"),
    app => {
        app.Use(async (context,next) => {
            await context.Response.WriteAsync("\nUsername Found");
            await next(context);
        });
    });

app.Run(context => context.Response.WriteAsync("Main Chain Middleware"));

app.Run();
