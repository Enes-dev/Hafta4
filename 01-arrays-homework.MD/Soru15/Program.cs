using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Random rand = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Orijinal Dizi:");
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }

        int[] oddNumbers = Array.FindAll(arr, n => n % 2 != 0);
        Array.Sort(oddNumbers);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                arr[i] = oddNumbers[0];
                oddNumbers = oddNumbers[1..]; // En küçük tek sayıyı çıkar
            }
        }

        Console.WriteLine("\nSıralanmış Tek Sayılar:");
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
    }
}