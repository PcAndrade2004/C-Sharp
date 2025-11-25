using System.Globalization;
Console.WriteLine("## Convert ##\n");

// Convertendo string para int
string numeroString = "100";
int numeroConvertido = Convert.ToInt32(numeroString);
Console.WriteLine($"Valor convertido para int: {numeroConvertido}");

Console.WriteLine("------------------------------------------");

// Convertendo string para decimal
string valorDecimalString = "100.50";
decimal valorDecimalConvertido = Convert.ToDecimal(valorDecimalString);
Console.WriteLine($"Valor convertido para decimal: {valorDecimalConvertido.ToString("F2")}`);

Console.ReadKey();
