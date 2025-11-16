Console.WriteLine("## Laço For em Arrays ##\n");

string[] nomes = { "Paulo", "Gabrielle", "Arthur", "Carlos", "Diomeneis", "Claudia" };

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Nome do índice {i} : {nomes[i]}");
}

Console.ReadKey();
