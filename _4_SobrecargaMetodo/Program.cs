using _4_SobrecargaMetodo;

Console.WriteLine("## Sobrecarga de Métodos ##\n");

Calculadora calculadora = new();
calculadora.Somar(5, 10);                // Chama o método que soma dois inteiros
calculadora.Somar(5.5, 10.3);            // Chama o método que soma dois doubles
calculadora.Somar(1, 2, 3);              // Chama o método que soma três inteiros
calculadora.Somar("Olá, ", "Mundo!");   // Chama o método que concatena duas strings

Email email = new();
email.Enviar("empresa.com.br");
email.Enviar("usuario", "empresa.com.br"); 
email.Enviar("empresa.com.br", 2000);



Console.ReadKey();

