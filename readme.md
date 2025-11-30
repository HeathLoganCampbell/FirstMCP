# First MCP

## Learnings
* Seems like Anti gravity doesn't like local MCP Servers, I assume it needs to be deployed
* C# is easier to get running compared to javascript. 
* ChatGPT doesn't have MCP support, even the ChatGPT desktop mode
* VS Code has the easiest MCP support
* Tool = endpoint
* Make sure your MCP Server is running, and the MCP Server in mcp.json is running
* MCP inspector made life a lot easier https://github.com/modelcontextprotocol/inspector
* LLMs suck at making MCP Servers, ironically. You can fix this by giving it the docs

## I Think
Overall, I think it's really critical we can make and run these models locally for the next 1 - 3 years because we could leverage some unreal ideas but it was a bit more difficult than I thought to set up a mcp server. 

ideas 
* make a MCP for WinForms application so reproducing bugs, features & tests becomes a lot easier, making it easier to onboard new people.

## Set Up
* MCP Client = vs code / copilot
* MCP Server = locally hosted C# app with http

![alt text](image.png)

![alt text](image-1.png)


```
{
	"servers": {
	
		"my-mcp-server-58fcc28f": {
			"url": "http://localhost:3001",
			"type": "http"
		}
	},
	"inputs": []
}
```
