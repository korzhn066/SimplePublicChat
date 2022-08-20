using Chat.Server.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Server.Hubs;

public class MessageHub : Hub
{
    public async Task MessageReceived(Message message)  
    {  
        await Clients.All.SendAsync("MessageReceived",message);  
    }  
}