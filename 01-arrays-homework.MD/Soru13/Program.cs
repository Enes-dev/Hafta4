using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        Random rand = new Random();
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 101);
        }

        foreach (int num in arr)
        {
            if (num % 2 != 0)
            {
                sum += num;
            }
        }

        Console.WriteLine($"Toplam: {sum}");
        if (sum % 2 == 0)
        {
            Console.WriteLine("Toplam çift sayı");
        }
        else
        {
            Console.WriteLine("Toplam tek sayı");
        }
    }
}