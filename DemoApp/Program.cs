using System.Collections;

namespace DemoApp
{
    internal class Program
    {
    class GFG
        {
            static void bubbleSort(int[] arr)
            {
                int count = 0;
                bool flag = true;
                for (int i = 1; (i <= (arr.Length - 1)) && flag; i++)
                {
                    flag = false;
                    for (int j = 0; j < (arr.Length - 1); j++)
                    {
                        count = count + 1;
                        if (arr[j + 1] > arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            flag = true;
                        }
                    }
                }
            }

            static void printArray(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

            public static void Main()
            {
                int[] arr = { 64, 25, 12, 22, 11 };
                bubbleSort(arr);
                Console.WriteLine("Sorted array");
                printArray(arr);
            }

        }
    }
}