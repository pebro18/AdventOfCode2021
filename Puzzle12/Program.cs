using System;
using System.Collections.Generic;

namespace Puzzle12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Functions obj = new();
            Console.WriteLine(obj.Solution1());
        }
    }

    class Functions
    {
        string[] input = new[] {
            "vn-DD",
            "qm-DD",
            "MV-xy",
            "end-xy",
            "KG-end",
            "end-kw",
            "qm-xy",
            "start-vn",
            "MV-vn",
            "vn-ko",
            "lj-KG",
            "DD-xy",
            "lj-kh",
            "lj-MV",
            "ko-MV",
            "kw-qm",
            "qm-MV",
            "lj-kw",
            "VH-lj",
            "ko-qm",
            "ko-start",
            "MV-start",
            "DD-ko"
        };

        public int Solution1()
        {
            List<CaveSystems> Caves = GenerateCaveSystem();
            List<CaveSystems>[] Paths = new List<CaveSystems>[] { };

            CaveSystems startCave = Caves.Find(x => x.Name.Contains("start"));
            Paths = RecursionGenPaths(startCave);
            return Paths.Length;
        }

        private List<CaveSystems>[] RecursionGenPaths(CaveSystems startCave)
        {
            throw new NotImplementedException();
        }

        private List<CaveSystems> GenerateCaveSystem()
        {
            List<CaveSystems> Output = new();

            foreach (string item in input)
            {
                string[] itemSplit = item.Split('-');
                foreach (string caveName in itemSplit)
                {
                    if (!Output.Exists(x => x.Name.Contains(caveName)))
                    {
                        Output.Add(new CaveSystems(caveName));
                    }
                }
                Output.Find(x => x.Name.Contains(itemSplit[0])).AddCaveConnection(itemSplit[1]);
                Output.Find(x => x.Name.Contains(itemSplit[1])).AddCaveConnection(itemSplit[0]);
            }

            return Output;
        }
    }

    class CaveSystems
    {
        public string Name;
        public List<string> ConnectedCaves;

        public CaveSystems(string name)
        {
            Name = name;
            ConnectedCaves = new();
        }

        public void AddCaveConnection(string CaveName)
        {
            ConnectedCaves.Add(CaveName);
        }
    }
}
