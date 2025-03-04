using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Agenda.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AgendaContext") ?? throw new InvalidOperationException("Connection string 'AgendaContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AgendaContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Contactos}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
