using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("PLease enter the number you need the square root to : ");
            x = double.Parse(Console.ReadLine());
            double SquareRoot;
            SquareRoot = Math.Sqrt(x);
            Console.WriteLine("The Square Root for " + x + " = " + SquareRoot);
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
    }
}
