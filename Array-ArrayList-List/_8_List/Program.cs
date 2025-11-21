Console.WriteLine("## List<T> ##\n");

List<string> listas = new List<string>();

//adicionando elementos 
listas.Add("Paulo");
listas.Add("Arthur");
listas.Add("Gabrielle");

for (int i = 0; i < listas.Count; i++)
{
    Console.WriteLine(listas[i]);
}

#region Inserindo itens em uma posição específica
listas.Insert(1, "Claudia");
#endregion

#region Acessando por índice
Console.WriteLine("\n--- Acessando pelo índice ---");
string x = listas[0];
Console.WriteLine(x);
#endregion

#region Atualizando por índice
Console.WriteLine("\n--- Atualizando por índice ---");
string y = listas[0] = "Diomeneis";
Console.WriteLine(y);
#endregion

#region Retornando quantidade de elementos
Console.WriteLine("\n--- Retornando a quantidade elementos ---");
int quantdade = listas.Count;
Console.WriteLine(quantdade);
#endregion

#region Removendo Elementos
Console.WriteLine("\n--- Removendo elemento ---");
listas.Remove("Paulo");

foreach (string s in listas)
{
    Console.WriteLine(s); 
}
#endregion

#region Ordenando a lista
Console.WriteLine("\n--- Ordenando a Lista ---");
listas.Sort();
foreach (string o in listas)
{
    Console.WriteLine(o);
}
#endregion

#region Invertendo a ordem
Console.WriteLine("\n--- Invertendo a ordem ---");
listas.Reverse();
foreach (string i in listas)
{
    Console.WriteLine(i);
}
#endregion

#region

#endregion







Console.ReadKey();
