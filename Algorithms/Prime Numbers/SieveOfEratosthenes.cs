namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;


    class PrimeNumbersAlgorithms
    {
        #region Tests
        static void Main(string[] args)
        {

            //Tests
            int t0 = 10;
            int t1 = 5;
            int t2 = 50;
            int t3 = 500;
            int t4 = 17;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Testing SieveOfEratosthenes");
            Console.WriteLine("Num of Primes <= {0} is {1}", t0, SieveOfEratosthenes(t0));
            Console.WriteLine("Num of Primes <= {0} is {1}", t1, SieveOfEratosthenes(t1));
            Console.WriteLine("Num of Primes <= {0} is {1}", t2, SieveOfEratosthenes(t2));
            Console.WriteLine("Num of Primes <= {0} is {1}", t3, SieveOfEratosthenes(t3));
            Console.WriteLine("Num of Primes <= {0} is {1}", t4, SieveOfEratosthenes(t4));
            Console.WriteLine("---------------------------");
            Console.ReadKey(true);

        }
        #endregion Tests


        #region Algorithm
        /*
         * Returns the number of primes smaller or equal to 
         * n (which is given as a parameter) using the Sieve
         * of Eratosthenes. 
         * 
         * The algorithm weeds out the non primes by finding
         * the multiples of primes
         * 
         * Time complexity: O(N * log (log N))
         * Space Complexity: O(N)
         */
        private static int SieveOfEratosthenes(int n)
        {
            if (n < 2)
                return -1;

            bool[] IsPrime = new bool[n+1];

            for (int i = 2; i <= n; i++)
            {
                IsPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (IsPrime[p] == true)
                {
                    // Mark all multiples
                    for (int i = p * 2; i <= n; i += p)
                        IsPrime[i] = false;
                }
            }
            
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime[i])
                    counter++;
            }

            return counter;
        }
        #endregion Algorithm
    }
}
