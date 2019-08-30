using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPattern
{
    public sealed class LoadBalancer
    {
        private static LoadBalancer _instance;
        private static readonly object SyncLock = new object();
        private readonly List<string>_servers = new List<string>();
        private readonly Random _random = new Random();

        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }

        public LoadBalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }
            return _instance;
        }
    }
}
