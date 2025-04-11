using UltimateGuide.Middleware;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Use(async (context,next) => {
    Endpoint? endpoint = context.GetEndpoint();
    await context.Response.WriteAsync($"Endpoint: {endpoint?.DisplayName}\n");
    await next(context);
});

//Enable Routing
app.UseRouting();

app.Use(async (context,next) => {
    Endpoint? endpoint = context.GetEndpoint();
    await context.Response.WriteAsync($"Endpoint: {endpoint?.DisplayName}\n");
    await next(context);
});

//creating end points
app.UseEndpoints(endpoints => {
    endpoints.MapGet("map1",async (context) => { 
        await context.Response.WriteAsync("map1 execute");
    });

    endpoints.MapPost("map2",async (context) => {
        await context.Response.WriteAsync("map2 execute");
    });
});

app.Run(async (context) => { 
    await context.Response.WriteAsync($"Request received at: {context.Request.Path}");
});

app.Run();
