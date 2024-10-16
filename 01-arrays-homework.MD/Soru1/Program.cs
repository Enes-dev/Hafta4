using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("10 tam sayı girin:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Kendinden önceki ve sonraki elemanları büyük olan sayılar:");
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}