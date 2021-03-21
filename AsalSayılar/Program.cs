using System;
using System.Transactions;

namespace AsalSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notPrime = false;
            Console.WriteLine("Enter your target");
            int target = Int32.Parse(Console.ReadLine());
            int j;
            for (int i = 2; i < target; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                    
                }

                if (notPrime == false)
                {
                    Console.WriteLine(j);
                }
                else
                    notPrime = false;
            }

        }

        
    }
}
