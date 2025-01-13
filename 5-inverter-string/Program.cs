using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe uma string para ser invertida:");
        string input = Console.ReadLine();
        string invertida = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            invertida += input[i];
        }

        Console.WriteLine("String invertida: " + invertida);
    }
}