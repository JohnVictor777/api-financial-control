# API Financial Control

REST API developed with ASP.NET Core for personal financial management.

## About the Project

The goal of this project is to provide a financial management solution, allowing users to manage:

- Users
- Income
- Expenses
- Categories
- Financial Goals

## Technologies

- ASP.NET Core Web API
- C#
- Entity Framework Core (planned)
- SQL Server (planned)
- Swagger / OpenAPI

## Domain Model

```text
User
   │
   ├── Transaction
   │
   └── Category
```

## Current Structure

```text
src/
└── ApiFinancialControl
```

## Getting Started

### Restore Dependencies

```bash
dotnet restore
```

### Run the Application

```bash
dotnet run
```

### Access Swagger

```text
https://localhost:<port>/swagger
```

## Roadmap

### Phase 1

- [ ] Initial API setup
- [ ] Entity Framework Core
- [ ] SQL Server
- [ ] Database Migrations

### Phase 2

- [ ] User CRUD
- [ ] Category CRUD
- [ ] Transaction CRUD

### Phase 3

- [ ] JWT Authentication
- [ ] Financial Goals
- [ ] Financial Dashboard

### Phase 4

- [ ] Docker
- [ ] Unit Tests
- [ ] GitHub Actions

## Developed By

**John Victor do E. Santo**

[![GitHub](https://img.shields.io/badge/GitHub-JohnVictor777-181717?logo=github)](https://github.com/JohnVictor777)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-johnvic7or-0A66C2?logo=linkedin)](https://linkedin.com/in/johnvic7or)
