Console.WriteLine("## Int.Parse ##\n");

#region Operação Matemática
//string numeroTexto = "150";
//int numeroConvertido = int.Parse(numeroTexto);

//var soma = 8;

//var somaTotal = soma += numeroConvertido;

//Console.WriteLine($"Soma Total : {somaTotal}");
#endregion

#region Entrada Usuário
//Console.WriteLine("Digite um número: ");
//string input = Console.ReadLine()!;
//var numero = int.Parse(input);
//Console.WriteLine($"Número convertido {numero}");

//var dobroNumero = numero * 2;
//Console.WriteLine($"Resultado do calculo : {dobroNumero}");
#endregion

#region Soma números em uma string
string n = ("10,20,30");
var partes = n.Split(',');

int soma = 0;   
foreach (string item in partes)
{
    int numero = int.Parse(item);
    soma += numero;
}

Console.WriteLine($"Soma : {soma}");
#endregion

Console.ReadKey();