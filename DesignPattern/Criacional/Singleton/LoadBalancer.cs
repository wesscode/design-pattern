using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new();

        private readonly List<Server> _servers;
        private readonly Random _random = new();
        public LoadBalancer()
        {
            _servers = new List<Server>()
            {
                new Server { Id = Guid.NewGuid(),IP = "127.0.0.1", Nome ="Server I"},
                new Server { Id = Guid.NewGuid(), IP = "127.0.0.2", Nome = "Server II"},
                new Server { Id = Guid.NewGuid(), IP = "127.0.0.3", Nome = "Server III"},
                new Server { Id = Guid.NewGuid(), IP = "127.0.0.3", Nome = "Server IV"},
                new Server { Id = Guid.NewGuid(), IP = "127.0.0.3", Nome = "Server V"},
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
