namespace ArraySorting
{
    using System;
    using System.Collections.Generic;


    class ArraySortingAlgorithms
    {
        #region Tests
        static void Main(string[] args)
        {

            //Tests
            int[] t0 = { 12, 11, 7, 5, 9 };
            int[] t1 = { 5, 4, 3, 2, 1 };
            int[] t2 = { 0, 1, 0, 15 ,27, 3, 4, 42, 6};

            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Testing InsertionSort");
            Console.WriteLine("---------------------------");
            Console.WriteLine("t0 Before");
            ArrayPrint(t0);
            Console.WriteLine("---------------------------");
            Console.WriteLine("t0 After");
            InsertionSort(t0);
            ArrayPrint(t0);
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            Console.WriteLine("t1 Before");
            ArrayPrint(t1);
            Console.WriteLine("---------------------------");
            Console.WriteLine("t1 After");
            InsertionSort(t1);
            ArrayPrint(t1);
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            Console.WriteLine("t2 Before");
            ArrayPrint(t2);
            Console.WriteLine("---------------------------");
            Console.WriteLine("t2 After");
            InsertionSort(t2);
            ArrayPrint(t2);
            Console.WriteLine("---------------------------");
           
            Console.WriteLine("---------------------------");
            Console.ReadKey(true);

        }

        /*****************************************/
        /* Helper function to print an Array */
        private static void ArrayPrint (int[] A)
        {
            int n = A.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(A[i] + " ");

            Console.Write("\n");
        }
        /*****************************************/
        #endregion Tests


        #region Algorithm
        /*
         * The function take an array of integers
         * as an argument and returns the array 
         * sorted in ascending order using the 
         * Insertion Sort algorithm
         * 
         * 
         * Time complexity-> Best    : Omega(N)
         *                -> Average : Theta(N^2)
         *                -> Worst   : O(N^2)
         * Space Complexity: O(1)
         */
        private static int[] InsertionSort(int[] A)
        {
            int n = A.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = A[i]; //key is the value to insert
                int j = i - 1;  //j is the position where key will be inserted 

                /* Move elements of A[0..i-1], that are
                 * greater than key, one position ahead
                 * of their current position to make space
                 * for the key element
                 */
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = key;
            }
            return A;
        }
        #endregion Algorithm
    }
}
