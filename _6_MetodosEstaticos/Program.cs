Console.WriteLine("## Métodos Estaticos ##\n");

var somar = Calculadora.Somar(10, 5); 
var subtrair = Calculadora.Subtrair(10, 5);

Console.WriteLine(somar);
Console.WriteLine(subtrair);

Console.ReadKey();

public class Calculadora
{
    // Método estático
    public static int Somar(int a, int b)
    {
        return a + b;
    }
    // Método de instância
    public static int Subtrair(int a, int b)
    {
        return a - b;
    }

}