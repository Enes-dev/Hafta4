using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle girin:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        Console.WriteLine("Kelime Listesi (ters):");
        int i = words.Length - 1;
        while (i >= 0)
        {
            Console.Write(words[i] + " ");
            i--;
        }
    }
}