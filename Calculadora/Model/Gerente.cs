using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public class Gerente : Funcionario
    {
        private double _salario;
        public override double Salario { get => _salario; set { _salario = (value >= 5000) ? Math.Round(value * 0.70,3) :  Math.Round(value * 0.8,3); } }

        public Gerente(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
