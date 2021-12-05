using System.Linq;

namespace AdventOfCode2021.Day01
{
    public class SonarSweepChallenge
    {
        private readonly string[] _inputLines;

        public SonarSweepChallenge(string[] inputLines)
        {
            _inputLines = inputLines;
        }

        public int Part1()
        {
            var depths = _inputLines.Select(int.Parse).ToList();

            var increments = 0;

            for (var i = 1; i < depths.Count; i++)
            {
                var previous = depths[i - 1];
                var current = depths[i];

                if (current > previous) increments++;
            }

            return increments;
        }

        public int Part2()
        {
            var depths = _inputLines.Select(int.Parse).ToList();

            var increments = 0;

            for (var i = 1; i <= depths.Count; i++)
            {
                var previousWindowTotal = depths.Skip(i - 1).Take(3).Sum();
                var currentWindowTotal = depths.Skip(i).Take(3).Sum();

                if (currentWindowTotal > previousWindowTotal) increments++;
            }

            return increments;
        }
    }
}
