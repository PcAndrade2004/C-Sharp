Console.WriteLine("## Construtores Estáticos ##\n");

Pessoa p1 = new Pessoa(25, "João");

Console.WriteLine($"Nome: {p1.Nome}, Idade: {p1.Idade}");   
Console.WriteLine($"Idade Mínima: {Pessoa.IdadeMinima}");



Console.ReadKey();
