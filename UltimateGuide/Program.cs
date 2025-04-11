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

    endpoints.Map("employees/profile/{name?}",async (context) => {
        if (context.Request.RouteValues.ContainsKey("name")) {
            string? name = context.Request.RouteValues["name"].ToString();
            await context.Response.WriteAsync($"Employee Profile: {name}");
        } else {
            await context.Response.WriteAsync($"Employee Profile: No Name provided");
        }
    });

    endpoints.Map("product/detail/{id?}",async (context) => {
        if (context.Request.RouteValues.ContainsKey("id")) {
            int? id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Product Detail: {id}");
        } else {
            await context.Response.WriteAsync($"Product Detail: No ID provided");
        }
    });

    endpoints.Map("daily-digest-report/{reportdate:datetime?}",async (context) => {
        if (context.Request.RouteValues.ContainsKey("reportdate")) {
            DateTime selectedDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
            await context.Response.WriteAsync($"Report: {selectedDate.ToShortDateString()}");
        } else {
            await context.Response.WriteAsync($"Report: No Date provided");
        }
    });

});

app.Run(async (context) => {
    await context.Response.WriteAsync($"Request received at: {context.Request.Path}");
});

app.Run();
