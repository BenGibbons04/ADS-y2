using System;
 
class project3 {
 
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
 
        for (int j = low; j <= high - 1; j++) {
 
            if (arr[j] < pivot) {
 
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, high);
        return (i + 1);
    }
 
    static void quickSort(int[] arr, int low, int high)
    {
        if (low < high) {

            int pi = partition(arr, low, high);
 
    
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
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
        int N = arr.Length;
 
        quickSort(arr, 0, N - 1);
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < N; i++)
            Console.Write(arr[i] + " ");
    }
}