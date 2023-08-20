using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double WrittenExamMarks, TermWorkMarks, MaxTermWorkMarks, MaxWrittenExamMarks;
            string Name;
            Console.WriteLine("Please enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the Written Exam Marks");
            WrittenExamMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Term Work Marks");
            TermWorkMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Max Written Exam Marks");
            MaxTermWorkMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Max Term Work Marks");
            
            
            MaxWrittenExamMarks = double.Parse(Console.ReadLine());

            double Total, MaxTotal, Percentage;
            Total = WrittenExamMarks + TermWorkMarks;
            MaxTotal = MaxTermWorkMarks + MaxWrittenExamMarks;
            Percentage = Total / (MaxTotal) * 100;
            if (Percentage >= 50.0)
            {
                Console.WriteLine("*****Congratulations*****");
            }
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Your total = " + Total);
            Console.WriteLine("Your percentage = " + Percentage);
            Console.Read();
        }
    }
}
