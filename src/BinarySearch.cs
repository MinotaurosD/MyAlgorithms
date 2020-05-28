using System;

/// <summary>
/// 二分查找
/// </summary>
public class BinarySearch
{
    /// <summary>
    /// 二分查找
    /// </summary>
    /// <param name="array">升序数组</param>
    /// <param name="value">目标值</param>
    /// <returns>-1为未找到，>0为目标值所在数组的索引</returns>
    public static int IndexOf(int[] array, int value)
    {
        //低位索引
        int low = 0;
        //高位索引
        int high = array.Length - 1;
        //如果value小于array[0]或者大于array[high]直接返回-1
        if (value < array[0] || (high >= 0 && value > array[high]))
        {
            return -1;
        }
        //当低位索引小于等于高位索引时，说明循环还未结束，继续循环；否则循环结束，未能查找到目标值
        //当数组本身长度为0时，不进循环直接返回-1
        //当数组本身长度为1时，首次进入循环middle为0，如果array[0]不等于value，则第二次循环条件不成立跳出循环
        while (low <= high)
        {
            //获取中位索引
            int middle = low + (high - low) / 2;
            //如果目标值小于中位索引的值，那么目标值一定在左侧数组中，于是将高位索引修改为当前的中位索引-1
            if (value < array[middle])
            {
                high = middle - 1;
            }
            //如果目标值高于中位索引的值，那么目标值一定在右侧数组中，于是将低位索引修改为当前中位索引+1
            else if (value > array[middle])
            {
                low = middle + 1;
            }
            //找到目标值直接返回索引
            else
            {
                return middle;
            }
        }
        return -1;
    }
}