using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTServerDemo.Entity
{
    public class ClientInfo
    {
        public string Id { get; set; }

        public string IpAddress { get; set; }

        public string Port { get; set; }

        public string ConnectTime { get; set; }

    }
}
