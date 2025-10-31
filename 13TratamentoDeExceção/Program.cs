Console.WriteLine("## Tratamento de Exceções Try-Catch ##\n");

try
{
    Console.WriteLine("\nInforme o valor de x ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nInforme o valor de y ");
    int y = Convert.ToInt32(Console.ReadLine());

    int z = x / y;
    Console.WriteLine($"\nO valor de z é: {z}");

}
catch (DivideByZeroException e)
{
    Console.WriteLine($"\nErro: <<< 10{e.Message} >>>");  
    Console.WriteLine($"\nDetalhes {e?.StackTrace?.ToString()}"); 
    
}


Console.ReadKey();  