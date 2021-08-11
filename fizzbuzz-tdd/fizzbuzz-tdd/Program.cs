using System;

namespace fizzbuzz_tdd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Print(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (n % 3 == 0)
            {
                return "Fizz";
            }
            else if (n % 5 == 0)
            {
                return "Buzz";
            }

            return n.ToString();

        }


    }
}

