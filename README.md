# auth-service
.NET 6 and EF Authentication Service

Experimenting with a multi-tenant JWT authentication service.

# Technologies Used

1. Microsoft SQL Server

2. .NET Core 6

3. Entity Framework 6

# Local Setup


1. Set your local PC name and service account password in the appsettings.json connection string

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/mssql5.png)

2. Create an Org by sending a POST request to https://localhost:7267/api/org with a "name" in the request body and Content-Type header set to "application/json"

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/api1.png)

3. Create a Site by sending a POST request to https://localhost:7267/api/site with a "name" and "orgId" in the request body and Content-Type header set to "application/json"

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/api2.png)

4. Create a User by sending a POST request to https://localhost:7267/api/user with a "firstName", "lastName", "email", "password" and "mobileNumber" in the request body and Content-Type header set to "application/json"

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/api3.png)

5. Register a UserSite by sending a POST request to https://localhost:7267/api/user/site with a "userId", "siteId", and "role" in the request body and Content-Type header set to "application/json"

![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/api4.png)

# Database Design
![Entity Relationship Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/erd.png)

# Architecture
![Architecture Diagram](https://raw.githubusercontent.com/bdconnors/auth-service/main/Image/arch.png)

