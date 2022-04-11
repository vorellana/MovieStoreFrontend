using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MovieStoreFrontend.WebAppBlazor.Data;

var builder = WebApplication.CreateBuilder(args);
var backendUrl = builder.Configuration.GetSection("MovieStoreBackendUrl").Value;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri(backendUrl)
});

// Ignore SSL certificate
var httpClientHandler = new HttpClientHandler();
httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();