        int casosTeste = int.Parse(Console.ReadLine());

        for (int i = 0; i < casosTeste; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] largada = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] chegada = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int ultrapassagens = CalcularUltrapassagens(n, largada, chegada);

            Console.WriteLine(ultrapassagens);
        }
    
int CalcularUltrapassagens(int n, int[] largada, int[] chegada)
    {
        int[] indiceChegada = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            indiceChegada[chegada[i]] = i;
        }

        int ultrapassagens = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (indiceChegada[largada[i]] > indiceChegada[largada[j]])
                {
                    ultrapassagens++;
                }
            }
        }

        return ultrapassagens;
    }
