using DependencyInjectionChallenge;
using DependencyInjectionChallenge.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = new ServiceCollection();
services.AddScoped<IScopedService, ScopedService>();
services.AddSingleton<ISingletonService, SingletonService>();
services.AddTransient<ITransientService, TransientService>();
var serviceProvider = services.BuildServiceProvider();

builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddTransient<ITransientService, TransientService>();

serviceProvider.Dispose();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
