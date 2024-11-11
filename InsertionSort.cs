using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class InsertionSort
    {
        static void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k] + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 6, 8, 10, 9, 5 };
            insertionSort(arr);
        }
    }
}
