var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
	context.Response.ContentType = "text/html";
	string? userAgent = context.Request.Headers["User-Agent"];
	await context.Response.WriteAsync($"<p>{userAgent}</p>");
});

app.Run();
