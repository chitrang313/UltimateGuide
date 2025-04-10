var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
    context.Response.ContentType = "text/html";
    string key = "AuthorizationKey";
    if (context.Request.Headers.ContainsKey(key)) {
        string? value = context.Request.Headers[key];
        await context.Response.WriteAsync($"<p>{value}</p>");
    }
});

app.Run();
