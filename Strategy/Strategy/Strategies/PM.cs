using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class PM : IPistol
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a PM");
        }
    }
}
