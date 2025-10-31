using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Enumaration_EX
{
    public class Carro
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public int Cor { get; set; }

        public Carro(string modelo, string marca, int ano, int cor)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Cor = cor;
        }

        public void exibirDetalhes()
        {
            string nomeCor = Enum.GetName(typeof(Cores), Cor);
            Console.WriteLine($"\nModelo: {Modelo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {nomeCor}");
        }
    }
}
