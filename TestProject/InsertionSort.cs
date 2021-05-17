using System;

namespace TestProject
{
    public static class InsertionSort<T> where T : IComparable
    {
        public static void InsSort(T[] elements)
        {
            for (var i = 1; i < elements.Length; ++i)
            {
                T t = elements[i];
                var j = i;
                while (j > 0 && t.CompareTo(elements[j - 1]) < 0)
                {
                    elements[j] = elements[j - 1];
                    j--;
                }
                elements[j] = t;

            }
        }
    }
}
