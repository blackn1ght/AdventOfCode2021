using System.Collections.Generic;

namespace AdventOfCode2021.Day11
{
    public static class CoordinateHelper
    {
        public static IEnumerable<(int Y, int X)> GetAdjacentOctopusCoordinates(int y, int x)
        {

            if (y > 0 && x != 0) yield return new(y - 1, x - 1);
            if (y > 0) yield return new(y - 1, x);
            if (y > 0 && x < 9) yield return new(y - 1, x + 1);

            if (x > 0) yield return new(y, x - 1);
            if (x < 9) yield return new(y, x + 1);

            if (y >= 0 && y < 9 && x > 0) yield return new(y + 1, x - 1);
            if (y >= 0 && y < 9) yield return new(y + 1, x);
            if (y >= 0 && y < 9 && x < 9) yield return new(y + 1, x + 1);

            //if (y < 9 && y > 0 && x > 0) yield return new(y - 1, x - 1);
            //if (y < 9 && y > 0) yield return new(y - 1, x);
            //if (y < 9 && y > 0 && x < 9) yield return new(y - 1, x + 1);
        }
    }
}
