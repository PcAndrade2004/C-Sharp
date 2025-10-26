using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ValidandoConhecimento
{
    public class Aluno
    {
        public string? nome;
        private int idade;
        private double peso;
        private double altura;
        private string plano;
        private double mensalidade;

        public int Idade
        {
            get => idade;
            set
            {
                if (idade > 12)
                {
                    idade = value;
                }
                else
                {
                    throw new Exception("A idade deve ser maior que 12 anos.");
                }
            }
        }

        public double Peso
        {
            get { return peso; }
            set
            {
                if (peso > 0)
                {
                    peso = value;
                }
                else
                {
                    throw new Exception("O peso deve ser maior que 0.");
                }
            }
        }

        public double Altura
        {
            get => altura;
            set
            {
                if (altura > 0)
                {
                    altura = value;
                }
                else
                {
                    throw new Exception("A altura deve ser maior que 0.");
                }
            }
        }

        public string PlanoMensal
        {
            get => plano;
            set
            {
                string planoLower = value.ToLower();
                if (planoLower == "básico" || planoLower == "básico")
                {
                    plano = "básico";
                    mensalidade = 50.0
;
                }
                else if (planoLower == "premium" || planoLower == "premium")
                {
                    plano = "premium";
                    mensalidade = 90.0;
                }
                else if (planoLower == "vip" || planoLower == "vip")
                {
                    plano = "vip";
                    mensalidade = 120.0;
                }
                else
                {
                    throw new Exception("Plano inválido. Os planos disponíveis são: básico, premium e vip.");
                }
            }
        }

       
    }
}

