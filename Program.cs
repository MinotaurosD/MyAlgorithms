using System;

namespace AlgorithmsOfCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            Console.WriteLine(BinarySearch.IndexOf(array1, 5));
            Console.ReadKey();
        }
    }
}