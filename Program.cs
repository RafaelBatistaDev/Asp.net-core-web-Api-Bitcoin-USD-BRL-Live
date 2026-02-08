using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Services; // Adicione este namespace para o serviço de cotação

var builder = WebApplication.CreateBuilder(args);

// --- CONFIGURAÇÃO DOS SERVIÇOS (BUILDER) ---

builder.Services.AddControllers();
builder.Services.AddOpenApi(); 

// Configura o banco de dados SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=moedas.db"));

// REGISTRA O SERVIÇO DE PREÇOS REAIS
builder.Services.AddHttpClient<CoinService>(); 

var app = builder.Build();

// --- CONFIGURAÇÃO DO PIPELINE (APP) ---

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); 
}

// Redireciona a raiz para o Scalar facilitar sua vida
app.MapGet("/", () => Results.Redirect("/scalar/v1"));

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();