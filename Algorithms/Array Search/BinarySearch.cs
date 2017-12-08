namespace ArraySearch
{
    using System;
    using System.Collections.Generic;


    class ArraySearchAlgorithms
    {
        #region Tests
        static void Main(string[] args)
        {

            //Tests
            int[] t0 = { 5, 7, 9, 11, 12 };
            int[] t1 = { 1, 2, 3, 4, 5};
            int[] t2 = { 0, 0, 1, 3, 4, 6, 15, 27, 42 };


            Console.WriteLine("---------------------------");
            Console.WriteLine("Testing BinarySearchRecursive and BinarySearchIterative");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Search in");
            ArrayPrint(t0);
            Console.WriteLine("For element: 11");
            Console.WriteLine("---------------------------");
            Console.WriteLine("The element is in index: {0}", BinarySearchRecursive(t0, 0 , t0.Length - 1, 11));
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Search in");
            ArrayPrint(t1);
            Console.WriteLine("For element: 5");
            Console.WriteLine("---------------------------");
            Console.WriteLine("The element is in index: {0}", BinarySearchIterative(t1, 5));

            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Search in");
            ArrayPrint(t2);
            Console.WriteLine("For element: 0");
            Console.WriteLine("---------------------------");
            Console.WriteLine("The element is in index: {0}", BinarySearchRecursive(t2, 0, t2.Length - 1, 0));

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
         * The function takes an array of integers,
         * the arrays' Left and RIght Bounds (to start with),
         * and an integer to search for as
         * arguments and returns the index of the
         * element in the array. If not found, the 
         * function returns -1.
         * The functions uses the recursive
         * Binary Search algorithm
         * 
         * 
         * Time complexity: O(log N)
         * Space Complexity: O(log N) (Keep in mind the use of stack!!)
         */
        private static int BinarySearchRecursive(int[] A, int LeftBound, int RightBound, int x)
        {
            if (RightBound < LeftBound)
                return -1;

            int middle = LeftBound + (RightBound - LeftBound) / 2;

            if (A[middle] == x)
                return middle;

            if (A[middle] > x)
                return ( BinarySearchRecursive(A, LeftBound, middle - 1, x) );

            // this is the case where (A[middle] < x)
            return ( BinarySearchRecursive(A, middle + 1, RightBound, x) );


        }

        /*
         * The function takes an array of integers
         * and an integer to search for as
         * arguments and returns the index of the
         * element in the array. If not found, the 
         * function returns -1.
         * The functions uses the iterative
         * Binary Search algorithm
         * 
         * 
         * Time complexity: O(log N)
         * Space Complexity: O(1)
         */
        private static int BinarySearchIterative(int[] A, int x)
        {
            int LeftBound = 0;
            int RightBound = A.Length - 1;

            while (LeftBound <= RightBound)
            {
                int middle = LeftBound + (RightBound - LeftBound) / 2;

                if (A[middle] == x)
                    return middle;

                if (A[middle] < x)
                    LeftBound = middle + 1;

                if (A[middle] > x)
                    RightBound = middle - 1;
            }
            //Case: not found
            return -1;
                


        }
        #endregion Algorithm
    }
}
