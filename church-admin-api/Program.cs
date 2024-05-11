using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChurchAdminContext>(context=>{
    context.UseSqlite(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
