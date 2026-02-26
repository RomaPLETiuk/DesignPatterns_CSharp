using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Builder;
{
    public class Employee
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}

