using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class Mauzer : IPistol
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a Mauzer");
        }
    }
}
