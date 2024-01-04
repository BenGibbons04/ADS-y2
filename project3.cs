using System;
using System.Linq;


namespace project3
{
    static void bubbleSort(int[] arr, int n)
    {
        int i, j, temp;
        bool swapped;
        for (i = 0; i < n - 1; i++) {
            swapped = false;
            for (j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                     
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (swapped == false)
                break;
        }
    }
 
    static void printArray(int[] arr, int size)
    {
        int i;
        for (i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
 
    public static void Main()
    {

        int Min = 0;
        int Max = 20;
        int[] arr = new int[500]; 

        Random randNum = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randNum.Next(Min, Max);
        }
        int n = arr.Length;
        bubbleSort(arr, n);
        Console.WriteLine("Sorted array:");
        printArray(arr, n);
    }
}
