using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 101); // 0-100 arası değerler
        }

        Console.WriteLine("Bir sayı girin:");
        int searchNumber = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int position = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchNumber)
            {
                count++;
                position = i;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"Sayı {searchNumber} dizide mevcut. Pozisyon: {position}, Tekrar Sayısı: {count}");
        }
        else
        {
            Console.WriteLine($"Sayı {searchNumber} dizide yok.");
        }
    }
}