using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using OpenTelemetry.Metrics;

namespace MyApi.Configurations.OpenTelemetry;

public static class OpenTelemetryExtension
{
    public static OpenTelemetryBuilder ConfigureTrace(this OpenTelemetryBuilder openTelemetryBuilder, string serviceName)
        => openTelemetryBuilder.WithTracing(x => x
              .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService(serviceName))
              .AddAspNetCoreInstrumentation()
              .AddHttpClientInstrumentation()
              .AddConsoleExporter()
              .AddOtlpExporter(x => x.Endpoint = new Uri("http://localhost:4317")));

    public static OpenTelemetryBuilder ConfigureMetric(this OpenTelemetryBuilder openTelemetryBuilder, string serviceName)
        => openTelemetryBuilder.WithMetrics(x => x
              .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService(serviceName))
              .AddAspNetCoreInstrumentation()
              .AddHttpClientInstrumentation()
              .AddConsoleExporter());
}