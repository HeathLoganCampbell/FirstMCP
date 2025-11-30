using System.ComponentModel;
using ModelContextProtocol.Server;

namespace FirstMCP;

[McpServerToolType]
public class EchoTool
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"hello {message} The time is {DateTime.Now}";
}