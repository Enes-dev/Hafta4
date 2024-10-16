using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 21); // 1-20 arası değerler
        }

        Console.WriteLine("Tekrar eden elemanlar:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine($"Eleman: {arr[i]}, Pozisyonlar: {i}, {j}");
                }
            }
        }
    }
}