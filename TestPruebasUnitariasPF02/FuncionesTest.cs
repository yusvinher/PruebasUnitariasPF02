using PruebasUnitariasPF02;

namespace TestPruebasUnitariasPF02
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-5, -1)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        public void CalcularFactorial_VariosCasos(
            int numero,
            long esperado)
        {
            long resultado =
                Funciones.CalcularFactorial(numero);

            Assert.AreEqual(
                esperado,
                resultado
            );
        }
        [TestMethod]
        public void EsContrasenyaValida_EsNull()
        {
            bool resultado = Funciones.EsContrasenyaValida(null);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_EstaVacia()
        {
            bool resultado = Funciones.EsContrasenyaValida("");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_LongitudMenor8()
        {
            bool resultado = Funciones.EsContrasenyaValida("abc#");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_SinAlmohadilla()
        {
            bool resultado = Funciones.EsContrasenyaValida("abcdefgh");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Valida()
        {
            bool resultado = Funciones.EsContrasenyaValida("abcd#123");

            Assert.IsTrue(resultado);
        }
    }


}