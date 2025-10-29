public struct Cliente
{
    public string? Nome;
    public String? Email;
    private int idade;

    public int Idade
    {
        get => idade;
        set
        {
            if (value < 18)
            {
                value = 18;
            }
        }
    }

    public Cliente(string nome, string email, int idade )
    {
        this.Nome = nome;
        this.Email = email;
        this.Idade = idade;
    }

    public static void ExibirInfo(string nome, string email, int idade)
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Idade: {idade}");
    }


}