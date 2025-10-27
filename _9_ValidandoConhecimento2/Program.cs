using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("## Exercício 2 – Carro ##\n");

        Carro carro = new Carro();
        carro.Modelo = "Civic";
        carro.Ano = 2023;

        carro.Acelerar(50);
        carro.Acelerar(180);
        carro.Frear(100);

        Console.WriteLine($"\nModelo: {carro.Modelo}");
        Console.WriteLine($"Ano: {carro.Ano}");
        Console.WriteLine($"Velocidade Atual: {carro.VelocidadeAtual} km/h");

        Console.ReadKey();
    }
}

public class Carro
{
    private int ano;
    public string Modelo { get; set; }
    public int VelocidadeAtual { get; private set; }

    public int Ano
    {
        get => ano;
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2025)
                ano = 2025;
            else
                ano = value;
        }
    }

    public void Acelerar(int valor)
    {
        VelocidadeAtual += valor;
        if (VelocidadeAtual > 200)
            VelocidadeAtual = 200;
        Console.WriteLine($"Acelerou para {VelocidadeAtual} km/h");
    }

    public void Frear(int valor)
    {
        VelocidadeAtual -= valor;
        if (VelocidadeAtual < 0)
            VelocidadeAtual = 0;
        Console.WriteLine($"Freou para {VelocidadeAtual} km/h");
    }
}
