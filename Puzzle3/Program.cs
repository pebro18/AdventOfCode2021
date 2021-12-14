using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Puzzle3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Functions obj = new();
            Console.WriteLine(obj.Solution1(obj.GetPuzzleInput()));
            Console.WriteLine(obj.Solution2(obj.GetPuzzleInput()));
        }
    }
     
    class Functions
    {
        public string[] GetPuzzleInput()
        {
            string[] datafile = File.ReadAllLines(@"C:\Users\pebro\source\repos\AdventOfCode2021\Puzzle3\Data.txt");
            return datafile;
        }

        public int Solution1(string[] input)
        {
            int gamma = 0;
            int epsilon = 0;


            // 12 rows
            int[] OutputG = new int[12];
            int[] OutputE = new int[12];

            for (int i = 0; i < 12; i++)
            {
                var Columm = RowOfInput(input, i);
                OutputG[i] = GetMostFrequentNumber(Columm);
                OutputE[i] = GetLeastFrequentNumber(Columm);
            }
            string resultG = string.Join("", OutputG);
            string resultE = string.Join("", OutputE);
            gamma = Convert.ToInt32(resultG, 2);
            epsilon = Convert.ToInt32(resultE, 2);
            return gamma * epsilon;
        }

        private string RowOfInput(string[] input, int index)
        {
            string Output = "";
            foreach (var item in input)
            {
                Output += item[index];
            }

            return Output;
        }

        private int GetMostFrequentNumber(string Output)
        {
            int Count1 = 0;
            int Count0 = 0;
            foreach (char c in Output)
            {
                if (c == '1')
                {
                    Count1++;
                }
                else
                {
                    Count0++;
                }
            }
            if (Count1 >= Count0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int GetLeastFrequentNumber(string Output)
        {
            int Count1 = 0;
            int Count0 = 0;
            foreach (char c in Output)
            {
                if (c == '1')
                {
                    Count1++;
                }
                else
                {
                    Count0++;
                }
            }
            if (Count1 < Count0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Solution2(string[] input)
        {
            int O2gen = 0;
            int CO2scrub = 0;

            foreach (var item in input)
            {
                int[] flipArr = { 1, 0 };
                int mostCommon = GetMostFrequentNumber(item);
                int leastCommon = flipArr[mostCommon];



                for (int i = 0; i < item.Length; i++)
                {

                }
            }

            return O2gen * CO2scrub;
        }
    }
}
