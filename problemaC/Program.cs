string texto;
int contador, cv;
char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
int total = 0;
int consoante = 1;


Console.WriteLine("Digita uma palavra: ");
texto = Console.ReadLine();

for (contador = 0; contador <= texto.Length - 1; contador++)
    for (cv = 0; cv <= 4; cv++)
    {
        if (Convert.ToChar(texto.Substring(contador, 1)) == vogais[cv])

        {
            total++;
        }
    }
        consoante = contador - total;
    
Console.Write("Vogais " +total+ "." + "Consoantes"+consoante);
Console.ReadKey();

