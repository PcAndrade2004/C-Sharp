using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Metodos
{
    public class Curso
    {
        public void Resultado(Aluno aluno)
        {
            Console.WriteLine($"Aluno: {aluno.Nome}, Idade: {aluno.Idade}, Sexo: {aluno.Sexo}, Situação: {aluno.Aprovado}");
        }
    }
}
