using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 快速排序
/// </summary>
public class QuickSort : MonoBehaviour
{

    private void Start()
    {
        int[] arr = new int[] {1, 11, 5, 3, 10, 8, 9, 4, 2, 1, 5, 6 };
        QuickSort_Ascending(arr, 0, arr.Length - 1);
        foreach (var item in arr)
        {
            print(item);
        }

    }

  

    /// <summary>
    /// 快排升序
    /// </summary>
    private void QuickSort_Ascending(int[] arr, int startIndex, int endIndex)
    {
        if (startIndex >= endIndex)
            return;

        int leftIndex = startIndex;
        int rightIndex = endIndex;
        int pivotArr = arr[leftIndex]; // 基准数

        while (leftIndex < rightIndex)
        {
            // 右边找比基准数大的
            while (leftIndex < rightIndex && arr[rightIndex] >= pivotArr)
            {
                rightIndex--;
            }
            // 左边找比基准数小的
            while (leftIndex < rightIndex && arr[leftIndex] <= pivotArr)
            {
                leftIndex++;
            }

            if (leftIndex < rightIndex)
            {
                int temp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = temp;
            }
        }

        // 当leftIndex = rightIndex 时 跳出循环,执行下面
        // 此时左边都比pivotArr要小 , 右边都比pivotArr 要大 ;
        // 把基准数归位 ;
        arr[startIndex] = arr[leftIndex];
        arr[leftIndex] = pivotArr;
        // 递归
        QuickSort_Ascending(arr, startIndex, leftIndex - 1);
        QuickSort_Ascending(arr, leftIndex + 1, endIndex);

    }


    /// <summary>
    /// 快排降序
    /// </summary>
    private void QuickSort_Descending(int[] arr, int startIndex, int endIndex)
    {
        if (startIndex >= endIndex) // 递归出口(没有出口就死循环了)
            return;

        int leftIndex = startIndex;
        int rightIndex = endIndex;
        int pivotArr = arr[leftIndex]; // 基准数

        while (leftIndex < rightIndex)
        {
            // 右边找比基准数小的
            while (leftIndex < rightIndex && arr[rightIndex] <= pivotArr)
            {
                rightIndex--;
            }
            // 左边找比基准数大的
            while (leftIndex < rightIndex && arr[leftIndex] >= pivotArr)
            {
                leftIndex++;
            }

            if (leftIndex < rightIndex)
            {
                int temp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = temp;
            }
        }

        // 当leftIndex = rightIndex 时 跳出循环,执行下面
        // 此时左边都比pivotArr要大 , 右边都比pivotArr 要小 ;
        // 把基准数归位 ;
        arr[startIndex] = arr[leftIndex];
        arr[leftIndex] = pivotArr;
        // 递归
        QuickSort_Ascending(arr, startIndex, leftIndex - 1);
        QuickSort_Ascending(arr, leftIndex + 1, endIndex);

    }


}
