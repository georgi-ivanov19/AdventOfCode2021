using System;

namespace Day_1_Sonar_Sweep
{
    class Program
    {
       public static int numberOfIncreases(string data) {
            var input = data.Split();
            {
                var count = 0;
                for (int i = 1; i < input.Length; i++)
                {
                    // Test
                    if (int.Parse(input[i]) > int.Parse(input[i - 1]))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
