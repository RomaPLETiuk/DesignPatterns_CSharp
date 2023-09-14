using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Soldier
    {
        private readonly string _name;
        private IPistol? _pistol;

        public Soldier (string name)
        {
            _name = name;
        }

        public void SetPistol(IPistol pistol)
        {
            _pistol = pistol;
        }

        public void Attack()
        {
            Console.WriteLine(">>>");
            if (_pistol is null)
            {
                Console.WriteLine($"{_name} can't attack. Set a pistol.");
                return;

            }

            Console.WriteLine($"{_name} stands and removed the fuse");
            Console.Write($"{_name} ");

            _pistol.Shoot();
            Console.WriteLine($"{_name} stands and and put the fuse");

        }


    }
}
