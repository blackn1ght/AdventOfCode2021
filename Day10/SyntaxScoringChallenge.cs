using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day10
{
    public class SyntaxScoringChallenge
    {
        private readonly IReadOnlyList<string> _inputData;

        public SyntaxScoringChallenge(IReadOnlyList<string> inputData)
        {
            _inputData = inputData;
        }

        public int Part1()
        {
            var tagPoints = new Dictionary<char, int>()
            {
                {')', 3},
                {']', 57},
                {'}', 1197},
                {'>', 25137}
            };

            return _inputData
                .Select(SyntaxHelper.FindCorruptedTag)
                .Where(c => c.HasValue)
                .GroupBy(c => c)
                .Sum(group => tagPoints[group.Key.Value] * group.Count());
        }

        public long Part2()
        {
            var tagPoints = new Dictionary<char, int>()
            {
                {')', 1},
                {']', 2},
                {'}', 3},
                {'>', 4}
            };

            var scores = _inputData
                .Where(data => SyntaxHelper.FindCorruptedTag(data) == null)
                .Select(SyntaxHelper.FindMissingClosingTags)
                .Select(missingClosingTags => missingClosingTags.ToCharArray())
                .Select(missingTags => missingTags.Aggregate((long)0, (sum, c) => sum * 5 + tagPoints[c]))
                .OrderBy(x => x)
                .ToList();

            var middleIndex = (int)Math.Ceiling((double)scores.Count / 2) - 1;

            return scores[middleIndex];
        }
    }
}
