using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int[] evenArr = new int[10];
        int evenCount = 0;

        Console.WriteLine("10 tam sayı girin:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] % 2 == 0)
            {
                evenArr[evenCount++] = arr[i];
            }
        }

        Array.Resize(ref evenArr, evenCount);
        Array.Sort(evenArr);

        Console.WriteLine("Çift sayılar (küçükten büyüğe):");
        foreach (var num in evenArr)
        {
            Console.WriteLine(num);
        }
    }
}
