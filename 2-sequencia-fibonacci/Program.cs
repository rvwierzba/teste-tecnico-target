using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());
        
        int a = 0, b = 1, fib = 0;

        while (fib < numero)
        {
            fib = a + b;
            a = b;
            b = fib;
        }

        if (fib == numero || numero == 0)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }
}