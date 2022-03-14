using System;
namespace AlgorithmProblems
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 6,10,7,8,1,4,2,9,3,5 };
            int n = 10, i, j, val, flag;
            
            Console.WriteLine("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = array[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}