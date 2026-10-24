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
    }
}