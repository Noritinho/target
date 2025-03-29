namespace ConsoleApp1.exercicios;

internal static class InvertesorDeString {
    public static void Executar()
    {
        Console.WriteLine("Informe uma string para inverter:");
        string input = Console.ReadLine();

        string stringInvertida = InverterString(input);

        Console.WriteLine($"String invertida: {stringInvertida}");
    }

    private static string InverterString(string str)
    {
        var caracteresInvertidos = new char[str.Length];

        var posicaoString = 0;
        for (int tamanhoString = str.Length - 1; tamanhoString >= 0; tamanhoString--)
        {
            caracteresInvertidos[posicaoString] = str[tamanhoString];
            posicaoString++;
        }

        return new string(caracteresInvertidos);
    }
}