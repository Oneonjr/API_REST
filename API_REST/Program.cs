using Pomelo.EntityFrameworkCore.MySql;
using API_REST.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStringMysql = builder.Configuration.GetConnectionString("ConexaoPadrao");
builder.Services.AddDbContext<VendasContext>(options => 
    options.UseMySql(connectionStringMysql,ServerVersion.Parse("8.0.31 MySQL"))); //utilizando MySql


//Ignorando Erro Json.
builder.Services.AddControllers().AddJsonOptions(x => 
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
;

//Ignorando Erros Json
JsonSerializerOptions options = new JsonSerializerOptions{
    Converters ={
        new JsonStringEnumConverter( JsonNamingPolicy.CamelCase)
    },
    
};

JsonSerializer.Serialize(options);

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
