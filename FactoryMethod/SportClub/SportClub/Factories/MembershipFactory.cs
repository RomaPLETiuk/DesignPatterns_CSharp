using SportClub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();

    }
}
