using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type First Value :");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Math operation :");
            string operation = Console.ReadLine();
            Console.WriteLine("Type Second Value :");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            Addition add = new Addition();
            add.operation(firstValue, operation, secondValue);
        }
    }
}
