using BlazorRealTime.Server;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.AddServices();

WebApplication? app = builder.Build();

app.AddConfig();

app.Run();
