using Ejercicio.Entidades;

namespace CilindroTest01
{
    [TestClass]
    public class CilindroTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            [Fact]
            public void Constructor_ValidParameters_ShouldInitializeCorrectly()
            {
                // Arrange
                int radio = 2;
                double altura = 5;

                // Act
                var cilindro = new Cilindro(radio, altura);

                // Assert
                Assert.Equals(radio, cilindro.Radio);
                Assert.Equal(altura, cilindro.Altura);
                Assert.Equal(4, cilindro.ObtenerDiametro());
            }
        }
    }
}