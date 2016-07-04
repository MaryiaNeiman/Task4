using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintMenu();
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "1":
                    Console.WriteLine(Mathematics.Fibonacci(EnterNumber()));
                    break;
                case "2":
                    Console.WriteLine( Mathematics.FactTree(EnterNumber()));;
                    break;
                case "exit":
                    Environment.Exit(2);
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }
            Console.ReadLine();
            
        }
        static void PrintMenu()
        {
            Console.WriteLine("Enter '1' to calculate the Fibonacci method");
            Console.WriteLine("Enter '2' to calculation of the factorial");
            Console.WriteLine("Enter 'exit' to exit");
        }
        static int EnterNumber()
        {
            int num;
            string StringNum = Console.ReadLine();
            while (!int.TryParse(StringNum, out num))
            {
                Console.WriteLine("Enter number:");
                StringNum = Console.ReadLine();
            }
            return num;
        }
    }
}
