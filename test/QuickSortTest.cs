using System;

public class QuickSortTest
{
    public void Test1()
    {
        int[] ints = new int[] { 1, 5, 3, 9, 11, 7, -1, 0, 8, 2, 6, 4, 10 };
        QuickSort.Sort(ints);
        for (int i = 0; i < ints.Length; i++)
        {
            Console.WriteLine(ints[i]);
        }
        Console.ReadKey();
    }
}