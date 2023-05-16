# auth-service
.NET 6 and EF Authentication Service

Experimenting with a multi-tenant JWT authentication service.

# Technologies Used

1. Microsoft SQL Server

2. .NET Core 6

3. Entity Framework 6

# Local Setup


1. Set your MSSQL connection string in the appsettings.json

![Connection string](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql5.png)

2. Run the Auth Solution in debug

![Run Auth Solution](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/run.png)

3. Execute a test GET request in Swagger to generate the schema in your database

![Swagger Test](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/swagger.png)

# Database Design
![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/erd.png)

# Architecture
![Architecture Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/arch.png)

