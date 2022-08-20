using Chat.Server.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Server.Controllers;

[Route("api/message")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IHubContext<MessageHub> _hubContext;
    
    public MessageController(IHubContext<MessageHub> hubContext)
    {
        _hubContext = hubContext;
        
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Message = "Request Completed" });
    }
}