using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _9_Exercicio
{
    public class Aluno
    {
        public string Nome { get; set; }
        public Double Nota { get; set; }

        public Aluno(string nome, double nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }

        public Aluno()
        {
            
        }

        public override string ToString()
        {
            return $"{Nome}, {Nota}";
        }
    }
}
