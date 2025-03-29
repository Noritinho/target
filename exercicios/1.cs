namespace ConsoleApp1.exercicios;

internal static class CalculaSoma {
    internal static void ExecutarCalculo() {
        const int indice = 13;
        var soma = 0;
        var k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine(soma);
    }
}