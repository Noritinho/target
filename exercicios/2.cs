namespace ConsoleApp1.exercicios;

internal static class VerificaSequenciaFibonacci
{
    internal static void VerificarSequencia()
    {
        var valorValido = false;
        long valorInformadoFibonnaci = 0;
        while (!valorValido)
        {
            Console.WriteLine("Informe um valor para verificação de Fibonacci: ");
            valorInformadoFibonnaci = long.TryParse((Console.ReadLine()), out long result) ? result : 0;

            if (result == 0)
            {
                Console.WriteLine("Número inválido ou fora do limite de de int64!");
                continue;
            }

            valorValido = true;
        }

        List<long> sequenciaDeFibonacci = DefineSequenciaFibonacci();

        if (sequenciaDeFibonacci.Contains(valorInformadoFibonnaci))
        {
            Console.WriteLine("O número informado pertence a sequência de Fibonacci!");
            return;
        }

        Console.WriteLine("O número informado nao pertence a sequência de Fibonacci!");
    }

    private static List<long> DefineSequenciaFibonacci()
    {
        List<long> fibonacci = new List<long>();

        fibonacci.Add(0);
        fibonacci.Add(1);

        while (true)
        {
            long proximoTermo = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];

            if (proximoTermo < 0)
                break;

            fibonacci.Add(proximoTermo);
        }

        return fibonacci;
    }
}