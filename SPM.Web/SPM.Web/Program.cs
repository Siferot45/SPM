using Microsoft.EntityFrameworkCore;
using SPM.Storage.Context;
using SPM.Web.Client.Pages;
using SPM.Web.Components;
using SPM.Domain.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//DI
builder.Services.AddDomainDI();

builder.Services.AddDbContext<DbSPMContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("postgre"));
});
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

app.Run();
