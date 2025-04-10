var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
	context.Response.ContentType = "text/html";
	if (context.Request.Method == "GET") {
		string key = "id";
		if (context.Request.Query.ContainsKey(key)) {
			string? value = context.Request.Query[key];
			await context.Response.WriteAsync($"<p>{value}</p>");
		}
    }
});

app.Run();
