using System;

namespace Test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to new Example for Prime Number");
            bool IsContinue = true;
            while (IsContinue)
            {
                int number = getNumber("Insert a number: ");
                if (verifyPrimeNumber(number))
                {
                    Console.WriteLine(String.Format("The number [{0}] is a Prime Number", number));
                }
                else
                {
                    Console.WriteLine(String.Format("The number [{0}] is NOT a Prime Number", number));
                }

                Console.WriteLine("\n \t Do you want Exit? Y/N");
                string resp = Console.ReadLine();
                if (resp.Equals("Y") || resp.Equals("y"))
                {
                    IsContinue = false;
                }
            }
            Console.WriteLine("Good Bye!");
        }

        static int getNumber(string Message)
        {
            int result = 0;
            while (true)
            { 
                try
                {
                    Console.WriteLine("\n" + Message);
                    result = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n Please, Insert a integer number ");
                }                

            }
            return result;
        }

        static bool verifyPrimeNumber(int number)// 1 y si mismo
        {
            bool result = true;
            int c;
            for (int i = 2; i < number; i++)
            {
                c = number % i;
                if(c == 0)
                {
                    result = false;
                    break;
                }
            }
            return result; 
        }
    }
}
