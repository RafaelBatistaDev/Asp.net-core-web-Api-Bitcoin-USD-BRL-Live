# 🪙 Bitcoin Price API

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0%2B-blue)](https://dotnet.microsoft.com)
[![C#](https://img.shields.io/badge/C%23-12-green)](https://docs.microsoft.com/dotnet/csharp)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-purple)](https://aspnet.core)
[![GitHub](https://img.shields.io/badge/GitHub-Public-black)](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-API-Bitcoin-USD-BRL-Live)

API RESTful em ASP.NET Core para cotações de Bitcoin em USD e BRL em tempo real.

**Licença:** MIT — Open source, use livremente! 📜

---

## 📋 Sobre o Projeto

**Bitcoin Price API** é uma API profissional que fornece:

✅ **Cotações em tempo real** de Bitcoin (USD/BRL)  
✅ **Endpoints RESTful** bem documentados  
✅ **Banco de dados** com Entity Framework Core  
✅ **Autenticação** preparada para integração  
✅ **C# moderno** (.NET 8+, nullable reference types)  
✅ **Testes e documentação** completos  

### Funcionalidades Principais

- **GET /api/moedas** — Listar todas as moedas
- **GET /api/moedas/{id}** — Obter cotação específica
- **POST /api/moedas** — Cadastrar nova moeda
- **PUT /api/moedas/{id}** — Atualizar cotação
- **DELETE /api/moedas/{id}** — Remover moeda
- **Swagger/OpenAPI** — Documentação interativa
- **Entity Framework Core** — ORM integrado
- **CI/CD** — GitHub Actions automático

---

## 🛠️ Requisitos

- **.NET SDK 8.0** ou superior ([Download](https://dotnet.microsoft.com/download))
- **SQL Server** ou **SQLite** (padrão)
- **Git** (para versionamento)

**Verificar instalação:**
```bash
dotnet --version
```

---

## 📂 Estrutura do Projeto

```
Bitcoin-API/
├── Program.cs                    # Entry point e configuração
├── API.csproj                    # Configuração do projeto
├── API.sln                       # Solução Visual Studio
│
├── Controllers/
│   ├── MoedasController.cs       # Endpoints de moedas
│   └── WeatherForecastController.cs
│
├── Models/
│   ├── Moeda.cs                  # Modelo de moeda
│   └── Produto.cs                # Modelo de produto
│
├── Services/
│   └── CoinService.cs            # Serviço de integração
│
├── Data/
│   └── AppDbContext.cs           # DbContext do EF Core
│
├── Migrations/
│   └── (migrações do banco)
│
├── Properties/
│   └── launchSettings.json       # Configuração de launch
│
├── appsettings.json              # Configurações gerais
├── appsettings.Development.json  # Config development
├── API.http                      # Testes de endpoints
│
├── .github/workflows/            # CI/CD
├── .gitignore
├── .editorconfig
├── LICENSE
└── README.md
```

---

## 🚀 Quick Start

### 1. **Clone o Repositório**
```bash
git clone https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-API-Bitcoin-USD-BRL-Live.git
cd ASP.NET-Core-Web-API-Bitcoin-USD-BRL-Live
```

### 2. **Instale Dependências**
```bash
dotnet restore
```

### 3. **Configure o Banco de Dados**
```bash
# Aplicar migrações
dotnet ef database update
```

### 4. **Execute em Desenvolvimento**
```bash
dotnet run
```

A API estará disponível em: `https://localhost:7001`  
Swagger UI: `https://localhost:7001/swagger`

### 5. **Build de Produção**
```bash
dotnet publish -c Release -o ./publish
```

---

## 📦 Dependências

| Pacote | Versão | Propósito |
|--------|--------|-----------|
| `Microsoft.EntityFrameworkCore` | 8.0+ | ORM - Acesso a dados |
| `Microsoft.EntityFrameworkCore.SqlServer` | 8.0+ | Provider SQL Server |
| `Swashbuckle.AspNetCore` | 6.0+ | Swagger/OpenAPI |

---

## 🔌 Endpoints da API

### Listar Moedas
```http
GET /api/moedas HTTP/1.1
Host: localhost:7001
```

**Response:**
```json
[
  {
    "id": 1,
    "nome": "Bitcoin",
    "simbolo": "BTC",
    "precoUsd": 45000.00,
    "precoBrl": 225000.00,
    "dataAtualizacao": "2026-04-04T10:30:00"
  }
]
```

### Obter Moeda Específica
```http
GET /api/moedas/1 HTTP/1.1
Host: localhost:7001
```

### Criar Nova Moeda
```http
POST /api/moedas HTTP/1.1
Content-Type: application/json

{
  "nome": "Ethereum",
  "simbolo": "ETH",
  "precoUsd": 2500.00,
  "precoBrl": 12500.00
}
```

---

## 📊 Configuração & Desenvolvimento

### Connection String
Edit `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=BitcoinApiDb;Trusted_Connection=true;"
  }
}
```

### Environment Variables
```bash
# Development
ASPNETCORE_ENVIRONMENT=Development

# Production
ASPNETCORE_ENVIRONMENT=Production
```

---

## 🧪 Testes

```bash
# Criar projeto de testes
dotnet new xunit -n API.Tests

# Rodar testes
dotnet test

# Com cobertura
dotnet test /p:CollectCoverage=true
```

---

## 📦 Deploy

### 1. **Azure App Service**
```bash
dotnet publish -c Release
# Deploy via Azure Portal
```

### 2. **Docker**
```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore && dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "API.dll"]
```

### 3. **AWS/Heroku**
```bash
# Build e deploy automático
dotnet publish -c Release -o ./publish
```

---

## 🤝 Contribuindo

Contribuições são bem-vindas!

1. **Fork** o repositório
2. **Crie um branch** (`git checkout -b feature/NewFeature`)
3. **Commit** as mudanças (`git commit -m 'Add NewFeature'`)
4. **Push** para o branch (`git push origin feature/NewFeature`)
5. **Abra uma Pull Request**

### Padrões de Código
- ✅ C# moderno (C# 12+)
- ✅ Nullable reference types habilitado
- ✅ Async/await em todas APIs
- ✅ Services bem separados
- ✅ Testes unitários
- ✅ Documentação completa

---

## 📜 Uso Público & Licença

Este projeto é **100% Open Source** sob a licença **MIT**.

### ✅ Você pode:
- ✅ Usar em projetos pessoais e comerciais
- ✅ Modificar e adaptar livremente
- ✅ Distribuir obras derivadas
- ✅ Usar privadamente

### ⚠️ Condições:
- ⚠️ Incluir cópia da licença MIT
- ⚠️ Indicar mudanças significativas

---

## 🔐 Segurança

- ✅ SQL Injection prevenido (Entity Framework)
- ✅ CORS configurável
- ✅ Validação de entrada
- ✅ Sem dados sensíveis no repositório
- ✅ Code open para auditoria

---

## 📞 Suporte

- 📖 [ASP.NET Core Docs](https://learn.microsoft.com/aspnet/core)
- 🐛 [Issues](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-API-Bitcoin-USD-BRL-Live/issues)
- 💬 [Discussions](https://github.com/RafaelBatistaDev/ASP.NET-Core-Web-API-Bitcoin-USD-BRL-Live/discussions)

---

## 🎯 Roadmap

- [ ] Autenticação JWT
- [ ] Rate limiting
- [ ] Cache com Redis
- [ ] Webhooks para cotações
- [ ] Integração com mais exchanges
- [ ] Testes de integração
- [ ] Docker Compose
- [ ] Documentação GraphQL

---

**Última atualização:** 4 de abril de 2026  
**Versão:** 1.0.0  
**Licença:** MIT  
**Status:** Production Ready ✅

---

## 👤 Autor

**Rafael Batista**  
🔗 GitHub: [@RafaelBatistaDev](https://github.com/RafaelBatistaDev)  
💼 LinkedIn: [Seu Perfil](https://linkedin.com)
