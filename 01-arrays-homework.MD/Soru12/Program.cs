using System;
using System.Collections.Generic;

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

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        int maxCount = 0;
        int mostFrequentNum = 0;

        foreach (var pair in frequency)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostFrequentNum = pair.Key;
            }
        }

        Console.WriteLine($"En sık tekrar eden eleman: {mostFrequentNum}, Tekrar Sayısı: {maxCount}");
    }
}