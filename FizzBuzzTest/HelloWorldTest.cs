using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        [Fact]
        public void Should_FizzBuzz_Return_1_Given_1()
        {
            //given
            int number = 1;

            //when
            string actual = HelloWorld.Say(number);

            //then
            Assert.Equal("1", actual);
        }

        [Fact]
        public void Should_FizzBuzz_Return_2_Given_2()
        {
            //given
            int number = 2;

            //when
            string actual = HelloWorld.Say(number);

            //then
            Assert.Equal("2", actual);
        }

        [Fact]
        public void Should_FizzBuzz_Return_Fizz_Given_3()
        {
            //given
            int number = 3;

            //when
            string actual = HelloWorld.Say(number);

            //then
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void Should_FizzBuzz_Return_Buzz_Given_5()
        {
            //given
            int number = 5;

            //when
            string actual = HelloWorld.Say(number);

            //then
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void Should_FizzBuzz_Return_Wizz_Given_7()
        {
            //given
            int number = 7;

            //when
            string actual = HelloWorld.Say(number);

            //then
            Assert.Equal("Wizz", actual);
        }
    }
}