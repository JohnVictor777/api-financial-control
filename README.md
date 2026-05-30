# API Financial Control

API REST desenvolvida com ASP.NET Core para gerenciamento financeiro pessoal.

## Sobre o Projeto

O objetivo deste projeto é fornecer uma solução para controle financeiro, permitindo o gerenciamento de:

- Usuários
- Receitas
- Despesas
- Categorias
- Metas financeiras

## Tecnologias

- ASP.NET Core Web API
- C#
- Entity Framework Core (planejado)
- SQL Server (planejado)
- Swagger/OpenAPI

## Modelo de Domínio

```text
Usuario
   │
   ├── Transacao
   │
   └── Categoria
```

## Estrutura Atual

```text
src/
└── ApiFinancialControl
```

## Como Executar

### Restaurar dependências

```bash
dotnet restore
```

### Executar aplicação

```bash
dotnet run
```

### Acessar Swagger

```text
https://localhost:<porta>/swagger
```

## Roadmap

### Fase 1

- [ ] Configuração inicial da API
- [ ] Entity Framework Core
- [ ] SQL Server
- [ ] Migrations

### Fase 2

- [ ] CRUD de Usuários
- [ ] CRUD de Categorias
- [ ] CRUD de Transações

### Fase 3

- [ ] Autenticação JWT
- [ ] Metas Financeiras
- [ ] Dashboard Financeiro

### Fase 4

- [ ] Docker
- [ ] Testes Unitários
- [ ] GitHub Actions

## Desenvolvido por

**John Victor do E. Santo**

[![GitHub](https://img.shields.io/badge/GitHub-JohnVictor777-181717?logo=github)](https://github.com/JohnVictor777)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-johnvic7or-0A66C2?logo=linkedin)](https://linkedin.com/in/johnvic7or)
