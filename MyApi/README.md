# Export trace data to Jaeger

1. Run Jaeger container
```bash
docker run --name jaeger -p 13133:13133 -p 16686:16686 -p 4317:4317 -d --restart=unless-stopped jaegertracing/opentelemetry-all-in-one:latest
```
2. AddOtlpExporter