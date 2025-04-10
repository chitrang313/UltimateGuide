using Microsoft.Extensions.Primitives;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
    StreamReader reader = new StreamReader(context.Request.Body);
    string result = await reader.ReadToEndAsync();

    Dictionary<string,StringValues> dictionary = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(result);

    if (dictionary.ContainsKey("firstname")) {
        StringValues firstName = dictionary["firstname"];
        await context.Response.WriteAsync($"{firstName}");
    }
    if (dictionary.ContainsKey("age")) {
        foreach (string? item in dictionary["age"]) {
            await context.Response.WriteAsync($"\n{item}");
        }
    }
});

app.Run();
