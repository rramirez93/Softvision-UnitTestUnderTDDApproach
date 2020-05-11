//using System;
//using Softvision.UnitTestUnderTDD.Methods;
//using Xunit;

//namespace Softvision.UnitTestUnderTDD.UnitTest.Tests
//{
//    public partial class ProgramTest
//    {
//        //Version 1
//        [Fact]
//        public void GivenDivideMethod_WhenValidInput_ShouldReturnQuotient()
//        {
//            //Arrange
//            var dividend = "10";
//            var divisor = "2";
//            var expectedQuotient = 5;

//            //Act
//            var actualQuotient = MathUtils.Divide(dividend, divisor);

//            //Assert
//            Assert.Equal(expectedQuotient, actualQuotient);
//        }

//        //Version 2
//        [Fact]
//        public void GivenDivideMethod_WhenInputIsNotANumber_ShouldThrowFormatException()
//        {
//            //Arrange
//            var dividend = "10";
//            var divisor = "a";

//            //Act
//            var ex = Assert.Throws<FormatException>(() => MathUtils.Divide(dividend, divisor));

//            //Assert
//            Assert.IsType<FormatException>(ex);
//            Assert.Equal("One or more of the argument provided are not numbers", ex.Message);
//        }
//    }
//}
