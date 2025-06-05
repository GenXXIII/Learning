using CRUD_API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CrudDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); // Ensure you have a connection string named "DefaultConnection" in your appsettings.json or environment variables.
});
builder.Services.AddSwaggerGen();  // This is needed to generate Swagger documentation for API

builder.Services.AddEndpointsApiExplorer(); // This is needed for Swagger to discover your API endpoints

var app = builder.Build();

if(app.Environment.IsDevelopment())  // Check if the environment is development before enabling Swagger
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
