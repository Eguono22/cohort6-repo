var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();

// Define endpoints
app.MapGet("/", () => "Hello World from ASP.NET Core!")
    .WithName("GetRoot")
    .WithOpenApi();

app.MapGet("/api/status", () => new
{
    Status = "Running",
    Version = "1.0.0",
    Timestamp = DateTime.UtcNow
})
    .WithName("GetStatus")
    .WithOpenApi();

app.MapGet("/api/time", () => new
{
    ServerTime = DateTime.UtcNow,
    TimeZone = TimeZoneInfo.Local.DisplayName
})
    .WithName("GetTime")
    .WithOpenApi();

app.Run();