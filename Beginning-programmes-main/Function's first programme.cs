using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsFirstProgramme
{
    class Program
    {static int min(int first, int second)
        {
            int result;
            if (first > second) result = second;
            else result = first;
            return result;
        }

        static void Main(string[] args)
        {
            int num1, num2, minimum;
            Console.WriteLine("the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("the second number");
            num2 = int.Parse(Console.ReadLine());
            minimum = min(num1, num2);
            Console.WriteLine("The minimum of the two numbers is :" + minimum);
            Console.Read();
        }
        

        }
    }

