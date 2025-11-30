using ModelContextProtocol.Server;
using System.ComponentModel;
using FirstMCP;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithTools<EchoTool>();
var app = builder.Build();

app.MapMcp();

app.Run("http://localhost:3001");