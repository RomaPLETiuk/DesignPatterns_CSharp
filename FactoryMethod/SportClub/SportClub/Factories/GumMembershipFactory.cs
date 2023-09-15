using SportClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Factories
{
    internal class GumMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GumMembershipFactory(decimal price, string description) 
        { 
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GumMembership membership = new(_price)
            {
                Description = _description
            };
            return membership;
        }
    }
}
