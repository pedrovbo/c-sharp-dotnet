using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperacoesAritmeticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesAritmeticas.Tests
{
    [TestClass()]
    public class OperacoesAritmeticasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var operacao = new OperacoesAritmeticas();

            var result = operacao.Soma(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var operacao = new OperacoesAritmeticas();

            var result = operacao.Subtracao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var operacao = new OperacoesAritmeticas();

            var result = operacao.Divisao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var operacao = new OperacoesAritmeticas();

            var result = operacao.Multiplicacao(a, b);

            Assert.AreEqual(esperado, result);
        }
    }
}