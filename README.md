# NeerCore Mediator-based REST-API

## Getting started

Execute the following command in your terminal to run the app: \
`dotnet run --project SeniorTemplate.Api`

Open Swagger Docs: https://localhost:7300/swagger/index.html

## Migrate a Database

### Apply migration

Create migration with following command: \
`dotnet ef migrations add <MigrationName> -p SeniorTemplate.Data.Sqlite`

Apply migrations on database: \
`dotnet ef database update`

### Rollback migrations

Rollback local migration: \
`dotnet ef migrations remove`

Rollback migrations on database: \
`dotnet ef database update <MigrationName>`

## Additional information

### Feature list

- Swagger UI
- API Versioning
- JWT Authorization
- Global Exception Handler
- Localization (coming soon)
- CQRS pattern (using MediatR)
- Model mapping (using Mapster)
- Logging (using NLog)
- Entity Framework Core
- Entity Framework Core Identity
- DB Migrations
- HashIDs (using Hashids)
- Sorting&Filtering (using Sieve)
