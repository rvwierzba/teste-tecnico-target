using System;

class Program
{
    static void Main(string[] args)
    {
        decimal sp = 67836.43m, rj = 36678.66m, mg = 29229.88m, es = 27165.48m, outros = 19849.53m;
        decimal total = sp + rj + mg + es + outros;

        Console.WriteLine($"Percentual de SP: {sp / total:P2}");
        Console.WriteLine($"Percentual de RJ: {rj / total:P2}");
        Console.WriteLine($"Percentual de MG: {mg / total:P2}");
        Console.WriteLine($"Percentual de ES: {es / total:P2}");
        Console.WriteLine($"Percentual de Outros: {outros / total:P2}");
    }
}