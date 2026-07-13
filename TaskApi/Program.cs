---------using Microsoft.EntityFrameworkCore;
using TaskApi;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TaskDbContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

app.MapGet("/", () =>  "THE API IS ALIVE");

app.Run();
