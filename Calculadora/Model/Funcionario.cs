﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public abstract double Salario { get; set; }
    }
}
