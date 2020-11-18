using System;

namespace FizzBuzz
{
    public class HelloWorld
    {
        public static string Say(int count)
        {
            if (count % 3 == 0)
            {
                return "Fizz";
            }

            if (count % 5 == 0)
            {
                return "Buzz";
            }

            return count.ToString();
        }
    }
}
