Console.WriteLine("## Consolidando Conhecimento Métodos ##\n");

Cadastro cadastro = new Cadastro(); 
var cliente = cadastro.Registrar(); 
cadastro.Exibir(cliente);

cliente = cadastro.Registrar(cliente);
cadastro.Exibir(cliente);

Console.ReadKey();  

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
    public Cliente()// ctor TAB + TAB cria o construtor Vazio
    { }
}

public class  Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Paulo0", 23, 3000);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 5000;
        return cliente;
    }

    public void Exibir(Cliente cliente)
    {
        Console.WriteLine($"Nome: {cliente.Nome}\nIdade: {cliente.Idade}\nRenda: {cliente.Renda.ToString("C")}");
    }


}