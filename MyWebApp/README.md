# MyWebApp

ASP.NET Core 9.0 Minimal API Web Application

## Description
A simple web application built with ASP.NET Core minimal API, designed to be deployed to Azure Web Apps.

## Prerequisites
- .NET 9.0 SDK or later
- Visual Studio 2022 or VS Code (optional)

## Running Locally

```bash
cd MyWebApp
dotnet restore
dotnet run
```

The application will start on `https://localhost:5001` (or `http://localhost:5000`)

## Endpoints

- `GET /` - Returns "Hello World from ASP.NET Core!"
- `GET /api/status` - Returns application status
- `GET /api/time` - Returns current server time

## Deployment

This application is configured to deploy to Azure Web Apps via GitHub Actions.

To deploy:
1. Push changes to the `main` branch, or
2. Manually trigger the workflow from the Actions tab

## Configuration

Application settings can be configured in:
- `appsettings.json` - Production settings
- `appsettings.Development.json` - Development settings

## Technologies Used

- ASP.NET Core 9.0
- Minimal APIs
- Azure Web Apps
- GitHub Actions for CI/CD