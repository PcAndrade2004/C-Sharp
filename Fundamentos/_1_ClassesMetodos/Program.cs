Console.WriteLine("## Classes e Métodos ##\n");

Pessoa p1 = new Pessoa();
p1.Nome = "Ana";
p1.Idade = 28;
p1.Sexo = "Feminino";

Console.WriteLine($"Nome: {p1.Nome}, {p1.Idade}, {p1.Sexo}");

Pessoa p2 = new();
p2.Nome = "Gabrielle";
p2.Idade = 25;
p2.Sexo = "Feminino";

Console.WriteLine($"Nome: {p2.Nome}, {p2.Idade}, {p2.Sexo}");

Console.ReadKey();

public class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;

    // A nomenclatura usada para declarar campos é a Pascal Case.
    // Assim o correto seria usar nomes com (iniciais maiúsculas): Nome, Idade e Sexo.
}
