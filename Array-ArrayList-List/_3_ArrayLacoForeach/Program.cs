Console.WriteLine("## Laço Foreach em Arrays ##\n");

#region Laço foreach com nomes
string[] nomes = { "Paulo", "Gabrielle", "Arthur", "Carlos", "Diomeneis", "Claudia" };

foreach (var nome in nomes)
{
    Console.WriteLine($"Nome: {nome}");
}
#endregion

Console.WriteLine("--------------------------------------");

#region Laço foreach com números
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (var numero in numeros)
{
    Console.WriteLine($"Número: {numero}");
}
#endregion

Console.ReadKey();
