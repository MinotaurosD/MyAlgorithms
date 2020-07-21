using System;

/// <summary>
/// 快速排序
/// </summary>
public class QuickSort
{
    /// <summary>
    /// 快速排序
    /// </summary>
    /// <param name="array"></param>
    public static void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    private static void Sort(int[] array, int low, int high)
    {
        if (high <= low)
        {
            return;
        }
        int result = Deparation(array, low, high);
        Sort(array, low, result - 1);
        Sort(array, result + 1, high);
    }

    /// <summary>
    /// 分割数组
    /// </summary>
    /// <param name="array"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    private static int Deparation(int[] array, int low, int high)
    {
        int value = array[low];
        int slow = low + 1;
        int quick = high;
        while (slow <= quick)
        {
            while (array[slow] < value)
            {
                slow++;
                if (slow >= high)
                {
                    break;
                }
            }
            while (array[quick] > value)
            {
                quick--;
                if (quick <= low)
                {
                    break;
                }
            }
            if (slow >= quick)
            {
                break;
            }
            Swap(array, slow, quick);
        }

        Swap(array, low, quick);
        return quick;
    }

    /// <summary>
    /// 交焕数组中的两个元素
    /// </summary>
    /// <param name="array"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    private static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}