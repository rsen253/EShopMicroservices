var builder = WebApplication.CreateBuilder(args);

// Add services to the container (AddServiceMethod)

var app = builder.Build();

// Configure the https request pipeline (UseMethod)

app.Run();
