Console.WriteLine("## Membros Estáticos ##\n");

var cliente1 = Cliente.Nome = "Ana";

Console.ReadKey();

public class Cliente
{
    public static string? Nome; // São campos de instância
    public static int Idade;

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }


}