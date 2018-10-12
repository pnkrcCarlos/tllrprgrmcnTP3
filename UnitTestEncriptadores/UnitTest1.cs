using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ4;

namespace UnitTestEncriptadores
{
    [TestClass]
    public class EncriptadoresTest
    {
        [TestMethod]
        public void CesarTest()
        {
            IEncriptador cesar = new EncriptadorCesar(17);
            String mPalabra = "Parlos Cankrac";
            String mPalabraEncriptada = cesar.Encriptar(mPalabra);
            Assert.AreEqual(mPalabra, cesar.Desencriptar(mPalabraEncriptada));
            Assert.AreEqual(cesar.Encriptar(mPalabra), mPalabraEncriptada);

            cesar = new EncriptadorCesar(10);
            String mPalabra2 = " AB!";
            String mPalabraEncriptada2 = cesar.Encriptar(mPalabra2);
            Assert.AreEqual(cesar.Encriptar(mPalabra2), "*KL+");
            Assert.AreEqual(cesar.Encriptar("~)z"), ")3%");
        }
    }
}
