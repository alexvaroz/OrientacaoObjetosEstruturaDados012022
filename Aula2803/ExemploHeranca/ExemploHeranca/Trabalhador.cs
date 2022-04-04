using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Trabalhador:Humano
    {
        private float salarioMensal;
        private int horasTrabalhadas;

        public Trabalhador(string nome,
            string sobreNome, 
            float salarioMensal, 
            int horasTrabalhadas):base(nome, sobreNome)
        {
            this.salarioMensal = salarioMensal;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public float SalarioMensal
        {
            get
            {
                return salarioMensal;
            }
        }

        public int HorasTrabalhadas
        {
            get
            {
                return horasTrabalhadas;
            }
        }

        public float ObterValorPorHora()
        {
            if (horasTrabalhadas != 0)
            {
                return salarioMensal / horasTrabalhadas;
            } else
            {
                return 0;
            }
        }
    }
}
