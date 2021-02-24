using System;
using Xunit;
using Calculadora;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var calculadora = new Calcula();
            // Act
            var resultat = calculadora.Suma(2, 3);
            // Assert
            Assert.Equal(5, resultat);

        }
    }
}
