using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day07
{
    public class WhaleTreacheryChallenge
    {
        private readonly int[] _positions;

        public WhaleTreacheryChallenge(IReadOnlyList<string> inputLines)
        {
            _positions = inputLines[0]
                .Split(',')
                .Select(int.Parse)
                .ToArray();
        }

        public int Part1()
        {
            var uniqueCrabPositions = _positions.Distinct().ToList();

            var uniquePositionCountLookup = _positions
                .GroupBy(p => p)
                .ToDictionary(n => n.Key, v => v.Count());

            var fuelUsagePerPositionLookup = uniqueCrabPositions
                .ToDictionary(n => n, _ => new Dictionary<int, int>());

            foreach (var uniqueCrabPosition in uniqueCrabPositions)
            {
                foreach (var innerPosition in uniqueCrabPositions)
                {
                    var fuelCost = uniqueCrabPosition > innerPosition
                        ? uniqueCrabPosition - innerPosition
                        : innerPosition - uniqueCrabPosition;

                    var totalFuelCostForCrabsInPosition = fuelCost * uniquePositionCountLookup[innerPosition];

                    fuelUsagePerPositionLookup[uniqueCrabPosition].Add(innerPosition, totalFuelCostForCrabsInPosition);
                }
            }

            return fuelUsagePerPositionLookup.Min(d => d.Value.Sum(v => v.Value));
        }

        public int Part2()
        {
            var uniqueCrabPositions = _positions.Distinct().ToList();

            var uniquePositionCountLookup = _positions
                .GroupBy(p => p)
                .ToDictionary(n => n.Key, v => v.Count());

            var possiblePositions = Enumerable.Range(0, _positions.Max()).ToList();

            var fuelCostLookup = new Dictionary<int, int>();

            var fuelUsagePerPositionLookup = possiblePositions.ToDictionary(n => n, _ => 0);

            int CalculateFuelCost(int positionDifference)
            {
                var fuelCost = 0;

                if (fuelCostLookup.ContainsKey(positionDifference))
                {
                    fuelCost = fuelCostLookup[positionDifference];
                }
                else
                {
                    fuelCost = Enumerable
                        .Range(0, positionDifference + 1)
                        .Aggregate(0, (total, current) => total + current);

                    fuelCostLookup.Add(positionDifference, fuelCost);
                }

                return fuelCost;
            }

            foreach (var uniqueCrabPosition in uniqueCrabPositions)
            {
                foreach (var position in possiblePositions)
                {
                    var fuelDifference = uniqueCrabPosition > position
                        ? uniqueCrabPosition - position
                        : position - uniqueCrabPosition;

                    var fuelCost = CalculateFuelCost(fuelDifference);

                    var numberOfCrabsInPosition = (uniquePositionCountLookup.ContainsKey(uniqueCrabPosition)
                        ? uniquePositionCountLookup[uniqueCrabPosition]
                        : 1);

                    var totalFuelCostForCrabsInPosition = fuelCost * numberOfCrabsInPosition;

                    fuelUsagePerPositionLookup[position] += totalFuelCostForCrabsInPosition;
                }
            }

            return fuelUsagePerPositionLookup.Min(x => x.Value);
        }
    }
}
