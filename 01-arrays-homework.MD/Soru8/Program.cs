using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 101);
        }

        Console.WriteLine("Bir sayı girin:");
        int numberToAdd = Convert.ToInt32(Console.ReadLine());

        Array.Sort(arr);
        if (Array.IndexOf(arr, numberToAdd) == -1)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = numberToAdd;
            Array.Sort(arr);
        }

        Console.WriteLine("Yeni Dizi:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}
