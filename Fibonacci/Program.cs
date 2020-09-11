using System;

namespace Fibonacci
{

    class Program
    {

        public static void FibonacciSequence(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void FibonacciNumber(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0  
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            Console.WriteLine(Fib[number]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to get all number or onlt n-th number?");
            Console.WriteLine("1. All numbers\n2. N-th nuber\nAnswer: ");
            int answ = 0;
            try
            {
                answ = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something go wrong. Try again later. Error: " + ex.Message);
            }
            if(answ == 1)
            {
                Console.WriteLine("Length? ");
                int len = int.Parse(Console.ReadLine());
                FibonacciSequence(len);
            }
            if (answ == 2)
            {
                Console.WriteLine("Length? ");
                int n = int.Parse(Console.ReadLine());
                FibonacciNumber(n);
            }
        }
    }
}
