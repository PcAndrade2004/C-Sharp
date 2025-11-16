using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SobrecargaMetodo
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"Resultado da soma de inteiros: {a + b}");
        }

        public void Somar(double a, double b)
        {
            Console.WriteLine($"Resultado da soma de doubles: {a + b}");
        }

        public void Somar(int a, int b, int c)
        {
            Console.WriteLine($"Resultado da soma de três inteiros: {a + b + c}");
        }

        public void Somar(string a, string b)
        {
            Console.WriteLine($"Resultado da concatenação de strings: {a + b}");
        }
    }
}
