using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[50];
        Random rand = new Random();
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 101); // 0-100 arası değerler
        }

        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }

        Console.WriteLine($"Çift sayıların toplamı: {sum}");
    }
}