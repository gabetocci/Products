using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Products.Web.Hubs
{
    public class PerfHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.newMessage(message); // js call 'newMessage'
        }
    }
}