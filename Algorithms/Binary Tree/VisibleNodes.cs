namespace BinaryTrees
{
    using System;
    using System.Collections.Generic;

    //
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
             *        3    10
             *       / \     \
             *      20  21    1
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
             *        2    3
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

            Console.WriteLine("-------------------------");
            Console.WriteLine("Testing VisibleNodesCount");
            Console.WriteLine(VisibleNodesCount(t0));
            Console.WriteLine(VisibleNodesCount(t1));
            Console.WriteLine(VisibleNodesCount(t2));

            Console.WriteLine("-------------------------\n");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Testing TreeHeight");
            Console.WriteLine(TreeHeight(t0));
            Console.WriteLine(TreeHeight(t1));
            Console.WriteLine(TreeHeight(t2));
            Console.WriteLine("-------------------------");
            Console.ReadKey(true);

        }
        #endregion Tests


        #region Solution
        /*
         * Given the root of a Binary Tree consisting of 
         * N nodes returns the number of visible nodes.
         * 
         * In case of an empty Binary Tree (root == null)
         * return -1
         * 
         * Time complexity: O(N)
         * Space complexity: O(N)
         */
        private static int VisibleNodesCount(Tree T)
        {
            if (T == null)
            {
                return -1;
            }

            var counter = 0;

            Stack<Tuple<int, Tree>> stack = new Stack<Tuple<int, Tree>>();
            stack.Push(new Tuple<int, Tree>(T.x, T));

            while (stack.Count > 0)
            {
                var tempNode = stack.Pop();

                //This is a visible node
                if (tempNode.Item1 <= tempNode.Item2.x)
                {
                    ++counter;
                }

                //Keep the max so far value
                var max = Math.Max(tempNode.Item1, tempNode.Item2.x);

                //Test children

                //if left SubT exists add to stack
                if (tempNode.Item2.l != null)
                {
                    stack.Push(new Tuple<int, Tree>(max, tempNode.Item2.l));
                }

                //if right SubT exists add to stack
                if (tempNode.Item2.r != null)
                {
                    stack.Push(new Tuple<int, Tree>(max, tempNode.Item2.r));
                }
            }

            return counter;
        }

        /*
         * Given the root of a Binary Tree consisting of 
         * N nodes returns the height of the tree.
         * 
         * In case of an empty Binary Tree (root == null)
         * return -1
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
        #endregion Solution
    }
}
