using UltimateGuide.Middleware;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//Enable Routing
app.UseRouting();

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
