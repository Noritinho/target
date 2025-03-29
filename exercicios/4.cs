namespace ConsoleApp1.exercicios;

internal static class CalculoDeRepresentacaoPorEstado {
    internal static void CalcularRepresentacao()
    {
        var faturamentoEstados = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double faturamentoTotal = faturamentoEstados.Values.Sum();

        Console.WriteLine("Percentual de representação de cada estado:");

        foreach (KeyValuePair<string, double> estado in faturamentoEstados)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}