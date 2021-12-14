using System;

namespace Puzzle11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Functions obj = new();
            Console.WriteLine(obj.Solution1(100));
            //Console.WriteLine(obj.solution2());
        }
    }


    class Functions
    {
        int[] input = new int[] {
            6,3,1,8,1,8,5,7,3,2,
            1,1,2,2,6,8,7,1,3,5,
            5,1,7,3,2,3,7,6,7,6,
            8,7,5,4,3,6,2,6,1,2,
            5,7,1,8,4,7,4,6,6,6,
            8,4,4,3,6,5,4,1,3,7,
            1,2,4,7,6,3,4,3,4,6,
            1,4,4,6,5,1,4,5,8,5,
            6,7,1,7,2,8,8,2,6,7,
            1,7,2,7,8,7,1,2,2,8
        };

        public int Solution1(int amount_steps)
        {
            int flashCount = 0;
            int[] simulation = input;

            for (int i = 0; i < amount_steps; i++)
            {
                simulation = IncrementArr(simulation);

                for (int i2 = 0; i2 < simulation.Length; i2++)
                {
                    if (simulation[i2] > 9)
                    {
                        simulation = IncrementAdjecent(simulation, i2);
                    }
                }
                for (int i2 = 0; i2 < simulation.Length; i2++)
                {
                    if (simulation[i2] > 9)
                    {
                        flashCount++;
                        simulation[i2] = 0;
                    }
                }
            }
            return flashCount;
        }

        private int[] IncrementAdjecent(int[] simulation, int i2)
        {
            int[] arrayPosition = new[] { -11, -10, -9, -1, 1, 9, 10, 11 };

            foreach (var item in arrayPosition)
            {
                int index = i2 + item;
                if (index < simulation.Length && index >= 0)
                {
                    if (simulation[index] != 0)
                    {
                        simulation[index]++;
                    }
                }
            }
            return simulation;
        }

        private int[] IncrementArr(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i]++;
            }

            return input;
        }
    }
}
