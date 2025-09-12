// HW1b Grade

// Your Name: Jackson Koch
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string first = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            string id = Console.ReadLine();
            Console.WriteLine("What is your homework grade?");
            string hwAsString = Console.ReadLine();
            Console.WriteLine("What is your participation grade?");
            string participationAsString = Console.ReadLine();
            Console.WriteLine("What is your Exam 1 grade?");
            string exam1AsString = Console.ReadLine();
            Console.WriteLine("What is your Exam 2 grade?");
            string exam2AsString = Console.ReadLine();
            Console.WriteLine("What is your Exam 3 grade?");
            string exam3AsString = Console.ReadLine();
            double hw = Convert.ToDouble(hwAsString);
            double participation = Convert.ToDouble(participationAsString);
            double exam1 = Convert.ToDouble(exam1AsString);
            double exam2 = Convert.ToDouble(exam2AsString);
            double exam3 = Convert.ToDouble(exam3AsString);
            double final = ((hw*0.20) + (participation*0.15) + (exam1*0.15) + (exam2*0.25) + (exam3*0.25))/100;
            Console.WriteLine($"{first} {last} ({id}), your final grade is: {final:P}");
        }
    }
}
