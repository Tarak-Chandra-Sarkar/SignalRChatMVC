using Microsoft.AspNet.SignalR;

namespace SignalRChatMVC
{
    public class ChatHub : Hub
    {
        //chat.server.send($('#displayname').val(), $('#message').val());
        //means you below method shoud be same as script chat.server.send() method
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.

            //chat.client.addNewMessageToPage = function(name, message) should mathc below method
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}