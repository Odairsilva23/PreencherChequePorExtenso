using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreencherChequePorExtenso.consoleApp;
using System;

namespace ChequePorExtensoTests
{
    [TestClass]
    public class ChequeExtensosTests
    {
        [TestMethod]
        public void EscreverZeroPorExtenso()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(0);
            Assert.AreEqual("Valor inválido!", resultado);
        }

        [TestMethod]
        public void EscreverNegativo()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(-100.10);
            Assert.AreEqual("Valor inválido!", resultado);
        }

        [TestMethod]
        public void Escrever5Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(0.05);
            Assert.AreEqual("Cinco Centavos", resultado);
        }

        [TestMethod]
        public void Escrever1RealE10Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(1.10);
            Assert.AreEqual("Um Real e Dez Centavos", resultado);
        }

        [TestMethod]
        public void Escrever23ReaisE50Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(23.50);
            Assert.AreEqual("Vinte e Três Reais e Cinquenta Centavos", resultado);
        }

        [TestMethod]
        public void Escrever333ReaisE75Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(333.75);
            Assert.AreEqual("Trezentos e Trinta e Três Reais e Setenta e Cinco Centavos", resultado);
        }

        [TestMethod]
        public void Escrever1MilhãoEMeio()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(1500000);
            Assert.AreEqual("Um Milhão e Quinhentos Mil Reais", resultado);
        }

        [TestMethod]
        public void Escrever550Bilhões323Milhões500MilE70Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(550323500000.70);
            Assert.AreEqual("Quinhentos e Cinquenta Bilhões e Trezentos e Vinte e Três Milhões e Quinhentos Mil Reais e Setenta Centavos", resultado);
        }
        [TestMethod]
        public void Escrever5milhoes357mil852reaise25Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(5357852.25);
            Assert.AreEqual("Cinco Milhões e Trezentos e Cinquenta e Sete Mil e Oitocentos e Cinquenta e Dois Reais e Vinte e Cinco Centavos", resultado);
        }

        [TestMethod]
        public void Escrever285Mil28ReaisE75Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(285028.75);
            Assert.AreEqual("Duzentos e Oitenta e Cinco Mil e Vinte e Oito Reais e Setenta e Cinco Centavos", resultado);
        }

        [TestMethod]
        public void Escrever4Mil256ReaisE22Centavos()
        {
            Cheque cheque = new Cheque();
            String resultado = cheque.ChequePorExtenso(4256.22);
            Assert.AreEqual("Quatro Mil e Duzentos e Cinquenta e Seis Reais e Vinte e Dois Centavos", resultado);
        }
    }   
}
    
