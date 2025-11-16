Console.WriteLine("## Arrays ##\n");

#region Declarando e simplificando arrays

// Declarando um array com valor já atribuido
int[] numero = new int[5] { 1, 2, 3, 4, 5 };

// simplificando a declaração do array
int[] numero2 = { 1, 2, 3, 4 };

string[] nome = { "Ana", "Beatriz", "Carlos" };

#endregion

#region Acessando valores do array

// Acessando valores do array
Console.WriteLine(numero[0]);
Console.WriteLine(numero[1]);
Console.WriteLine(numero[2]);

Console.WriteLine(nome[0]);
Console.WriteLine(nome[1]);
Console.WriteLine(nome[2]);

#endregion  

Console.ReadKey();