using System;
using System.Linq;

namespace Day_1_Part_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllLines("../../../data.txt").Select(n => Convert.ToInt32(n)).ToArray(); ;
            {
                var count = 0;
                for (int i = 0; i < input.Length-3; i++)
                {
                    int sum1 = input[i] + input[i+1] + input[i+2];
                    int sum2 = input[i + 1] + input[i + 2] + input[i + 3];

                    if(sum1 < sum2)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
