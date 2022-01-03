using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 10;
            var b = 10;
            var correto = 20;
            var contas = new Contas();

            var result = contas.Soma(a, b);
            Assert.AreEqual(correto, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 10;
            var b = 10;
            var correto = 0;
            var contas = new Contas();

            var result = contas.Subtracao(a, b);
            Assert.AreEqual(correto, result);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 10;
            var b = 10;
            var correto = 1;
            var contas = new Contas();

            var result = contas.Divisao(a, b);
            Assert.AreEqual(correto, result);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 10;
            var b = 10;
            var correto = 100;
            var contas = new Contas();

            var result = contas.Multiplicacao(a, b);
            Assert.AreEqual(correto, result);
        }
    }
}