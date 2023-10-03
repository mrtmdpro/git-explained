using System.Collections;

namespace DemoApp
{
    internal class Program
    {
    class GFG
        {
            static void swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            static int partition(int[] arr, int low, int high)
            {
                int pivot = arr[high];

                int i = (low - 1);

                for (int j = low; j <= high - 1; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        swap(arr, i, j);
                    }
                }
                swap(arr, i + 1, high);
                return (i + 1);
            }

            static void quickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {

                    int pi = partition(arr, low, high);

                    quickSort(arr, low, pi - 1);
                    quickSort(arr, pi + 1, high);
                }
            }


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
                quickSort(arr, 0, arr.Length-1);
                Console.WriteLine("Sorted array");
                printArray(arr);
            }

        }
    }
}