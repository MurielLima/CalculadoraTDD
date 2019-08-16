using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public class Desenvolvedor : Funcionario
    {
        private double _salario;
        public override double Salario { get => _salario; set => _salario = (value >= 3000) ? Math.Round(value * 0.8) :  Math.Round(value * 0.9,3);  }

        public Desenvolvedor(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
