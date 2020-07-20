using System;
using System.IO;
using System.Text.Json;

namespace MyAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //new BinarySearchTest().Test1(args);
            //new LinkedListTest().Test1();
            int[] ints = new int[] { 1, 5, 3, 9, 11, 7 };
            QuickSort.Sort(ints, 0, ints.Length - 1);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            Console.Read();
        }
    }
}