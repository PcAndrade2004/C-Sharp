Console.WriteLine("## Validando Conhecimento 4 ##\n");  

Console.ReadKey();


public class Produto
{
    private string nome;
    private decimal preco;
    private int quantidade;

    public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Nome não pode ser vazio.");  
            }else
            {
                nome = value;
            }
        }
    }

    public void Preco
    {
        get => preco;
        set
        {
            if ()
            {

            }
        }
    }
}