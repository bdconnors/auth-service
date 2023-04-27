# auth-service
.NET 6 and EF Authentication Service

Experimenting with a multi-tenant JWT authentication service.

# Technologies Used

1. Microsoft SQL Server

2. .NET Core 6

3. Entity Framework 6

# Local Setup

1. Open TCP all ports in SQL Server Configuration Manager

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql1.png)

2. Set password on MSSQL root service account

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql2.png)

3. Enable connect and login on MSSQL root service account

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql3.png)

4. Verify service account can login

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql4.png)

5. Set your local PC name and service account password in the appsettings.json connection string

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql5.png)

# Database Design
![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/erd.png)

# Architecture Design
![Architecture Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/design.png)

