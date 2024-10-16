using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        int posCount = 0, negCount = 0;
        int[] posArr = new int[100];
        int[] negArr = new int[100];

        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-100, 101);
            if (arr[i] > 0)
            {
                posArr[posCount++] = arr[i];
            }
            else if (arr[i] < 0)
            {
                negArr[negCount++] = arr[i];
            }
        }

        Console.WriteLine("Pozitif Sayılar:");
        for (int i = 0; i < posCount; i++)
        {
            Console.WriteLine(posArr[i]);
        }

        Console.WriteLine("Negatif Sayılar:");
        for (int i = 0; i < negCount; i++)
        {
            Console.WriteLine(negArr[i]);
        }
    }
}
