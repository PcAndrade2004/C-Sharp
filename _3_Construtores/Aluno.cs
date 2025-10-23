using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Construtores
{
    public class Aluno
    {
        public string? Nome;
        public int Idade;
        public string? Materia;
        public string? Aprovado;

        // Construtor com parâmetros
        public Aluno(string? nome, int idade, string? materia, string? aprovado)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Materia = materia;
            this.Aprovado = aprovado;
        }
        public void exibir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Matéria: " + Materia);
            Console.WriteLine("Aprovado: " + Aprovado);
        }
    }
}
