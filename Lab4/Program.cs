using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");
            bool run;
            run = true;

            while (run == true)
            {
                Console.Write("Enter an integer that's greater than 0 but less than 10:");
                int n = Convert.ToInt32(Console.ReadLine());
                long r = Factorial(n);
                Console.WriteLine(n.ToString() + "! = " + r.ToString());
                run = Continue();
            }
           
        }
    
       /* Another way to do it
            static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }*/

        static long Factorial(int n)
        {
            if (n <= 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine().ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }

    }
}
