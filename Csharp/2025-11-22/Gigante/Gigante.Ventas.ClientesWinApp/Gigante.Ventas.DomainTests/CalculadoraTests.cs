using Gigante.Ventas.Domain;
using System;
using Xunit;

namespace Gigante.Ventas.DomainTests
{
    // TDD: Test Driven Development
    // Green, red, refactor
    // Moq, cual llegues a cierto metodo que se conecte a la bd
    // regresa tal cosa

    // Cypress para la UI
    // Selenium con Watin
    public class CalculadoraTests
    {
        [Fact]
        public void Sumar_Exito()
        {
            


        }

        [Fact]
        public void Sumar_Fracaso()
        {

        }

        [Fact]
        public void Dividir_Exito()
        {
            // AAA: Arrange, Act, Assert

            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            var actual = calculadora.Dividir(4, 2);

            // Assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Dividir_Fracaso()
        {
            // AAA: Arrange, Act, Assert

            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            var actual = calculadora.Dividir(4, 0);

            // Assert
            Assert.Equal(0, actual);
        }
    }
}
