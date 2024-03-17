        Console.WriteLine("qtde de brinquedos:");
        int N = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Altura do jovem");
        int H = int.Parse(Console.ReadLine()); 

        int[] alturaMinima = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Informe a altura mínima do brinquedo {i + 1}:");
            alturaMinima[i] = int.Parse(Console.ReadLine());
        }

        int brinquedos = ContarBrinquedos(N, H, alturaMinima);

        Console.WriteLine($"O jovem pode ir nos {brinquedos} brinquedos.");

int ContarBrinquedos(int N, int H, int[] alturaMinima)
    {
        int brinquedos = 0;
        for (int i = 0; i < N; i++)
        {
            if (H >= alturaMinima[i])
            {
                brinquedos++;
            }
        }
        return brinquedos;
    }

