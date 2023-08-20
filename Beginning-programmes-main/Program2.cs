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


            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Your total = " + Total);
            Console.WriteLine("Your percentage = " + Percentage);



            if (Percentage >= 85 && Percentage <= 100)
            {
                Console.WriteLine("Grade : Excelent");
            }
            else if (Percentage >= 75 && Percentage < 85)
            { Console.WriteLine("Grade : Very Good"); }
            else if (Percentage >= 65 && Percentage < 75)
            { Console.WriteLine("Grade : Good"); }
            else if (Percentage >= 50 && Percentage < 65)
            { Console.WriteLine("Grade : Pass"); }
            else if (Percentage >= 30 && Percentage < 50)
            { Console.WriteLine("Grade : Bad"); }
            else if (Percentage >= 0 && Percentage < 30)
            { Console.WriteLine("Grade : Very bad"); }
            else
            {
                Console.WriteLine("No grade because it's invalid");
            }




            Console.Read();
        }
    }
}
