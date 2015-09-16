using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[100];

            for (int i = 0; i < 100; ++i)
            {
                array[i] = random.Next(0, 500);
            }

            QuickSorter.Sort(ref array, 0, 99);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
