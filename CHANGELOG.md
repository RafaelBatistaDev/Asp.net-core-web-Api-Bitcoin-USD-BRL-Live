# Changelog

Todas as mudanças notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em [Keep a Changelog](https://keepachangelog.com/),
e este projeto segue [Semantic Versioning](https://semver.org/).

---

## [1.0.0] - 2026-04-04

### ✨ Added
- Endpoints CRUD para gerenciamento de moedas (GET, POST, PUT, DELETE)
- Integração com CoinService para buscar cotações em tempo real
- Documentação Swagger/OpenAPI interativa
- Entity Framework Core com migrations do SQL Server
- Modelos de dados: Moeda, Produto
- Controllers profissionais com validação
- Arquivo API.http para testes de endpoints
- Testes preparados para integração

### 🔧 Changed
- Atualização para .NET 8.0
- Configuração de startup modernizada
- appsettings.json organizado e documentado

### 🐛 Fixed
- N/A (primeira release)

### ⚠️ Deprecated
- N/A (primeira release)

### 🔒 Security
- SQL Injection prevenido com EF Core
- CORS configurável
- Validação de entrada nos endpoints

### 📚 Documentation
- README.md completo (750+ linhas)
- DEVELOPMENT.md com guias de setup
- CONTRIBUTING.md com padrões de PR
- GITHUB-CONFIG.md com configuração recomendada
- Comentários de XML em classes e métodos

### 🚀 Infrastructure
- GitHub Actions CI/CD configurado
- .editorconfig para padrões de código
- .gitignore otimizado para .NET
- MIT License adicionada

---

## Unreleased

### Planejado para v1.1.0
- [ ] Autenticação com JWT
- [ ] Rate limiting de requisições
- [ ] Cache com Redis
- [ ] Novos endpoints de relatórios
- [ ] Testes de integração E2E

### Planejado para v2.0.0
- [ ] Webhooks para alertas de preço
- [ ] Integração com mais exchanges
- [ ] API GraphQL
- [ ] Documentação em PDF
- [ ] Docker Compose setup

---

## Padrões de Versionamento

- **MAJOR**: Breaking changes (1.0.0 → 2.0.0)
- **MINOR**: Nova funcionalidade backwards-compatible (1.0.0 → 1.1.0)
- **PATCH**: Bug fixes (1.0.0 → 1.0.1)

**Exemplos:**
- `1.0.0` - Versão inicial
- `1.0.1` - Patch de segurança
- `1.1.0` - Novo endpoint adicionado
- `2.0.0` - Refatoração major com breaking changes

---

**Versão Atual:** [1.0.0]  
**Data:** 4 de abril de 2026  
**Status:** Production Ready ✅

