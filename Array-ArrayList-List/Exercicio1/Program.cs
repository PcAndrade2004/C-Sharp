Console.WriteLine("## Criar e adicionar elemento ##\n");

List<string> nomes = new List<string>();


nomes.Add("Paulo Cesar");
nomes.Add("Gabrielle Oliveira");
nomes.Add("Arthur Araujo");

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}


Console.ReadKey();