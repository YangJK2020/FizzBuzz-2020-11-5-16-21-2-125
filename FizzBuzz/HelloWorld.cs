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

            return count.ToString();
        }
    }
}
