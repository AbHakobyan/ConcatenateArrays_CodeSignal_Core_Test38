using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateArrays_CodeSignal_Core_Test38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = concatenateArrays(array1, array2);
            foreach (var item in array3)
            {
                Console.WriteLine(item);
            }
        }

        static int[] concatenateArrays(int[] a, int[] b)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                list.Add(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                list.Add(b[i]);
            }
            int[] array = list.ToArray();
            return array;
        }

    }
}
