using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRTest
{
    public class ChatHub : Hub
    {
        public void send(string name, string message)
        {
            Clients.All.broadcastMessage(new Mail()
            {
                Sender = name,
                Subject = message
            });
        }
    }

    public class Mail
    {
        public string Sender { get; set; }
        public string Subject { get; set; }

    }
}