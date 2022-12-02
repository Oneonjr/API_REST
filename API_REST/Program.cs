using Pomelo.EntityFrameworkCore.MySql;
using API_REST.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStringMysql = builder.Configuration.GetConnectionString("ConexaoPadrao");
builder.Services.AddDbContext<VendasContext>(options => 
    options.UseMySql(connectionStringMysql,ServerVersion.Parse("8.0.31 MySQL")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
