using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TP2Test
{
    [TestClass]
    public class MatematicaTest //CLASE DE PRUEBA
    {
        [TestMethod] //METODO DE PRUEBA
        public void TestDividir()
        {
            
            int aDividiendo = 50;
            int aDivisor = 10;
            double aResultadoEsperado = 5;
            double aResultado;

            aResultado = Matematica.Dividir(aDividiendo, aDivisor); //método en la clase Matematica

            Assert.AreEqual(aResultadoEsperado,aResultado); //comapra valores. Ver métodos de Assert 
            
            //Test Explorer
        }
    }
}