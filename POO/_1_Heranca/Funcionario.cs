using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Heranca
{
    public class Funcionario : Pessoa
    {
        public string? Empresa { get; set; }    
        public decimal Salario { get; set; }    
    }
}
