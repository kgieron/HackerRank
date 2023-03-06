using FluentAssertions;
using Xunit;
using Plus_Minus;

namespace Plus_Minus_Tests
{
    public class PlusMinusChallengeUnitTests
    {
        [Fact]
        public void returns_proper_console_string()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Result.plusMinus(new List<int> { -4, 3, -9, 0, 4, 1 });

            //Assert
            var output = writer.ToString();
            output.Should().Be("0.50000\r\n0.33333\r\n0.16667\r\n");
        }
    }
}