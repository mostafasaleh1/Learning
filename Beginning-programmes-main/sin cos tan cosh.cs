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
            double x, y, a, b, c, d;

            Console.WriteLine("This programme finds the value of ( sin , cos , tan , sinh , cosh , tanh ) of an angle");
            Console.WriteLine("Please enter an angle to find the value of its sin");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("the value of sin" + x + " = " + Math.Sin(x));
            //0000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            Console.WriteLine("Please enter an angle to find the value of its cos");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("the value of cos" + y + " = " + Math.Cos(y));
            //0000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            Console.WriteLine("Please enter an angle to find the value of its tan");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("the value of tan" + a + " = " + Math.Tan(a));
            //0000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            Console.WriteLine("Please enter an angle to find the value of its sinh");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("the value of sinh" + b + " = " + Math.Sinh(b));
            //0000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            Console.WriteLine("Please enter an angle to find the value of its cosh");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("the value of cosh" + c + " = " + Math.Cosh(c));
            //0000000000000000000000000000000000000000000000000000000000000000000000000000000000000
            Console.WriteLine("Please enter an angle to find the value of its tanh");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("the value of tanh" + d + " = " + Math.Tanh(d));
            Console.Read();
        }
    }
}
