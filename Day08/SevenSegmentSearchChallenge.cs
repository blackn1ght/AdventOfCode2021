using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day08
{
    public class SevenSegmentSearchChallenge
    {
        private readonly List<Tuple<string[], string[]>> _inputs;

        public SevenSegmentSearchChallenge(IReadOnlyList<string> inputLines)
        {
            static string[] SortAlphaAsc(string input)
            {
                return input
                    .Split(' ')
                    .Select(x => string.Concat(x.OrderBy(c => c)))
                    .ToArray();
            }

            _inputs = inputLines
                .Select(input => input.Split('|').Select(s => s.Trim()).ToArray())
                .Select(parts => new Tuple<string[], string[]>(
                    SortAlphaAsc(parts[0]), 
                    SortAlphaAsc(parts[1])
                ))
                .ToList();
        }

        public int Part1()
        {
            return _inputs.Sum(input => input.Item2.Count(v => v.Length is 2 or 3 or 4 or 7));
        }

        public int Part2()
        {
            var answer = 0;

            foreach (var (signalPatterns, outputValues) in _inputs)
            {
                var digits = signalPatterns.ToList();

                var one = digits.Single(x => x.Length == 2);
                var four = digits.Single(x => x.Length == 4);
                var seven = digits.Single(x => x.Length == 3);
                var eight = digits.Single(x => x.Length == 7);

                var nine = digits.Single(x => four.All(x.Contains) && x.Length == 6);

                digits.Remove(one);
                digits.Remove(four);
                digits.Remove(seven);
                digits.Remove(eight);
                digits.Remove(nine);

                var zero = digits.Single(d => d.Length == 6 && d.Except(one).Count() == 4);
                digits.Remove(zero);
                var six = digits.Single(d => d.Length == 6);
                digits.Remove(six);
                var three = digits.Single(d => d.Except(one).Count() == 3);
                digits.Remove(three);
                var two = digits.Single(d => d.Except(six).Count() == 1);
                digits.Remove(two);
                var five = digits.Last();
                
                var localMatrix = new Dictionary<string, int>
                {
                    {zero, 0},
                    {one, 1},
                    {two, 2},
                    {three, 3},
                    {four, 4},
                    {five, 5},
                    {six, 6},
                    {seven, 7},
                    {eight, 8},
                    {nine, 9}
                };

                var total = outputValues
                    .Select(val => localMatrix.First(kv => string.Concat(kv.Key.OrderBy(x => x)) == val))
                    .Aggregate("", (current, num) => current + num.Value);

                answer += int.Parse(total);
            }

            return answer;
        }
    }
}
