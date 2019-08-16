using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using Calculadora.Model;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TesteSalarioDesenvolvedor1()//Não deve passar depois da implementação final
        {
            Desenvolvedor dev = new Desenvolvedor("Muriel José Lima", "muriel@email.com", 1);
            Assert.AreEqual(1,dev.Salario);
        }
        [TestMethod]
        public void TesteSalarioDBA1()
        {
            Dba dba = new Dba("Muriel José Lima", "muriel@email.com", 1);
            Assert.AreEqual(1,dba.Salario);
        }
        [TestMethod]
        public void TesteSalarioGerente1()
        {
            Gerente ger = new Gerente("Muriel José Lima", "muriel@email.com", 1); ;
            Assert.AreEqual(1,ger.Salario);
        }
        [TestMethod]
        public void TesteSalarioTestador1()
        {
            Testador test = new Testador("Muriel José Lima", "muriel@email.com", 1); ;
            Assert.AreEqual(1,test.Salario);
        }

        [TestMethod]
        public void TesteSalarioDesenvolvedorDesconto20()
        {
            Desenvolvedor dev = new Desenvolvedor("Muriel José Lima", "muriel@email.com", 5500);
            Assert.AreEqual(4400,dev.Salario);
        }
        [TestMethod]
        public void TesteSalarioGerenteDesconto30()
        {
            Gerente ger = new Gerente("Muriel José Lima", "muriel@email.com", 5000);
            Assert.AreEqual(3500,ger.Salario);
        }
        [TestMethod]
        public void TesteSalarioDBADesconto25()
        {
            Dba dba = new Dba("Muriel José Lima", "muriel@email.com", 2000);
            Assert.AreEqual(1500,dba.Salario);
        }
        [TestMethod]
        public void TesteSalarioTestadorDesconto25()
        {
            Testador test = new Testador("Muriel José Lima", "muriel@email.com", 2000); ;
            Assert.AreEqual(1500,test.Salario);
        }
        [TestMethod]
        public void TesteSalarioDesenvolvedorDesconto10()
        {
            Desenvolvedor dev = new Desenvolvedor("Muriel José Lima", "muriel@email.com", 2500);
            Assert.AreEqual(2250,dev.Salario);
        }
        [TestMethod]
        public void TesteSalarioGerenteDesconto20()
        {
            Gerente ger = new Gerente("Muriel José Lima", "muriel@email.com", 4500);
            Assert.AreEqual(3600,ger.Salario);
        }
        [TestMethod]
        public void TesteSalarioDBADesconto15()
        {
            Dba dba = new Dba("Muriel José Lima", "muriel@email.com", 1500);
            Assert.AreEqual(1275,dba.Salario);
        }
        [TestMethod]
        public void TesteSalarioTestadorDesconto15()
        {
            Testador test = new Testador("Muriel José Lima", "muriel@email.com", 1500); ;
            Assert.AreEqual(1275,test.Salario);
        }
        [TestMethod]
        public void TesteSalarioDesenvolvedorFinal()
        {
            Desenvolvedor dev = new Desenvolvedor("Muriel José Lima", "muriel@email.com", 5000);
            Assert.AreEqual(4000,dev.Salario);
        }
        [TestMethod]
        public void TesteSalarioGerenteFinal()
        {
            Gerente ger = new Gerente("Muriel José Lima", "muriel@email.com", 2500);
            Assert.AreEqual(2000,ger.Salario);
        }
        [TestMethod]
        public void TesteSalarioDBAFinal()
        {
            Dba dba = new Dba("Muriel José Lima", "muriel@email.com", 550);
            Assert.AreEqual(467.50,dba.Salario);
        }
        [TestMethod]
        public void TesteSalarioTestadorFinal()
        {
            Testador test = new Testador("Muriel José Lima", "muriel@email.com", 1500); ;
            Assert.AreEqual(1275,test.Salario);
        }
    }
}
