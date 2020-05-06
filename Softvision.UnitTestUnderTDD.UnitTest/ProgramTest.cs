using System;
using Xunit;

namespace Softvision.UnitTestUnderTDD.UnitTest
{
    public class ProgramTest
    {
        //Version 1
        [Fact]
        public void GivenDividirMethod_WhenValidInput_ShouldReturnQuotient()
        {
            //Arrange
            string dividendo = "10";
            string divisor = "2";
            int cocienteEsperado = 5;

            //Act
            var cocienteReal = Program.Dividir(dividendo, divisor);

            //Assert
            Assert.Equal(cocienteEsperado, cocienteReal);
        }

        //Version 2
        [Fact]
        public void GivenDividirMethod_WhenInputIsNotANumber_ShouldThrowFormatException()
        {
            //Arrange
            string dividendo = "10";
            string divisor = "a";

            //Act
            Exception ex = Assert.Throws<FormatException>(() => Program.Dividir(dividendo, divisor));

            //Assert
            Assert.IsType<FormatException>(ex);
            Assert.Equal("Input string was not in a correct format.", ex.Message);
        }

        [Fact]
        public void GivenDividirMethod_WhenInputIsZero_ShouldThrowDivideByZeroException()
        {
            //Arrange
            string dividendo = "10";
            string divisor = "0";

            //Act
            Exception ex = Assert.Throws<DivideByZeroException>(() => Program.Dividir(dividendo, divisor));

            //Assert
            Assert.IsType<DivideByZeroException>(ex);
            Assert.Equal("Attempted to divide by zero.", ex.Message);
        }

        [Fact]
        public void GivenDividirMethod_WhenInputIsDecimal_ShouldReturnRightQuotient()
        {
            //Arrange
            string dividendo = "10";
            string divisor = "2.5";
            decimal cocienteEsperado = 4;

            //Act
            var cocienteReal = Program.Dividir(dividendo, divisor);

            //Assert
            Assert.Equal(cocienteReal, cocienteEsperado);
        }

    }
}
