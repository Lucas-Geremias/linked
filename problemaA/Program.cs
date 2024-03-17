Console.WriteLine("Informe a largura do tabuleiro:");
int larguraTabuleiro = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o comprimento do tabuleiro:");
int comprimentoTabuleiro = int.Parse(Console.ReadLine());

int maxReis = CalcularMaxReis(larguraTabuleiro, comprimentoTabuleiro);

Console.WriteLine($"Número máximo de reis que podem ser colocados sem se atacarem: {maxReis}");
int CalcularMaxReis(int largura, int comprimento)
{
    int numerosCasas = largura * comprimento;

    return numerosCasas / 2;
}

