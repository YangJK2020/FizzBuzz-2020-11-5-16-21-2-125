using System;

namespace FizzBuzz
{
    public class HelloWorld
    {
        public static string Say(int count)
        {
            string word = string.Empty;
            if (count % 3 == 0)
            {
                word = "Fizz";
            }

            if (count % 5 == 0)
            {
                word = "Buzz";
            }

            if (count % 7 == 0)
            {
                word = "Wizz";
            }

            return word.Equals(string.Empty) ? count.ToString() : word;
        }
    }
}
