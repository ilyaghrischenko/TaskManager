using AccountService.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddOpenAPI()
    .AddApplicationServices()
    .AddIntegrationServices()
    .AddDbContext();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();