using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SobrecargaMetodo
{
    public class Email
    {

        public void Enviar(string endereco)
        {
            Console.WriteLine($"Enviando email para: {endereco}");
            Console.WriteLine("Assunto: Bem-vindo!");
        }
        public void Enviar(string endereco, string assunto)
        {
            Console.WriteLine($"{endereco}");
            Console.WriteLine($"{assunto}");
        }
        public void Enviar(string endereco, decimal valor)
        {
            Console.WriteLine($"{endereco}");
            Console.WriteLine($"Proposta comercial");
            Console.WriteLine($"valor : {valor:C}");
        }
    }
}
