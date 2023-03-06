using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using TesteAutoGlass.Configuration;
using TesteAutoGlassNegocio.DTO;
using TesteAutoGlassNegocio.Interface;
using TesteAutoGlassNegocio.Services;
using TesteAutoGlassNegocio.Validation;
using TesteAutoGlassPersistencia.Interface;
using TesteAutoGlassPersistencia.Padrao;
using TesteAutoGlassPersistencia.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//BANCO DE DADOS
string mySqlConnection = builder.Configuration.GetConnectionString("DEV");
builder.Services.AddDbContext<TesteDbContext>(options => options.UseSqlServer(mySqlConnection));

//mapper
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//INJEÇÂO DE DEPENDENCIA
builder.Services.AddScoped<IProdutosService, ProdutosService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IPadraoDB, PadraoDB>();
builder.Services.AddValidatorsFromAssemblyContaining<ProdutoValidation>();

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
