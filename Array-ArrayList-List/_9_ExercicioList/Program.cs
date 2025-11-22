using _9_Exercicio;
using _9_ExercicioList;

Console.WriteLine("## Exercicio ##\n");

List<Aluno> alunos = DadosEntrega.getAlunos();

ExibirAlunos(alunos);

#region Adicionando novos alunos
Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };
alunos.Add(bia);
alunos.Add(mario);
#endregion

ExibirAlunos(alunos); 

#region Localizando o aluno 
Console.WriteLine("##\nBusca aluno e removendo ##");
var localizarAluno = alunos.Find(n=> n.Equals("Amanda"));
alunos.Remove(localizarAluno);
ExibirAlunos(alunos);
#endregion

#region Ordenando lista pelo nome
Console.WriteLine("## Ordenando Lista ##");
var listaOrdenada = alunos.OrderBy(a => a.Nome).ToList();
ExibirAlunos(alunos);
#endregion

#region Notas maior que 8
var notaMaior = alunos.FindAll(a => a.Nota >= 8);
foreach(var teste in alunos)
{
    Console.WriteLine(teste.Nome);
}
#endregion



Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    //Criei um método para que ficasse mais facil de exibir os alunso. Porque irei precisar de novo.
    Console.WriteLine("\nNomes na lista principal: ");
    var somaNotas = 0.0;
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Nota}");
        somaNotas = +item.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count;
    Console.WriteLine($"\nMédia das notas : {mediaNotas}");
    Console.WriteLine($"Total de alunos : {alunos.Count()}");
}