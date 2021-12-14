using System;
using System.IO;

namespace Puzzle1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Functions obj = new Functions();
            Console.WriteLine(obj.SumDepthMeasurementsIncreases(obj.GetPuzzleInput()));
            Console.WriteLine(obj.SumThreeMeasurement(obj.GetPuzzleInput()));
        }
    }

    class Functions
    {
        public int[] GetPuzzleInput()
        {
            string[] datafile = File.ReadAllLines(@"C:\Users\pebro\source\repos\AdventOfCode2021\AdventOfCode2021\Data.txt");
            int[] inputs = Array.ConvertAll(datafile, i => int.Parse(i));
            return inputs;
        }

        public int SumDepthMeasurementsIncreases(int[] input)
        {
            int Increments = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    Increments++;
                }
            }
            return Increments;
        }

        public int SumThreeMeasurement(int[] input)
        {
            int Increments = 0;

            for (int i = 3; i < input.Length; i++)
            {
                int oldSum = input[i - 1] + input[i - 2] + input[i - 3];
                int newSum = input[i] + input[i - 1] + input[i - 2];
                if (newSum > oldSum)
                {
                    Increments++;
                }
            }
            return Increments;
        }

    }

}
