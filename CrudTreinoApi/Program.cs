using CrudDomain.Data;
using CrudService.Service;
using CrudTreinoApi.Repository;
using CrudTreinoApi.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CadastroContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddScoped<ICadastroRepository, CadastroRepository>();
builder.Services.AddScoped<ICadastroService, CadastroService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
