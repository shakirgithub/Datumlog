﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
    public class ChatHub : Hub
    {
        public void Send(string name,string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addMessageToPage(name, message);
            //Clients.All.hello();
        }
    }
}