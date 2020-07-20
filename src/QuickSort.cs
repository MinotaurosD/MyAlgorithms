using System;

/// <summary>
/// 快速排序
/// </summary>
public class QuickSort
{
    public static void Sort(int[] array, int low, int high)
    {
        if (high <= low)
        {
            return;
        }
        int value = array[low];
        int result = Deparation(array, low, high, value);
        Sort(array, low, result - 1);
        Sort(array, result + 1, high);
    }

    private static int Deparation(int[] array, int low, int high, int value)
    {
        int slow = low + 1;
        int quick = high;
        if (slow == quick)
        {
            return slow + 1;
        }
        for (; slow < quick;)
        {
            if (array[slow] <= value)
            {
                slow++;
            }
            else if (array[quick] > value)
            {
                quick--;
            }
            else
            {
                int temp1 = array[slow];
                array[slow] = array[quick];
                array[quick] = temp1;
            }
        }

        if (slow != low + 1)
        {
            int temp = array[low];
            array[low] = array[slow - 1];
            array[slow - 1] = temp;
        }

        return slow - 1;
    }
}