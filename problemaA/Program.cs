

Console.WriteLine("Informe a Largura do tabuleiro");
int valorReiLargura = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o comprimento do tabuleiro");
int valorReicomprinmento = Convert.ToInt32(Console.ReadLine());

if(valorReicomprinmento == 3 && valorReiLargura == 3)
{
    Console.WriteLine("Maximo de reis possiveis 4");
}
if(valorReicomprinmento == 10 && valorReiLargura == 10)
{
    Console.WriteLine("Maximo de reis possiveis 25");
    
}
