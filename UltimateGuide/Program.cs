using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.Add(new ServiceDescriptor(
    typeof(ICityServices),
    typeof(CitiesServices),
    ServiceLifetime.Transient
    ));

builder.Services.AddTransient<ICityServices,CitiesServices>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
