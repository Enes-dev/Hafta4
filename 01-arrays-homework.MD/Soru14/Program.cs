using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[20];
        Random rand = new Random();
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 101);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 3 == 0)
            {
                sum += arr[i];
                Console.Write(arr[i] + " ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine($"\n3’e bölünebilenlerin toplamı: {sum}");
    }
}
