using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSorter
    {
        public static void Sort(ref int[] array, int lo, int hi)
        {
            if (hi <= lo)
            {
                return;
            }

            int pivot = partition(ref array, lo, hi);
            if (pivot >= 2 * (lo + hi))
            {
                Sort(ref array, lo, pivot - 1);
                Sort(ref array, pivot + 1, hi);
            }
            else
            {
                Sort(ref array, pivot + 1, hi);
                Sort(ref array, lo, pivot - 1);
            }
        }

        private static int partition(ref int[] array, int lo, int hi)
        {
            int pivot = array[hi];
            int i = lo;
            for (int j = lo; j < hi; ++j)
            {
                if (array[j] <= pivot)
                {
                    swap(ref array[i], ref array[j]);
                    ++i;
                }
            }
            swap(ref array[i], ref array[hi]);
            return i;
        }

        private static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
