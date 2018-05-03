using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 插入排序(O(n^2))
/// 时间复杂度越高,执行效率越低
/// </summary>
public class InsertSort : MonoBehaviour
{

    private void Start()
    {
        int[] arr = new int[] { 1, 5, 3, 10, 8, 9, 4, 2, 1, 5, 6 };
        AscendingSort(arr);
        foreach (var item in arr)
        {
            print(item);
        }
    }

    /// <summary>
    /// 升序
    /// </summary>
    /// <param name="arr"></param>
    private void AscendingSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++) // 默认第一个数有序,所以i从1开始
        {
            int tempArr = arr[i];
            int index = i - 1;
            while (index >=0 && tempArr > arr[index]) //  tempArr > arr[index]  大于是从大到小(降序) 
            {
                arr[index + 1] = arr[index];
                index--;
            }
            arr[index + 1] = tempArr;
        }
    }

    /// <summary>
    /// 降序
    /// </summary>
    /// <param name="arr"></param>
    private void DescendingSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++) // 默认第一个数有序,所以i从1开始
        {
            int tempArr = arr[i];
            int index = i - 1;
            while (index >= 0 && tempArr < arr[index]) //  tempArr > arr[index]   小于是从小到大(升序)
            {
                arr[index + 1] = arr[index];
                index--;
            }
            arr[index + 1] = tempArr;
        }
    }



}
