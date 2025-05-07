using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//builder.Services.Add(new ServiceDescriptor(
//    typeof(ICityServices),
//    typeof(CitiesServices),
//    ServiceLifetime.Scoped
//    ));

builder.Services.AddTransient<ICityServices,CitiesServices>();
builder.Services.AddScoped<ICityServices,CitiesServices>();
builder.Services.AddSingleton<ICityServices,CitiesServices>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
