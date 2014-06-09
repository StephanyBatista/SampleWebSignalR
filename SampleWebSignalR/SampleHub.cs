using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SampleWebSignalR
{
    public class SampleHub : Hub
    {
        public SampleHub()
        {

        }

        public override Task OnConnected()
        {
            Clients.All.entryClient(Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected()
        {
 	        Clients.All.exitClient(Context.ConnectionId); 
            return base.OnDisconnected();
        }

        public string WellCome()
        {
            return "Bem vindo";
        }
    }
}