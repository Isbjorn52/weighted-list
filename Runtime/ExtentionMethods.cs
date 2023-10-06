using System.Collections.Generic;
using UnityEngine;

namespace WeightedList
{
    public static class ExtentionMethods
    {
        public static T GetRandomElement<T>(this T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }

        public static T GetRandomElement<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}