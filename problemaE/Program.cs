int  i, treze, quatro;

    Console.WriteLine("Numero do andar: ");
    Console.ReadLine();

    for (i = 0; i < 1080; i++)
    {
      int numeroAndar;
        treze = ProcuraNumero(13, numeroAndar);

        quatro = ProcuraNumero(4, numeroAndar);

        if ((quatro == 1) || (treze == 1))
        {
            numeroAndar += 1;
        }
    }

int ProcuraNumero(int v, int numeroAndar)
{
    throw new NotImplementedException();
}

Console.WriteLine("Novo numero do andar: ", numeroAndar);