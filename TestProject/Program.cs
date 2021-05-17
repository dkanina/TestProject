using System;

namespace TestProject
{
    internal class Program
    {
        static int N = 10;
        public static void ListWrite(LinkList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        public static void LinkListTest() //test
        {
            LinkList<int> myList = new LinkList<int>();
            Console.WriteLine("LinkList test:");
            for (int i = 0; i < N; i++)
                myList.Add(i);
            Console.Write("List: "); ListWrite(myList);

            myList.Reverse();
            Console.Write("Reverse(): "); ListWrite(myList);

            myList.Reverse();
            Console.Write("Reverse(): "); ListWrite(myList);

            int pos = 6, data = 21;
            myList.Insert(pos, data);
            Console.Write("Insert(pos(" + pos + "), data(" + data + ")): "); ListWrite(myList);

            pos = 4;
            myList.Remove(pos);
            Console.Write("Remove(pos(" + pos + ")): "); ListWrite(myList);

            myList.RemoveFirst();
            Console.Write("RemoveFirst(): "); ListWrite(myList);

            myList.RemoveLast();
            Console.Write("RemoveLast(): "); ListWrite(myList);

            data = 277;
            myList.AddFirst(data);
            Console.Write("AddFirst(" + data + "): "); ListWrite(myList);

        }

        public static void BinTreeTest()
        {
            BinaryTree<int> myTree = new BinaryTree<int>();
            for (var i = 0; i < N; i++)
            {
                myTree.Add(i);
            }
            myTree.Remove(5);
            myTree.Add(-21); 
            TreeNode<int> node;
            Console.WriteLine("BinTree test:");
            if ((node = myTree.FindNode(5)) != null) // test
            {
                Console.WriteLine("FindNode(5)");
                Console.WriteLine("node.Data " + node.Data);
            }
            else
                Console.WriteLine("Node 5 is not found");

            if ((node = myTree.FindNode(-21)) != null)
            {
                Console.WriteLine("FindNode(-21)");
                Console.WriteLine("node.Data " + node.Data);
            }
            else Console.WriteLine("Node -21 is not found");

            if ((node = myTree.FindNode(9)) != null)
            {
                Console.WriteLine("FindNode(9)");
                Console.WriteLine("node.Data " + node.Data);
            }
            else Console.WriteLine("Node 9 is not found");

        }

        public static void InsertionSortTest()
        {
            string[] strings = { "bbb", "zzz", "aaa", "ddddd", "ccccc", "lllllll" };
            InsertionSort<string>.InsSort(strings);
            Console.WriteLine("InsertionSort test:");
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            int[] numbers = new[] { 6, 5, 3, 1, 8, 7, 2, 4, -1, -2, 10 };
            InsertionSort<int>.InsSort(numbers);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        { 
            LinkListTest();
            BinTreeTest();
            InsertionSortTest();
            //
        }
    }
}
