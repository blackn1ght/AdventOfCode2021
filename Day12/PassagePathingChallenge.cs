using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day12
{
    public class PassagePathingChallenge
    {
        private readonly Cave _startCave;

        public PassagePathingChallenge(IReadOnlyList<string> inputData)
        {
            var paths = inputData.ToList();

            var caves = inputData
                .SelectMany(x => x.Split('-'))
                .Distinct()
                .ToDictionary(k => k, v => new Cave(v));

            foreach (var line in paths)
            {
                var caveNames = line.Split('-');

                var cave0 = caves[caveNames[0]];
                var cave1 = caves[caveNames[1]];

                if (cave0.Name != "start" && cave1.Name != "end")
                {
                    cave1.LinkedCaves.Add(cave0);
                }

                if (cave1.Name != "start" && cave0.Name != "end")
                {
                    cave0.LinkedCaves.Add(cave1);
                }
            }

            _startCave = caves["start"];
        }

        private bool HasAlreadyVisitedSmallCave(List<string> visitedCaves, string caveName ,int smallCaveVisitLimit)
        {
            var smallCaves = visitedCaves
                .Where(x => string.Equals(x, x.ToLower(), StringComparison.CurrentCulture))
                .GroupBy(x => x);

            var hasSmallCaveMultiple = smallCaves.Any(c => c.Count() == smallCaveVisitLimit);

            return hasSmallCaveMultiple && visitedCaves.Contains(caveName);
        }

        private void FindPaths(Cave cave, List<string> visitedCaves, List<List<string>> paths, int smallCaveVisitLimit)
        {
            if (cave.Name == "end")
            {
                paths.Add(visitedCaves);
                return;
            }

            visitedCaves.Add(cave.Name);

            foreach (var linkedCave in cave.LinkedCaves)
            {
                if (linkedCave.IsSmallCave && HasAlreadyVisitedSmallCave(visitedCaves, linkedCave.Name, smallCaveVisitLimit)) continue;

                FindPaths(linkedCave, new List<string>(visitedCaves), paths, smallCaveVisitLimit);
            }
        }

        public int Part1()
        {
            var paths = new List<List<string>>();

            foreach (var startChild in _startCave.LinkedCaves)
            {
                FindPaths(startChild, new List<string>(), paths, 1);
            }

            return paths.Count;
        }

        public int Part2()
        {
            var paths = new List<List<string>>();

            foreach (var startChild in _startCave.LinkedCaves)
            {
                FindPaths(startChild, new List<string>(), paths, 2);
            }

            return paths.Count;
        }
    }
}
