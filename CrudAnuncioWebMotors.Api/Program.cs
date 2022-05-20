using CrudAnuncioWebMotors.Api.Configurations;
using CrudAnuncioWebMotors.Domain.Handlers;
using CrudAnuncioWebMotors.Domain.Repositories;
using CrudAnuncioWebMotors.Domain.Services.Anuncio;
using CrudAnuncioWebMotors.Domain.Services.Config;
using CrudAnuncioWebMotors.Infra.Repositories;
using CrudAnuncioWebMotors.Infra.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RepositoryMap();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


