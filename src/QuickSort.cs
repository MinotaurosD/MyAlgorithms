using System;

/// <summary>
/// 快速排序
/// </summary>
public class QuickSort
{
    /// <summary>
    /// 快速排序
    /// </summary>
    /// <param name="array">待排序数组</param>
    public static void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    /// <summary>
    /// 快速排序
    /// </summary>
    /// <param name="array">待排序数组</param>
    /// <param name="low">起始索引</param>
    /// <param name="high">结束索引</param>
    private static void Sort(int[] array, int low, int high)
    {
        //如果起始大于等于high，说明待排序元素为1，结束循环
        if (low >= high)
        {
            return;
        }
        int index = Partition(array, low, high);
        Sort(array, low, index - 1);
        Sort(array, index + 1, high);
    }

    /// <summary>
    /// 分割数组
    /// </summary>
    /// <param name="array">待排序数组</param>
    /// <param name="low">起始索引</param>
    /// <param name="high">结束索引</param>
    /// <returns></returns>
    private static int Partition(int[] array, int low, int high)
    {
        //选定最左侧元素为判断的基准元素
        int value = array[low];
        //左侧从基准元素右边元素开始
        int left = low + 1;
        //右侧从最右侧元素开始
        int right = high;
        //左索引小于等于右索引时循环
        while (left <= right)
        {
            //找到左侧第一个大于等于value的索引
            while (array[left] < value)
            {
                left++;
            }
            //找到右侧第一个小于等于value的索引
            while (array[right] > value)
            {
                right--;
            }
            //如果左索引大于等于右索引，说明循环结束
            if (left >= right)
            {
                break;
            }
            //交换找到的左侧和右侧的值
            Swap(array, left, right);
        }

        //此时right指向的元素是左数组最后一个小于等于value的索引，使其与最左侧元素交换，以保证right左侧都比value小，右侧都比value大
        Swap(array, low, right);
        //right正好为value所在的索引位置，即此时right位置的值是排序过的
        return right;
    }

    /// <summary>
    /// 交换数组中的两个元素
    /// </summary>
    /// <param name="array">数组</param>
    /// <param name="a">位置1</param>
    /// <param name="b">位置2</param>
    private static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}