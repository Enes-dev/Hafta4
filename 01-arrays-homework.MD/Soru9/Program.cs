using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-10, 11); // -10 ile 10 arası
        }

        Console.WriteLine("Orijinal Dizi:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                arr[i] = -arr[i]; // Pozitif sayıları ters çeviriyoruz.
            }
        }

        Console.WriteLine("\nTers Çevrilmiş Dizi:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}