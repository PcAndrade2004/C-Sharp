Console.WriteLine("## Métodos ##\n");

MinhaClasse minhaClasse = new(); // Criando uma instância da classe MinhaClasse
minhaClasse.Saudacao();// Chamando o método Saudacao da classe MinhaClasse
minhaClasse.ExibirDataAtual(); 


Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Olá! Bem-vindo ao curso de C#!");
        ExibirDataAtual();
    }

    public void ExibirDataAtual()
    {
        DateTime.Now.ToShortDateString();
        //Console.WriteLine($"Data atual: {DateTime.Now.ToShortDateString()}");
    }
}
