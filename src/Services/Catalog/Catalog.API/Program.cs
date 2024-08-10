var builder = WebApplication.CreateBuilder(args);

// Add services to the container (AddServiceMethod)
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure the https request pipeline (UseMethod)
app.MapCarter();
app.Run();
