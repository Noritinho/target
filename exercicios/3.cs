using Newtonsoft.Json;

namespace ConsoleApp1.exercicios;

internal static class CalculaFaturamento
{
    private class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    internal static void ExecutarCalculo(string caminhoArquivo)
    {
        List<Faturamento> faturamentos = LerFaturamento(caminhoArquivo);

        Faturamento menorFaturamento =
            faturamentos.Where(faturamento => faturamento.valor > 0).OrderBy(faturamento => faturamento.valor).First();
        Faturamento maiorFaturamento =
            faturamentos.Where(faturamento => faturamento.valor > 0).OrderByDescending(faturamento => faturamento.valor).First();

        List<Faturamento> faturamentosComValor =
            faturamentos.Where(faturamento => faturamento.valor > 0).ToList();
        double mediaFaturamento =
            faturamentosComValor.Average(faturamento => faturamento.valor);

        List<Faturamento> diasAcimaMedia = faturamentosComValor.FindAll(faturamento => faturamento.valor > mediaFaturamento);

        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento.valor}, dia {menorFaturamento.dia}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento.valor}, dia {maiorFaturamento.dia}");

        Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMedia.Count}");
        Console.WriteLine("Dias com faturamento superior à média:");
        foreach (Faturamento dia in diasAcimaMedia)
        {
            Console.WriteLine($"Dia {dia.dia}: {dia.valor}");
        }
    }
    private static List<Faturamento> LerFaturamento(string caminho)
    {
            string jsonData = File.ReadAllText(caminho);
            var faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(jsonData);
            return faturamentos;
    }
}