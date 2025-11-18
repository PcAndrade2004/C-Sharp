using System.Collections;

Console.WriteLine("## ArrayList ##\n");

#region Criando ArrayList
// criando um ArrayList
//ArrayList names = new ArrayList();
#endregion

#region Adicionando elemento
// adicionando elementos
//names.Add("Paulo");
//names.Add("Gabrielle");
//names.Add("Arthur");
#endregion

#region Acessando elemento
// Acessando elementos usando ( for )
//Console.WriteLine("Acessando elementos usando ## for ##");
//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);    
//}

//// Acessando elementos usando ( foreach )
//Console.WriteLine("\nAcessando elementos usando ## foreach ##");
//foreach (string name in names)
//{ 
//     Console.WriteLine(name); 
//}
#endregion

#region AddRange e InsertRange
//ArrayList lista = new ArrayList();

//// Primeiro conjunto
//string[] nomesIniciais = { "Paulo", "Gabrielle", "Arthur", "Ola" };
//lista.AddRange(nomesIniciais);

//// Mostrar elementos iniciais
//Console.WriteLine("## Lista inicial ##");
//foreach (string str in lista)
//{
//    Console.WriteLine(str);
//}

//// Segundo conjunto (novos elementos)
//string[] novosNomes = { "Marcos", "Julia", "Fernanda" };
//lista.AddRange(novosNomes); // <-- Adiciona no final da lista

//// Mostrar lista final
//Console.WriteLine("\n## Lista após adicionar novos elementos ##");
//foreach (string str in lista)
//{
//    Console.WriteLine(str);
//}
#endregion

#region Verificar elemento na coleção

ArrayList nomes = new ArrayList();
nomes.Add("Paulo");
nomes.Add("Gabrielle");
nomes.Add("Arthur");

Console.WriteLine("Digite o nome que buscado : ");
var nomeBusca = Console.ReadLine()!;

if (nomes.Contains(nomeBusca))
{
    Console.WriteLine($"Nome encontrado! : {nomeBusca}");
}
else
{
    Console.WriteLine($"{nomeBusca} não encontrado! ");
}

#endregion





Console.ReadKey();