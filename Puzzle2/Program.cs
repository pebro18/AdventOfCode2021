using System;
using System.IO;

namespace Puzzle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Functions obj = new Functions();
            Console.WriteLine(obj.solution1(obj.GetPuzzleInput()));
            Console.WriteLine(obj.solution2(obj.GetPuzzleInput()));
        }
    }

    class Functions
    {
        public string[] GetPuzzleInput()
        {
            string[] datafile = File.ReadAllLines(@"C:\Users\pebro\source\repos\AdventOfCode2021\Puzzle2\Data.txt");
            return datafile;
        }

        public int solution1(string[] input)
        {
            int x = 0;
            int y = 0;

            foreach (var item in input)
            {
                string[] split = item.Split(' ');
                //Console.WriteLine(split[0]);
                //Console.WriteLine(split[1]);
                switch (split[0])
                {
                    case "forward":
                        x += int.Parse(split[1]);
                        break;
                    case "down":
                        y += int.Parse(split[1]);
                        break;
                    case "up":
                        y -= int.Parse(split[1]);
                        break;
                    default:
                        break;
                }
            }

            return x * y;
        }
        public int solution2(string[] input)
        {
            int x = 0;
            int y = 0;
            int aim = 0;

            foreach (var item in input)
            {
                string[] split = item.Split(' ');
                //Console.WriteLine(split[0]);
                //Console.WriteLine(split[1]);
                switch (split[0])
                {
                    case "forward":
                        x += int.Parse(split[1]);
                        y += int.Parse(split[1]) * aim;
                        break;
                    case "down":
                        aim += int.Parse(split[1]);
                        break;
                    case "up":
                        aim -= int.Parse(split[1]);
                        break;
                    default:
                        break;
                }
            }

            return x * y;
        }

    }
}
