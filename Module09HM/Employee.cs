using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09HM
{
    public class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public virtual double CalculateAnnualSalary()
        {
            return BaseSalary * 12;
        }
    }

}

