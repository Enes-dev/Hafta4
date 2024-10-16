using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-100, 101);
        }

        int max = arr[0];
        int min = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine($"En Büyük: {max}, En Küçük: {min}");
    }
}