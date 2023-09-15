using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub.Domain
{
    internal interface IMembership
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
