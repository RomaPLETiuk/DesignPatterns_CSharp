﻿namespace Proxy
{
    internal class ProxyChief : IChief
    {

        private readonly Chief _chief;
        private IDictionary<int, string>? _statuses;

        public ProxyChief(Chief chief)
        {
            _chief = chief;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders();
        }

        public IDictionary<int, string> GetStatuses()
        {
            if (_statuses is null)
            {
                _statuses = _chief.GetStatuses();
            }

            return _statuses;
        }
    }
}
