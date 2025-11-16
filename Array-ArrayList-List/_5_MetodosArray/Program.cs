Console.WriteLine("## Métodos de Array em C# ##\n");

Console.WriteLine("### Ordenando Array ###\n");
#region Método Array.Sort()
int[] numeros = { 5, 2, 8, 1, 4 };
Array.Sort(numeros); // Ordenando o array em ordem crescente
foreach (var numero in numeros)
{
    Console.WriteLine($"Número: {numero}");
}
#endregion

Console.WriteLine("\n### Invertendo Array ###\n");
#region Método Array.Reverse()
string[] frutas = { "Banana", "Maçã", "Laranja", "Uva" };
Array.Reverse(frutas); // Invertendo a ordem do array
foreach (var fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}
#endregion

Console.WriteLine("\n### Copiando Array ###\n");
#region Método Array.Copy()
char[] letrasOriginais = { 'A', 'B', 'C', 'D', 'E' };
char[] letrasCopia = new char[3];
Array.Copy(letrasOriginais, letrasCopia, 3); // Copiando os primeiros 3 elementos
foreach (var letra in letrasCopia)
{
    Console.WriteLine($"Letra: {letra}");
}
#endregion

Console.WriteLine("\n### Encontrando Índice ###\n");
#region Método Array.IndexOf()
string[] cores = { "Vermelho", "Verde", "Azul", "Amarelo" };
int indice = Array.IndexOf(cores, "Azul"); // Encontrando o índice do elemento "Azul"
Console.WriteLine($"Índice da cor 'Azul': {indice}");
#endregion

Console.WriteLine("\n### Redimensionando Array ###\n");
#region Método Array.Resize()
int[] numerosRedimensionados = { 1, 2, 3 };
Array.Resize(ref numerosRedimensionados, 5); // Redimensionando o array para tamanho 5
numerosRedimensionados[3] = 4;
numerosRedimensionados[4] = 5;
foreach (var numero in numerosRedimensionados)
{
    Console.WriteLine($"Número: {numero}");
}
#endregion

Console.WriteLine("\n### Limpando Array ###\n");
#region Método Array.Clear();
string[] animais = { "Cachorro", "Gato", "Pássaro", "Peixe" };
Array.Clear(animais, 1, 2); // Limpando os elementos nos índices 1 e 2
foreach (var animal in animais)
{
    Console.WriteLine($"Animal: {animal ?? "null"}");
}
#endregion

