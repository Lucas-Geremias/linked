using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o número do andar:");
        long andar = long.Parse(Console.ReadLine());

        long numeroAtribuido = CalcularNumeroAtribuido(andar);
        Console.WriteLine($"O número atribuído ao {andar}-ésimo andar é: {numeroAtribuido}");
    }

    static long CalcularNumeroAtribuido(long andar)
    {
        long contador = 0;
        long numeroAtual = 0;

        while (contador < andar)
        {
            numeroAtual++;

            if (!ContemDigito4OuSequencia13(numeroAtual))
            {
                contador++;
            }
        }

        return numeroAtual;
    }

    static bool ContemDigito4OuSequencia13(long numero)
    {
        string numeroString = numero.ToString();

        if (numeroString.Contains("4") || numeroString.Contains("13"))
        {
            return true;
        }

        return false;
    }
}
