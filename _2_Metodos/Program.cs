using _2_Metodos;

Console.WriteLine("## Métodos ##\n");

//Console.WriteLine("Métodos sem Parâmetros");
//MinhaClasse minhaClasse = new(); // Criando uma instância da classe MinhaClasse
//minhaClasse.Saudacao();// Chamando o método Saudacao da classe MinhaClasse
//minhaClasse.ExibirDataAtual();

//Console.WriteLine("\nMétodos com Parâmetros");
//MetodoParametro metodoParametro = new();
//metodoParametro.ExibirInformacoes("Paulo Cesar", DateTime.Now.ToShortDateString());


Aluno aluno = new Aluno();

Console.WriteLine("Nome : ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Idade : ");
aluno.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Sexo : ");
aluno.Sexo = Console.ReadLine();
Console.WriteLine("Aprovado (Sim/Não) : ");
aluno.Aprovado = Console.ReadLine();

Curso curso = new Curso();  
curso.Resultado(aluno);


Console.ReadKey();

#region Métodos com Sem Parâmetros
public class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Olá! Bem-vindo ao curso de C#!");
        ExibirDataAtual();
    }

    public void ExibirDataAtual() => Console.WriteLine($"Data atual: {DateTime.Now.ToShortDateString()}");
}
#endregion

#region Métodos com Parâmetros
// Definindo os métodos com parâmetros.
// Parâmetros permitem que você passe informações para dentro do método quando ele é chamado.

public class MetodoParametro()
{
    public void ExibirInformacoes(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
    
}

#endregion

