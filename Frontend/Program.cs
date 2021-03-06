using Frontend.Data;
using Infrastructure;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<PdfService>();
builder.Services.AddSingleton<ExcelService>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddRazorPages();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Services.AddServerSideBlazor()
       .AddHubOptions(o =>
        {
            o.MaximumReceiveMessageSize = 102400000;
        });

var app = builder.Build();

SyncfusionLicenseProvider.RegisterLicense(app.Configuration.GetValue<string>("LicenseKey"));

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