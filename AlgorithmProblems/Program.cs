using System;
namespace BubbleSort
{
    class MySort
    {
        static void Main(string[] args)
        {
            int[] array = { 5,2,6,9,1 };
            int temp;

            Console.WriteLine("The original elements are:");
            foreach (int a in array)
            Console.Write(a + " ");

            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.WriteLine("The bubble sorted elements are:");
            foreach (int p in array)
            Console.Write(p + " ");
           
        }
    }
}