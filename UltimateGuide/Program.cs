using UltimateGuide.Middleware;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//Enable Routing
app.UseRouting();

//creating end points
app.UseEndpoints(endpoints => {

});


app.Run();
