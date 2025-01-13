using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("faturamento.json");
        var faturamento = JsonConvert.DeserializeObject<decimal[]>(json);

        var diasComFaturamento = faturamento.Where(x => x > 0).ToArray();
        decimal menorValor = diasComFaturamento.Min();
        decimal maiorValor = diasComFaturamento.Max();
        decimal media = diasComFaturamento.Average();

        int diasAcimaDaMedia = diasComFaturamento.Count(x => x > media);

        Console.WriteLine($"Menor valor de faturamento: {menorValor}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}