using MyApi.Configurations.OpenTelemetry;

var builder = WebApplication.CreateBuilder(args);
var applicationName = builder.Environment.ApplicationName;

builder.Services.AddOpenTelemetry()
    .ConfigureTrace(applicationName)
    .ConfigureMetric(applicationName);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();