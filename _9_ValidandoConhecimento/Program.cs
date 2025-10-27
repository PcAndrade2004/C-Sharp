Console.WriteLine("## Consolidando Conhecimento ##\n");

Console.WriteLine("Digite o seu nome: ");
var nome = Console.ReadLine();

Console.WriteLine("Digite sua idade : ");
var idade = int.Parse(Console.ReadLine()!);


Console.WriteLine("\nDados informados:");
Pessoa pessoa = new Pessoa();   
pessoa.Nome = nome!;
pessoa.Idade = idade;

Console.WriteLine($"Nome: {pessoa.Nome}");
Console.WriteLine($"Idade: {pessoa.Idade}");
Console.ReadKey(); 


public class Pessoa
{
    private string nome;
    private int idade;

    public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Nome não pode ser vazio.");
            }
            else
            {
                nome = value;
            }
        }
    }
    public int Idade
    {
        get => idade;
        set
        {
            if (value > 0)
            {
                idade = 0;
            }else if (value > 120)
            {
                idade = 120;
            }else
            {
                idade = value;
            }
        }
    }
}