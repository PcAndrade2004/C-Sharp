public class Pessoa
{

    public static int IdadeMinima;

    public int Idade { get; set; }
    public string? Nome { get; set; }
    public Pessoa(int idade, string? nome)
    {
        Idade = idade;
        Nome = nome;
    }

    public Pessoa()
    { }

    static Pessoa()
    {
        Console.WriteLine("Construtor Estático chamado");
        IdadeMinima = 18;
    }

   


}