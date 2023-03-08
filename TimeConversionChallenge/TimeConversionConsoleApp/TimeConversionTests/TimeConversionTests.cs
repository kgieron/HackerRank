using FluentAssertions;
using Xunit;

namespace TimeConversionTests
{
    public class TimeConversionTests
    {
        [Fact]
        public void returns_19_05_45_when_input_07_05_45PM()
        {
            //Arrange
            var input = "07:05:45PM";

            //Act
            var result = Result.timeConversion(input);

            //Assert
            result.Should().Be("19:05:45");
        }

        [Fact]
        public void returns_12_01_00_when_input_12_01_00PM()
        {
            //Arrange
            var input = "12:01:00PM";

            //Act
            var result = Result.timeConversion(input);

            //Assert
            result.Should().Be("12:01:00");
        }

        [Fact]
        public void returns_00_01_00_when_input_12_01_00AM()
        {
            //Arrange
            var input = "12:01:00AM";

            //Act
            var result = Result.timeConversion(input);

            //Assert
            result.Should().Be("00:01:00");
        }
    }
}