using System;
namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3,6,9,2,4,6,8,0,1,5 };
            int n = 10, i;
            MergeSort merge = new MergeSort();
           
            Console.WriteLine("Initial array is:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            merge.mergeSort(arr, 0, n - 1);

            Console.WriteLine("\nSorted Array is:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}