using SportClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Factories
{
    internal class IndividualTrainingMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public IndividualTrainingMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            IndividualTrainingMembership membership = new(_price)
            {
                Description = _description
            };
            return membership;
        }
    }
}
