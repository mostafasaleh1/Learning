using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaSaleh
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, c;
            Console.WriteLine("Please enter the numerator: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the denomenator: ");
            y = double.Parse(Console.ReadLine());
            c = x / y;
            Console.WriteLine(x + "/" + y + "=" + c);
            Console.Read();
        }
    }
}
