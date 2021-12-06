using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day06
{
    public class LanternfishChallenge
    {
        private int[] _lanternfish;

        public LanternfishChallenge(IReadOnlyList<string> inputLines)
        {
            _lanternfish = inputLines[0]
                .Split(',')
                .Select(int.Parse)
                .ToArray();
        }

        private static Dictionary<int, long> GenerateInitialLookup(int[] lanternFish)
        {
            var lookup = Enumerable
                .Range(0, 9)
                .ToDictionary(k => k, v => (long)0);

            foreach (var fish in lanternFish)
            {
                lookup[fish]++;
            }

            return lookup;
        }

        private long RunSimulation(int days)
        {
            var lookup = GenerateInitialLookup(_lanternfish);

            for (var day = 0; day < days; day++)
            {
                var zeros = lookup[0];

                for (var t = 0; t < 8; t++)
                {
                    lookup[t] = lookup[t + 1];
                }

                lookup[8] = zeros;
                lookup[6] += zeros;
            }

            return lookup.Sum(kv => kv.Value);
        }

        public long Part1()
        {
            return RunSimulation(80);
        }

        public long Part2()
        {
            return RunSimulation(256);
        }
    }
}
