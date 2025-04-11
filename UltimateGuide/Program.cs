using UltimateGuide.Middleware;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//Enable Routing
app.UseRouting();

//creating end points
app.UseEndpoints(endpoints => {
    endpoints.Map("files/{filename}.{extension}",async (context) => {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"Reading File: {filename} - {extension}");
    });

    endpoints.Map("employees/profile/{name=user}", async (context) => {
        string? name = context.Request.RouteValues["name"].ToString();
        await context.Response.WriteAsync($"Employee Profile: {name}");
    });

    endpoints.Map("product/detail/{id=0}",async (context) => {
        int? id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Product Detail: {id}");
    });

});

app.Run(async (context) => { 
    await context.Response.WriteAsync($"Request received at: {context.Request.Path}");
});

app.Run();
