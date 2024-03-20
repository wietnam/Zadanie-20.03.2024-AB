using System;

class QuickSort
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);

        Console.WriteLine("Przed sortowaniem:");
        PrintArray(array);

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("\nPo sortowaniu:");
        PrintArray(array);
    }

    static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSortAlgorithm(arr, low, pivotIndex - 1);
            QuickSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        
        Swap(arr, i + 1, high);

        return i + 1;
    }

    
    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(100); 
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
