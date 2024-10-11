# AuthenticationApp

AuthenticationApp is a web application built with ASP.NET Core 8 that implements user authentication and authorization using ASP.NET Core Identity with role management. This app allows users to register, log in, and be assigned different roles with varying permissions.

## Features

- **User Registration**: New users can create an account.
- **Login & Logout**: Users can log in and log out securely.
- **Role Management**: Assign roles to users (e.g., Admin, User).
- **Authorization**: Control access to different parts of the application based on user roles.

## Technologies Used

- C#
- ASP.NET Core 8 MVC
- ASP.NET Core Identity
- Entity Framework Core (for user data storage)
- SQL Server (or any other compatible database)

## Getting Started

Follow these instructions to get the project up and running locally.

### Prerequisites

Ensure you have the following installed on your machine:

- [.NET Core 8 SDK](https://dotnet.microsoft.com/download/dotnet-core/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or any other preferred C# IDE.
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or any compatible database system.

### Installation

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/NikaL25/AuthenticationApp.git
2. cd AuthenticationApp
3. dotnet restore

### Database Setup
"ConnectionStrings": {
  "DefaultConnection": "Data Source=DESKTOP-9CHL98U\SQLEXPRESS;Initial Catalog=authenticationapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
}

