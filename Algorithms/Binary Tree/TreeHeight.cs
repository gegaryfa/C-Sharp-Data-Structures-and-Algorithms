namespace BinaryTrees
{
    using System;
    using System.Collections.Generic;

    /*
     * Tree -> Node
     * x -> Node value
     * l -> Left Node
     * r -> Right Node
     */
    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    }

    class BinaryTreeAlgorithms
    {
        #region Tests
        static void Main(string[] args)
        {
            //empty Binary Tree
            var t0 = default(Tree);

            /* 
             *          5
             *         / \
             *        3   10
             *       / \    \
             *      20  21   1
             *               
             */
            var t1 = new Tree
            {
                x = 5,
                l = new Tree
                {
                    x = 3,
                    l = new Tree { x = 20 },
                    r = new Tree { x = 21 }
                },
                r = new Tree
                {
                    x = 10,
                    r = new Tree { x = 1 }
                }
            };

            /* 
             *          8
             *         / \
             *        2   3
             *       / \
             *      8   7
             *               
             */
            var t2 = new Tree
            {
                x = 8,
                l = new Tree
                {
                    x = 2,
                    l = new Tree { x = 8 },
                    r = new Tree { x = 7 }
                },
                r = new Tree { x = 3 }
            };

            /* 
             *          10
             *         / \
             *        2   3
             *       / \   \
             *      8   7   27
             *     / \       \
             *    1   9       2
             *   /
             *  10            
             */
            var t3 = new Tree
            {
                x = 10,
                l = new Tree
                {
                    x = 2,
                    l = new Tree
                    {
                        x = 8,
                        l = new Tree
                        {
                            x = 1,
                            l = new Tree
                            {
                                x = 10
                            },
                        },
                        r = new Tree
                        {
                            x = 9
                        }
                    },
                    r = new Tree
                    {
                        x = 7
                    }
                },
                r = new Tree
                {
                    x = 3,
                    r = new Tree
                    {
                        x = 27,
                        r = new Tree
                        {
                            x = 2
                        }
                    }
                }
            };

            Console.WriteLine("-------------------------");
            Console.WriteLine("Testing TreeHeight");
            Console.WriteLine(TreeHeight(t0));
            Console.WriteLine(TreeHeight(t1));
            Console.WriteLine(TreeHeight(t2));
            Console.WriteLine(TreeHeight(t3));
            Console.WriteLine("-------------------------");
            Console.ReadKey(true);

        }
        #endregion Tests


        #region Algorithm
        /*
         * Given the root of a Binary Tree consisting of 
         * N nodes returns the height of the tree.
         * 
         * In case of an empty Binary Tree (root == null)
         * returns -1
         * 
         * Time complexity: O(N)
         * Space complexity: O(N)
         */
        private static int TreeHeight(Tree T)
        {
            if (T == null)
            {
                return -1;
            }

            int left = 0;
            int right = 0;

            if (T.l != null)
                left = TreeHeight(T.l) + 1;

            if (T.r != null)
                right = TreeHeight(T.r) + 1;

            return Math.Max( left, right );
        }
        #endregion Algorithm
    }
}
