using Microsoft.EntityFrameworkCore;
using prjEmpSys.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddDbContext<EmpDbContext>(options => 
          options.UseSqlServer(builder.Configuration.GetConnectionString("MyDB")));

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(name: "default",
    pattern: "{Controller=Home}/{Action=Index}/{id?}");

app.Run();
