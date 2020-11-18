using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        [Fact]
        public void Should_Given_1_Return_1()
        {
            //given
            int number = 1;

            //when
            string actual = HelloWorld.Say(number);

            //then
            Assert.Equal("1", actual);
        }
    }
}