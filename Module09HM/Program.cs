using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09HM
{
    public class Program
    {
        static void Main()
        {
            Manager manager = new Manager("iman", 190000, 10000);
            double annualSalary = manager.CalculateAnnualSalary();

            Console.WriteLine($"{manager.Name} годовой оклад: ${annualSalary}");
            Console.ReadKey();
        }
    }
}
