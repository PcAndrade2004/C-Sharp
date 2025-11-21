Console.WriteLine("## Método Find ##\n");

List<string> frutas = new List<string>()
{
    "Uva", "Maça", "Pera", "Banana", "Laranja", "Morango"
};
#region Forma Antiga, criando função.
//var fruta1 = frutas.Find(Procura);
//Console.WriteLine($"\nPredicdo => {fruta1}");


//Console.ReadKey();  

//static bool Procura(string item)
//{
//    return item.Contains('L');
//}
#endregion

#region Find 
var fruta2 = frutas.Find(F=> F.Contains('M'));
Console.WriteLine($"\nexpressões lambda => {fruta2} ");
#endregion

#region FindLast 
var fruta3 = frutas.FindLast(A=> A.Contains('o'));
Console.WriteLine($"\nFindLast : {fruta3}");
#endregion

#region FindIndex
var fruta4 = frutas.FindIndex(B=> B.Contains('U'));
Console.WriteLine($"\nFindIndex : {fruta4}");
#endregion