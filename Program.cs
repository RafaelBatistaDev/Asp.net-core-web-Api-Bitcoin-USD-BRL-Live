using Scalar.AspNetCore;
using Microsoft.EntityFrameworkCore; // Para o UseSqlite
using API.Data; // Para o seu AppDbContext

var builder = WebApplication.CreateBuilder(args);

// 1. PRIMEIRO: Configura os serviços (Builder)
builder.Services.AddControllers();
builder.Services.AddOpenApi(); 

// 2. CONFIGURA O BANCO: Sempre dentro da parte do builder
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=moedas.db"));

var app = builder.Build();

// 3. DEPOIS: Configura o pipeline (App)
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); 
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();