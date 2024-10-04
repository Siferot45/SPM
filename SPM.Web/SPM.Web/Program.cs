using Microsoft.EntityFrameworkCore;
using SPM.Domain.DependencyInjection;
using SPM.Storage.DependencyInjection;
using SPM.Web.Client;
using SPM.Web.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//DI
builder.Services.AddDomainDI();
builder.Services.AddStorageDI(builder.Configuration.GetConnectionString("postgre"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(SPM.Web.Client._Imports).Assembly);

app.MapControllers();

app.Run();
