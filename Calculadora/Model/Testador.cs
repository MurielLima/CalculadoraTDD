using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public class Testador : Funcionario
    {
        private double _salario;
        public override double Salario { get => _salario; set => _salario = (value >= 2000) ? Math.Round(value * 0.75,3) : Math.Round(value * 0.85,3); }

        public Testador(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
