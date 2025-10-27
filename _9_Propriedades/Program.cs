Console.WriteLine("## Propriedades ##\n");

Console.WriteLine("Informe o ano do Carro: ");
var ano = Convert.ToInt32(Console.ReadLine());

Carro carro = new Carro();
carro.Ano = ano;

Console.WriteLine($"O ano do carro é: {carro.Ano}");    

Console.ReadKey();

public class Carro
{
    private int ano;
    public int Ano
    {
        get => ano;
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }else if(value > 2022)
            {
                ano = 2022;
            }else
            {
                ano = value;
            }
        }
    }

    
}