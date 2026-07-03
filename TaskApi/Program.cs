using Microsoft.EntityFrameworkCore;
using TaskApi;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TaskDbContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

app.MapGet("/", () =>  "THE API IS ALIVE");

app.Run();

//1. Instalar la herramienta de consola de Entity Framework
//dotnet tool install --global dotnet-ef
//2. Crear el "plano" de construcción (La Migración)
//dotnet ef migrations add InitialCreate
//3. Ejecutar la construcción
//dotnet ef database update
//Text is required for the notes 

//sd